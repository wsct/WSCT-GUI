using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WSCT.GUI.Common.Resources.Helpers;
using WSCT.GUI.Plugins;
using WSCT.GUI.Resources;
using WSCT.Helpers;
using WSCT.Helpers.Linq;
using WSCT.Linq;
using WSCT.Stack;
using WSCT.Wrapper;
using WSCT.Wrapper.Desktop.Core;

namespace WSCT.GUI
{
    public partial class WinSCardGui : Form, IWinSCardGui
    {
        #region >> Fields

        private readonly CardChannelStackDescription _channelLayers;
        private readonly CardContextStackDescription _contextLayers;
        private readonly StatusChangeMonitor _statusMonitor;
        private readonly LogObserver _observer;
        private readonly LogObserver _stackObserver;

        private readonly Dictionary<object, Color> _defaultControlBackColors = new Dictionary<object, Color>();

        #endregion

        #region >> Constructors

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public WinSCardGui()
        {
            InitializeComponent();

            Icon = Common.Resources.Icons.WSCT;

            guiShareMode.DataSource = Enum.GetValues(typeof(ShareMode));
            guiShareMode.SelectedItem = ShareMode.Shared;

            guiProtocol.DataSource = Enum.GetValues(typeof(Protocol));
            guiProtocol.SelectedItem = Protocol.Any;

            guiDisposition.DataSource = Enum.GetValues(typeof(Disposition));
            guiDisposition.SelectedItem = Disposition.UnpowerCard;

            guiAttribute.DataSource = Enum.GetValues(typeof(Attrib));
            guiAttribute.SelectedItem = Attrib.AtrString;

            var pluginManager = new PluginsManager();
            pluginManager.DiscoverInDirectory(Directory.GetCurrentDirectory());

            _observer = new LogObserver(this, Colors.LogDefaultColor);
            _stackObserver = new LogObserver(this, Colors.LogHighlightColor);

            _channelLayers = SerializedObject<CardChannelStackDescription>.LoadFromXml("Stack.Channel.xml");

            _contextLayers = SerializedObject<CardContextStackDescription>.LoadFromXml("Stack.Context.xml");

            _statusMonitor = new StatusChangeMonitor();

            #region >> Initialize plugins menu and tab

            foreach (var plugin in pluginManager.Plugins)
            {
                var pluginMenuItem = new ToolStripMenuItem
                {
                    Text = plugin.Attribute.Name,
                    Tag = plugin
                };
                pluginMenuItem.Click += guiPluginsMenu_Click;
                guiPluginsMenuItem.DropDownItems.Add(pluginMenuItem);
            }

            guiAvailablePlugins.Format += (sender, args) =>
                args.Value = ((PluginInfo)args.ListItem).Attribute.Name;
            guiAvailablePlugins.DataSource = pluginManager.Plugins;

            #endregion

            #region >> Initialize layers menu and tab

            _channelLayers.LayerDescriptions.DoForEach(d => guiAvailableChannelLayers.Items.Add(d));
            guiAvailableChannelLayers.DisplayMember = "name";

            _contextLayers.LayerDescriptions.DoForEach(d => guiAvailableContextLayers.Items.Add(d));
            guiAvailableContextLayers.DisplayMember = "name";

            #endregion

            TryToEstablishContext();
        }

        #endregion

        #region >> Methods

        private void TryToEstablishContext()
        {
            _statusMonitor.OnCardInsertionEvent = null;
            _statusMonitor.OnCardRemovalEvent = null;
            CreateCardContextStack();

            var lastError = SharedData.CardContext.Establish();

            if (lastError == ErrorCode.Success)
            {
                if (SharedData.CardContext.ListReaderGroups() == ErrorCode.Success)
                {
                    guiReaderGroups.DataSource = SharedData.CardContext.Groups;
                    guiFoundReaderGroups.Text = string.Format(Lang.ReaderGroupsFoundAre, SharedData.CardContext.GroupsCount);

                    if (SharedData.CardContext.ListReaders(SharedData.CardContext.Groups[0]) == ErrorCode.Success)
                    {
                        guiReaders.DataSource = SharedData.CardContext.Readers;
                        guiFoundReaders.Text = string.Format(Lang.ReadersFoundAre, SharedData.CardContext.ReadersCount);

                        _statusMonitor.Context = SharedData.CardContext;
                        _statusMonitor.Start();
                    }
                }

                UpdateContextEstablished();
            }
            else
            {
                guiContextState.Text = Lang.AnErrorOccured;
                guiContextState.SetControlBackColor(Common.Resources.Colors.StatusError);
            }
        }

        #endregion

        #region >> createCard * Stack

        private void CreateCardChannelStack()
        {
            var layers = _channelLayers.LayerDescriptions
                .Select(ld => _channelLayers.CreateInstance(ld.Name))
                .ToObservableLayers()
                .ForEach(_observer.ObserveChannel);

            var stack = new CardChannelStack(layers).ToObservableStack();

            stack.Attach(SharedData.CardContext, guiReaders.SelectedItem.ToString());

            _stackObserver.ObserveChannel(stack);

            SharedData.CardChannel = stack;
        }

