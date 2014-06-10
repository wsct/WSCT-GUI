namespace WSCT.GUI
{
	/// <summary>
	/// 
	/// </summary>
	partial class WinSCardGui
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
            System.Windows.Forms.GroupBox guiGroupCard;
            System.Windows.Forms.GroupBox guiGroupContext;
            System.Windows.Forms.TabPage guiTabConnection;
            System.Windows.Forms.Label labelReaderInUser;
            System.Windows.Forms.Label labelCardChannel;
            System.Windows.Forms.Label labelContext;
            System.Windows.Forms.Label labelDisposition;
            System.Windows.Forms.Label labelShareMode;
            System.Windows.Forms.Label labelProtocol;
            System.Windows.Forms.Label labelStringAttribute;
            System.Windows.Forms.Label labelRawAttribute;
            System.Windows.Forms.StatusStrip guiStatus;
            System.Windows.Forms.GroupBox guiGroupBoxLoadedPlugins;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.GroupBox groupBox4;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.GroupBox groupBox5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinSCardGui));
            this.guiCardConnect = new System.Windows.Forms.Button();
            this.guiCardWarmReset = new System.Windows.Forms.Button();
            this.guiCardUnpower = new System.Windows.Forms.Button();
            this.guiCardColdReset = new System.Windows.Forms.Button();
            this.guiContextRelease = new System.Windows.Forms.Button();
            this.guiContextEstablish = new System.Windows.Forms.Button();
            this.guiGroupCardInformations = new System.Windows.Forms.GroupBox();
            this.guiReaderInUse = new System.Windows.Forms.TextBox();
            this.guiChannelState = new System.Windows.Forms.TextBox();
            this.guiContextState = new System.Windows.Forms.TextBox();
            this.guiGroupCardConnection = new System.Windows.Forms.GroupBox();
            this.guiChannelConnect = new System.Windows.Forms.Button();
            this.guiFoundReaders = new System.Windows.Forms.Label();
            this.guiFoundReaderGroups = new System.Windows.Forms.Label();
            this.guiReaderGroups = new System.Windows.Forms.ComboBox();
            this.guiReaders = new System.Windows.Forms.ComboBox();
            this.guiChannelDisconnect = new System.Windows.Forms.Button();
            this.guiShareMode = new System.Windows.Forms.ComboBox();
            this.guiChannelReconnect = new System.Windows.Forms.Button();
            this.guiDisposition = new System.Windows.Forms.ComboBox();
            this.guiProtocol = new System.Windows.Forms.ComboBox();
            this.guiGroupCardAttributes = new System.Windows.Forms.GroupBox();
            this.guiGetAttribute = new System.Windows.Forms.Button();
            this.guiStringAttribute = new System.Windows.Forms.TextBox();
            this.guiRawAttribute = new System.Windows.Forms.TextBox();
            this.guiAttribute = new System.Windows.Forms.ComboBox();
            this.guiLastError = new System.Windows.Forms.ToolStripStatusLabel();
            this.guiLoadedPlugins = new System.Windows.Forms.ListBox();
            this.guiPluginPathToDll = new System.Windows.Forms.TextBox();
            this.guiPluginClassName = new System.Windows.Forms.TextBox();
            this.guiPluginDLL = new System.Windows.Forms.TextBox();
            this.guiPluginName = new System.Windows.Forms.TextBox();
            this.guiPluginAssemblyName = new System.Windows.Forms.TextBox();
            this.guiPluginAssemblyVersion = new System.Windows.Forms.TextBox();
            this.guiPluginAssemblyDescription = new System.Windows.Forms.TextBox();
            this.guiLayerAssemblyDescription = new System.Windows.Forms.TextBox();
            this.guiLayerAssemblyName = new System.Windows.Forms.TextBox();
            this.guiLayerAssemblyVersion = new System.Windows.Forms.TextBox();
            this.guiLayerPathToDll = new System.Windows.Forms.TextBox();
            this.guiLayerClassName = new System.Windows.Forms.TextBox();
            this.guiLayerDLL = new System.Windows.Forms.TextBox();
            this.guiLayerName = new System.Windows.Forms.TextBox();
            this.guiLoadedContextLayers = new System.Windows.Forms.ListBox();
            this.guiLoadedChannelLayers = new System.Windows.Forms.ListBox();
            this.guiTabs = new System.Windows.Forms.TabControl();
            this.guiTabLogs = new System.Windows.Forms.TabPage();
            this.guiLogsView = new System.Windows.Forms.RichTextBox();
            this.guiTabPlugins = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.guiMenu = new System.Windows.Forms.MenuStrip();
            this.guiFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.guiPluginsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiAboutWinSCardGUI = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            guiGroupCard = new System.Windows.Forms.GroupBox();
            guiGroupContext = new System.Windows.Forms.GroupBox();
            guiTabConnection = new System.Windows.Forms.TabPage();
            labelReaderInUser = new System.Windows.Forms.Label();
            labelCardChannel = new System.Windows.Forms.Label();
            labelContext = new System.Windows.Forms.Label();
            labelDisposition = new System.Windows.Forms.Label();
            labelShareMode = new System.Windows.Forms.Label();
            labelProtocol = new System.Windows.Forms.Label();
            labelStringAttribute = new System.Windows.Forms.Label();
            labelRawAttribute = new System.Windows.Forms.Label();
            guiStatus = new System.Windows.Forms.StatusStrip();
            guiGroupBoxLoadedPlugins = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label15 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label14 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            groupBox5 = new System.Windows.Forms.GroupBox();
            guiGroupCard.SuspendLayout();
            guiGroupContext.SuspendLayout();
            guiTabConnection.SuspendLayout();
            this.guiGroupCardInformations.SuspendLayout();
            this.guiGroupCardConnection.SuspendLayout();
            this.guiGroupCardAttributes.SuspendLayout();
            guiStatus.SuspendLayout();
            guiGroupBoxLoadedPlugins.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            this.guiTabs.SuspendLayout();
            this.guiTabLogs.SuspendLayout();
            this.guiTabPlugins.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.guiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // guiGroupCard
            // 
            guiGroupCard.AutoSize = true;
            guiGroupCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            guiGroupCard.Controls.Add(this.guiCardConnect);
            guiGroupCard.Controls.Add(this.guiCardWarmReset);
            guiGroupCard.Controls.Add(this.guiCardUnpower);
            guiGroupCard.Controls.Add(this.guiCardColdReset);
            guiGroupCard.Location = new System.Drawing.Point(12, 99);
            guiGroupCard.Name = "guiGroupCard";
            guiGroupCard.Size = new System.Drawing.Size(102, 148);
            guiGroupCard.TabIndex = 1;
            guiGroupCard.TabStop = false;
            guiGroupCard.Text = "Quick Connect";
            // 
            // guiCardConnect
            // 
            this.guiCardConnect.Enabled = false;
            this.guiCardConnect.Location = new System.Drawing.Point(6, 19);
            this.guiCardConnect.Name = "guiCardConnect";
            this.guiCardConnect.Size = new System.Drawing.Size(90, 23);
            this.guiCardConnect.TabIndex = 0;
            this.guiCardConnect.Text = "Connect";
            this.guiCardConnect.UseVisualStyleBackColor = true;
            this.guiCardConnect.Click += new System.EventHandler(this.guiCardConnect_Click);
            // 
            // guiCardWarmReset
            // 
            this.guiCardWarmReset.Enabled = false;
            this.guiCardWarmReset.Location = new System.Drawing.Point(6, 48);
            this.guiCardWarmReset.Name = "guiCardWarmReset";
            this.guiCardWarmReset.Size = new System.Drawing.Size(90, 23);
            this.guiCardWarmReset.TabIndex = 1;
            this.guiCardWarmReset.Text = "Warm reset";
            this.guiCardWarmReset.UseVisualStyleBackColor = true;
            this.guiCardWarmReset.Click += new System.EventHandler(this.guiCardWarmReset_Click);
            // 
            // guiCardUnpower
            // 
            this.guiCardUnpower.Enabled = false;
            this.guiCardUnpower.Location = new System.Drawing.Point(6, 106);
            this.guiCardUnpower.Name = "guiCardUnpower";
            this.guiCardUnpower.Size = new System.Drawing.Size(90, 23);
            this.guiCardUnpower.TabIndex = 3;
            this.guiCardUnpower.Text = "Unpower";
            this.guiCardUnpower.UseVisualStyleBackColor = true;
            this.guiCardUnpower.Click += new System.EventHandler(this.guiCardUnpower_Click);
            // 
            // guiCardColdReset
            // 
            this.guiCardColdReset.Enabled = false;
            this.guiCardColdReset.Location = new System.Drawing.Point(6, 77);
            this.guiCardColdReset.Name = "guiCardColdReset";
            this.guiCardColdReset.Size = new System.Drawing.Size(90, 23);
            this.guiCardColdReset.TabIndex = 2;
            this.guiCardColdReset.Text = "Cold reset";
            this.guiCardColdReset.UseVisualStyleBackColor = true;
            this.guiCardColdReset.Click += new System.EventHandler(this.guiCardColdReset_Click);
            // 
            // guiGroupContext
            // 
            guiGroupContext.AutoSize = true;
            guiGroupContext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            guiGroupContext.Controls.Add(this.guiContextRelease);
            guiGroupContext.Controls.Add(this.guiContextEstablish);
            guiGroupContext.Location = new System.Drawing.Point(12, 3);
            guiGroupContext.Name = "guiGroupContext";
            guiGroupContext.Size = new System.Drawing.Size(102, 90);
            guiGroupContext.TabIndex = 0;
            guiGroupContext.TabStop = false;
            guiGroupContext.Text = "Context";
            // 
            // guiContextRelease
            // 
            this.guiContextRelease.Enabled = false;
            this.guiContextRelease.Location = new System.Drawing.Point(6, 48);
            this.guiContextRelease.Name = "guiContextRelease";
            this.guiContextRelease.Size = new System.Drawing.Size(90, 23);
            this.guiContextRelease.TabIndex = 1;
            this.guiContextRelease.Text = "Release";
            this.guiContextRelease.UseVisualStyleBackColor = true;
            this.guiContextRelease.Click += new System.EventHandler(this.guiContextRelease_Click);
            // 
            // guiContextEstablish
            // 
            this.guiContextEstablish.Location = new System.Drawing.Point(6, 19);
            this.guiContextEstablish.Name = "guiContextEstablish";
            this.guiContextEstablish.Size = new System.Drawing.Size(90, 23);
            this.guiContextEstablish.TabIndex = 0;
            this.guiContextEstablish.Text = "Establish";
            this.guiContextEstablish.UseVisualStyleBackColor = true;
            this.guiContextEstablish.Click += new System.EventHandler(this.guiContextEstablish_Click);
            // 
            // guiTabConnection
            // 
            guiTabConnection.Controls.Add(this.guiGroupCardInformations);
            guiTabConnection.Controls.Add(this.guiGroupCardConnection);
            guiTabConnection.Controls.Add(this.guiGroupCardAttributes);
            guiTabConnection.Location = new System.Drawing.Point(4, 22);
            guiTabConnection.Name = "guiTabConnection";
            guiTabConnection.Padding = new System.Windows.Forms.Padding(3);
            guiTabConnection.Size = new System.Drawing.Size(661, 468);
            guiTabConnection.TabIndex = 0;
            guiTabConnection.Text = "Card Tools";
            guiTabConnection.UseVisualStyleBackColor = true;
            // 
            // guiGroupCardInformations
            // 
            this.guiGroupCardInformations.AutoSize = true;
            this.guiGroupCardInformations.Controls.Add(this.guiReaderInUse);
            this.guiGroupCardInformations.Controls.Add(labelReaderInUser);
            this.guiGroupCardInformations.Controls.Add(this.guiChannelState);
            this.guiGroupCardInformations.Controls.Add(labelCardChannel);
            this.guiGroupCardInformations.Controls.Add(this.guiContextState);
            this.guiGroupCardInformations.Controls.Add(labelContext);
            this.guiGroupCardInformations.Location = new System.Drawing.Point(6, 300);
            this.guiGroupCardInformations.Name = "guiGroupCardInformations";
            this.guiGroupCardInformations.Size = new System.Drawing.Size(640, 81);
            this.guiGroupCardInformations.TabIndex = 2;
            this.guiGroupCardInformations.TabStop = false;
            this.guiGroupCardInformations.Text = "Card Informations";
            // 
            // guiReaderInUse
            // 
            this.guiReaderInUse.Location = new System.Drawing.Point(284, 42);
            this.guiReaderInUse.Name = "guiReaderInUse";
            this.guiReaderInUse.ReadOnly = true;
            this.guiReaderInUse.Size = new System.Drawing.Size(200, 20);
            this.guiReaderInUse.TabIndex = 5;
            this.guiReaderInUse.TabStop = false;
            // 
            // labelReaderInUser
            // 
            labelReaderInUser.AutoSize = true;
            labelReaderInUser.Location = new System.Drawing.Point(198, 45);
            labelReaderInUser.Name = "labelReaderInUser";
            labelReaderInUser.Size = new System.Drawing.Size(76, 13);
            labelReaderInUser.TabIndex = 4;
            labelReaderInUser.Text = "Reader in use:";
            // 
            // guiChannelState
            // 
            this.guiChannelState.Location = new System.Drawing.Point(92, 42);
            this.guiChannelState.Name = "guiChannelState";
            this.guiChannelState.ReadOnly = true;
            this.guiChannelState.Size = new System.Drawing.Size(100, 20);
            this.guiChannelState.TabIndex = 3;
            this.guiChannelState.TabStop = false;
            this.guiChannelState.Text = "Disconnected";
            // 
            // labelCardChannel
            // 
            labelCardChannel.AutoSize = true;
            labelCardChannel.Location = new System.Drawing.Point(6, 45);
            labelCardChannel.Name = "labelCardChannel";
            labelCardChannel.Size = new System.Drawing.Size(73, 13);
            labelCardChannel.TabIndex = 2;
            labelCardChannel.Text = "Card channel:";
            // 
            // guiContextState
            // 
            this.guiContextState.Location = new System.Drawing.Point(92, 16);
            this.guiContextState.Name = "guiContextState";
            this.guiContextState.ReadOnly = true;
            this.guiContextState.Size = new System.Drawing.Size(100, 20);
            this.guiContextState.TabIndex = 1;
            this.guiContextState.TabStop = false;
            this.guiContextState.Text = "Released";
            // 
            // labelContext
            // 
            labelContext.AutoSize = true;
            labelContext.Location = new System.Drawing.Point(6, 19);
            labelContext.Name = "labelContext";
            labelContext.Size = new System.Drawing.Size(46, 13);
            labelContext.TabIndex = 0;
            labelContext.Text = "Context:";
            // 
            // guiGroupCardConnection
            // 
            this.guiGroupCardConnection.AutoSize = true;
            this.guiGroupCardConnection.Controls.Add(this.guiChannelConnect);
            this.guiGroupCardConnection.Controls.Add(this.guiFoundReaders);
            this.guiGroupCardConnection.Controls.Add(this.guiFoundReaderGroups);
            this.guiGroupCardConnection.Controls.Add(labelDisposition);
            this.guiGroupCardConnection.Controls.Add(this.guiReaderGroups);
            this.guiGroupCardConnection.Controls.Add(this.guiReaders);
            this.guiGroupCardConnection.Controls.Add(this.guiChannelDisconnect);
            this.guiGroupCardConnection.Controls.Add(this.guiShareMode);
            this.guiGroupCardConnection.Controls.Add(labelShareMode);
            this.guiGroupCardConnection.Controls.Add(this.guiChannelReconnect);
            this.guiGroupCardConnection.Controls.Add(this.guiDisposition);
            this.guiGroupCardConnection.Controls.Add(this.guiProtocol);
            this.guiGroupCardConnection.Controls.Add(labelProtocol);
            this.guiGroupCardConnection.Enabled = false;
            this.guiGroupCardConnection.Location = new System.Drawing.Point(6, 6);
            this.guiGroupCardConnection.Name = "guiGroupCardConnection";
            this.guiGroupCardConnection.Size = new System.Drawing.Size(640, 141);
            this.guiGroupCardConnection.TabIndex = 0;
            this.guiGroupCardConnection.TabStop = false;
            this.guiGroupCardConnection.Text = "Card connection";
            // 
            // guiChannelConnect
            // 
            this.guiChannelConnect.Location = new System.Drawing.Point(6, 99);
            this.guiChannelConnect.Name = "guiChannelConnect";
            this.guiChannelConnect.Size = new System.Drawing.Size(90, 23);
            this.guiChannelConnect.TabIndex = 10;
            this.guiChannelConnect.Text = "Connect";
            this.guiChannelConnect.UseVisualStyleBackColor = true;
            this.guiChannelConnect.Click += new System.EventHandler(this.guiChannelConnect_Click);
            // 
            // guiFoundReaders
            // 
            this.guiFoundReaders.AutoSize = true;
            this.guiFoundReaders.Location = new System.Drawing.Point(309, 16);
            this.guiFoundReaders.Name = "guiFoundReaders";
            this.guiFoundReaders.Size = new System.Drawing.Size(143, 13);
            this.guiFoundReaders.TabIndex = 2;
            this.guiFoundReaders.Text = "Readers descriptionFound: 0";
            // 
            // guiFoundReaderGroups
            // 
            this.guiFoundReaderGroups.AutoSize = true;
            this.guiFoundReaderGroups.Location = new System.Drawing.Point(6, 16);
            this.guiFoundReaderGroups.Name = "guiFoundReaderGroups";
            this.guiFoundReaderGroups.Size = new System.Drawing.Size(173, 13);
            this.guiFoundReaderGroups.TabIndex = 0;
            this.guiFoundReaderGroups.Text = "Reader groups descriptionFound: 0";
            // 
            // labelDisposition
            // 
            labelDisposition.AutoSize = true;
            labelDisposition.Location = new System.Drawing.Point(415, 56);
            labelDisposition.Name = "labelDisposition";
            labelDisposition.Size = new System.Drawing.Size(58, 13);
            labelDisposition.TabIndex = 8;
            labelDisposition.Text = "Disposition";
            // 
            // guiReaderGroups
            // 
            this.guiReaderGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiReaderGroups.FormattingEnabled = true;
            this.guiReaderGroups.Location = new System.Drawing.Point(6, 32);
            this.guiReaderGroups.Name = "guiReaderGroups";
            this.guiReaderGroups.Size = new System.Drawing.Size(300, 21);
            this.guiReaderGroups.TabIndex = 1;
            // 
            // guiReaders
            // 
            this.guiReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiReaders.FormattingEnabled = true;
            this.guiReaders.Location = new System.Drawing.Point(312, 32);
            this.guiReaders.Name = "guiReaders";
            this.guiReaders.Size = new System.Drawing.Size(300, 21);
            this.guiReaders.TabIndex = 3;
            // 
            // guiChannelDisconnect
            // 
            this.guiChannelDisconnect.Location = new System.Drawing.Point(198, 99);
            this.guiChannelDisconnect.Name = "guiChannelDisconnect";
            this.guiChannelDisconnect.Size = new System.Drawing.Size(90, 23);
            this.guiChannelDisconnect.TabIndex = 12;
            this.guiChannelDisconnect.Text = "Disconnect";
            this.guiChannelDisconnect.UseVisualStyleBackColor = true;
            this.guiChannelDisconnect.Click += new System.EventHandler(this.guiChannelDisconnect_Click);
            // 
            // guiShareMode
            // 
            this.guiShareMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiShareMode.FormattingEnabled = true;
            this.guiShareMode.Location = new System.Drawing.Point(6, 72);
            this.guiShareMode.Name = "guiShareMode";
            this.guiShareMode.Size = new System.Drawing.Size(200, 21);
            this.guiShareMode.TabIndex = 5;
            // 
            // labelShareMode
            // 
            labelShareMode.AutoSize = true;
            labelShareMode.Location = new System.Drawing.Point(6, 56);
            labelShareMode.Name = "labelShareMode";
            labelShareMode.Size = new System.Drawing.Size(64, 13);
            labelShareMode.TabIndex = 4;
            labelShareMode.Text = "Share mode";
            // 
            // guiChannelReconnect
            // 
            this.guiChannelReconnect.Location = new System.Drawing.Point(102, 99);
            this.guiChannelReconnect.Name = "guiChannelReconnect";
            this.guiChannelReconnect.Size = new System.Drawing.Size(90, 23);
            this.guiChannelReconnect.TabIndex = 11;
            this.guiChannelReconnect.Text = "Reconnect";
            this.guiChannelReconnect.UseVisualStyleBackColor = true;
            this.guiChannelReconnect.Click += new System.EventHandler(this.guiChannelReconnect_Click);
            // 
            // guiDisposition
            // 
            this.guiDisposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiDisposition.FormattingEnabled = true;
            this.guiDisposition.Location = new System.Drawing.Point(418, 72);
            this.guiDisposition.Name = "guiDisposition";
            this.guiDisposition.Size = new System.Drawing.Size(200, 21);
            this.guiDisposition.TabIndex = 9;
            // 
            // guiProtocol
            // 
            this.guiProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiProtocol.FormattingEnabled = true;
            this.guiProtocol.Location = new System.Drawing.Point(212, 72);
            this.guiProtocol.Name = "guiProtocol";
            this.guiProtocol.Size = new System.Drawing.Size(200, 21);
            this.guiProtocol.TabIndex = 7;
            // 
            // labelProtocol
            // 
            labelProtocol.AutoSize = true;
            labelProtocol.Location = new System.Drawing.Point(209, 56);
            labelProtocol.Name = "labelProtocol";
            labelProtocol.Size = new System.Drawing.Size(46, 13);
            labelProtocol.TabIndex = 6;
            labelProtocol.Text = "Protocol";
            // 
            // guiGroupCardAttributes
            // 
            this.guiGroupCardAttributes.AutoSize = true;
            this.guiGroupCardAttributes.Controls.Add(this.guiGetAttribute);
            this.guiGroupCardAttributes.Controls.Add(labelStringAttribute);
            this.guiGroupCardAttributes.Controls.Add(labelRawAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.guiStringAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.guiRawAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.guiAttribute);
            this.guiGroupCardAttributes.Enabled = false;
            this.guiGroupCardAttributes.Location = new System.Drawing.Point(6, 153);
            this.guiGroupCardAttributes.Name = "guiGroupCardAttributes";
            this.guiGroupCardAttributes.Size = new System.Drawing.Size(640, 141);
            this.guiGroupCardAttributes.TabIndex = 1;
            this.guiGroupCardAttributes.TabStop = false;
            this.guiGroupCardAttributes.Text = "Card Attributes";
            // 
            // guiGetAttribute
            // 
            this.guiGetAttribute.Location = new System.Drawing.Point(312, 19);
            this.guiGetAttribute.Name = "guiGetAttribute";
            this.guiGetAttribute.Size = new System.Drawing.Size(90, 23);
            this.guiGetAttribute.TabIndex = 1;
            this.guiGetAttribute.Text = "Get attribute";
            this.guiGetAttribute.UseVisualStyleBackColor = true;
            this.guiGetAttribute.Click += new System.EventHandler(this.guiGetAttribute_Click);
            // 
            // labelStringAttribute
            // 
            labelStringAttribute.AutoSize = true;
            labelStringAttribute.Location = new System.Drawing.Point(309, 45);
            labelStringAttribute.Name = "labelStringAttribute";
            labelStringAttribute.Size = new System.Drawing.Size(98, 13);
            labelStringAttribute.TabIndex = 4;
            labelStringAttribute.Text = "String interpretation";
            // 
            // labelRawAttribute
            // 
            labelRawAttribute.AutoSize = true;
            labelRawAttribute.Location = new System.Drawing.Point(6, 46);
            labelRawAttribute.Name = "labelRawAttribute";
            labelRawAttribute.Size = new System.Drawing.Size(71, 13);
            labelRawAttribute.TabIndex = 2;
            labelRawAttribute.Text = "Raw Attribute";
            // 
            // guiStringAttribute
            // 
            this.guiStringAttribute.Location = new System.Drawing.Point(312, 62);
            this.guiStringAttribute.Multiline = true;
            this.guiStringAttribute.Name = "guiStringAttribute";
            this.guiStringAttribute.ReadOnly = true;
            this.guiStringAttribute.Size = new System.Drawing.Size(300, 60);
            this.guiStringAttribute.TabIndex = 5;
            this.guiStringAttribute.TabStop = false;
            // 
            // guiRawAttribute
            // 
            this.guiRawAttribute.Location = new System.Drawing.Point(6, 62);
            this.guiRawAttribute.Multiline = true;
            this.guiRawAttribute.Name = "guiRawAttribute";
            this.guiRawAttribute.ReadOnly = true;
            this.guiRawAttribute.Size = new System.Drawing.Size(300, 60);
            this.guiRawAttribute.TabIndex = 3;
            this.guiRawAttribute.TabStop = false;
            // 
            // guiAttribute
            // 
            this.guiAttribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiAttribute.FormattingEnabled = true;
            this.guiAttribute.Location = new System.Drawing.Point(6, 22);
            this.guiAttribute.Name = "guiAttribute";
            this.guiAttribute.Size = new System.Drawing.Size(300, 21);
            this.guiAttribute.TabIndex = 0;
            // 
            // guiStatus
            // 
            guiStatus.Dock = System.Windows.Forms.DockStyle.None;
            guiStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiLastError});
            guiStatus.Location = new System.Drawing.Point(0, 0);
            guiStatus.Name = "guiStatus";
            guiStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            guiStatus.Size = new System.Drawing.Size(784, 22);
            guiStatus.TabIndex = 0;
            // 
            // guiLastError
            // 
            this.guiLastError.Name = "guiLastError";
            this.guiLastError.Size = new System.Drawing.Size(76, 17);
            this.guiLastError.Text = "Last Error: {0}";
            // 
            // guiGroupBoxLoadedPlugins
            // 
            guiGroupBoxLoadedPlugins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            guiGroupBoxLoadedPlugins.Controls.Add(this.guiLoadedPlugins);
            guiGroupBoxLoadedPlugins.Dock = System.Windows.Forms.DockStyle.Left;
            guiGroupBoxLoadedPlugins.Location = new System.Drawing.Point(3, 3);
            guiGroupBoxLoadedPlugins.Name = "guiGroupBoxLoadedPlugins";
            guiGroupBoxLoadedPlugins.Size = new System.Drawing.Size(200, 462);
            guiGroupBoxLoadedPlugins.TabIndex = 0;
            guiGroupBoxLoadedPlugins.TabStop = false;
            guiGroupBoxLoadedPlugins.Text = "Loaded plugins";
            // 
            // guiLoadedPlugins
            // 
            this.guiLoadedPlugins.Dock = System.Windows.Forms.DockStyle.Left;
            this.guiLoadedPlugins.FormattingEnabled = true;
            this.guiLoadedPlugins.Location = new System.Drawing.Point(3, 16);
            this.guiLoadedPlugins.Name = "guiLoadedPlugins";
            this.guiLoadedPlugins.Size = new System.Drawing.Size(188, 443);
            this.guiLoadedPlugins.TabIndex = 0;
            this.guiLoadedPlugins.SelectedIndexChanged += new System.EventHandler(this.guiLoadedPlugins_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 94);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(27, 13);
            label3.TabIndex = 4;
            label3.Text = "DLL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 13);
            label4.TabIndex = 2;
            label4.Text = "Class Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 133);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(64, 13);
            label5.TabIndex = 6;
            label5.Text = "Path to DLL";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(this.guiPluginPathToDll);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(this.guiPluginClassName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(this.guiPluginDLL);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(this.guiPluginName);
            groupBox1.Location = new System.Drawing.Point(212, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(436, 188);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plugin Description";
            // 
            // guiPluginPathToDll
            // 
            this.guiPluginPathToDll.Location = new System.Drawing.Point(6, 149);
            this.guiPluginPathToDll.Name = "guiPluginPathToDll";
            this.guiPluginPathToDll.ReadOnly = true;
            this.guiPluginPathToDll.Size = new System.Drawing.Size(424, 20);
            this.guiPluginPathToDll.TabIndex = 7;
            // 
            // guiPluginClassName
            // 
            this.guiPluginClassName.Location = new System.Drawing.Point(6, 71);
            this.guiPluginClassName.Name = "guiPluginClassName";
            this.guiPluginClassName.ReadOnly = true;
            this.guiPluginClassName.Size = new System.Drawing.Size(424, 20);
            this.guiPluginClassName.TabIndex = 3;
            // 
            // guiPluginDLL
            // 
            this.guiPluginDLL.Location = new System.Drawing.Point(6, 110);
            this.guiPluginDLL.Name = "guiPluginDLL";
            this.guiPluginDLL.ReadOnly = true;
            this.guiPluginDLL.Size = new System.Drawing.Size(424, 20);
            this.guiPluginDLL.TabIndex = 5;
            // 
            // guiPluginName
            // 
            this.guiPluginName.Location = new System.Drawing.Point(6, 32);
            this.guiPluginName.Name = "guiPluginName";
            this.guiPluginName.ReadOnly = true;
            this.guiPluginName.Size = new System.Drawing.Size(424, 20);
            this.guiPluginName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 13);
            label6.TabIndex = 0;
            label6.Text = "Version";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 55);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(35, 13);
            label7.TabIndex = 2;
            label7.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(this.guiPluginAssemblyName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(this.guiPluginAssemblyVersion);
            groupBox2.Controls.Add(this.guiPluginAssemblyDescription);
            groupBox2.Location = new System.Drawing.Point(212, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(436, 169);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Plugin Assembly Informations";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(6, 94);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(60, 13);
            label15.TabIndex = 4;
            label15.Text = "Description";
            // 
            // guiPluginAssemblyName
            // 
            this.guiPluginAssemblyName.Location = new System.Drawing.Point(6, 71);
            this.guiPluginAssemblyName.Name = "guiPluginAssemblyName";
            this.guiPluginAssemblyName.ReadOnly = true;
            this.guiPluginAssemblyName.Size = new System.Drawing.Size(424, 20);
            this.guiPluginAssemblyName.TabIndex = 3;
            // 
            // guiPluginAssemblyVersion
            // 
            this.guiPluginAssemblyVersion.Location = new System.Drawing.Point(6, 32);
            this.guiPluginAssemblyVersion.Name = "guiPluginAssemblyVersion";
            this.guiPluginAssemblyVersion.ReadOnly = true;
            this.guiPluginAssemblyVersion.Size = new System.Drawing.Size(424, 20);
            this.guiPluginAssemblyVersion.TabIndex = 1;
            // 
            // guiPluginAssemblyDescription
            // 
            this.guiPluginAssemblyDescription.Location = new System.Drawing.Point(6, 110);
            this.guiPluginAssemblyDescription.Multiline = true;
            this.guiPluginAssemblyDescription.Name = "guiPluginAssemblyDescription";
            this.guiPluginAssemblyDescription.ReadOnly = true;
            this.guiPluginAssemblyDescription.Size = new System.Drawing.Size(424, 40);
            this.guiPluginAssemblyDescription.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(this.guiLayerAssemblyDescription);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(this.guiLayerAssemblyName);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(this.guiLayerAssemblyVersion);
            groupBox3.Location = new System.Drawing.Point(212, 200);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(436, 169);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Layer Assembly Informations";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(6, 94);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(60, 13);
            label14.TabIndex = 4;
            label14.Text = "Description";
            // 
            // guiLayerAssemblyDescription
            // 
            this.guiLayerAssemblyDescription.Location = new System.Drawing.Point(6, 110);
            this.guiLayerAssemblyDescription.Multiline = true;
            this.guiLayerAssemblyDescription.Name = "guiLayerAssemblyDescription";
            this.guiLayerAssemblyDescription.ReadOnly = true;
            this.guiLayerAssemblyDescription.Size = new System.Drawing.Size(424, 40);
            this.guiLayerAssemblyDescription.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 55);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(35, 13);
            label8.TabIndex = 2;
            label8.Text = "Name";
            // 
            // guiLayerAssemblyName
            // 
            this.guiLayerAssemblyName.Location = new System.Drawing.Point(6, 71);
            this.guiLayerAssemblyName.Name = "guiLayerAssemblyName";
            this.guiLayerAssemblyName.ReadOnly = true;
            this.guiLayerAssemblyName.Size = new System.Drawing.Size(424, 20);
            this.guiLayerAssemblyName.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(6, 16);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(42, 13);
            label9.TabIndex = 0;
            label9.Text = "Version";
            // 
            // guiLayerAssemblyVersion
            // 
            this.guiLayerAssemblyVersion.Location = new System.Drawing.Point(6, 32);
            this.guiLayerAssemblyVersion.Name = "guiLayerAssemblyVersion";
            this.guiLayerAssemblyVersion.ReadOnly = true;
            this.guiLayerAssemblyVersion.Size = new System.Drawing.Size(424, 20);
            this.guiLayerAssemblyVersion.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.AutoSize = true;
            groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(this.guiLayerPathToDll);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(this.guiLayerClassName);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(this.guiLayerDLL);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(this.guiLayerName);
            groupBox4.Location = new System.Drawing.Point(212, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(436, 188);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Layer Description";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(6, 133);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(64, 13);
            label10.TabIndex = 6;
            label10.Text = "Path to DLL";
            // 
            // guiLayerPathToDll
            // 
            this.guiLayerPathToDll.Location = new System.Drawing.Point(6, 149);
            this.guiLayerPathToDll.Name = "guiLayerPathToDll";
            this.guiLayerPathToDll.ReadOnly = true;
            this.guiLayerPathToDll.Size = new System.Drawing.Size(424, 20);
            this.guiLayerPathToDll.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 55);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(63, 13);
            label11.TabIndex = 2;
            label11.Text = "Class Name";
            // 
            // guiLayerClassName
            // 
            this.guiLayerClassName.Location = new System.Drawing.Point(6, 71);
            this.guiLayerClassName.Name = "guiLayerClassName";
            this.guiLayerClassName.ReadOnly = true;
            this.guiLayerClassName.Size = new System.Drawing.Size(424, 20);
            this.guiLayerClassName.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(6, 94);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(27, 13);
            label12.TabIndex = 4;
            label12.Text = "DLL";
            // 
            // guiLayerDLL
            // 
            this.guiLayerDLL.Location = new System.Drawing.Point(6, 110);
            this.guiLayerDLL.Name = "guiLayerDLL";
            this.guiLayerDLL.ReadOnly = true;
            this.guiLayerDLL.Size = new System.Drawing.Size(424, 20);
            this.guiLayerDLL.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 16);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(35, 13);
            label13.TabIndex = 0;
            label13.Text = "Name";
            // 
            // guiLayerName
            // 
            this.guiLayerName.Location = new System.Drawing.Point(6, 32);
            this.guiLayerName.Name = "guiLayerName";
            this.guiLayerName.ReadOnly = true;
            this.guiLayerName.Size = new System.Drawing.Size(424, 20);
            this.guiLayerName.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox5.Controls.Add(this.guiLoadedContextLayers);
            groupBox5.Controls.Add(this.guiLoadedChannelLayers);
            groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            groupBox5.Location = new System.Drawing.Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(200, 462);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Loaded layers";
            // 
            // guiLoadedContextLayers
            // 
            this.guiLoadedContextLayers.FormattingEnabled = true;
            this.guiLoadedContextLayers.Location = new System.Drawing.Point(3, 237);
            this.guiLoadedContextLayers.Name = "guiLoadedContextLayers";
            this.guiLoadedContextLayers.Size = new System.Drawing.Size(191, 212);
            this.guiLoadedContextLayers.TabIndex = 1;
            this.guiLoadedContextLayers.SelectedIndexChanged += new System.EventHandler(this.guiLoadedContextLayers_SelectedIndexChanged);
            // 
            // guiLoadedChannelLayers
            // 
            this.guiLoadedChannelLayers.FormattingEnabled = true;
            this.guiLoadedChannelLayers.Location = new System.Drawing.Point(3, 19);
            this.guiLoadedChannelLayers.Name = "guiLoadedChannelLayers";
            this.guiLoadedChannelLayers.Size = new System.Drawing.Size(191, 212);
            this.guiLoadedChannelLayers.TabIndex = 0;
            this.guiLoadedChannelLayers.SelectedIndexChanged += new System.EventHandler(this.guiLoadedChannelLayers_SelectedIndexChanged);
            // 
            // guiTabs
            // 
            this.guiTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiTabs.Controls.Add(guiTabConnection);
            this.guiTabs.Controls.Add(this.guiTabLogs);
            this.guiTabs.Controls.Add(this.guiTabPlugins);
            this.guiTabs.Controls.Add(this.tabPage1);
            this.guiTabs.HotTrack = true;
            this.guiTabs.Location = new System.Drawing.Point(120, 3);
            this.guiTabs.Multiline = true;
            this.guiTabs.Name = "guiTabs";
            this.guiTabs.SelectedIndex = 0;
            this.guiTabs.Size = new System.Drawing.Size(669, 494);
            this.guiTabs.TabIndex = 1;
            // 
            // guiTabLogs
            // 
            this.guiTabLogs.Controls.Add(this.guiLogsView);
            this.guiTabLogs.Location = new System.Drawing.Point(4, 22);
            this.guiTabLogs.Name = "guiTabLogs";
            this.guiTabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.guiTabLogs.Size = new System.Drawing.Size(661, 468);
            this.guiTabLogs.TabIndex = 4;
            this.guiTabLogs.Text = "Logs";
            this.guiTabLogs.UseVisualStyleBackColor = true;
            // 
            // guiLogsView
            // 
            this.guiLogsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiLogsView.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLogsView.Location = new System.Drawing.Point(6, 6);
            this.guiLogsView.Name = "guiLogsView";
            this.guiLogsView.Size = new System.Drawing.Size(649, 458);
            this.guiLogsView.TabIndex = 0;
            this.guiLogsView.Text = "";
            this.guiLogsView.WordWrap = false;
            // 
            // guiTabPlugins
            // 
            this.guiTabPlugins.Controls.Add(groupBox2);
            this.guiTabPlugins.Controls.Add(groupBox1);
            this.guiTabPlugins.Controls.Add(guiGroupBoxLoadedPlugins);
            this.guiTabPlugins.Location = new System.Drawing.Point(4, 22);
            this.guiTabPlugins.Name = "guiTabPlugins";
            this.guiTabPlugins.Padding = new System.Windows.Forms.Padding(3);
            this.guiTabPlugins.Size = new System.Drawing.Size(661, 468);
            this.guiTabPlugins.TabIndex = 5;
            this.guiTabPlugins.Text = "Plugins";
            this.guiTabPlugins.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(groupBox3);
            this.tabPage1.Controls.Add(groupBox4);
            this.tabPage1.Controls.Add(groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 468);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Layers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(guiStatus);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.guiTabs);
            this.toolStripContainer1.ContentPanel.Controls.Add(guiGroupCard);
            this.toolStripContainer1.ContentPanel.Controls.Add(guiGroupContext);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 518);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(784, 564);
            this.toolStripContainer1.TabIndex = 8;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.guiMenu);
            // 
            // guiMenu
            // 
            this.guiMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.guiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiFileMenuItem,
            this.guiPluginsMenuItem,
            this.guiHelpMenuItem});
            this.guiMenu.Location = new System.Drawing.Point(0, 0);
            this.guiMenu.Name = "guiMenu";
            this.guiMenu.Size = new System.Drawing.Size(784, 24);
            this.guiMenu.TabIndex = 0;
            this.guiMenu.Text = "menuStrip1";
            // 
            // guiFileMenuItem
            // 
            this.guiFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiQuit});
            this.guiFileMenuItem.Name = "guiFileMenuItem";
            this.guiFileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.guiFileMenuItem.Text = "&File";
            // 
            // guiQuit
            // 
            this.guiQuit.Name = "guiQuit";
            this.guiQuit.Size = new System.Drawing.Size(97, 22);
            this.guiQuit.Text = "&Quit";
            this.guiQuit.Click += new System.EventHandler(this.guiQuit_Click);
            // 
            // guiPluginsMenuItem
            // 
            this.guiPluginsMenuItem.Name = "guiPluginsMenuItem";
            this.guiPluginsMenuItem.Size = new System.Drawing.Size(58, 20);
            this.guiPluginsMenuItem.Text = "Plugins";
            // 
            // guiHelpMenuItem
            // 
            this.guiHelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiAboutWinSCardGUI});
            this.guiHelpMenuItem.Name = "guiHelpMenuItem";
            this.guiHelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.guiHelpMenuItem.Text = "&Help";
            // 
            // guiAboutWinSCardGUI
            // 
            this.guiAboutWinSCardGUI.Name = "guiAboutWinSCardGUI";
            this.guiAboutWinSCardGUI.Size = new System.Drawing.Size(184, 22);
            this.guiAboutWinSCardGUI.Text = "&About WinSCard GUI";
            this.guiAboutWinSCardGUI.Click += new System.EventHandler(this.guiAboutWinSCardGUI_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Found: 0";
            // 
            // WinSCardGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.guiMenu;
            this.Name = "WinSCardGui";
            this.Text = "WinSCard GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinSCardGUI_FormClosing);
            guiGroupCard.ResumeLayout(false);
            guiGroupContext.ResumeLayout(false);
            guiTabConnection.ResumeLayout(false);
            guiTabConnection.PerformLayout();
            this.guiGroupCardInformations.ResumeLayout(false);
            this.guiGroupCardInformations.PerformLayout();
            this.guiGroupCardConnection.ResumeLayout(false);
            this.guiGroupCardConnection.PerformLayout();
            this.guiGroupCardAttributes.ResumeLayout(false);
            this.guiGroupCardAttributes.PerformLayout();
            guiStatus.ResumeLayout(false);
            guiStatus.PerformLayout();
            guiGroupBoxLoadedPlugins.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            this.guiTabs.ResumeLayout(false);
            this.guiTabLogs.ResumeLayout(false);
            this.guiTabPlugins.ResumeLayout(false);
            this.guiTabPlugins.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.guiMenu.ResumeLayout(false);
            this.guiMenu.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button guiCardConnect;
		private System.Windows.Forms.Button guiCardWarmReset;
		private System.Windows.Forms.Button guiCardUnpower;
		private System.Windows.Forms.Button guiCardColdReset;
		private System.Windows.Forms.Button guiContextRelease;
		private System.Windows.Forms.Button guiContextEstablish;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ComboBox guiReaderGroups;
		private System.Windows.Forms.Label guiFoundReaderGroups;
		private System.Windows.Forms.Label guiFoundReaders;
		private System.Windows.Forms.Button guiChannelConnect;
		private System.Windows.Forms.Button guiChannelDisconnect;
		private System.Windows.Forms.Button guiChannelReconnect;
		private System.Windows.Forms.ComboBox guiProtocol;
		private System.Windows.Forms.ComboBox guiShareMode;
		private System.Windows.Forms.ComboBox guiDisposition;
		private System.Windows.Forms.TabControl guiTabs;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip guiMenu;
		private System.Windows.Forms.ToolStripMenuItem guiFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guiQuit;
		private System.Windows.Forms.ToolStripMenuItem guiHelpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guiAboutWinSCardGUI;
		private System.Windows.Forms.Button guiGetAttribute;
		private System.Windows.Forms.TextBox guiChannelState;
		private System.Windows.Forms.ToolStripStatusLabel guiLastError;
		private System.Windows.Forms.TextBox guiContextState;
		private System.Windows.Forms.TextBox guiReaderInUse;
		private System.Windows.Forms.ComboBox guiReaders;
		private System.Windows.Forms.ComboBox guiAttribute;
		private System.Windows.Forms.TextBox guiRawAttribute;
		private System.Windows.Forms.TextBox guiStringAttribute;
		private System.Windows.Forms.TabPage guiTabLogs;
		internal System.Windows.Forms.RichTextBox guiLogsView;
        private System.Windows.Forms.ToolStripMenuItem guiPluginsMenuItem;
		private System.Windows.Forms.TabPage guiTabPlugins;
		private System.Windows.Forms.ListBox guiLoadedPlugins;
		private System.Windows.Forms.TextBox guiPluginDLL;
		private System.Windows.Forms.TextBox guiPluginName;
		private System.Windows.Forms.TextBox guiPluginClassName;
		private System.Windows.Forms.TextBox guiPluginPathToDll;
		private System.Windows.Forms.TextBox guiPluginAssemblyVersion;
		private System.Windows.Forms.TextBox guiPluginAssemblyName;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox guiLayerAssemblyName;
		private System.Windows.Forms.TextBox guiLayerAssemblyVersion;
		private System.Windows.Forms.TextBox guiLayerPathToDll;
		private System.Windows.Forms.TextBox guiLayerClassName;
		private System.Windows.Forms.TextBox guiLayerDLL;
		private System.Windows.Forms.TextBox guiLayerName;
		private System.Windows.Forms.ListBox guiLoadedChannelLayers;
		private System.Windows.Forms.ListBox guiLoadedContextLayers;
        private System.Windows.Forms.GroupBox guiGroupCardConnection;
        private System.Windows.Forms.GroupBox guiGroupCardAttributes;
        private System.Windows.Forms.GroupBox guiGroupCardInformations;
        private System.Windows.Forms.TextBox guiLayerAssemblyDescription;
        private System.Windows.Forms.TextBox guiPluginAssemblyDescription;
	}
}

