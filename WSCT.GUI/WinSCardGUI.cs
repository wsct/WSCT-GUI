using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

using WSCT;
using WSCT.Core;
using WSCT.Stack;
using WSCT.Wrapper;
using WSCT.Helpers;
using WSCT.GUI.Plugins;

namespace WSCT.GUI
{
    public partial class WinSCardGUI : Form
    {
        #region >> Fields

        Plugins.PluginRepository pluginRepository;

        CardContextStackDescription contextLayers;
        CardChannelStackDescription channelLayers;
        StatusChangeMonitor statusMonitor;

        #endregion

        #region >> Constructors

        /// <summary>
        /// 
        /// </summary>
        public WinSCardGUI()
        {
            InitializeComponent();

            guiShareMode.DataSource = Enum.GetValues(typeof(ShareMode));
            guiShareMode.SelectedItem = ShareMode.SCARD_SHARE_SHARED;

            guiProtocol.DataSource = Enum.GetValues(typeof(Protocol));
            guiProtocol.SelectedItem = Protocol.SCARD_PROTOCOL_ANY;

            guiDisposition.DataSource = Enum.GetValues(typeof(Disposition));
            guiDisposition.SelectedItem = Disposition.SCARD_UNPOWER_CARD;

            guiAttribute.DataSource = Enum.GetValues(typeof(Attrib));
            guiAttribute.SelectedItem = Attrib.SCARD_ATTR_ATR_STRING;

            pluginRepository = new Plugins.PluginRepository();
            // Read all independant plugins repository and aggregate them in <c>pluginRepository</c>
            foreach (String fileName in System.IO.Directory.GetFiles(".", "Plugin*.xml"))
            {
                PluginRepository pr = SerializedObject<PluginRepository>.loadFromXml(fileName);
                foreach (PluginDescription pluginDesc in pr.plugins)
                    pluginRepository.add(pluginDesc);
            }

            channelLayers = SerializedObject<CardChannelStackDescription>.loadFromXml(@"Stack.Channel.xml");

            contextLayers = SerializedObject<CardContextStackDescription>.loadFromXml(@"Stack.Context.xml");

            statusMonitor = new StatusChangeMonitor();

            #region >> Initialize plugins menu and tab

            foreach (Plugins.PluginDescription plugin in pluginRepository.plugins)
            {
                ToolStripMenuItem pluginMenuItem = new ToolStripMenuItem();
                pluginMenuItem.Text = plugin.name;
                pluginMenuItem.Click += new System.EventHandler(this.guiPluginsMenu_Click);
                guiPluginsMenuItem.DropDownItems.Add(pluginMenuItem);

                guiLoadedPlugins.Items.Add(plugin);
            }

            guiLoadedPlugins.DisplayMember = "name";

            #endregion

            #region >> Initialize layers menu and tab

            foreach (CardChannelLayerDescription layer in channelLayers.layerDescriptions)
            {
                guiLoadedChannelLayers.Items.Add(layer);
            }
            guiLoadedChannelLayers.DisplayMember = "name";

            foreach (CardContextLayerDescription layer in contextLayers.layerDescriptions)
            {
                guiLoadedContextLayers.Items.Add(layer);
            }
            guiLoadedContextLayers.DisplayMember = "name";

            #endregion
        }

        #endregion

        #region >> Methods

        String getLastNamespaceOf(Object instance)
        {
            String[] splittedNamespace = instance.GetType().Namespace.Split('.');
            return splittedNamespace[splittedNamespace.Length - 1];
        }

        #endregion

        #region >> createCard * Stack

        void createCardChannelStack()
        {
            CardChannelStack cardStack = new CardChannelStack();
            foreach (CardChannelLayerDescription cardLayer in channelLayers.layerDescriptions)
            {
                ICardChannelLayer cardChannelLayer = channelLayers.createInstance(cardLayer.name);
                cardChannelLayer.setStack(cardStack);
                if (cardChannelLayer is ICardChannelObservable)
                {
                    CardObserver cardObserver = new CardObserver(this, getLastNamespaceOf(cardChannelLayer));
                    cardObserver.observeChannel((Core.ICardChannelObservable)cardChannelLayer);
                }
                cardStack.addLayer(cardChannelLayer);
            }
            cardStack.attach(SharedData.cardContext, guiReaders.SelectedItem.ToString());

            SharedData.cardChannel = cardStack;
        }