        private void CreateCardContextStack()
        {
            var layers = _contextLayers.LayerDescriptions
                .Select(ld => _contextLayers.CreateInstance(ld.Name))
                .ToObservableLayers()
                .ForEach(_observer.ObserveContext);

            var stack = new CardContextStack(layers).ToObservableStack();

            _stackObserver.ObserveContext(stack);

            SharedData.CardContext = stack;
        }

        #endregion

        #region >> *_Click

        private void guiContextEstablish_Click(object sender, EventArgs e)
        {
            TryToEstablishContext();
        }

        private void guiContextRelease_Click(object sender, EventArgs e)
        {
            _statusMonitor.Stop();

            var lastError = SharedData.CardContext.Release();
            if (lastError == ErrorCode.Success)
            {
                SharedData.CardContext = null;
                guiContextState.Text = Lang.ContextIsReleased;
                UpdateChannelStatus(ChannelStatusType.Disconnected);

                UpdateContextReleased();
            }
        }

        private void guiCardConnect_Click(object sender, EventArgs e)
        {
            CreateCardChannelStack();

            var errorCode = SharedData.CardChannel.Connect(ShareMode.Shared, Protocol.Any);
            if (errorCode == ErrorCode.Success)
            {
                UpdateReaderInUse(guiReaders.SelectedItem.ToString());
            }
        }

        private void guiCardWarmReset_Click(object sender, EventArgs e)
        {
            SharedData.CardChannel.Reconnect(ShareMode.Shared, Protocol.Any, Disposition.ResetCard);
        }

        private void guiCardColdReset_Click(object sender, EventArgs e)
        {
            SharedData.CardChannel.Reconnect(ShareMode.Shared, Protocol.Any, Disposition.UnpowerCard);
        }

        private void guiCardUnpower_Click(object sender, EventArgs e)
        {
            SharedData.CardChannel.Disconnect(Disposition.UnpowerCard);
            UpdateReaderInUse("");
        }

        private void guiChannelConnect_Click(object sender, EventArgs e)
        {
            CreateCardChannelStack();

            var errorCode = SharedData.CardChannel.Connect((ShareMode)guiShareMode.SelectedItem, (Protocol)guiProtocol.SelectedItem);
            if (errorCode == ErrorCode.Success)
            {
                UpdateReaderInUse(guiReaders.SelectedItem.ToString());
            }
        }

        private void guiChannelReconnect_Click(object sender, EventArgs e)
        {
            SharedData.CardChannel.Reconnect((ShareMode)guiShareMode.SelectedItem, (Protocol)guiProtocol.SelectedItem, (Disposition)guiDisposition.SelectedItem);
        }

        private void guiChannelDisconnect_Click(object sender, EventArgs e)
        {
            SharedData.CardChannel.Disconnect((Disposition)guiDisposition.SelectedItem);
        }

