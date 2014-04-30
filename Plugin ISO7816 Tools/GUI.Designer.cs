namespace WSCT.GUI.Plugins.ISO7816Tools
{
	partial class Gui
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
            System.Windows.Forms.ToolStripContainer toolStripContainer1;
            System.Windows.Forms.StatusStrip statusStrip1;
            System.Windows.Forms.TabControl tabControl1;
            System.Windows.Forms.TabPage tabPage5;
            System.Windows.Forms.GroupBox groupBox15;
            System.Windows.Forms.GroupBox groupBox9;
            System.Windows.Forms.TabControl guiCommandTabs;
            System.Windows.Forms.TabPage guiCommandTabSelect;
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.TabPage guiCommandTabGetResponse;
            System.Windows.Forms.GroupBox groupBox4;
            System.Windows.Forms.TabControl tabControl4;
            System.Windows.Forms.TabPage guiCommandTabReadRecord;
            System.Windows.Forms.GroupBox groupBox8;
            System.Windows.Forms.GroupBox groupBox7;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.GroupBox groupBox5;
            System.Windows.Forms.TabPage guiCommandTabUpdateRecord;
            System.Windows.Forms.GroupBox groupBox28;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.GroupBox groupBox27;
            System.Windows.Forms.GroupBox groupBox24;
            System.Windows.Forms.TabPage guiCommandTabAppendRecord;
            System.Windows.Forms.GroupBox groupBox26;
            System.Windows.Forms.GroupBox groupBox25;
            System.Windows.Forms.TabControl tabControl3;
            System.Windows.Forms.TabPage tabPage11;
            System.Windows.Forms.TabControl tabControl2;
            System.Windows.Forms.TabPage tabPage2;
            System.Windows.Forms.Panel rightPanel;
            System.Windows.Forms.GroupBox groupCommandAPDU;
            System.Windows.Forms.Label labelLc;
            System.Windows.Forms.Label labelLe;
            System.Windows.Forms.Label labelCLA;
            System.Windows.Forms.Label labelP2;
            System.Windows.Forms.Label labelINS;
            System.Windows.Forms.Label labelP1;
            System.Windows.Forms.GroupBox groupBox16;
            System.Windows.Forms.ColumnHeader guiHistoricNumber;
            System.Windows.Forms.ColumnHeader guiHistoricCAPDU;
            System.Windows.Forms.GroupBox groupResponseAPDU;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.GroupBox groupBox29;
            System.Windows.Forms.GroupBox groupBox30;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.GroupBox groupBox31;
            System.Windows.Forms.GroupBox groupBox32;
            System.Windows.Forms.Label label25;
            System.Windows.Forms.GroupBox groupBox33;
            System.Windows.Forms.Label label26;
            System.Windows.Forms.GroupBox groupBox34;
            System.Windows.Forms.GroupBox groupBox35;
            System.Windows.Forms.Label label27;
            System.Windows.Forms.GroupBox groupBox36;
            System.Windows.Forms.GroupBox groupBox37;
            System.Windows.Forms.Label label28;
            System.Windows.Forms.GroupBox groupBox38;
            System.Windows.Forms.Label label29;
            System.Windows.Forms.GroupBox groupBox6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.guiStatusStatusWord = new System.Windows.Forms.ToolStripStatusLabel();
            this.guiParametersReleaseObserver = new System.Windows.Forms.Button();
            this.guiParametersAttachObserver = new System.Windows.Forms.Button();
            this.guiParametersProtocolT = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.guiSelectExecute = new System.Windows.Forms.Button();
            this.guiSelectUDC = new System.Windows.Forms.RichTextBox();
            this.guiSelectFCI = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guiSelectFileOccurence = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guiSelectP1 = new System.Windows.Forms.ComboBox();
            this.guiGetResponseExecute = new System.Windows.Forms.Button();
            this.guiGetResponseLe = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guiReadRecordLe = new System.Windows.Forms.RichTextBox();
            this.guiReadRecordExecute = new System.Windows.Forms.Button();
            this.guiReadRecordP1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guiReadRecordSearchMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guiReadRecordSFI = new System.Windows.Forms.RichTextBox();
            this.guiWriteRecordP1 = new System.Windows.Forms.RichTextBox();
            this.guiWriteRecordUDC = new System.Windows.Forms.RichTextBox();
            this.guiWriteRecordExecute = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.guiWriteRecordTarget = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.guiWriteRecordSFI = new System.Windows.Forms.RichTextBox();
            this.guiAppendRecordUDC = new System.Windows.Forms.RichTextBox();
            this.guiAppendRecordExecute = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.guiAppendRecordSFI = new System.Windows.Forms.RichTextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.guiLc = new System.Windows.Forms.TextBox();
            this.guiUDC = new System.Windows.Forms.TextBox();
            this.guiLe = new System.Windows.Forms.TextBox();
            this.guiSendCAPDU = new System.Windows.Forms.Button();
            this.guiP2 = new System.Windows.Forms.TextBox();
            this.guiP1 = new System.Windows.Forms.TextBox();
            this.guiCLA = new System.Windows.Forms.TextBox();
            this.guiINS = new System.Windows.Forms.TextBox();
            this.guiCRPHistoric = new System.Windows.Forms.ListView();
            this.guiRAPDU = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.guiReadRecordCC = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.guiReadBinaryLe = new System.Windows.Forms.RichTextBox();
            this.guiReadBinaryExecute = new System.Windows.Forms.Button();
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage5 = new System.Windows.Forms.TabPage();
            groupBox15 = new System.Windows.Forms.GroupBox();
            groupBox9 = new System.Windows.Forms.GroupBox();
            guiCommandTabs = new System.Windows.Forms.TabControl();
            guiCommandTabSelect = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            guiCommandTabGetResponse = new System.Windows.Forms.TabPage();
            groupBox4 = new System.Windows.Forms.GroupBox();
            tabControl4 = new System.Windows.Forms.TabControl();
            guiCommandTabReadRecord = new System.Windows.Forms.TabPage();
            groupBox8 = new System.Windows.Forms.GroupBox();
            groupBox7 = new System.Windows.Forms.GroupBox();
            label7 = new System.Windows.Forms.Label();
            groupBox5 = new System.Windows.Forms.GroupBox();
            guiCommandTabUpdateRecord = new System.Windows.Forms.TabPage();
            groupBox28 = new System.Windows.Forms.GroupBox();
            label20 = new System.Windows.Forms.Label();
            groupBox27 = new System.Windows.Forms.GroupBox();
            groupBox24 = new System.Windows.Forms.GroupBox();
            guiCommandTabAppendRecord = new System.Windows.Forms.TabPage();
            groupBox26 = new System.Windows.Forms.GroupBox();
            groupBox25 = new System.Windows.Forms.GroupBox();
            tabControl3 = new System.Windows.Forms.TabControl();
            tabPage11 = new System.Windows.Forms.TabPage();
            tabControl2 = new System.Windows.Forms.TabControl();
            tabPage2 = new System.Windows.Forms.TabPage();
            rightPanel = new System.Windows.Forms.Panel();
            groupCommandAPDU = new System.Windows.Forms.GroupBox();
            labelLc = new System.Windows.Forms.Label();
            labelLe = new System.Windows.Forms.Label();
            labelCLA = new System.Windows.Forms.Label();
            labelP2 = new System.Windows.Forms.Label();
            labelINS = new System.Windows.Forms.Label();
            labelP1 = new System.Windows.Forms.Label();
            groupBox16 = new System.Windows.Forms.GroupBox();
            guiHistoricNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            guiHistoricCAPDU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            groupResponseAPDU = new System.Windows.Forms.GroupBox();
            label10 = new System.Windows.Forms.Label();
            groupBox29 = new System.Windows.Forms.GroupBox();
            groupBox30 = new System.Windows.Forms.GroupBox();
            label24 = new System.Windows.Forms.Label();
            groupBox31 = new System.Windows.Forms.GroupBox();
            groupBox32 = new System.Windows.Forms.GroupBox();
            label25 = new System.Windows.Forms.Label();
            groupBox33 = new System.Windows.Forms.GroupBox();
            label26 = new System.Windows.Forms.Label();
            groupBox34 = new System.Windows.Forms.GroupBox();
            groupBox35 = new System.Windows.Forms.GroupBox();
            label27 = new System.Windows.Forms.Label();
            groupBox36 = new System.Windows.Forms.GroupBox();
            groupBox37 = new System.Windows.Forms.GroupBox();
            label28 = new System.Windows.Forms.Label();
            groupBox38 = new System.Windows.Forms.GroupBox();
            label29 = new System.Windows.Forms.Label();
            groupBox6 = new System.Windows.Forms.GroupBox();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage5.SuspendLayout();
            groupBox15.SuspendLayout();
            groupBox9.SuspendLayout();
            this.tabPage3.SuspendLayout();
            guiCommandTabs.SuspendLayout();
            guiCommandTabSelect.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            guiCommandTabGetResponse.SuspendLayout();
            groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            tabControl4.SuspendLayout();
            guiCommandTabReadRecord.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox5.SuspendLayout();
            guiCommandTabUpdateRecord.SuspendLayout();
            groupBox28.SuspendLayout();
            groupBox27.SuspendLayout();
            groupBox24.SuspendLayout();
            guiCommandTabAppendRecord.SuspendLayout();
            groupBox26.SuspendLayout();
            groupBox25.SuspendLayout();
            this.tabPage8.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage11.SuspendLayout();
            this.tabPage4.SuspendLayout();
            tabControl2.SuspendLayout();
            rightPanel.SuspendLayout();
            groupCommandAPDU.SuspendLayout();
            groupBox16.SuspendLayout();
            groupResponseAPDU.SuspendLayout();
            groupBox29.SuspendLayout();
            groupBox30.SuspendLayout();
            groupBox31.SuspendLayout();
            groupBox32.SuspendLayout();
            groupBox33.SuspendLayout();
            groupBox34.SuspendLayout();
            groupBox35.SuspendLayout();
            groupBox36.SuspendLayout();
            groupBox37.SuspendLayout();
            groupBox38.SuspendLayout();
            groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tabControl1);
            toolStripContainer1.ContentPanel.Controls.Add(rightPanel);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 517);
            toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new System.Drawing.Size(784, 564);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiStatusStatusWord});
            statusStrip1.Location = new System.Drawing.Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(784, 22);
            statusStrip1.TabIndex = 0;
            // 
            // guiStatusStatusWord
            // 
            this.guiStatusStatusWord.Name = "guiStatusStatusWord";
            this.guiStatusStatusWord.Size = new System.Drawing.Size(71, 17);
            this.guiStatusStatusWord.Text = "StatusWord:";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(this.tabPage3);
            tabControl1.Controls.Add(this.tabPage4);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            tabControl1.HotTrack = true;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(317, 517);
            tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(groupBox15);
            tabPage5.Controls.Add(groupBox9);
            tabPage5.Location = new System.Drawing.Point(23, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new System.Windows.Forms.Padding(3);
            tabPage5.Size = new System.Drawing.Size(290, 509);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Global";
            // 
            // groupBox15
            // 
            groupBox15.AutoSize = true;
            groupBox15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox15.Controls.Add(this.guiParametersReleaseObserver);
            groupBox15.Controls.Add(this.guiParametersAttachObserver);
            groupBox15.Location = new System.Drawing.Point(6, 71);
            groupBox15.Name = "groupBox15";
            groupBox15.Size = new System.Drawing.Size(278, 61);
            groupBox15.TabIndex = 5;
            groupBox15.TabStop = false;
            groupBox15.Text = "Card Observer";
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
            // groupBox9
            // 
            groupBox9.AutoSize = true;
            groupBox9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox9.Controls.Add(this.guiParametersProtocolT);
            groupBox9.Location = new System.Drawing.Point(6, 6);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new System.Drawing.Size(278, 59);
            groupBox9.TabIndex = 4;
            groupBox9.TabStop = false;
            groupBox9.Text = "Protocol T";
            // 
            // guiParametersProtocolT
            // 
            this.guiParametersProtocolT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiParametersProtocolT.FormattingEnabled = true;
            this.guiParametersProtocolT.Location = new System.Drawing.Point(6, 19);
            this.guiParametersProtocolT.Name = "guiParametersProtocolT";
            this.guiParametersProtocolT.Size = new System.Drawing.Size(266, 21);
            this.guiParametersProtocolT.TabIndex = 2;
            this.guiParametersProtocolT.SelectedIndexChanged += new System.EventHandler(this.guiCommandTabProtocolT_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(guiCommandTabs);
            this.tabPage3.Location = new System.Drawing.Point(23, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(290, 509);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Interchange";
            // 
            // guiCommandTabs
            // 
            guiCommandTabs.Controls.Add(guiCommandTabSelect);
            guiCommandTabs.Controls.Add(guiCommandTabGetResponse);
            guiCommandTabs.Controls.Add(this.tabPage1);
            guiCommandTabs.Controls.Add(this.tabPage8);
            guiCommandTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            guiCommandTabs.HotTrack = true;
            guiCommandTabs.Location = new System.Drawing.Point(3, 3);
            guiCommandTabs.Multiline = true;
            guiCommandTabs.Name = "guiCommandTabs";
            guiCommandTabs.SelectedIndex = 0;
            guiCommandTabs.Size = new System.Drawing.Size(284, 503);
            guiCommandTabs.TabIndex = 0;
            // 
            // guiCommandTabSelect
            // 
            guiCommandTabSelect.Controls.Add(this.guiSelectExecute);
            guiCommandTabSelect.Controls.Add(groupBox3);
            guiCommandTabSelect.Controls.Add(this.guiSelectFCI);
            guiCommandTabSelect.Controls.Add(groupBox2);
            guiCommandTabSelect.Controls.Add(groupBox1);
            guiCommandTabSelect.Location = new System.Drawing.Point(4, 22);
            guiCommandTabSelect.Name = "guiCommandTabSelect";
            guiCommandTabSelect.Padding = new System.Windows.Forms.Padding(3);
            guiCommandTabSelect.Size = new System.Drawing.Size(276, 477);
            guiCommandTabSelect.TabIndex = 0;
            guiCommandTabSelect.Text = "SELECT";
            guiCommandTabSelect.UseVisualStyleBackColor = true;
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
            groupBox3.Controls.Add(this.guiSelectUDC);
            groupBox3.Location = new System.Drawing.Point(6, 199);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(264, 59);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "UDC";
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
            groupBox2.Controls.Add(this.label2);
            groupBox2.Controls.Add(this.guiSelectFileOccurence);
            groupBox2.Controls.Add(this.label3);
            groupBox2.Location = new System.Drawing.Point(6, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(264, 109);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "P2";
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
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(this.guiSelectP1);
            groupBox1.Location = new System.Drawing.Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(264, 72);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "P1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 13);
            label1.TabIndex = 0;
            label1.Text = "Selection Mode";
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
            guiCommandTabGetResponse.Controls.Add(this.guiGetResponseExecute);
            guiCommandTabGetResponse.Controls.Add(groupBox4);
            guiCommandTabGetResponse.Location = new System.Drawing.Point(4, 22);
            guiCommandTabGetResponse.Name = "guiCommandTabGetResponse";
            guiCommandTabGetResponse.Padding = new System.Windows.Forms.Padding(3);
            guiCommandTabGetResponse.Size = new System.Drawing.Size(276, 477);
            guiCommandTabGetResponse.TabIndex = 2;
            guiCommandTabGetResponse.Text = "GET RESPONSE";
            guiCommandTabGetResponse.UseVisualStyleBackColor = true;
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
            groupBox4.AutoSize = true;
            groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox4.Controls.Add(this.guiGetResponseLe);
            groupBox4.Location = new System.Drawing.Point(6, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(264, 59);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Le [hexa]";
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
            this.tabPage1.Controls.Add(tabControl4);
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
            tabControl4.Controls.Add(guiCommandTabReadRecord);
            tabControl4.Controls.Add(guiCommandTabUpdateRecord);
            tabControl4.Controls.Add(guiCommandTabAppendRecord);
            tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl4.Location = new System.Drawing.Point(3, 3);
            tabControl4.Name = "tabControl4";
            tabControl4.SelectedIndex = 0;
            tabControl4.Size = new System.Drawing.Size(270, 471);
            tabControl4.TabIndex = 0;
            // 
            // guiCommandTabReadRecord
            // 
            guiCommandTabReadRecord.Controls.Add(groupBox8);
            guiCommandTabReadRecord.Controls.Add(this.guiReadRecordExecute);
            guiCommandTabReadRecord.Controls.Add(groupBox7);
            guiCommandTabReadRecord.Controls.Add(groupBox5);
            guiCommandTabReadRecord.Location = new System.Drawing.Point(4, 22);
            guiCommandTabReadRecord.Name = "guiCommandTabReadRecord";
            guiCommandTabReadRecord.Padding = new System.Windows.Forms.Padding(3);
            guiCommandTabReadRecord.Size = new System.Drawing.Size(262, 445);
            guiCommandTabReadRecord.TabIndex = 4;
            guiCommandTabReadRecord.Text = "READ";
            guiCommandTabReadRecord.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            groupBox8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox8.Controls.Add(this.guiReadRecordLe);
            groupBox8.Location = new System.Drawing.Point(6, 202);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new System.Drawing.Size(250, 59);
            groupBox8.TabIndex = 3;
            groupBox8.TabStop = false;
            groupBox8.Text = "Le [hexa]";
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
            groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox7.Controls.Add(this.guiReadRecordP1);
            groupBox7.Controls.Add(label7);
            groupBox7.Location = new System.Drawing.Point(6, 6);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new System.Drawing.Size(250, 72);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "P1 [hexa]";
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
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 16);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(137, 13);
            label7.TabIndex = 0;
            label7.Text = "Record Number or Identifier";
            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox5.Controls.Add(this.label6);
            groupBox5.Controls.Add(this.guiReadRecordSearchMode);
            groupBox5.Controls.Add(this.label4);
            groupBox5.Controls.Add(this.guiReadRecordSFI);
            groupBox5.Location = new System.Drawing.Point(6, 84);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(250, 112);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "P2";
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
            guiCommandTabUpdateRecord.Controls.Add(groupBox28);
            guiCommandTabUpdateRecord.Controls.Add(groupBox27);
            guiCommandTabUpdateRecord.Controls.Add(this.guiWriteRecordExecute);
            guiCommandTabUpdateRecord.Controls.Add(groupBox24);
            guiCommandTabUpdateRecord.Location = new System.Drawing.Point(4, 22);
            guiCommandTabUpdateRecord.Name = "guiCommandTabUpdateRecord";
            guiCommandTabUpdateRecord.Padding = new System.Windows.Forms.Padding(3);
            guiCommandTabUpdateRecord.Size = new System.Drawing.Size(262, 445);
            guiCommandTabUpdateRecord.TabIndex = 8;
            guiCommandTabUpdateRecord.Text = "WRITE";
            guiCommandTabUpdateRecord.UseVisualStyleBackColor = true;
            // 
            // groupBox28
            // 
            groupBox28.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox28.Controls.Add(this.guiWriteRecordP1);
            groupBox28.Controls.Add(label20);
            groupBox28.Location = new System.Drawing.Point(6, 6);
            groupBox28.Name = "groupBox28";
            groupBox28.Size = new System.Drawing.Size(250, 72);
            groupBox28.TabIndex = 0;
            groupBox28.TabStop = false;
            groupBox28.Text = "P1 [hexa]";
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
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(6, 16);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(137, 13);
            label20.TabIndex = 0;
            label20.Text = "Record Number or Identifier";
            // 
            // groupBox27
            // 
            groupBox27.Controls.Add(this.guiWriteRecordUDC);
            groupBox27.Location = new System.Drawing.Point(6, 201);
            groupBox27.Name = "groupBox27";
            groupBox27.Size = new System.Drawing.Size(250, 59);
            groupBox27.TabIndex = 2;
            groupBox27.TabStop = false;
            groupBox27.Text = "UDC";
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
            groupBox24.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox24.Controls.Add(this.label21);
            groupBox24.Controls.Add(this.guiWriteRecordTarget);
            groupBox24.Controls.Add(this.label23);
            groupBox24.Controls.Add(this.guiWriteRecordSFI);
            groupBox24.Location = new System.Drawing.Point(6, 83);
            groupBox24.Name = "groupBox24";
            groupBox24.Size = new System.Drawing.Size(250, 112);
            groupBox24.TabIndex = 1;
            groupBox24.TabStop = false;
            groupBox24.Text = "P2";
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
            guiCommandTabAppendRecord.Controls.Add(groupBox26);
            guiCommandTabAppendRecord.Controls.Add(this.guiAppendRecordExecute);
            guiCommandTabAppendRecord.Controls.Add(groupBox25);
            guiCommandTabAppendRecord.Location = new System.Drawing.Point(4, 22);
            guiCommandTabAppendRecord.Name = "guiCommandTabAppendRecord";
            guiCommandTabAppendRecord.Padding = new System.Windows.Forms.Padding(3);
            guiCommandTabAppendRecord.Size = new System.Drawing.Size(262, 445);
            guiCommandTabAppendRecord.TabIndex = 9;
            guiCommandTabAppendRecord.Text = "APPEND";
            guiCommandTabAppendRecord.UseVisualStyleBackColor = true;
            // 
            // groupBox26
            // 
            groupBox26.Controls.Add(this.guiAppendRecordUDC);
            groupBox26.Location = new System.Drawing.Point(6, 84);
            groupBox26.Name = "groupBox26";
            groupBox26.Size = new System.Drawing.Size(250, 59);
            groupBox26.TabIndex = 1;
            groupBox26.TabStop = false;
            groupBox26.Text = "UDC";
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
            groupBox25.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox25.Controls.Add(this.label22);
            groupBox25.Controls.Add(this.guiAppendRecordSFI);
            groupBox25.Location = new System.Drawing.Point(6, 6);
            groupBox25.Name = "groupBox25";
            groupBox25.Size = new System.Drawing.Size(250, 72);
            groupBox25.TabIndex = 0;
            groupBox25.TabStop = false;
            groupBox25.Text = "P2";
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
            this.tabPage8.Controls.Add(tabControl3);
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
            tabControl3.Controls.Add(tabPage11);
            tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl3.HotTrack = true;
            tabControl3.Location = new System.Drawing.Point(3, 3);
            tabControl3.Multiline = true;
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new System.Drawing.Size(270, 471);
            tabControl3.TabIndex = 0;
            // 
            // tabPage11
            // 
            tabPage11.Controls.Add(this.guiReadBinaryExecute);
            tabPage11.Controls.Add(groupBox6);
            tabPage11.Location = new System.Drawing.Point(4, 22);
            tabPage11.Name = "tabPage11";
            tabPage11.Padding = new System.Windows.Forms.Padding(3);
            tabPage11.Size = new System.Drawing.Size(262, 445);
            tabPage11.TabIndex = 6;
            tabPage11.Text = "READ BINARY";
            tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(tabControl2);
            this.tabPage4.Location = new System.Drawing.Point(23, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(290, 509);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Card Management";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(this.tabPage7);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Controls.Add(this.tabPage6);
            tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl2.Location = new System.Drawing.Point(3, 3);
            tabControl2.Multiline = true;
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(284, 503);
            tabControl2.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(276, 477);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "CREATE FILE";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(276, 477);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "TERMINATE CARD USAGE";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(276, 477);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Other";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // rightPanel
            // 
            rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            rightPanel.Controls.Add(groupCommandAPDU);
            rightPanel.Controls.Add(groupBox16);
            rightPanel.Controls.Add(groupResponseAPDU);
            rightPanel.Location = new System.Drawing.Point(322, 3);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new System.Drawing.Size(459, 510);
            rightPanel.TabIndex = 1;
            // 
            // groupCommandAPDU
            // 
            groupCommandAPDU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupCommandAPDU.Controls.Add(this.guiLc);
            groupCommandAPDU.Controls.Add(labelLc);
            groupCommandAPDU.Controls.Add(this.guiUDC);
            groupCommandAPDU.Controls.Add(this.guiLe);
            groupCommandAPDU.Controls.Add(this.guiSendCAPDU);
            groupCommandAPDU.Controls.Add(labelLe);
            groupCommandAPDU.Controls.Add(this.guiP2);
            groupCommandAPDU.Controls.Add(labelCLA);
            groupCommandAPDU.Controls.Add(this.guiP1);
            groupCommandAPDU.Controls.Add(labelP2);
            groupCommandAPDU.Controls.Add(this.guiCLA);
            groupCommandAPDU.Controls.Add(labelINS);
            groupCommandAPDU.Controls.Add(this.guiINS);
            groupCommandAPDU.Controls.Add(labelP1);
            groupCommandAPDU.Location = new System.Drawing.Point(3, 3);
            groupCommandAPDU.Name = "groupCommandAPDU";
            groupCommandAPDU.Size = new System.Drawing.Size(447, 184);
            groupCommandAPDU.TabIndex = 0;
            groupCommandAPDU.TabStop = false;
            groupCommandAPDU.Text = "Command APDU";
            // 
            // guiLc
            // 
            this.guiLc.Location = new System.Drawing.Point(283, 19);
            this.guiLc.MaxLength = 2;
            this.guiLc.Name = "guiLc";
            this.guiLc.Size = new System.Drawing.Size(25, 20);
            this.guiLc.TabIndex = 9;
            // 
            // labelLc
            // 
            labelLc.AutoSize = true;
            labelLc.Location = new System.Drawing.Point(255, 22);
            labelLc.Name = "labelLc";
            labelLc.Size = new System.Drawing.Size(22, 13);
            labelLc.TabIndex = 8;
            labelLc.Text = "Lc:";
            // 
            // guiUDC
            // 
            this.guiUDC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.guiUDC.Location = new System.Drawing.Point(6, 45);
            this.guiUDC.MaxLength = 32000;
            this.guiUDC.Multiline = true;
            this.guiUDC.Name = "guiUDC";
            this.guiUDC.Size = new System.Drawing.Size(435, 91);
            this.guiUDC.TabIndex = 12;
            // 
            // guiLe
            // 
            this.guiLe.Location = new System.Drawing.Point(342, 19);
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
            labelLe.AutoSize = true;
            labelLe.Location = new System.Drawing.Point(314, 22);
            labelLe.Name = "labelLe";
            labelLe.Size = new System.Drawing.Size(22, 13);
            labelLe.TabIndex = 10;
            labelLe.Text = "Le:";
            // 
            // guiP2
            // 
            this.guiP2.Location = new System.Drawing.Point(224, 19);
            this.guiP2.MaxLength = 2;
            this.guiP2.Name = "guiP2";
            this.guiP2.Size = new System.Drawing.Size(25, 20);
            this.guiP2.TabIndex = 7;
            // 
            // labelCLA
            // 
            labelCLA.AutoSize = true;
            labelCLA.Location = new System.Drawing.Point(6, 22);
            labelCLA.Name = "labelCLA";
            labelCLA.Size = new System.Drawing.Size(30, 13);
            labelCLA.TabIndex = 0;
            labelCLA.Text = "CLA:";
            // 
            // guiP1
            // 
            this.guiP1.Location = new System.Drawing.Point(164, 19);
            this.guiP1.MaxLength = 2;
            this.guiP1.Name = "guiP1";
            this.guiP1.Size = new System.Drawing.Size(25, 20);
            this.guiP1.TabIndex = 5;
            // 
            // labelP2
            // 
            labelP2.AutoSize = true;
            labelP2.Location = new System.Drawing.Point(195, 22);
            labelP2.Name = "labelP2";
            labelP2.Size = new System.Drawing.Size(23, 13);
            labelP2.TabIndex = 6;
            labelP2.Text = "P2:";
            // 
            // guiCLA
            // 
            this.guiCLA.Location = new System.Drawing.Point(39, 19);
            this.guiCLA.MaxLength = 2;
            this.guiCLA.Name = "guiCLA";
            this.guiCLA.Size = new System.Drawing.Size(25, 20);
            this.guiCLA.TabIndex = 1;
            // 
            // labelINS
            // 
            labelINS.AutoSize = true;
            labelINS.Location = new System.Drawing.Point(70, 22);
            labelINS.Name = "labelINS";
            labelINS.Size = new System.Drawing.Size(28, 13);
            labelINS.TabIndex = 2;
            labelINS.Text = "INS:";
            // 
            // guiINS
            // 
            this.guiINS.Location = new System.Drawing.Point(104, 19);
            this.guiINS.MaxLength = 2;
            this.guiINS.Name = "guiINS";
            this.guiINS.Size = new System.Drawing.Size(25, 20);
            this.guiINS.TabIndex = 3;
            // 
            // labelP1
            // 
            labelP1.AutoSize = true;
            labelP1.Location = new System.Drawing.Point(135, 22);
            labelP1.Name = "labelP1";
            labelP1.Size = new System.Drawing.Size(23, 13);
            labelP1.TabIndex = 4;
            labelP1.Text = "P1:";
            // 
            // groupBox16
            // 
            groupBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBox16.Controls.Add(this.guiCRPHistoric);
            groupBox16.Location = new System.Drawing.Point(3, 359);
            groupBox16.Name = "groupBox16";
            groupBox16.Size = new System.Drawing.Size(447, 148);
            groupBox16.TabIndex = 2;
            groupBox16.TabStop = false;
            groupBox16.Text = "Commands historic";
            // 
            // guiCRPHistoric
            // 
            this.guiCRPHistoric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.guiCRPHistoric.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            guiHistoricNumber,
            guiHistoricCAPDU});
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
            guiHistoricNumber.Text = "N°";
            guiHistoricNumber.Width = 30;
            // 
            // guiHistoricCAPDU
            // 
            guiHistoricCAPDU.Text = "CAPDU";
            guiHistoricCAPDU.Width = 400;
            // 
            // groupResponseAPDU
            // 
            groupResponseAPDU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupResponseAPDU.Controls.Add(this.guiRAPDU);
            groupResponseAPDU.Location = new System.Drawing.Point(3, 193);
            groupResponseAPDU.Name = "groupResponseAPDU";
            groupResponseAPDU.Size = new System.Drawing.Size(447, 160);
            groupResponseAPDU.TabIndex = 1;
            groupResponseAPDU.TabStop = false;
            groupResponseAPDU.Text = "Response APDU";
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
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(6, 16);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(81, 13);
            label10.TabIndex = 0;
            label10.Text = "Selection Mode";
            // 
            // groupBox29
            // 
            groupBox29.AutoSize = true;
            groupBox29.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox29.Controls.Add(this.richTextBox1);
            groupBox29.Location = new System.Drawing.Point(6, 305);
            groupBox29.Name = "groupBox29";
            groupBox29.Size = new System.Drawing.Size(264, 59);
            groupBox29.TabIndex = 4;
            groupBox29.TabStop = false;
            groupBox29.Text = "Le [hexa]";
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
            groupBox30.AutoSize = true;
            groupBox30.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox30.Controls.Add(label24);
            groupBox30.Controls.Add(this.comboBox3);
            groupBox30.Location = new System.Drawing.Point(6, 71);
            groupBox30.Name = "groupBox30";
            groupBox30.Size = new System.Drawing.Size(264, 72);
            groupBox30.TabIndex = 1;
            groupBox30.TabStop = false;
            groupBox30.Text = "P1 [b8]";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(6, 16);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(81, 13);
            label24.TabIndex = 0;
            label24.Text = "Selection Mode";
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
            groupBox31.AutoSize = true;
            groupBox31.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox31.Controls.Add(this.comboBox4);
            groupBox31.Location = new System.Drawing.Point(6, 6);
            groupBox31.Name = "groupBox31";
            groupBox31.Size = new System.Drawing.Size(264, 59);
            groupBox31.TabIndex = 0;
            groupBox31.TabStop = false;
            groupBox31.Text = "READ BINARY";
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
            groupBox32.AutoSize = true;
            groupBox32.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox32.Controls.Add(this.richTextBox2);
            groupBox32.Controls.Add(label25);
            groupBox32.Location = new System.Drawing.Point(6, 149);
            groupBox32.Name = "groupBox32";
            groupBox32.Size = new System.Drawing.Size(264, 72);
            groupBox32.TabIndex = 2;
            groupBox32.TabStop = false;
            groupBox32.Text = "P1 [b7...b1]";
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
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(6, 16);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(94, 13);
            label25.TabIndex = 0;
            label25.Text = "Short File Identifier";
            // 
            // groupBox33
            // 
            groupBox33.AutoSize = true;
            groupBox33.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox33.Controls.Add(this.richTextBox3);
            groupBox33.Controls.Add(label26);
            groupBox33.Location = new System.Drawing.Point(6, 227);
            groupBox33.Name = "groupBox33";
            groupBox33.Size = new System.Drawing.Size(264, 72);
            groupBox33.TabIndex = 3;
            groupBox33.TabStop = false;
            groupBox33.Text = "(P1) P2";
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
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(6, 16);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(35, 13);
            label26.TabIndex = 0;
            label26.Text = "Offset";
            // 
            // groupBox34
            // 
            groupBox34.AutoSize = true;
            groupBox34.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox34.Controls.Add(this.richTextBox4);
            groupBox34.Location = new System.Drawing.Point(6, 305);
            groupBox34.Name = "groupBox34";
            groupBox34.Size = new System.Drawing.Size(264, 59);
            groupBox34.TabIndex = 4;
            groupBox34.TabStop = false;
            groupBox34.Text = "Le [hexa]";
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
            groupBox35.AutoSize = true;
            groupBox35.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox35.Controls.Add(label27);
            groupBox35.Controls.Add(this.comboBox5);
            groupBox35.Location = new System.Drawing.Point(6, 71);
            groupBox35.Name = "groupBox35";
            groupBox35.Size = new System.Drawing.Size(264, 72);
            groupBox35.TabIndex = 1;
            groupBox35.TabStop = false;
            groupBox35.Text = "P1 [b8]";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(6, 16);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(81, 13);
            label27.TabIndex = 0;
            label27.Text = "Selection Mode";
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
            groupBox36.AutoSize = true;
            groupBox36.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox36.Controls.Add(this.comboBox6);
            groupBox36.Location = new System.Drawing.Point(6, 6);
            groupBox36.Name = "groupBox36";
            groupBox36.Size = new System.Drawing.Size(264, 59);
            groupBox36.TabIndex = 0;
            groupBox36.TabStop = false;
            groupBox36.Text = "READ BINARY";
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
            groupBox37.AutoSize = true;
            groupBox37.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox37.Controls.Add(this.richTextBox5);
            groupBox37.Controls.Add(label28);
            groupBox37.Location = new System.Drawing.Point(6, 149);
            groupBox37.Name = "groupBox37";
            groupBox37.Size = new System.Drawing.Size(264, 72);
            groupBox37.TabIndex = 2;
            groupBox37.TabStop = false;
            groupBox37.Text = "P1 [b7...b1]";
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
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(6, 16);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(94, 13);
            label28.TabIndex = 0;
            label28.Text = "Short File Identifier";
            // 
            // groupBox38
            // 
            groupBox38.AutoSize = true;
            groupBox38.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox38.Controls.Add(this.richTextBox6);
            groupBox38.Controls.Add(label29);
            groupBox38.Location = new System.Drawing.Point(6, 227);
            groupBox38.Name = "groupBox38";
            groupBox38.Size = new System.Drawing.Size(264, 72);
            groupBox38.TabIndex = 3;
            groupBox38.TabStop = false;
            groupBox38.Text = "(P1) P2";
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
            label29.AutoSize = true;
            label29.Location = new System.Drawing.Point(6, 16);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(35, 13);
            label29.TabIndex = 0;
            label29.Text = "Offset";
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
            // groupBox6
            // 
            groupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox6.Controls.Add(this.guiReadBinaryLe);
            groupBox6.Location = new System.Drawing.Point(6, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(250, 59);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Le [hexa]";
            // 
            // guiReadBinaryLe
            // 
            this.guiReadBinaryLe.Location = new System.Drawing.Point(6, 19);
            this.guiReadBinaryLe.Name = "guiReadBinaryLe";
            this.guiReadBinaryLe.Size = new System.Drawing.Size(238, 21);
            this.guiReadBinaryLe.TabIndex = 0;
            this.guiReadBinaryLe.Text = "";
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
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI";
            this.Text = "ISO7816 Tools Plugin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            groupBox15.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            guiCommandTabs.ResumeLayout(false);
            guiCommandTabSelect.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            guiCommandTabGetResponse.ResumeLayout(false);
            guiCommandTabGetResponse.PerformLayout();
            groupBox4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            tabControl4.ResumeLayout(false);
            guiCommandTabReadRecord.ResumeLayout(false);
            guiCommandTabReadRecord.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            guiCommandTabUpdateRecord.ResumeLayout(false);
            groupBox28.ResumeLayout(false);
            groupBox28.PerformLayout();
            groupBox27.ResumeLayout(false);
            groupBox24.ResumeLayout(false);
            groupBox24.PerformLayout();
            guiCommandTabAppendRecord.ResumeLayout(false);
            groupBox26.ResumeLayout(false);
            groupBox25.ResumeLayout(false);
            groupBox25.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tabPage11.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            groupCommandAPDU.ResumeLayout(false);
            groupCommandAPDU.PerformLayout();
            groupBox16.ResumeLayout(false);
            groupResponseAPDU.ResumeLayout(false);
            groupBox29.ResumeLayout(false);
            groupBox30.ResumeLayout(false);
            groupBox30.PerformLayout();
            groupBox31.ResumeLayout(false);
            groupBox32.ResumeLayout(false);
            groupBox32.PerformLayout();
            groupBox33.ResumeLayout(false);
            groupBox33.PerformLayout();
            groupBox34.ResumeLayout(false);
            groupBox35.ResumeLayout(false);
            groupBox35.PerformLayout();
            groupBox36.ResumeLayout(false);
            groupBox37.ResumeLayout(false);
            groupBox37.PerformLayout();
            groupBox38.ResumeLayout(false);
            groupBox38.PerformLayout();
            groupBox6.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripStatusLabel guiStatusStatusWord;
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
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.Button guiParametersReleaseObserver;
		private System.Windows.Forms.Button guiParametersAttachObserver;
        private System.Windows.Forms.ComboBox guiParametersProtocolT;
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




	}
}