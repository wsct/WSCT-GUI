using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using WSCT.Core;
using WSCT.GUI.Plugins;
using WSCT.Helpers;
using WSCT.Stack;
using WSCT.Wrapper;

namespace WSCT.GUI
{
    public partial class WinSCardGUI : Form
    {
        #region >> Fields

        private readonly CardChannelStackDescription channelLayers;
        private readonly CardContextStackDescription contextLayers;
        private readonly PluginRepository pluginRepository;
        private readonly StatusChangeMonitor statusMonitor;

        #endregion

        #region >> Constructors

        /// <summary>
        /// 
        /// </summary>
        public WinSCardGUI()
        {
            InitializeComponent();

            guiShareMode.DataSource = Enum.GetValues(typeof(ShareMode));
            guiShareMode.SelectedItem = ShareMode.Shared;

            guiProtocol.DataSource = Enum.GetValues(typeof(Protocol));
            guiProtocol.SelectedItem = Protocol.Any;

            guiDisposition.DataSource = Enum.GetValues(typeof(Disposition));
            guiDisposition.SelectedItem = Disposition.UnpowerCard;

            guiAttribute.DataSource = Enum.GetValues(typeof(Attrib));
            guiAttribute.SelectedItem = Attrib.AtrString;

            pluginRepository = new PluginRepository();
            // Read all independant plugins repository and aggregate them in <c>pluginRepository</c>
            foreach (var fileName in Directory.GetFiles(".", "Plugin*.xml"))
            {
                var pr = SerializedObject<PluginRepository>.LoadFromXml(fileName);
                foreach (var pluginDesc in pr.plugins)
                {
                    pluginRepository.add(pluginDesc);
                }
            }

            channelLayers = SerializedObject<CardChannelStackDescription>.LoadFromXml(@"Stack.Channel.xml");

            contextLayers = SerializedObject<CardContextStackDescription>.LoadFromXml(@"Stack.Context.xml");

            statusMonitor = new StatusChangeMonitor();

            #region >> Initialize plugins menu and tab

            foreach (var plugin in pluginRepository.plugins)
            {
                var pluginMenuItem = new ToolStripMenuItem { Text = plugin.name };
                pluginMenuItem.Click += guiPluginsMenu_Click;
                guiPluginsMenuItem.DropDownItems.Add(pluginMenuItem);

                guiLoadedPlugins.Items.Add(plugin);
            }

            guiLoadedPlugins.DisplayMember = "name";

            #endregion

            #region >> Initialize layers menu and tab

            foreach (var layer in channelLayers.LayerDescriptions)
            {
                guiLoadedChannelLayers.Items.Add(layer);
            }
            guiLoadedChannelLayers.DisplayMember = "name";

            foreach (var layer in contextLayers.LayerDescriptions)
            {
                guiLoadedContextLayers.Items.Add(layer);
            }
            guiLoadedContextLayers.DisplayMember = "name";

            #endregion
        }

        #endregion

        #region >> Methods

        private String getLastNamespaceOf(Object instance)
        {
            var splittedNamespace = instance.GetType().Namespace.Split('.');
            return splittedNamespace[splittedNamespace.Length - 1];
        }

        #endregion

        #region >> createCard * Stack

        private void createCardChannelStack()
        {
            var cardStack = new CardChannelStack();
            foreach (var cardLayer in channelLayers.LayerDescriptions)
            {
                var cardChannelLayer = channelLayers.CreateInstance(cardLayer.Name);
                cardChannelLayer.SetStack(cardStack);
                if (cardChannelLayer is ICardChannelObservable)
                {
                    var cardObserver = new CardObserver(this, getLastNamespaceOf(cardChannelLayer));
                    cardObserver.observeChannel((ICardChannelObservable)cardChannelLayer);
                }
                cardStack.AddLayer(cardChannelLayer);
            }
            cardStack.Attach(SharedData.cardContext, guiReaders.SelectedItem.ToString());

            SharedData.cardChannel = cardStack;
        }

        private void createCardContextStack()
        {
            ICardContextStack cardStack = new CardContextStack();
            foreach (var layer in contextLayers.LayerDescriptions)
            {
                var cardContextLayer = contextLayers.CreateInstance(layer.Name);
                cardContextLayer.SetStack(cardStack);
                if (cardContextLayer is ICardContextObservable)
                {
                    var cardObserver = new CardObserver(this, getLastNamespaceOf(cardContextLayer));
                    cardObserver.observeContext((ICardContextObservable)cardContextLayer);
                    cardObserver.observeMonitor(statusMonitor);
                }
                cardStack.AddLayer(cardContextLayer);
            }

            SharedData.cardContext = cardStack;
        }

