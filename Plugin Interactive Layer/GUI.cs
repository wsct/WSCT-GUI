using System;
using System.Windows.Forms;
using System.Xml.Serialization;

using WSCT.Helpers;
using WSCT.Layers.Interactive;
using WSCT.Layers.Interactive.Actions;

namespace WSCT.GUI.Plugins.LayerInteractive
{
    /// <summary>
    /// Plugin dedicated form
    /// </summary>
    public partial class GUI : Form
    {
        const String defaultFileName = @"InteractiveData.xml";

        #region >> Constructor

        /// <inheritdoc />
        public GUI()
        {
            InitializeComponent();

            guiContextLayerPresence.Checked = InteractiveController.contextLayerPresence;
            guiChannelLayerPresence.Checked = InteractiveController.channelLayerPresence;

            guiUseFakeReader.Checked = InteractiveController.useFakeReader;
            guiFakeReaderName.Text = InteractiveController.fakeReaderName;

            guiInteractiveMode.DataSource = Enum.GetValues(typeof(InteractiveMode));
            guiInteractiveMode.SelectedItem = InteractiveController.mode;

            InteractiveController.interactiveModeChangedEvent += onInteractiveModeChanged;
            SharedData.cardContextChangedEvent += onCardContextChanged;
            SharedData.cardChannelChangedEvent += onCardChannelChanged;
        }

        #endregion

        #region >> on * Changed

        private void onInteractiveModeChanged()
        {
            if (guiInteractiveMode.InvokeRequired)
            {
                guiInteractiveMode.Invoke(new MethodInvoker(delegate() { guiInteractiveMode.SelectedItem = InteractiveController.mode; }));
            }
            else
            {
                guiInteractiveMode.SelectedItem = InteractiveController.mode;
            }

        }

        private void onCardContextChanged()
        {
            if (guiContextLayerPresence.InvokeRequired)
            {
                guiContextLayerPresence.Invoke(new MethodInvoker(delegate() { guiContextLayerPresence.Checked = InteractiveController.contextLayerPresence; }));
            }
            else
            {
                guiContextLayerPresence.Checked = InteractiveController.contextLayerPresence;
            }
        }

        private void onCardChannelChanged()
        {
            if (guiContextLayerPresence.InvokeRequired)
            {
                guiChannelLayerPresence.Invoke(new MethodInvoker(delegate() { guiChannelLayerPresence.Checked = InteractiveController.channelLayerPresence; }));
            }
            else
            {
                guiChannelLayerPresence.Checked = InteractiveController.channelLayerPresence;
            }
        }

        #endregion

        #region >> gui * Changed

        private void guiUseFakeReader_CheckedChanged(object sender, EventArgs e)
        {
            InteractiveController.useFakeReader = guiUseFakeReader.Checked;
        }

        private void guiInteractiveMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            InteractiveController.mode = (InteractiveMode)guiInteractiveMode.SelectedItem;
        }

        private void guiFakeReaderName_TextChanged(object sender, EventArgs e)
        {
            InteractiveController.fakeReaderName = guiFakeReaderName.Text;
        }

        #endregion

        #region >> gui * Click

        private void guiDoSaveRecordedData_Click(object sender, EventArgs e)
        {
            guiSaveFileInteractive.FileName = defaultFileName;
            if (guiSaveFileInteractive.ShowDialog() == DialogResult.OK && guiSaveFileInteractive.FileName != "")
            {
                SerializedObject<ActionsContainer>.saveToXml(new ActionsContainer(InteractiveController.actionsList), guiSaveFileInteractive.FileName);
            }
        }

        private void guiDoLoadReplayData_Click(object sender, EventArgs e)
        {
            guiOpenFileInteractive.FileName = defaultFileName;
            if (guiOpenFileInteractive.ShowDialog() == DialogResult.OK && guiOpenFileInteractive.FileName != "")
            {
                ActionsContainer actionsContainer = SerializedObject<ActionsContainer>.loadFromXml(guiOpenFileInteractive.FileName);
                InteractiveController.actionsList = actionsContainer.actionsList;
            }
            InteractiveController.actionsListId = 0;
        }

        #endregion

        #region >> gui * FormClosing

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            InteractiveController.interactiveModeChangedEvent -= onInteractiveModeChanged;
            SharedData.cardContextChangedEvent -= onCardContextChanged;
            SharedData.cardChannelChangedEvent -= onCardChannelChanged;
        }

        #endregion
    }
}