        private void guiGetAttribute_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] recvBuffer = null;
                var errorCode = SharedData.CardChannel.GetAttrib((Attrib)guiAttribute.SelectedItem, ref recvBuffer);
                if (errorCode == ErrorCode.Success)
                {
                    UpdateAttribute(recvBuffer);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void guiQuit_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void guiAboutWinSCardGUI_Click(object sender, EventArgs e)
        {
            Form about = new AboutWinSCardGui();
            about.Show();
        }

        private void guiPluginsMenu_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            try
            {
                var plugin = (PluginInfo)menuItem.Tag;
                plugin.CreateInstance().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, String.Format(Lang.ErrorWhenLaunchingPluginX, menuItem.Text), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region >> IWinSCardGui

        /// <inheritdoc />
        public void AppendLineToLog(string text)
        {
            guiLogsView.AppendText(text);
        }

        /// <inheritdoc />
        public void InvokeOnUiThread(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        /// <inheritdoc />
        public void SetLogForeColor(Color color)
        {
            guiLogsView.SelectionColor = color;
        }

        /// <inheritdoc />
        public void UpdateAttribute(byte[] attribute)
        {
            guiRawAttribute.Text = attribute.ToHexa();
            guiStringAttribute.Text = attribute.ToAsciiString();
        }

        /// <inheritdoc />
        public void UpdateLastError(ErrorCode error)
        {
            guiLastError.Text = String.Format(Lang.LastErrorIsX, error);
            guiStatus.SetControlBackColor(error == ErrorCode.Success ? Common.Resources.Colors.StatusSuccess : Common.Resources.Colors.StatusError);
        }

        /// <inheritdoc />
        public void UpdateChannelStatus(ChannelStatusType status)
        {
            switch (status)
            {
                case ChannelStatusType.Connected:
                    guiChannelState.Text = Lang.ChannelIsConnected;
                    guiChannelState.SetControlBackColor(Common.Resources.Colors.StatusSuccess);
                    break;
                case ChannelStatusType.Disconnected:
                    guiChannelState.Text = Lang.ChannelIsDisconnected;
                    guiChannelState.ResetControlBackColor();
                    break;
                case ChannelStatusType.Error:
                    guiChannelState.Text = Lang.AnErrorOccured;
                    guiChannelState.SetControlBackColor(Common.Resources.Colors.StatusError);
                    break;
            }
        }

        /// <inheritdoc />
        public void UpdateReaderInUse(string readerName)
        {
            guiReaderInUse.Text = readerName;
        }

        /// <inheritdoc />
        public void UpdateContextEstablished()
        {
            guiGroupCardConnection.Enabled = true;
            guiGroupCardAttributes.Enabled = true;
            guiGroupCardInformations.Enabled = true;

            guiContextState.Text = Lang.ContextIsEstablish;

            guiContextEstablish.Enabled = false;
            guiContextRelease.Enabled = true;
            guiCardConnect.Enabled = true;
            guiCardWarmReset.Enabled = true;
            guiCardColdReset.Enabled = true;
            guiCardUnpower.Enabled = true;
        }

        /// <inheritdoc />
        public void UpdateContextReleased()
        {
            guiGroupCardConnection.Enabled = false;
            guiGroupCardAttributes.Enabled = false;
            guiGroupCardInformations.Enabled = false;

            guiFoundReaderGroups.Text = String.Format(Lang.ReaderGroupsFoundAre, 0);
            guiReaderGroups.DataSource = null;
            guiFoundReaders.Text = String.Format(Lang.ReadersFoundAre, 0);
            guiReaders.DataSource = null;

            guiContextEstablish.Enabled = true;
            guiContextRelease.Enabled = false;
            guiCardConnect.Enabled = false;
            guiCardWarmReset.Enabled = false;
            guiCardColdReset.Enabled = false;
            guiCardUnpower.Enabled = false;
        }

        #endregion

        #region >> *_SelectedIndexChanged

        private void guiLoadedPlugins_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            if (listBox.SelectedItem != null)
            {
                var plugin = (PluginInfo)listBox.SelectedItem;
                var assembly = plugin.Type.Assembly;

                guiPluginName.Text = plugin.Attribute.Name;
                guiPluginClassName.Text = plugin.Type.FullName;
                guiPluginDescription.Text = plugin.Attribute.Description;

                guiPluginAssemblyPath.Text = assembly.Location;
                guiPluginAssemblyVersion.Text = assembly.GetName().Version.ToString();
                guiPluginAssemblyName.Text = assembly.FullName;
                guiPluginAssemblyDescription.Text = assembly.GetCustomAttribute<AssemblyDescriptionAttribute>().Description;
            }
        }

        private void guiLoadedChannelLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            if (listBox.SelectedItem != null)
            {
                // Deselect the selected layer in context layers
                guiAvailableContextLayers.SetSelected(0, false);

                // Update assembly information
                var layer = (CardChannelLayerDescription)listBox.SelectedItem;
                guiLayerName.Text = layer.Name;
                guiLayerClassName.Text = layer.ClassName;
                guiLayerDLL.Text = layer.DllName;
                guiLayerPathToDll.Text = layer.PathToDll;

                try
                {
                    var assembly = Assembly.LoadFrom(Path.Combine(layer.PathToDll, layer.DllName));
                    var assemblyName = new AssemblyName(assembly.FullName);
                    guiLayerAssemblyVersion.Text = assemblyName.Version.ToString();
                    guiLayerAssemblyName.Text = assemblyName.Name;
                    var assemblyDescription = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute));
                    guiLayerAssemblyDescription.Text = assemblyDescription.Description;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, String.Format(Lang.ErrorAccessingLayerAssemblyX, layer.Name), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void guiLoadedContextLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            if (listBox.SelectedItem != null)
            {
                // Deselect the selected layer in channel layers
                guiAvailableChannelLayers.SetSelected(0, false);

                // Update assembly informations
                var layer = (CardContextLayerDescription)listBox.SelectedItem;
                guiLayerName.Text = layer.Name;
                guiLayerClassName.Text = layer.ClassName;
                guiLayerDLL.Text = layer.DllName;
                guiLayerPathToDll.Text = layer.PathToDll;

                try
                {
                    var assembly = Assembly.LoadFrom(Path.Combine(layer.PathToDll, layer.DllName));
                    var assemblyName = new AssemblyName(assembly.FullName);
                    guiLayerAssemblyVersion.Text = assemblyName.Version.ToString();
                    guiLayerAssemblyName.Text = assemblyName.Name;
                    var assemblyDescription = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute));
                    guiLayerAssemblyDescription.Text = assemblyDescription.Description;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, String.Format(Lang.ErrorAccessingLayerAssemblyX, layer.Name), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

        #region >> *_FormClosing

        private void WinSCardGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            _statusMonitor.Stop();
        }

        #endregion

        private void guiClearLogs_Click(object sender, EventArgs e)
        {
            guiLogsView.Clear();
        }
    }
}