        #endregion

        #region >> *_Click

        private void guiContextEstablish_Click(object sender, EventArgs e)
        {
            statusMonitor.OnCardInsertionEvent = null;
            statusMonitor.OnCardRemovalEvent = null;
            createCardContextStack();

            var lastError = SharedData.cardContext.Establish();

            if (lastError == ErrorCode.Success)
            {
                if (SharedData.cardContext.ListReaderGroups() == ErrorCode.Success)
                {
                    guiReaderGroups.DataSource = SharedData.cardContext.Groups;
                    guiFoundReaderGroups.Text = String.Format("Reader groups descriptionFound: {0}", SharedData.cardContext.GroupsCount);

                    if (SharedData.cardContext.ListReaders(SharedData.cardContext.Groups[0]) == ErrorCode.Success)
                    {
                        guiReaders.DataSource = SharedData.cardContext.Readers;
                        guiFoundReaders.Text = String.Format("Readers descriptionFound: {0}", SharedData.cardContext.ReadersCount);

                        statusMonitor.Context = SharedData.cardContext;
                        statusMonitor.Start();
                    }
                }

                updateContextEstablished();
            }
            else
            {
                guiContextState.Text = "An error occured";
            }
        }

        private void guiContextRelease_Click(object sender, EventArgs e)
        {
            statusMonitor.Stop();

            var lastError = SharedData.cardContext.Release();
            if (lastError == ErrorCode.Success)
            {
                SharedData.cardContext = null;
                guiContextState.Text = "Released";
                updateChannelStatus(ChannelStatusType.disconnected);

                updateContextReleased();
            }
        }

        private void guiCardConnect_Click(object sender, EventArgs e)
        {
            createCardChannelStack();

            var errorCode = SharedData.cardChannel.Connect(ShareMode.Shared, Protocol.Any);
            if (errorCode == ErrorCode.Success)
            {
                updateReaderInUse(guiReaders.SelectedItem.ToString());
            }
        }

        private void guiCardWarmReset_Click(object sender, EventArgs e)
        {
            SharedData.cardChannel.Reconnect(ShareMode.Shared, Protocol.Any, Disposition.ResetCard);
        }

        private void guiCardColdReset_Click(object sender, EventArgs e)
        {
            SharedData.cardChannel.Reconnect(ShareMode.Shared, Protocol.Any, Disposition.UnpowerCard);
        }

        private void guiCardUnpower_Click(object sender, EventArgs e)
        {
            SharedData.cardChannel.Disconnect(Disposition.UnpowerCard);
            updateReaderInUse("");
        }

        private void guiChannelConnect_Click(object sender, EventArgs e)
        {
            createCardChannelStack();

            var errorCode = SharedData.cardChannel.Connect((ShareMode)guiShareMode.SelectedItem, (Protocol)guiProtocol.SelectedItem);
            if (errorCode == ErrorCode.Success)
            {
                updateReaderInUse(guiReaders.SelectedItem.ToString());
            }
        }

        private void guiChannelReconnect_Click(object sender, EventArgs e)
        {
            SharedData.cardChannel.Reconnect((ShareMode)guiShareMode.SelectedItem, (Protocol)guiProtocol.SelectedItem, (Disposition)guiDisposition.SelectedItem);
        }

        private void guiChannelDisconnect_Click(object sender, EventArgs e)
        {
            SharedData.cardChannel.Disconnect((Disposition)guiDisposition.SelectedItem);
        }

