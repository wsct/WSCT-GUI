using System;
using System.Windows.Forms;
using WSCT.Helpers;
using WSCT.Layers.Interactive;
using WSCT.Layers.Interactive.Actions;

namespace WSCT.GUI.Plugins.LayerInteractive
{
    /// <summary>
    /// Plugin dedicated form.
    /// </summary>
    public partial class Gui : Form
    {
        private const String DefaultFileName = @"InteractiveData.xml";

        #region >> Constructor

        /// <inheritdoc />
        public Gui()
        {
            InitializeComponent();

            guiUseFakeReader.Checked = InteractiveController.UseFakeReader;
            guiFakeReaderName.Text = InteractiveController.FakeReaderName;

            guiInteractiveMode.DataSource = Enum.GetValues(typeof(InteractiveMode));
            guiInteractiveMode.SelectedItem = InteractiveController.Mode;

            InteractiveController.InteractiveModeChangedEvent += OnInteractiveModeChanged;
        }

        #endregion

        #region >> on * Changed

        private void OnInteractiveModeChanged()
        {
            if (guiInteractiveMode.InvokeRequired)
            {
                guiInteractiveMode.Invoke(new MethodInvoker(() => guiInteractiveMode.SelectedItem = InteractiveController.Mode));
            }
            else
            {
                guiInteractiveMode.SelectedItem = InteractiveController.Mode;
            }
        }

        #endregion

        #region >> gui * Changed

        private void guiUseFakeReader_CheckedChanged(object sender, EventArgs e)
        {
            InteractiveController.UseFakeReader = guiUseFakeReader.Checked;
        }

        private void guiInteractiveMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            InteractiveController.Mode = (InteractiveMode)guiInteractiveMode.SelectedItem;
        }

        private void guiFakeReaderName_TextChanged(object sender, EventArgs e)
        {
            InteractiveController.FakeReaderName = guiFakeReaderName.Text;
        }

        #endregion

        #region >> gui * Click

        private void guiDoSaveRecordedData_Click(object sender, EventArgs e)
        {
            guiSaveFileInteractive.FileName = DefaultFileName;
            if (guiSaveFileInteractive.ShowDialog() == DialogResult.OK && guiSaveFileInteractive.FileName != "")
            {
                SerializedObject<ActionsContainer>.SaveToXml(new ActionsContainer(InteractiveController.ActionsList), guiSaveFileInteractive.FileName);
            }
        }

        private void guiDoLoadReplayData_Click(object sender, EventArgs e)
        {
            guiOpenFileInteractive.FileName = DefaultFileName;
            if (guiOpenFileInteractive.ShowDialog() == DialogResult.OK && guiOpenFileInteractive.FileName != "")
            {
                var actionsContainer = SerializedObject<ActionsContainer>.LoadFromXml(guiOpenFileInteractive.FileName);
                InteractiveController.ActionsList = actionsContainer.ActionsList;
            }
            InteractiveController.ActionsListId = 0;
        }

        #endregion

        #region >> gui * FormClosing

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            InteractiveController.InteractiveModeChangedEvent -= OnInteractiveModeChanged;
        }

        #endregion
    }
}