        void createCardContextStack()
        {
            ICardContextStack cardStack = new CardContextStack();
            foreach (CardContextLayerDescription layer in contextLayers.layerDescriptions)
            {
                ICardContextLayer cardContextLayer = contextLayers.createInstance(layer.name);
                cardContextLayer.setStack(cardStack);
                if (cardContextLayer is ICardContextObservable)
                {
                    CardObserver cardObserver = new CardObserver(this, getLastNamespaceOf(cardContextLayer));
                    cardObserver.observeContext((Core.ICardContextObservable)cardContextLayer);
                    cardObserver.observeMonitor(statusMonitor);
                }
                cardStack.addLayer(cardContextLayer);
            }

            SharedData.cardContext = cardStack;
        }

        #endregion

        #region >> *_Click

        private void guiContextEstablish_Click(object sender, EventArgs e)
        {
            statusMonitor.onCardInsertionEvent = null;
            statusMonitor.onCardRemovalEvent = null;
            createCardContextStack();

            ErrorCode lastError = SharedData.cardContext.establish();

            if (lastError == ErrorCode.SCARD_S_SUCCESS)
            {

                if (SharedData.cardContext.listReaderGroups() == ErrorCode.SCARD_S_SUCCESS)
                {
                    guiReaderGroups.DataSource = SharedData.cardContext.groups;
                    guiFoundReaderGroups.Text = String.Format("Reader groups descriptionFound: {0}", SharedData.cardContext.groupsCount);

                    if (SharedData.cardContext.listReaders(SharedData.cardContext.groups[0]) == ErrorCode.SCARD_S_SUCCESS)
                    {
                        guiReaders.DataSource = SharedData.cardContext.readers;
                        guiFoundReaders.Text = String.Format("Readers descriptionFound: {0}", SharedData.cardContext.readersCount);

                        statusMonitor.context = SharedData.cardContext;
                        statusMonitor.start();
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
            statusMonitor.stop();

            ErrorCode lastError = SharedData.cardContext.release();
            if (lastError == ErrorCode.SCARD_S_SUCCESS)
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

            ErrorCode errorCode = SharedData.cardChannel.connect(ShareMode.SCARD_SHARE_SHARED, Protocol.SCARD_PROTOCOL_ANY);
            if (errorCode == ErrorCode.SCARD_S_SUCCESS)
            {
                updateReaderInUse(guiReaders.SelectedItem.ToString());
            }
        }

        private void guiCardWarmReset_Click(object sender, EventArgs e)
        {
            SharedData.cardChannel.reconnect(ShareMode.SCARD_SHARE_SHARED, Protocol.SCARD_PROTOCOL_ANY, Disposition.SCARD_RESET_CARD);
        }

        private void guiCardColdReset_Click(object sender, EventArgs e)
        {
            SharedData.cardChannel.reconnect(ShareMode.SCARD_SHARE_SHARED, Protocol.SCARD_PROTOCOL_ANY, Disposition.SCARD_UNPOWER_CARD);
        }

        private void guiCardUnpower_Click(object sender, EventArgs e)
        {
            SharedData.cardChannel.disconnect(Disposition.SCARD_UNPOWER_CARD);
            updateReaderInUse("");
        }

        private void guiChannelConnect_Click(object sender, EventArgs e)
        {
            createCardChannelStack();

            ErrorCode errorCode = SharedData.cardChannel.connect((ShareMode)guiShareMode.SelectedItem, (Protocol)guiProtocol.SelectedItem);
            if (errorCode == ErrorCode.SCARD_S_SUCCESS)
                updateReaderInUse(guiReaders.SelectedItem.ToString());
        }

        private void guiChannelReconnect_Click(object sender, EventArgs e)
        {
            SharedData.cardChannel.reconnect((ShareMode)guiShareMode.SelectedItem, (Protocol)guiProtocol.SelectedItem, (Disposition)guiDisposition.SelectedItem);
        }

        private void guiChannelDisconnect_Click(object sender, EventArgs e)
        {
            SharedData.cardChannel.disconnect((Disposition)guiDisposition.SelectedItem);
        }

        private void guiGetAttribute_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] recvBuffer = null;
                ErrorCode errorCode = SharedData.cardChannel.getAttrib((Attrib)guiAttribute.SelectedItem, ref recvBuffer);
                if (errorCode == ErrorCode.SCARD_S_SUCCESS)
                    updateAttribute(recvBuffer);
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
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            try
            {
                Plugins.IPlugin plugin = pluginRepository.createInstance(menuItem.Text);
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
            guiRawAttribute.Text = attribute.toHexa();
            guiStringAttribute.Text = attribute.toString();
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
                default:
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
            ListBox listBox = (ListBox)sender;
            if (listBox.SelectedItem != null)
            {
                Plugins.PluginDescription plugin = (Plugins.PluginDescription)listBox.SelectedItem;
                guiPluginName.Text = plugin.name;
                guiPluginClassName.Text = plugin.className;
                guiPluginDLL.Text = plugin.dllName;
                guiPluginPathToDll.Text = plugin.pathToDll;

                try
                {
                    System.Reflection.Assembly assembly = System.Reflection.Assembly.LoadFrom(plugin.pathToDll + plugin.dllName);
                    System.Reflection.AssemblyName assemblyName = new System.Reflection.AssemblyName(assembly.FullName);
                    guiPluginAssemblyVersion.Text = assemblyName.Version.ToString();
                    guiPluginAssemblyName.Text = assemblyName.Name;
                    AssemblyDescriptionAttribute assemblyDescription = (AssemblyDescriptionAttribute)AssemblyDescriptionAttribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute));
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
            ListBox listBox = (ListBox)sender;
            if (listBox.SelectedItem != null)
            {
                // Deselect the selected layer in context layers
                guiLoadedContextLayers.SetSelected(0, false);

                // Update assembly informations
                CardChannelLayerDescription layer = (CardChannelLayerDescription)listBox.SelectedItem;
                guiLayerName.Text = layer.name;
                guiLayerClassName.Text = layer.className;
                guiLayerDLL.Text = layer.dllName;
                guiLayerPathToDll.Text = layer.pathToDll;

                try
                {
                    System.Reflection.Assembly assembly = System.Reflection.Assembly.LoadFrom(layer.pathToDll + layer.dllName);
                    System.Reflection.AssemblyName assemblyName = new System.Reflection.AssemblyName(assembly.FullName);
                    guiLayerAssemblyVersion.Text = assemblyName.Version.ToString();
                    guiLayerAssemblyName.Text = assemblyName.Name;
                    AssemblyDescriptionAttribute assemblyDescription = (AssemblyDescriptionAttribute)AssemblyDescriptionAttribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute));
                    guiLayerAssemblyDescription.Text = assemblyDescription.Description;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error(s) occured when accessing layer '" + layer.name + "'", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void guiLoadedContextLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (listBox.SelectedItem != null)
            {
                // Deselect the selected layer in channel layers
                guiLoadedChannelLayers.SetSelected(0, false);

                // Update assembly informations
                CardContextLayerDescription layer = (CardContextLayerDescription)listBox.SelectedItem;
                guiLayerName.Text = layer.name;
                guiLayerClassName.Text = layer.className;
                guiLayerDLL.Text = layer.dllName;
                guiLayerPathToDll.Text = layer.pathToDll;

                try
                {
                    System.Reflection.Assembly assembly = System.Reflection.Assembly.LoadFrom(layer.pathToDll + layer.dllName);
                    System.Reflection.AssemblyName assemblyName = new System.Reflection.AssemblyName(assembly.FullName);
                    guiLayerAssemblyVersion.Text = assemblyName.Version.ToString();
                    guiLayerAssemblyName.Text = assemblyName.Name;
                    AssemblyDescriptionAttribute assemblyDescription = (AssemblyDescriptionAttribute)AssemblyDescriptionAttribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute));
                    guiLayerAssemblyDescription.Text = assemblyDescription.Description;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error(s) occured when accessing layer '" + layer.name + "'", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

        #region >> *_FormClosing

        private void WinSCardGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            statusMonitor.stop();
        }

        #endregion
    }
}