        private void guiGetAttribute_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] recvBuffer = null;
                var errorCode = SharedData.cardChannel.GetAttrib((Attrib)guiAttribute.SelectedItem, ref recvBuffer);
                if (errorCode == ErrorCode.Success)
                {
                    updateAttribute(recvBuffer);
                }
            }
            catch (Exception)
            {
            }
        }

        private void guiQuit_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void guiAboutWinSCardGUI_Click(object sender, EventArgs e)
        {
            Form about = new AboutWinSCardGUI();
            about.Show();
        }

        private void guiPluginsMenu_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            try
            {
                var plugin = pluginRepository.createInstance(menuItem.Text);
                plugin.show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error(s) occured when launching plugin '" + menuItem.Text + "'", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region >> update*

        /// <summary>
        /// 
        /// </summary>
        /// <param name="attribute"></param>
        public void updateAttribute(byte[] attribute)
        {
            guiRawAttribute.Text = attribute.ToHexa();
            guiStringAttribute.Text = attribute.ToAsciiString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="error"></param>
        public void updateLastError(ErrorCode error)
        {
            guiLastError.Text = String.Format("Last Error: {0}", error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        public void updateChannelStatus(ChannelStatusType status)
        {
            switch (status)
            {
                case ChannelStatusType.connected:
                    guiChannelState.Text = "Connected";
                    break;
                case ChannelStatusType.disconnected:
                    guiChannelState.Text = "Disconnected";
                    break;
                case ChannelStatusType.error:
                    guiChannelState.Text = "An error occured";
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="readerName"></param>
        public void updateReaderInUse(string readerName)
        {
            guiReaderInUse.Text = readerName;
        }

        /// <summary>
        /// Called when new context established: update GUI
        /// </summary>
        public void updateContextEstablished()
        {
            guiGroupCardConnection.Enabled = true;
            guiGroupCardAttributes.Enabled = true;
            guiGroupCardInformations.Enabled = true;

            guiContextState.Text = "Established";

            guiContextEstablish.Enabled = false;
            guiContextRelease.Enabled = true;
            guiCardConnect.Enabled = true;
            guiCardWarmReset.Enabled = true;
            guiCardColdReset.Enabled = true;
            guiCardUnpower.Enabled = true;
        }

        /// <summary>
        /// Called when context is released: updateGUI
        /// </summary>
        public void updateContextReleased()
        {
            guiGroupCardConnection.Enabled = false;
            guiGroupCardAttributes.Enabled = false;
            guiGroupCardInformations.Enabled = false;

            guiFoundReaderGroups.Text = String.Format("Reader groups descriptionFound: {0}", 0);
            guiReaderGroups.DataSource = null;
            guiFoundReaders.Text = String.Format("Readers descriptionFound: {0}", 0);
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
                var plugin = (PluginDescription)listBox.SelectedItem;
                guiPluginName.Text = plugin.name;
                guiPluginClassName.Text = plugin.className;
                guiPluginDLL.Text = plugin.dllName;
                guiPluginPathToDll.Text = plugin.pathToDll;

                try
                {
                    var assembly = Assembly.LoadFrom(plugin.pathToDll + plugin.dllName);
                    var assemblyName = new AssemblyName(assembly.FullName);
                    guiPluginAssemblyVersion.Text = assemblyName.Version.ToString();
                    guiPluginAssemblyName.Text = assemblyName.Name;
                    var assemblyDescription = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute));
                    guiPluginAssemblyDescription.Text = assemblyDescription.Description;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error(s) occured when accessing plugin '" + plugin.name + "'", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void guiLoadedChannelLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            if (listBox.SelectedItem != null)
            {
                // Deselect the selected layer in context layers
                guiLoadedContextLayers.SetSelected(0, false);

                // Update assembly informations
                var layer = (CardChannelLayerDescription)listBox.SelectedItem;
                guiLayerName.Text = layer.Name;
                guiLayerClassName.Text = layer.ClassName;
                guiLayerDLL.Text = layer.DllName;
                guiLayerPathToDll.Text = layer.PathToDll;

                try
                {
                    var assembly = Assembly.LoadFrom(layer.PathToDll + layer.DllName);
                    var assemblyName = new AssemblyName(assembly.FullName);
                    guiLayerAssemblyVersion.Text = assemblyName.Version.ToString();
                    guiLayerAssemblyName.Text = assemblyName.Name;
                    var assemblyDescription = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute));
                    guiLayerAssemblyDescription.Text = assemblyDescription.Description;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error(s) occured when accessing layer '" + layer.Name + "'", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void guiLoadedContextLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            if (listBox.SelectedItem != null)
            {
                // Deselect the selected layer in channel layers
                guiLoadedChannelLayers.SetSelected(0, false);

                // Update assembly informations
                var layer = (CardContextLayerDescription)listBox.SelectedItem;
                guiLayerName.Text = layer.Name;
                guiLayerClassName.Text = layer.ClassName;
                guiLayerDLL.Text = layer.DllName;
                guiLayerPathToDll.Text = layer.PathToDll;

                try
                {
                    var assembly = Assembly.LoadFrom(layer.PathToDll + layer.DllName);
                    var assemblyName = new AssemblyName(assembly.FullName);
                    guiLayerAssemblyVersion.Text = assemblyName.Version.ToString();
                    guiLayerAssemblyName.Text = assemblyName.Name;
                    var assemblyDescription = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute));
                    guiLayerAssemblyDescription.Text = assemblyDescription.Description;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error(s) occured when accessing layer '" + layer.Name + "'", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

        #region >> *_FormClosing

        private void WinSCardGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            statusMonitor.Stop();
        }

        #endregion
    }
}