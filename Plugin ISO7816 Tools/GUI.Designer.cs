namespace WSCT.GUI.Plugins.ISO7816Tools
{
    public partial class Gui
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.globalTabPage = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.guiParametersReleaseObserver = new System.Windows.Forms.Button();
            this.guiParametersAttachObserver = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.guiStatusStrip = new System.Windows.Forms.StatusStrip();
            this.guiStatusStripStatusWord = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.interchangeTabPage = new System.Windows.Forms.TabPage();
            this.guiCommandTabs = new System.Windows.Forms.TabControl();
            this.guiCommandTabSelect = new System.Windows.Forms.TabPage();
            this.guiSelectExecute = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.guiSelectUDC = new System.Windows.Forms.RichTextBox();
            this.guiSelectFCI = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guiSelectFileOccurence = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guiSelectP1 = new System.Windows.Forms.ComboBox();
            this.guiCommandTabGetResponse = new System.Windows.Forms.TabPage();
            this.guiGetResponseExecute = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.guiGetResponseLe = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.guiCommandTabReadRecord = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.guiReadRecordLe = new System.Windows.Forms.RichTextBox();
            this.guiReadRecordExecute = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.guiReadRecordP1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guiReadRecordSearchMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guiReadRecordSFI = new System.Windows.Forms.RichTextBox();
            this.guiCommandTabUpdateRecord = new System.Windows.Forms.TabPage();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.guiWriteRecordP1 = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.guiWriteRecordUDC = new System.Windows.Forms.RichTextBox();
            this.guiWriteRecordExecute = new System.Windows.Forms.Button();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.guiWriteRecordTarget = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.guiWriteRecordSFI = new System.Windows.Forms.RichTextBox();
            this.guiCommandTabAppendRecord = new System.Windows.Forms.TabPage();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.guiAppendRecordUDC = new System.Windows.Forms.RichTextBox();
            this.guiAppendRecordExecute = new System.Windows.Forms.Button();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.guiAppendRecordSFI = new System.Windows.Forms.RichTextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.guiReadBinaryExecute = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.guiReadBinaryLe = new System.Windows.Forms.RichTextBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.groupCommandAPDU = new System.Windows.Forms.GroupBox();
            this.guiLcAutoCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guiLc = new System.Windows.Forms.TextBox();
            this.labelLc = new System.Windows.Forms.Label();
            this.guiUDC = new System.Windows.Forms.TextBox();
            this.guiLe = new System.Windows.Forms.TextBox();
            this.guiSendCAPDU = new System.Windows.Forms.Button();
            this.labelLe = new System.Windows.Forms.Label();
            this.guiP2 = new System.Windows.Forms.TextBox();
            this.labelCLA = new System.Windows.Forms.Label();
            this.guiP1 = new System.Windows.Forms.TextBox();
            this.labelP2 = new System.Windows.Forms.Label();
            this.guiCLA = new System.Windows.Forms.TextBox();
            this.labelINS = new System.Windows.Forms.Label();
            this.guiINS = new System.Windows.Forms.TextBox();
            this.labelP1 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.guiCRPHistoric = new System.Windows.Forms.ListView();
            this.guiHistoricNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guiHistoricCAPDU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupResponseAPDU = new System.Windows.Forms.GroupBox();
            this.guiRAPDU = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.guiReadRecordCC = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.globalTabPage.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.guiStatusStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.interchangeTabPage.SuspendLayout();
            this.guiCommandTabs.SuspendLayout();
            this.guiCommandTabSelect.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.guiCommandTabGetResponse.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.guiCommandTabReadRecord.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.guiCommandTabUpdateRecord.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.guiCommandTabAppendRecord.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.groupCommandAPDU.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupResponseAPDU.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.groupBox35.SuspendLayout();
            this.groupBox36.SuspendLayout();
            this.groupBox37.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.SuspendLayout();
            // 
            // globalTabPage
            // 
            this.globalTabPage.Controls.Add(this.groupBox15);
            this.globalTabPage.Location = new System.Drawing.Point(23, 4);
            this.globalTabPage.Name = "globalTabPage";
            this.globalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.globalTabPage.Size = new System.Drawing.Size(290, 509);
            this.globalTabPage.TabIndex = 2;
            this.globalTabPage.Text = "Global";
            // 
            // groupBox15
            // 
            this.groupBox15.AutoSize = true;
            this.groupBox15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox15.Controls.Add(this.guiParametersReleaseObserver);
            this.groupBox15.Controls.Add(this.guiParametersAttachObserver);
            this.groupBox15.Location = new System.Drawing.Point(6, 6);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(278, 61);
            this.groupBox15.TabIndex = 5;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Card Observer";
            // 
            // guiParametersReleaseObserver
            // 
            this.guiParametersReleaseObserver.Location = new System.Drawing.Point(197, 19);
            this.guiParametersReleaseObserver.Name = "guiParametersReleaseObserver";
            this.guiParametersReleaseObserver.Size = new System.Drawing.Size(75, 23);
            this.guiParametersReleaseObserver.TabIndex = 7;
            this.guiParametersReleaseObserver.Text = "Release";
            this.guiParametersReleaseObserver.UseVisualStyleBackColor = true;
            this.guiParametersReleaseObserver.Click += new System.EventHandler(this.guiParametersReleaseObserver_Click);
            // 
            // guiParametersAttachObserver
            // 
            this.guiParametersAttachObserver.Location = new System.Drawing.Point(116, 19);
            this.guiParametersAttachObserver.Name = "guiParametersAttachObserver";
            this.guiParametersAttachObserver.Size = new System.Drawing.Size(75, 23);
            this.guiParametersAttachObserver.TabIndex = 6;
            this.guiParametersAttachObserver.Text = "Attach";
            this.guiParametersAttachObserver.UseVisualStyleBackColor = true;
            this.guiParametersAttachObserver.Click += new System.EventHandler(this.guiParametersAttachObserver_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.guiStatusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.mainTabControl);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rightPanel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 517);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(784, 564);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // guiStatusStrip
            // 
            this.guiStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.guiStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiStatusStripStatusWord});
            this.guiStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.guiStatusStrip.Name = "guiStatusStrip";
            this.guiStatusStrip.Size = new System.Drawing.Size(784, 22);
            this.guiStatusStrip.TabIndex = 0;
            // 
            // guiStatusStripStatusWord
            // 
            this.guiStatusStripStatusWord.Name = "guiStatusStripStatusWord";
            this.guiStatusStripStatusWord.Size = new System.Drawing.Size(71, 17);
            this.guiStatusStripStatusWord.Text = "StatusWord:";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainTabControl.Controls.Add(this.globalTabPage);
            this.mainTabControl.Controls.Add(this.interchangeTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainTabControl.HotTrack = true;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(317, 517);
            this.mainTabControl.TabIndex = 0;
            // 
            // interchangeTabPage
            // 
            this.interchangeTabPage.Controls.Add(this.guiCommandTabs);
            this.interchangeTabPage.Location = new System.Drawing.Point(23, 4);
            this.interchangeTabPage.Name = "interchangeTabPage";
            this.interchangeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.interchangeTabPage.Size = new System.Drawing.Size(290, 509);
            this.interchangeTabPage.TabIndex = 0;
            this.interchangeTabPage.Text = "Interchange";
            // 
            // guiCommandTabs
            // 
            this.guiCommandTabs.Controls.Add(this.guiCommandTabSelect);
            this.guiCommandTabs.Controls.Add(this.guiCommandTabGetResponse);
            this.guiCommandTabs.Controls.Add(this.tabPage1);
            this.guiCommandTabs.Controls.Add(this.tabPage8);
            this.guiCommandTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guiCommandTabs.Enabled = false;
            this.guiCommandTabs.HotTrack = true;
            this.guiCommandTabs.Location = new System.Drawing.Point(3, 3);
            this.guiCommandTabs.Multiline = true;
            this.guiCommandTabs.Name = "guiCommandTabs";
            this.guiCommandTabs.SelectedIndex = 0;
            this.guiCommandTabs.Size = new System.Drawing.Size(284, 503);
            this.guiCommandTabs.TabIndex = 0;
            // 
            // guiCommandTabSelect
            // 
            this.guiCommandTabSelect.Controls.Add(this.guiSelectExecute);
            this.guiCommandTabSelect.Controls.Add(this.groupBox3);
            this.guiCommandTabSelect.Controls.Add(this.guiSelectFCI);
            this.guiCommandTabSelect.Controls.Add(this.groupBox2);
            this.guiCommandTabSelect.Controls.Add(this.groupBox1);
            this.guiCommandTabSelect.Location = new System.Drawing.Point(4, 22);
            this.guiCommandTabSelect.Name = "guiCommandTabSelect";
            this.guiCommandTabSelect.Padding = new System.Windows.Forms.Padding(3);
            this.guiCommandTabSelect.Size = new System.Drawing.Size(276, 477);
            this.guiCommandTabSelect.TabIndex = 0;
            this.guiCommandTabSelect.Text = "SELECT";
            this.guiCommandTabSelect.UseVisualStyleBackColor = true;
            // 
            // guiSelectExecute
            // 
            this.guiSelectExecute.Location = new System.Drawing.Point(195, 264);
            this.guiSelectExecute.Name = "guiSelectExecute";
            this.guiSelectExecute.Size = new System.Drawing.Size(75, 23);
            this.guiSelectExecute.TabIndex = 5;
            this.guiSelectExecute.Text = "Execute";
            this.guiSelectExecute.UseVisualStyleBackColor = true;
            this.guiSelectExecute.Click += new System.EventHandler(this.guiSelectExecute_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.guiSelectUDC);
            this.groupBox3.Location = new System.Drawing.Point(6, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 59);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UDC";
            // 
            // guiSelectUDC
            // 
            this.guiSelectUDC.Location = new System.Drawing.Point(6, 19);
            this.guiSelectUDC.Name = "guiSelectUDC";
            this.guiSelectUDC.Size = new System.Drawing.Size(252, 21);
            this.guiSelectUDC.TabIndex = 0;
            this.guiSelectUDC.Text = "";
            // 
            // guiSelectFCI
            // 
            this.guiSelectFCI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiSelectFCI.FormattingEnabled = true;
            this.guiSelectFCI.Location = new System.Drawing.Point(12, 161);
            this.guiSelectFCI.Name = "guiSelectFCI";
            this.guiSelectFCI.Size = new System.Drawing.Size(252, 21);
            this.guiSelectFCI.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.guiSelectFileOccurence);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "P2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "File Occurence";
            // 
            // guiSelectFileOccurence
            // 
            this.guiSelectFileOccurence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiSelectFileOccurence.FormattingEnabled = true;
            this.guiSelectFileOccurence.Location = new System.Drawing.Point(6, 32);
            this.guiSelectFileOccurence.Name = "guiSelectFileOccurence";
            this.guiSelectFileOccurence.Size = new System.Drawing.Size(252, 21);
            this.guiSelectFileOccurence.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "File Control Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.guiSelectP1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "P1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selection Mode";
            // 
            // guiSelectP1
            // 
            this.guiSelectP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiSelectP1.FormattingEnabled = true;
            this.guiSelectP1.Location = new System.Drawing.Point(6, 32);
            this.guiSelectP1.Name = "guiSelectP1";
            this.guiSelectP1.Size = new System.Drawing.Size(252, 21);
            this.guiSelectP1.TabIndex = 1;
            // 
            // guiCommandTabGetResponse
            // 
            this.guiCommandTabGetResponse.Controls.Add(this.guiGetResponseExecute);
            this.guiCommandTabGetResponse.Controls.Add(this.groupBox4);
            this.guiCommandTabGetResponse.Location = new System.Drawing.Point(4, 22);
            this.guiCommandTabGetResponse.Name = "guiCommandTabGetResponse";
            this.guiCommandTabGetResponse.Padding = new System.Windows.Forms.Padding(3);
            this.guiCommandTabGetResponse.Size = new System.Drawing.Size(276, 477);
            this.guiCommandTabGetResponse.TabIndex = 2;
            this.guiCommandTabGetResponse.Text = "GET RESPONSE";
            this.guiCommandTabGetResponse.UseVisualStyleBackColor = true;
            // 
            // guiGetResponseExecute
            // 
            this.guiGetResponseExecute.Location = new System.Drawing.Point(195, 71);
            this.guiGetResponseExecute.Name = "guiGetResponseExecute";
            this.guiGetResponseExecute.Size = new System.Drawing.Size(75, 23);
            this.guiGetResponseExecute.TabIndex = 1;
            this.guiGetResponseExecute.Text = "Execute";
            this.guiGetResponseExecute.UseVisualStyleBackColor = true;
            this.guiGetResponseExecute.Click += new System.EventHandler(this.guiGetResponseExecute_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.guiGetResponseLe);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 59);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Le [hexa]";
            // 
            // guiGetResponseLe
            // 
            this.guiGetResponseLe.Location = new System.Drawing.Point(6, 19);
            this.guiGetResponseLe.Name = "guiGetResponseLe";
            this.guiGetResponseLe.Size = new System.Drawing.Size(252, 21);
            this.guiGetResponseLe.TabIndex = 0;
            this.guiGetResponseLe.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 477);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "* RECORD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.guiCommandTabReadRecord);
            this.tabControl4.Controls.Add(this.guiCommandTabUpdateRecord);
            this.tabControl4.Controls.Add(this.guiCommandTabAppendRecord);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(3, 3);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(270, 471);
            this.tabControl4.TabIndex = 0;
            // 
            // guiCommandTabReadRecord
            // 
            this.guiCommandTabReadRecord.Controls.Add(this.groupBox8);
            this.guiCommandTabReadRecord.Controls.Add(this.guiReadRecordExecute);
            this.guiCommandTabReadRecord.Controls.Add(this.groupBox7);
            this.guiCommandTabReadRecord.Controls.Add(this.groupBox5);
            this.guiCommandTabReadRecord.Location = new System.Drawing.Point(4, 22);
            this.guiCommandTabReadRecord.Name = "guiCommandTabReadRecord";
            this.guiCommandTabReadRecord.Padding = new System.Windows.Forms.Padding(3);
            this.guiCommandTabReadRecord.Size = new System.Drawing.Size(262, 445);
            this.guiCommandTabReadRecord.TabIndex = 4;
            this.guiCommandTabReadRecord.Text = "READ";
            this.guiCommandTabReadRecord.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox8.Controls.Add(this.guiReadRecordLe);
            this.groupBox8.Location = new System.Drawing.Point(6, 202);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(250, 59);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Le [hexa]";
            // 
            // guiReadRecordLe
            // 
            this.guiReadRecordLe.Location = new System.Drawing.Point(6, 19);
            this.guiReadRecordLe.Name = "guiReadRecordLe";
            this.guiReadRecordLe.Size = new System.Drawing.Size(238, 21);
            this.guiReadRecordLe.TabIndex = 0;
            this.guiReadRecordLe.Text = "";
            // 
            // guiReadRecordExecute
            // 
            this.guiReadRecordExecute.Location = new System.Drawing.Point(181, 267);
            this.guiReadRecordExecute.Name = "guiReadRecordExecute";
            this.guiReadRecordExecute.Size = new System.Drawing.Size(75, 23);
            this.guiReadRecordExecute.TabIndex = 4;
            this.guiReadRecordExecute.Text = "Execute";
            this.guiReadRecordExecute.UseVisualStyleBackColor = true;
            this.guiReadRecordExecute.Click += new System.EventHandler(this.guiReadRecordExecute_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox7.Controls.Add(this.guiReadRecordP1);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(250, 72);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "P1 [hexa]";
            // 
            // guiReadRecordP1
            // 
            this.guiReadRecordP1.Location = new System.Drawing.Point(6, 32);
            this.guiReadRecordP1.Name = "guiReadRecordP1";
            this.guiReadRecordP1.Size = new System.Drawing.Size(238, 21);
            this.guiReadRecordP1.TabIndex = 1;
            this.guiReadRecordP1.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Record Number or Identifier";
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.guiReadRecordSearchMode);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.guiReadRecordSFI);
            this.groupBox5.Location = new System.Drawing.Point(6, 84);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 112);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "P2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Search mode";
            // 
            // guiReadRecordSearchMode
            // 
            this.guiReadRecordSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiReadRecordSearchMode.FormattingEnabled = true;
            this.guiReadRecordSearchMode.Location = new System.Drawing.Point(6, 72);
            this.guiReadRecordSearchMode.Name = "guiReadRecordSearchMode";
            this.guiReadRecordSearchMode.Size = new System.Drawing.Size(238, 21);
            this.guiReadRecordSearchMode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Short File Identifier (5 bits) [hexa]";
            // 
            // guiReadRecordSFI
            // 
            this.guiReadRecordSFI.Location = new System.Drawing.Point(6, 32);
            this.guiReadRecordSFI.Name = "guiReadRecordSFI";
            this.guiReadRecordSFI.Size = new System.Drawing.Size(238, 21);
            this.guiReadRecordSFI.TabIndex = 1;
            this.guiReadRecordSFI.Text = "";
            // 
            // guiCommandTabUpdateRecord
            // 
            this.guiCommandTabUpdateRecord.Controls.Add(this.groupBox28);
            this.guiCommandTabUpdateRecord.Controls.Add(this.groupBox27);
            this.guiCommandTabUpdateRecord.Controls.Add(this.guiWriteRecordExecute);
            this.guiCommandTabUpdateRecord.Controls.Add(this.groupBox24);
            this.guiCommandTabUpdateRecord.Location = new System.Drawing.Point(4, 22);
            this.guiCommandTabUpdateRecord.Name = "guiCommandTabUpdateRecord";
            this.guiCommandTabUpdateRecord.Padding = new System.Windows.Forms.Padding(3);
            this.guiCommandTabUpdateRecord.Size = new System.Drawing.Size(262, 445);
            this.guiCommandTabUpdateRecord.TabIndex = 8;
            this.guiCommandTabUpdateRecord.Text = "WRITE";
            this.guiCommandTabUpdateRecord.UseVisualStyleBackColor = true;
            // 
            // groupBox28
            // 
            this.groupBox28.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox28.Controls.Add(this.guiWriteRecordP1);
            this.groupBox28.Controls.Add(this.label20);
            this.groupBox28.Location = new System.Drawing.Point(6, 6);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(250, 72);
            this.groupBox28.TabIndex = 0;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "P1 [hexa]";
            // 
            // guiWriteRecordP1
            // 
            this.guiWriteRecordP1.Location = new System.Drawing.Point(6, 32);
            this.guiWriteRecordP1.Name = "guiWriteRecordP1";
            this.guiWriteRecordP1.Size = new System.Drawing.Size(238, 21);
            this.guiWriteRecordP1.TabIndex = 1;
            this.guiWriteRecordP1.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Record Number or Identifier";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.guiWriteRecordUDC);
            this.groupBox27.Location = new System.Drawing.Point(6, 201);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(250, 59);
            this.groupBox27.TabIndex = 2;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "UDC";
            // 
            // guiWriteRecordUDC
            // 
            this.guiWriteRecordUDC.Location = new System.Drawing.Point(6, 19);
            this.guiWriteRecordUDC.Name = "guiWriteRecordUDC";
            this.guiWriteRecordUDC.Size = new System.Drawing.Size(238, 21);
            this.guiWriteRecordUDC.TabIndex = 0;
            this.guiWriteRecordUDC.Text = "";
            // 
            // guiWriteRecordExecute
            // 
            this.guiWriteRecordExecute.Location = new System.Drawing.Point(181, 266);
            this.guiWriteRecordExecute.Name = "guiWriteRecordExecute";
            this.guiWriteRecordExecute.Size = new System.Drawing.Size(75, 23);
            this.guiWriteRecordExecute.TabIndex = 3;
            this.guiWriteRecordExecute.Text = "Execute";
            this.guiWriteRecordExecute.UseVisualStyleBackColor = true;
            this.guiWriteRecordExecute.Click += new System.EventHandler(this.guiWriteRecordExecute_Click);
            // 
            // groupBox24
            // 
            this.groupBox24.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox24.Controls.Add(this.label21);
            this.groupBox24.Controls.Add(this.guiWriteRecordTarget);
            this.groupBox24.Controls.Add(this.label23);
            this.groupBox24.Controls.Add(this.guiWriteRecordSFI);
            this.groupBox24.Location = new System.Drawing.Point(6, 83);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(250, 112);
            this.groupBox24.TabIndex = 1;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "P2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "P1 target";
            // 
            // guiWriteRecordTarget
            // 
            this.guiWriteRecordTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiWriteRecordTarget.FormattingEnabled = true;
            this.guiWriteRecordTarget.Location = new System.Drawing.Point(6, 72);
            this.guiWriteRecordTarget.Name = "guiWriteRecordTarget";
            this.guiWriteRecordTarget.Size = new System.Drawing.Size(238, 21);
            this.guiWriteRecordTarget.TabIndex = 3;
            this.guiWriteRecordTarget.SelectedIndexChanged += new System.EventHandler(this.guiWriteRecordTarget_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(160, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Short File Identifier (5 bits) [hexa]";
            // 
            // guiWriteRecordSFI
            // 
            this.guiWriteRecordSFI.Location = new System.Drawing.Point(6, 32);
            this.guiWriteRecordSFI.Name = "guiWriteRecordSFI";
            this.guiWriteRecordSFI.Size = new System.Drawing.Size(252, 21);
            this.guiWriteRecordSFI.TabIndex = 1;
            this.guiWriteRecordSFI.Text = "";
            // 
            // guiCommandTabAppendRecord
            // 
            this.guiCommandTabAppendRecord.Controls.Add(this.groupBox26);
            this.guiCommandTabAppendRecord.Controls.Add(this.guiAppendRecordExecute);
            this.guiCommandTabAppendRecord.Controls.Add(this.groupBox25);
            this.guiCommandTabAppendRecord.Location = new System.Drawing.Point(4, 22);
            this.guiCommandTabAppendRecord.Name = "guiCommandTabAppendRecord";
            this.guiCommandTabAppendRecord.Padding = new System.Windows.Forms.Padding(3);
            this.guiCommandTabAppendRecord.Size = new System.Drawing.Size(262, 445);
            this.guiCommandTabAppendRecord.TabIndex = 9;
            this.guiCommandTabAppendRecord.Text = "APPEND";
            this.guiCommandTabAppendRecord.UseVisualStyleBackColor = true;
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.guiAppendRecordUDC);
            this.groupBox26.Location = new System.Drawing.Point(6, 84);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(250, 59);
            this.groupBox26.TabIndex = 1;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "UDC";
            // 
            // guiAppendRecordUDC
            // 
            this.guiAppendRecordUDC.Location = new System.Drawing.Point(6, 19);
            this.guiAppendRecordUDC.Name = "guiAppendRecordUDC";
            this.guiAppendRecordUDC.Size = new System.Drawing.Size(238, 21);
            this.guiAppendRecordUDC.TabIndex = 0;
            this.guiAppendRecordUDC.Text = "";
            // 
            // guiAppendRecordExecute
            // 
            this.guiAppendRecordExecute.Location = new System.Drawing.Point(181, 149);
            this.guiAppendRecordExecute.Name = "guiAppendRecordExecute";
            this.guiAppendRecordExecute.Size = new System.Drawing.Size(75, 23);
            this.guiAppendRecordExecute.TabIndex = 2;
            this.guiAppendRecordExecute.Text = "Execute";
            this.guiAppendRecordExecute.UseVisualStyleBackColor = true;
            this.guiAppendRecordExecute.Click += new System.EventHandler(this.guiAppendRecordExecute_Click);
            // 
            // groupBox25
            // 
            this.groupBox25.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox25.Controls.Add(this.label22);
            this.groupBox25.Controls.Add(this.guiAppendRecordSFI);
            this.groupBox25.Location = new System.Drawing.Point(6, 6);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(250, 72);
            this.groupBox25.TabIndex = 0;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "P2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Short File Identifier (5 bits) [hexa]";
            // 
            // guiAppendRecordSFI
            // 
            this.guiAppendRecordSFI.Location = new System.Drawing.Point(6, 32);
            this.guiAppendRecordSFI.Name = "guiAppendRecordSFI";
            this.guiAppendRecordSFI.Size = new System.Drawing.Size(238, 21);
            this.guiAppendRecordSFI.TabIndex = 1;
            this.guiAppendRecordSFI.Text = "";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tabControl3);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(276, 477);
            this.tabPage8.TabIndex = 9;
            this.tabPage8.Text = "* BINARY";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage11);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.HotTrack = true;
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Multiline = true;
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(270, 471);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.guiReadBinaryExecute);
            this.tabPage11.Controls.Add(this.groupBox6);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(262, 445);
            this.tabPage11.TabIndex = 6;
            this.tabPage11.Text = "READ BINARY";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // guiReadBinaryExecute
            // 
            this.guiReadBinaryExecute.Location = new System.Drawing.Point(181, 71);
            this.guiReadBinaryExecute.Name = "guiReadBinaryExecute";
            this.guiReadBinaryExecute.Size = new System.Drawing.Size(75, 23);
            this.guiReadBinaryExecute.TabIndex = 5;
            this.guiReadBinaryExecute.Text = "Execute";
            this.guiReadBinaryExecute.UseVisualStyleBackColor = true;
            this.guiReadBinaryExecute.Click += new System.EventHandler(this.guiReadBinaryExecute_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox6.Controls.Add(this.guiReadBinaryLe);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 59);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Le [hexa]";
            // 
            // guiReadBinaryLe
            // 
            this.guiReadBinaryLe.Location = new System.Drawing.Point(6, 19);
            this.guiReadBinaryLe.Name = "guiReadBinaryLe";
            this.guiReadBinaryLe.Size = new System.Drawing.Size(238, 21);
            this.guiReadBinaryLe.TabIndex = 0;
            this.guiReadBinaryLe.Text = "";
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Controls.Add(this.groupCommandAPDU);
            this.rightPanel.Controls.Add(this.groupBox16);
            this.rightPanel.Controls.Add(this.groupResponseAPDU);
            this.rightPanel.Location = new System.Drawing.Point(322, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(459, 510);
            this.rightPanel.TabIndex = 1;
            // 
            // groupCommandAPDU
            // 
            this.groupCommandAPDU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCommandAPDU.Controls.Add(this.guiLcAutoCheckBox);
            this.groupCommandAPDU.Controls.Add(this.label5);
            this.groupCommandAPDU.Controls.Add(this.guiLc);
            this.groupCommandAPDU.Controls.Add(this.labelLc);
            this.groupCommandAPDU.Controls.Add(this.guiUDC);
            this.groupCommandAPDU.Controls.Add(this.guiLe);
            this.groupCommandAPDU.Controls.Add(this.guiSendCAPDU);
            this.groupCommandAPDU.Controls.Add(this.labelLe);
            this.groupCommandAPDU.Controls.Add(this.guiP2);
            this.groupCommandAPDU.Controls.Add(this.labelCLA);
            this.groupCommandAPDU.Controls.Add(this.guiP1);
            this.groupCommandAPDU.Controls.Add(this.labelP2);
            this.groupCommandAPDU.Controls.Add(this.guiCLA);
            this.groupCommandAPDU.Controls.Add(this.labelINS);
            this.groupCommandAPDU.Controls.Add(this.guiINS);
            this.groupCommandAPDU.Controls.Add(this.labelP1);
            this.groupCommandAPDU.Location = new System.Drawing.Point(3, 3);
            this.groupCommandAPDU.Name = "groupCommandAPDU";
            this.groupCommandAPDU.Size = new System.Drawing.Size(447, 184);
            this.groupCommandAPDU.TabIndex = 0;
            this.groupCommandAPDU.TabStop = false;
            this.groupCommandAPDU.Text = "Command APDU";
            // 
            // guiLcAutoCheckBox
            // 
            this.guiLcAutoCheckBox.AutoSize = true;
            this.guiLcAutoCheckBox.Location = new System.Drawing.Point(42, 142);
            this.guiLcAutoCheckBox.Name = "guiLcAutoCheckBox";
            this.guiLcAutoCheckBox.Size = new System.Drawing.Size(63, 17);
            this.guiLcAutoCheckBox.TabIndex = 16;
            this.guiLcAutoCheckBox.Text = "Lc Auto";
            this.guiLcAutoCheckBox.UseVisualStyleBackColor = true;
            this.guiLcAutoCheckBox.CheckedChanged += new System.EventHandler(this.guiLcAutoCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "UDC:";
            // 
            // guiLc
            // 
            this.guiLc.Location = new System.Drawing.Point(286, 19);
            this.guiLc.MaxLength = 2;
            this.guiLc.Name = "guiLc";
            this.guiLc.Size = new System.Drawing.Size(25, 20);
            this.guiLc.TabIndex = 9;
            // 
            // labelLc
            // 
            this.labelLc.AutoSize = true;
            this.labelLc.Location = new System.Drawing.Point(258, 22);
            this.labelLc.Name = "labelLc";
            this.labelLc.Size = new System.Drawing.Size(22, 13);
            this.labelLc.TabIndex = 8;
            this.labelLc.Text = "Lc:";
            // 
            // guiUDC
            // 
            this.guiUDC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiUDC.Location = new System.Drawing.Point(42, 45);
            this.guiUDC.MaxLength = 32000;
            this.guiUDC.Multiline = true;
            this.guiUDC.Name = "guiUDC";
            this.guiUDC.Size = new System.Drawing.Size(399, 91);
            this.guiUDC.TabIndex = 12;
            // 
            // guiLe
            // 
            this.guiLe.Location = new System.Drawing.Point(416, 19);
            this.guiLe.MaxLength = 2;
            this.guiLe.Name = "guiLe";
            this.guiLe.Size = new System.Drawing.Size(25, 20);
            this.guiLe.TabIndex = 11;
            // 
            // guiSendCAPDU
            // 
            this.guiSendCAPDU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guiSendCAPDU.Location = new System.Drawing.Point(349, 142);
            this.guiSendCAPDU.Name = "guiSendCAPDU";
            this.guiSendCAPDU.Size = new System.Drawing.Size(92, 23);
            this.guiSendCAPDU.TabIndex = 13;
            this.guiSendCAPDU.Text = "Send C-APDU";
            this.guiSendCAPDU.UseVisualStyleBackColor = true;
            this.guiSendCAPDU.Click += new System.EventHandler(this.guiSendCAPDU_Click);
            // 
            // labelLe
            // 
            this.labelLe.AutoSize = true;
            this.labelLe.Location = new System.Drawing.Point(388, 23);
            this.labelLe.Name = "labelLe";
            this.labelLe.Size = new System.Drawing.Size(22, 13);
            this.labelLe.TabIndex = 10;
            this.labelLe.Text = "Le:";
            // 
            // guiP2
            // 
            this.guiP2.Location = new System.Drawing.Point(227, 19);
            this.guiP2.MaxLength = 2;
            this.guiP2.Name = "guiP2";
            this.guiP2.Size = new System.Drawing.Size(25, 20);
            this.guiP2.TabIndex = 7;
            // 
            // labelCLA
            // 
            this.labelCLA.AutoSize = true;
            this.labelCLA.Location = new System.Drawing.Point(6, 22);
            this.labelCLA.Name = "labelCLA";
            this.labelCLA.Size = new System.Drawing.Size(30, 13);
            this.labelCLA.TabIndex = 0;
            this.labelCLA.Text = "CLA:";
            // 
            // guiP1
            // 
            this.guiP1.Location = new System.Drawing.Point(167, 19);
            this.guiP1.MaxLength = 2;
            this.guiP1.Name = "guiP1";
            this.guiP1.Size = new System.Drawing.Size(25, 20);
            this.guiP1.TabIndex = 5;
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Location = new System.Drawing.Point(198, 22);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(23, 13);
            this.labelP2.TabIndex = 6;
            this.labelP2.Text = "P2:";
            // 
            // guiCLA
            // 
            this.guiCLA.Location = new System.Drawing.Point(42, 19);
            this.guiCLA.MaxLength = 2;
            this.guiCLA.Name = "guiCLA";
            this.guiCLA.Size = new System.Drawing.Size(25, 20);
            this.guiCLA.TabIndex = 1;
            // 
            // labelINS
            // 
            this.labelINS.AutoSize = true;
            this.labelINS.Location = new System.Drawing.Point(73, 22);
            this.labelINS.Name = "labelINS";
            this.labelINS.Size = new System.Drawing.Size(28, 13);
            this.labelINS.TabIndex = 2;
            this.labelINS.Text = "INS:";
            // 
            // guiINS
            // 
            this.guiINS.Location = new System.Drawing.Point(107, 19);
            this.guiINS.MaxLength = 2;
            this.guiINS.Name = "guiINS";
            this.guiINS.Size = new System.Drawing.Size(25, 20);
            this.guiINS.TabIndex = 3;
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Location = new System.Drawing.Point(138, 22);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(23, 13);
            this.labelP1.TabIndex = 4;
            this.labelP1.Text = "P1:";
            // 
            // groupBox16
            // 
            this.groupBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox16.Controls.Add(this.guiCRPHistoric);
            this.groupBox16.Location = new System.Drawing.Point(3, 359);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(447, 148);
            this.groupBox16.TabIndex = 2;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Commands historic";
            // 
            // guiCRPHistoric
            // 
            this.guiCRPHistoric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiCRPHistoric.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.guiHistoricNumber,
            this.guiHistoricCAPDU});
            this.guiCRPHistoric.FullRowSelect = true;
            this.guiCRPHistoric.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.guiCRPHistoric.HideSelection = false;
            this.guiCRPHistoric.Location = new System.Drawing.Point(6, 19);
            this.guiCRPHistoric.MultiSelect = false;
            this.guiCRPHistoric.Name = "guiCRPHistoric";
            this.guiCRPHistoric.Size = new System.Drawing.Size(435, 123);
            this.guiCRPHistoric.TabIndex = 0;
            this.guiCRPHistoric.UseCompatibleStateImageBehavior = false;
            this.guiCRPHistoric.View = System.Windows.Forms.View.Details;
            this.guiCRPHistoric.SelectedIndexChanged += new System.EventHandler(this.guiCRPHistoric_SelectedIndexChanged);
            // 
            // guiHistoricNumber
            // 
            this.guiHistoricNumber.Text = "N°";
            this.guiHistoricNumber.Width = 30;
            // 
            // guiHistoricCAPDU
            // 
            this.guiHistoricCAPDU.Text = "CAPDU";
            this.guiHistoricCAPDU.Width = 400;
            // 
            // groupResponseAPDU
            // 
            this.groupResponseAPDU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupResponseAPDU.Controls.Add(this.guiRAPDU);
            this.groupResponseAPDU.Location = new System.Drawing.Point(3, 193);
            this.groupResponseAPDU.Name = "groupResponseAPDU";
            this.groupResponseAPDU.Size = new System.Drawing.Size(447, 160);
            this.groupResponseAPDU.TabIndex = 1;
            this.groupResponseAPDU.TabStop = false;
            this.groupResponseAPDU.Text = "Response APDU";
            // 
            // guiRAPDU
            // 
            this.guiRAPDU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiRAPDU.Location = new System.Drawing.Point(6, 19);
            this.guiRAPDU.Name = "guiRAPDU";
            this.guiRAPDU.ReadOnly = true;
            this.guiRAPDU.Size = new System.Drawing.Size(435, 122);
            this.guiRAPDU.TabIndex = 0;
            this.guiRAPDU.TabStop = false;
            this.guiRAPDU.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Selection Mode";
            // 
            // groupBox29
            // 
            this.groupBox29.AutoSize = true;
            this.groupBox29.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox29.Controls.Add(this.richTextBox1);
            this.groupBox29.Location = new System.Drawing.Point(6, 305);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(264, 59);
            this.groupBox29.TabIndex = 4;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Le [hexa]";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 21);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox30
            // 
            this.groupBox30.AutoSize = true;
            this.groupBox30.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox30.Controls.Add(this.label24);
            this.groupBox30.Controls.Add(this.comboBox3);
            this.groupBox30.Location = new System.Drawing.Point(6, 71);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(264, 72);
            this.groupBox30.TabIndex = 1;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "P1 [b8]";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Selection Mode";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 32);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(252, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // groupBox31
            // 
            this.groupBox31.AutoSize = true;
            this.groupBox31.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox31.Controls.Add(this.comboBox4);
            this.groupBox31.Location = new System.Drawing.Point(6, 6);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(264, 59);
            this.groupBox31.TabIndex = 0;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "READ BINARY";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(6, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(252, 21);
            this.comboBox4.TabIndex = 0;
            // 
            // groupBox32
            // 
            this.groupBox32.AutoSize = true;
            this.groupBox32.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox32.Controls.Add(this.richTextBox2);
            this.groupBox32.Controls.Add(this.label25);
            this.groupBox32.Location = new System.Drawing.Point(6, 149);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(264, 72);
            this.groupBox32.TabIndex = 2;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "P1 [b7...b1]";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 32);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(252, 21);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Short File Identifier";
            // 
            // groupBox33
            // 
            this.groupBox33.AutoSize = true;
            this.groupBox33.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox33.Controls.Add(this.richTextBox3);
            this.groupBox33.Controls.Add(this.label26);
            this.groupBox33.Location = new System.Drawing.Point(6, 227);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(264, 72);
            this.groupBox33.TabIndex = 3;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "(P1) P2";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(6, 32);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(252, 21);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Offset";
            // 
            // groupBox34
            // 
            this.groupBox34.AutoSize = true;
            this.groupBox34.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox34.Controls.Add(this.richTextBox4);
            this.groupBox34.Location = new System.Drawing.Point(6, 305);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(264, 59);
            this.groupBox34.TabIndex = 4;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "Le [hexa]";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(6, 19);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(252, 21);
            this.richTextBox4.TabIndex = 0;
            this.richTextBox4.Text = "";
            // 
            // groupBox35
            // 
            this.groupBox35.AutoSize = true;
            this.groupBox35.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox35.Controls.Add(this.label27);
            this.groupBox35.Controls.Add(this.comboBox5);
            this.groupBox35.Location = new System.Drawing.Point(6, 71);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Size = new System.Drawing.Size(264, 72);
            this.groupBox35.TabIndex = 1;
            this.groupBox35.TabStop = false;
            this.groupBox35.Text = "P1 [b8]";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(81, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Selection Mode";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(6, 32);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(252, 21);
            this.comboBox5.TabIndex = 1;
            // 
            // groupBox36
            // 
            this.groupBox36.AutoSize = true;
            this.groupBox36.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox36.Controls.Add(this.comboBox6);
            this.groupBox36.Location = new System.Drawing.Point(6, 6);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Size = new System.Drawing.Size(264, 59);
            this.groupBox36.TabIndex = 0;
            this.groupBox36.TabStop = false;
            this.groupBox36.Text = "READ BINARY";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(6, 19);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(252, 21);
            this.comboBox6.TabIndex = 0;
            // 
            // groupBox37
            // 
            this.groupBox37.AutoSize = true;
            this.groupBox37.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox37.Controls.Add(this.richTextBox5);
            this.groupBox37.Controls.Add(this.label28);
            this.groupBox37.Location = new System.Drawing.Point(6, 149);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Size = new System.Drawing.Size(264, 72);
            this.groupBox37.TabIndex = 2;
            this.groupBox37.TabStop = false;
            this.groupBox37.Text = "P1 [b7...b1]";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(6, 32);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(252, 21);
            this.richTextBox5.TabIndex = 1;
            this.richTextBox5.Text = "";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(94, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Short File Identifier";
            // 
            // groupBox38
            // 
            this.groupBox38.AutoSize = true;
            this.groupBox38.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox38.Controls.Add(this.richTextBox6);
            this.groupBox38.Controls.Add(this.label29);
            this.groupBox38.Location = new System.Drawing.Point(6, 227);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(264, 72);
            this.groupBox38.TabIndex = 3;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "(P1) P2";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(6, 32);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(252, 21);
            this.richTextBox6.TabIndex = 1;
            this.richTextBox6.Text = "";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Offset";
            // 
            // guiReadRecordCC
            // 
            this.guiReadRecordCC.Location = new System.Drawing.Point(7, 19);
            this.guiReadRecordCC.Name = "guiReadRecordCC";
            this.guiReadRecordCC.Size = new System.Drawing.Size(281, 21);
            this.guiReadRecordCC.TabIndex = 1;
            this.guiReadRecordCC.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(282, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Execute";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Gui";
            this.Text = "ISO7816 Tools Plugin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.globalTabPage.ResumeLayout(false);
            this.globalTabPage.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.guiStatusStrip.ResumeLayout(false);
            this.guiStatusStrip.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.interchangeTabPage.ResumeLayout(false);
            this.guiCommandTabs.ResumeLayout(false);
            this.guiCommandTabSelect.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guiCommandTabGetResponse.ResumeLayout(false);
            this.guiCommandTabGetResponse.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.guiCommandTabReadRecord.ResumeLayout(false);
            this.guiCommandTabReadRecord.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.guiCommandTabUpdateRecord.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.guiCommandTabAppendRecord.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.groupCommandAPDU.ResumeLayout(false);
            this.groupCommandAPDU.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupResponseAPDU.ResumeLayout(false);
            this.groupBox29.ResumeLayout(false);
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            this.groupBox36.ResumeLayout(false);
            this.groupBox37.ResumeLayout(false);
            this.groupBox37.PerformLayout();
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button guiSelectExecute;
        private System.Windows.Forms.RichTextBox guiSelectUDC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox guiSelectFCI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox guiSelectFileOccurence;
        private System.Windows.Forms.ComboBox guiSelectP1;
        private System.Windows.Forms.Button guiGetResponseExecute;
        private System.Windows.Forms.RichTextBox guiGetResponseLe;
        private System.Windows.Forms.RichTextBox guiReadRecordCC;
        private System.Windows.Forms.ToolStripStatusLabel guiStatusStripStatusWord;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox guiLc;
        private System.Windows.Forms.TextBox guiUDC;
        private System.Windows.Forms.TextBox guiLe;
        private System.Windows.Forms.Button guiSendCAPDU;
        private System.Windows.Forms.TextBox guiP2;
        private System.Windows.Forms.TextBox guiP1;
        private System.Windows.Forms.TextBox guiCLA;
        private System.Windows.Forms.TextBox guiINS;
        private System.Windows.Forms.RichTextBox guiRAPDU;
        internal System.Windows.Forms.ListView guiCRPHistoric;
        private System.Windows.Forms.TabPage interchangeTabPage;
        private System.Windows.Forms.Button guiParametersReleaseObserver;
        private System.Windows.Forms.Button guiParametersAttachObserver;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox guiReadRecordLe;
        private System.Windows.Forms.Button guiReadRecordExecute;
        private System.Windows.Forms.RichTextBox guiReadRecordP1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox guiReadRecordSearchMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox guiReadRecordSFI;
        private System.Windows.Forms.RichTextBox guiWriteRecordP1;
        private System.Windows.Forms.RichTextBox guiWriteRecordUDC;
        private System.Windows.Forms.Button guiWriteRecordExecute;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox guiWriteRecordTarget;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RichTextBox guiWriteRecordSFI;
        private System.Windows.Forms.RichTextBox guiAppendRecordUDC;
        private System.Windows.Forms.Button guiAppendRecordExecute;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox guiAppendRecordSFI;
        private System.Windows.Forms.Button guiReadBinaryExecute;
        private System.Windows.Forms.RichTextBox guiReadBinaryLe;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip guiStatusStrip;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TabControl guiCommandTabs;
        private System.Windows.Forms.TabPage guiCommandTabSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage guiCommandTabGetResponse;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage guiCommandTabReadRecord;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabPage guiCommandTabUpdateRecord;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.TabPage guiCommandTabAppendRecord;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.GroupBox groupCommandAPDU;
        private System.Windows.Forms.Label labelLc;
        private System.Windows.Forms.Label labelLe;
        private System.Windows.Forms.Label labelCLA;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelINS;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ColumnHeader guiHistoricNumber;
        private System.Windows.Forms.ColumnHeader guiHistoricCAPDU;
        private System.Windows.Forms.GroupBox groupResponseAPDU;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.GroupBox groupBox35;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.GroupBox groupBox37;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox38;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TabPage globalTabPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox guiLcAutoCheckBox;
    }
}