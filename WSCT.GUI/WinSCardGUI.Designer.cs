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
            this.guiGroupCard = new System.Windows.Forms.GroupBox();
            this.guiCardConnect = new System.Windows.Forms.Button();
            this.guiCardWarmReset = new System.Windows.Forms.Button();
            this.guiCardUnpower = new System.Windows.Forms.Button();
            this.guiCardColdReset = new System.Windows.Forms.Button();
            this.guiGroupContext = new System.Windows.Forms.GroupBox();
            this.guiContextRelease = new System.Windows.Forms.Button();
            this.guiContextEstablish = new System.Windows.Forms.Button();
            this.guiTabConnection = new System.Windows.Forms.TabPage();
            this.guiGroupCardInformations = new System.Windows.Forms.GroupBox();
            this.guiReaderInUse = new System.Windows.Forms.TextBox();
            this.labelReaderInUser = new System.Windows.Forms.Label();
            this.guiChannelState = new System.Windows.Forms.TextBox();
            this.labelCardChannel = new System.Windows.Forms.Label();
            this.guiContextState = new System.Windows.Forms.TextBox();
            this.labelContext = new System.Windows.Forms.Label();
            this.guiGroupCardConnection = new System.Windows.Forms.GroupBox();
            this.guiChannelConnect = new System.Windows.Forms.Button();
            this.guiFoundReaders = new System.Windows.Forms.Label();
            this.guiFoundReaderGroups = new System.Windows.Forms.Label();
            this.labelDisposition = new System.Windows.Forms.Label();
            this.guiReaderGroups = new System.Windows.Forms.ComboBox();
            this.guiReaders = new System.Windows.Forms.ComboBox();
            this.guiChannelDisconnect = new System.Windows.Forms.Button();
            this.guiShareMode = new System.Windows.Forms.ComboBox();
            this.labelShareMode = new System.Windows.Forms.Label();
            this.guiChannelReconnect = new System.Windows.Forms.Button();
            this.guiDisposition = new System.Windows.Forms.ComboBox();
            this.guiProtocol = new System.Windows.Forms.ComboBox();
            this.labelProtocol = new System.Windows.Forms.Label();
            this.guiGroupCardAttributes = new System.Windows.Forms.GroupBox();
            this.guiGetAttribute = new System.Windows.Forms.Button();
            this.labelStringAttribute = new System.Windows.Forms.Label();
            this.labelRawAttribute = new System.Windows.Forms.Label();
            this.guiStringAttribute = new System.Windows.Forms.TextBox();
            this.guiRawAttribute = new System.Windows.Forms.TextBox();
            this.guiAttribute = new System.Windows.Forms.ComboBox();
            this.guiStatus = new System.Windows.Forms.StatusStrip();
            this.guiLastError = new System.Windows.Forms.ToolStripStatusLabel();
            this.guiGroupBoxLoadedPlugins = new System.Windows.Forms.GroupBox();
            this.guiLoadedPlugins = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guiPluginPathToDll = new System.Windows.Forms.TextBox();
            this.guiPluginClassName = new System.Windows.Forms.TextBox();
            this.guiPluginName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.guiPluginAssemblyName = new System.Windows.Forms.TextBox();
            this.guiPluginAssemblyVersion = new System.Windows.Forms.TextBox();
            this.guiPluginAssemblyDescription = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.guiLayerAssemblyDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guiLayerAssemblyName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guiLayerAssemblyVersion = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guiLayerPathToDll = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guiLayerClassName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.guiLayerDLL = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.guiLayerName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
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
            this.label16 = new System.Windows.Forms.Label();
            this.guiPluginDescription = new System.Windows.Forms.TextBox();
            this.guiGroupCard.SuspendLayout();
            this.guiGroupContext.SuspendLayout();
            this.guiTabConnection.SuspendLayout();
            this.guiGroupCardInformations.SuspendLayout();
            this.guiGroupCardConnection.SuspendLayout();
            this.guiGroupCardAttributes.SuspendLayout();
            this.guiStatus.SuspendLayout();
            this.guiGroupBoxLoadedPlugins.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.guiGroupCard.AutoSize = true;
            this.guiGroupCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guiGroupCard.Controls.Add(this.guiCardConnect);
            this.guiGroupCard.Controls.Add(this.guiCardWarmReset);
            this.guiGroupCard.Controls.Add(this.guiCardUnpower);
            this.guiGroupCard.Controls.Add(this.guiCardColdReset);
            this.guiGroupCard.Location = new System.Drawing.Point(24, 190);
            this.guiGroupCard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupCard.Name = "guiGroupCard";
            this.guiGroupCard.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupCard.Size = new System.Drawing.Size(204, 284);
            this.guiGroupCard.TabIndex = 1;
            this.guiGroupCard.TabStop = false;
            this.guiGroupCard.Text = "Quick Connect";
            // 
            // guiCardConnect
            // 
            this.guiCardConnect.Enabled = false;
            this.guiCardConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiCardConnect.Location = new System.Drawing.Point(12, 37);
            this.guiCardConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiCardConnect.Name = "guiCardConnect";
            this.guiCardConnect.Size = new System.Drawing.Size(180, 44);
            this.guiCardConnect.TabIndex = 0;
            this.guiCardConnect.Text = "Connect";
            this.guiCardConnect.UseVisualStyleBackColor = true;
            this.guiCardConnect.Click += new System.EventHandler(this.guiCardConnect_Click);
            // 
            // guiCardWarmReset
            // 
            this.guiCardWarmReset.Enabled = false;
            this.guiCardWarmReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiCardWarmReset.Location = new System.Drawing.Point(12, 92);
            this.guiCardWarmReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiCardWarmReset.Name = "guiCardWarmReset";
            this.guiCardWarmReset.Size = new System.Drawing.Size(180, 44);
            this.guiCardWarmReset.TabIndex = 1;
            this.guiCardWarmReset.Text = "Warm reset";
            this.guiCardWarmReset.UseVisualStyleBackColor = true;
            this.guiCardWarmReset.Click += new System.EventHandler(this.guiCardWarmReset_Click);
            // 
            // guiCardUnpower
            // 
            this.guiCardUnpower.Enabled = false;
            this.guiCardUnpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiCardUnpower.Location = new System.Drawing.Point(12, 204);
            this.guiCardUnpower.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiCardUnpower.Name = "guiCardUnpower";
            this.guiCardUnpower.Size = new System.Drawing.Size(180, 44);
            this.guiCardUnpower.TabIndex = 3;
            this.guiCardUnpower.Text = "Unpower";
            this.guiCardUnpower.UseVisualStyleBackColor = true;
            this.guiCardUnpower.Click += new System.EventHandler(this.guiCardUnpower_Click);
            // 
            // guiCardColdReset
            // 
            this.guiCardColdReset.Enabled = false;
            this.guiCardColdReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiCardColdReset.Location = new System.Drawing.Point(12, 148);
            this.guiCardColdReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiCardColdReset.Name = "guiCardColdReset";
            this.guiCardColdReset.Size = new System.Drawing.Size(180, 44);
            this.guiCardColdReset.TabIndex = 2;
            this.guiCardColdReset.Text = "Cold reset";
            this.guiCardColdReset.UseVisualStyleBackColor = true;
            this.guiCardColdReset.Click += new System.EventHandler(this.guiCardColdReset_Click);
            // 
            // guiGroupContext
            // 
            this.guiGroupContext.AutoSize = true;
            this.guiGroupContext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guiGroupContext.Controls.Add(this.guiContextRelease);
            this.guiGroupContext.Controls.Add(this.guiContextEstablish);
            this.guiGroupContext.Location = new System.Drawing.Point(24, 6);
            this.guiGroupContext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupContext.Name = "guiGroupContext";
            this.guiGroupContext.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupContext.Size = new System.Drawing.Size(204, 172);
            this.guiGroupContext.TabIndex = 0;
            this.guiGroupContext.TabStop = false;
            this.guiGroupContext.Text = "Context";
            // 
            // guiContextRelease
            // 
            this.guiContextRelease.Enabled = false;
            this.guiContextRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiContextRelease.Location = new System.Drawing.Point(12, 92);
            this.guiContextRelease.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiContextRelease.Name = "guiContextRelease";
            this.guiContextRelease.Size = new System.Drawing.Size(180, 44);
            this.guiContextRelease.TabIndex = 1;
            this.guiContextRelease.Text = "Release";
            this.guiContextRelease.UseVisualStyleBackColor = true;
            this.guiContextRelease.Click += new System.EventHandler(this.guiContextRelease_Click);
            // 
            // guiContextEstablish
            // 
            this.guiContextEstablish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiContextEstablish.Location = new System.Drawing.Point(12, 37);
            this.guiContextEstablish.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiContextEstablish.Name = "guiContextEstablish";
            this.guiContextEstablish.Size = new System.Drawing.Size(180, 44);
            this.guiContextEstablish.TabIndex = 0;
            this.guiContextEstablish.Text = "Establish";
            this.guiContextEstablish.UseVisualStyleBackColor = true;
            this.guiContextEstablish.Click += new System.EventHandler(this.guiContextEstablish_Click);
            // 
            // guiTabConnection
            // 
            this.guiTabConnection.Controls.Add(this.guiGroupCardInformations);
            this.guiTabConnection.Controls.Add(this.guiGroupCardConnection);
            this.guiTabConnection.Controls.Add(this.guiGroupCardAttributes);
            this.guiTabConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiTabConnection.Location = new System.Drawing.Point(8, 39);
            this.guiTabConnection.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiTabConnection.Name = "guiTabConnection";
            this.guiTabConnection.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiTabConnection.Size = new System.Drawing.Size(1328, 963);
            this.guiTabConnection.TabIndex = 0;
            this.guiTabConnection.Text = "Card Tools";
            this.guiTabConnection.UseVisualStyleBackColor = true;
            // 
            // guiGroupCardInformations
            // 
            this.guiGroupCardInformations.AutoSize = true;
            this.guiGroupCardInformations.Controls.Add(this.guiReaderInUse);
            this.guiGroupCardInformations.Controls.Add(this.labelReaderInUser);
            this.guiGroupCardInformations.Controls.Add(this.guiChannelState);
            this.guiGroupCardInformations.Controls.Add(this.labelCardChannel);
            this.guiGroupCardInformations.Controls.Add(this.guiContextState);
            this.guiGroupCardInformations.Controls.Add(this.labelContext);
            this.guiGroupCardInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiGroupCardInformations.Location = new System.Drawing.Point(12, 577);
            this.guiGroupCardInformations.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupCardInformations.Name = "guiGroupCardInformations";
            this.guiGroupCardInformations.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupCardInformations.Size = new System.Drawing.Size(1280, 198);
            this.guiGroupCardInformations.TabIndex = 2;
            this.guiGroupCardInformations.TabStop = false;
            this.guiGroupCardInformations.Text = "Card Informations";
            // 
            // guiReaderInUse
            // 
            this.guiReaderInUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiReaderInUse.Location = new System.Drawing.Point(568, 81);
            this.guiReaderInUse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiReaderInUse.Name = "guiReaderInUse";
            this.guiReaderInUse.ReadOnly = true;
            this.guiReaderInUse.Size = new System.Drawing.Size(396, 31);
            this.guiReaderInUse.TabIndex = 5;
            this.guiReaderInUse.TabStop = false;
            // 
            // labelReaderInUser
            // 
            this.labelReaderInUser.AutoSize = true;
            this.labelReaderInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReaderInUser.Location = new System.Drawing.Point(396, 87);
            this.labelReaderInUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReaderInUser.Name = "labelReaderInUser";
            this.labelReaderInUser.Size = new System.Drawing.Size(152, 25);
            this.labelReaderInUser.TabIndex = 4;
            this.labelReaderInUser.Text = "Reader in use:";
            // 
            // guiChannelState
            // 
            this.guiChannelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiChannelState.Location = new System.Drawing.Point(184, 81);
            this.guiChannelState.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiChannelState.Name = "guiChannelState";
            this.guiChannelState.ReadOnly = true;
            this.guiChannelState.Size = new System.Drawing.Size(196, 31);
            this.guiChannelState.TabIndex = 3;
            this.guiChannelState.TabStop = false;
            this.guiChannelState.Text = "Disconnected";
            // 
            // labelCardChannel
            // 
            this.labelCardChannel.AutoSize = true;
            this.labelCardChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardChannel.Location = new System.Drawing.Point(12, 87);
            this.labelCardChannel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCardChannel.Name = "labelCardChannel";
            this.labelCardChannel.Size = new System.Drawing.Size(146, 25);
            this.labelCardChannel.TabIndex = 2;
            this.labelCardChannel.Text = "Card channel:";
            // 
            // guiContextState
            // 
            this.guiContextState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiContextState.Location = new System.Drawing.Point(184, 31);
            this.guiContextState.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiContextState.Name = "guiContextState";
            this.guiContextState.ReadOnly = true;
            this.guiContextState.Size = new System.Drawing.Size(196, 31);
            this.guiContextState.TabIndex = 1;
            this.guiContextState.TabStop = false;
            this.guiContextState.Text = "Released";
            // 
            // labelContext
            // 
            this.labelContext.AutoSize = true;
            this.labelContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContext.Location = new System.Drawing.Point(12, 37);
            this.labelContext.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelContext.Name = "labelContext";
            this.labelContext.Size = new System.Drawing.Size(92, 25);
            this.labelContext.TabIndex = 0;
            this.labelContext.Text = "Context:";
            // 
            // guiGroupCardConnection
            // 
            this.guiGroupCardConnection.AutoSize = true;
            this.guiGroupCardConnection.Controls.Add(this.guiChannelConnect);
            this.guiGroupCardConnection.Controls.Add(this.guiFoundReaders);
            this.guiGroupCardConnection.Controls.Add(this.guiFoundReaderGroups);
            this.guiGroupCardConnection.Controls.Add(this.labelDisposition);
            this.guiGroupCardConnection.Controls.Add(this.guiReaderGroups);
            this.guiGroupCardConnection.Controls.Add(this.guiReaders);
            this.guiGroupCardConnection.Controls.Add(this.guiChannelDisconnect);
            this.guiGroupCardConnection.Controls.Add(this.guiShareMode);
            this.guiGroupCardConnection.Controls.Add(this.labelShareMode);
            this.guiGroupCardConnection.Controls.Add(this.guiChannelReconnect);
            this.guiGroupCardConnection.Controls.Add(this.guiDisposition);
            this.guiGroupCardConnection.Controls.Add(this.guiProtocol);
            this.guiGroupCardConnection.Controls.Add(this.labelProtocol);
            this.guiGroupCardConnection.Enabled = false;
            this.guiGroupCardConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiGroupCardConnection.Location = new System.Drawing.Point(12, 12);
            this.guiGroupCardConnection.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupCardConnection.Name = "guiGroupCardConnection";
            this.guiGroupCardConnection.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupCardConnection.Size = new System.Drawing.Size(1280, 292);
            this.guiGroupCardConnection.TabIndex = 0;
            this.guiGroupCardConnection.TabStop = false;
            this.guiGroupCardConnection.Text = "Card connection";
            // 
            // guiChannelConnect
            // 
            this.guiChannelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiChannelConnect.Location = new System.Drawing.Point(12, 190);
            this.guiChannelConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiChannelConnect.Name = "guiChannelConnect";
            this.guiChannelConnect.Size = new System.Drawing.Size(180, 44);
            this.guiChannelConnect.TabIndex = 10;
            this.guiChannelConnect.Text = "Connect";
            this.guiChannelConnect.UseVisualStyleBackColor = true;
            this.guiChannelConnect.Click += new System.EventHandler(this.guiChannelConnect_Click);
            // 
            // guiFoundReaders
            // 
            this.guiFoundReaders.AutoSize = true;
            this.guiFoundReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiFoundReaders.Location = new System.Drawing.Point(618, 31);
            this.guiFoundReaders.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.guiFoundReaders.Name = "guiFoundReaders";
            this.guiFoundReaders.Size = new System.Drawing.Size(289, 25);
            this.guiFoundReaders.TabIndex = 2;
            this.guiFoundReaders.Text = "Readers descriptionFound: 0";
            // 
            // guiFoundReaderGroups
            // 
            this.guiFoundReaderGroups.AutoSize = true;
            this.guiFoundReaderGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiFoundReaderGroups.Location = new System.Drawing.Point(12, 31);
            this.guiFoundReaderGroups.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.guiFoundReaderGroups.Name = "guiFoundReaderGroups";
            this.guiFoundReaderGroups.Size = new System.Drawing.Size(350, 25);
            this.guiFoundReaderGroups.TabIndex = 0;
            this.guiFoundReaderGroups.Text = "Reader groups descriptionFound: 0";
            // 
            // labelDisposition
            // 
            this.labelDisposition.AutoSize = true;
            this.labelDisposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisposition.Location = new System.Drawing.Point(830, 108);
            this.labelDisposition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDisposition.Name = "labelDisposition";
            this.labelDisposition.Size = new System.Drawing.Size(118, 25);
            this.labelDisposition.TabIndex = 8;
            this.labelDisposition.Text = "Disposition";
            // 
            // guiReaderGroups
            // 
            this.guiReaderGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiReaderGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiReaderGroups.FormattingEnabled = true;
            this.guiReaderGroups.Location = new System.Drawing.Point(12, 62);
            this.guiReaderGroups.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiReaderGroups.Name = "guiReaderGroups";
            this.guiReaderGroups.Size = new System.Drawing.Size(596, 33);
            this.guiReaderGroups.TabIndex = 1;
            // 
            // guiReaders
            // 
            this.guiReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiReaders.FormattingEnabled = true;
            this.guiReaders.Location = new System.Drawing.Point(624, 62);
            this.guiReaders.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiReaders.Name = "guiReaders";
            this.guiReaders.Size = new System.Drawing.Size(596, 33);
            this.guiReaders.TabIndex = 3;
            // 
            // guiChannelDisconnect
            // 
            this.guiChannelDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiChannelDisconnect.Location = new System.Drawing.Point(396, 190);
            this.guiChannelDisconnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiChannelDisconnect.Name = "guiChannelDisconnect";
            this.guiChannelDisconnect.Size = new System.Drawing.Size(180, 44);
            this.guiChannelDisconnect.TabIndex = 12;
            this.guiChannelDisconnect.Text = "Disconnect";
            this.guiChannelDisconnect.UseVisualStyleBackColor = true;
            this.guiChannelDisconnect.Click += new System.EventHandler(this.guiChannelDisconnect_Click);
            // 
            // guiShareMode
            // 
            this.guiShareMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiShareMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiShareMode.FormattingEnabled = true;
            this.guiShareMode.Location = new System.Drawing.Point(12, 138);
            this.guiShareMode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiShareMode.Name = "guiShareMode";
            this.guiShareMode.Size = new System.Drawing.Size(396, 33);
            this.guiShareMode.TabIndex = 5;
            // 
            // labelShareMode
            // 
            this.labelShareMode.AutoSize = true;
            this.labelShareMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShareMode.Location = new System.Drawing.Point(12, 108);
            this.labelShareMode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelShareMode.Name = "labelShareMode";
            this.labelShareMode.Size = new System.Drawing.Size(128, 25);
            this.labelShareMode.TabIndex = 4;
            this.labelShareMode.Text = "Share mode";
            // 
            // guiChannelReconnect
            // 
            this.guiChannelReconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiChannelReconnect.Location = new System.Drawing.Point(204, 190);
            this.guiChannelReconnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiChannelReconnect.Name = "guiChannelReconnect";
            this.guiChannelReconnect.Size = new System.Drawing.Size(180, 44);
            this.guiChannelReconnect.TabIndex = 11;
            this.guiChannelReconnect.Text = "Reconnect";
            this.guiChannelReconnect.UseVisualStyleBackColor = true;
            this.guiChannelReconnect.Click += new System.EventHandler(this.guiChannelReconnect_Click);
            // 
            // guiDisposition
            // 
            this.guiDisposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiDisposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiDisposition.FormattingEnabled = true;
            this.guiDisposition.Location = new System.Drawing.Point(836, 138);
            this.guiDisposition.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiDisposition.Name = "guiDisposition";
            this.guiDisposition.Size = new System.Drawing.Size(396, 33);
            this.guiDisposition.TabIndex = 9;
            // 
            // guiProtocol
            // 
            this.guiProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiProtocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiProtocol.FormattingEnabled = true;
            this.guiProtocol.Location = new System.Drawing.Point(424, 138);
            this.guiProtocol.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiProtocol.Name = "guiProtocol";
            this.guiProtocol.Size = new System.Drawing.Size(396, 33);
            this.guiProtocol.TabIndex = 7;
            // 
            // labelProtocol
            // 
            this.labelProtocol.AutoSize = true;
            this.labelProtocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProtocol.Location = new System.Drawing.Point(418, 108);
            this.labelProtocol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelProtocol.Name = "labelProtocol";
            this.labelProtocol.Size = new System.Drawing.Size(91, 25);
            this.labelProtocol.TabIndex = 6;
            this.labelProtocol.Text = "Protocol";
            // 
            // guiGroupCardAttributes
            // 
            this.guiGroupCardAttributes.AutoSize = true;
            this.guiGroupCardAttributes.Controls.Add(this.guiGetAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.labelStringAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.labelRawAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.guiStringAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.guiRawAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.guiAttribute);
            this.guiGroupCardAttributes.Enabled = false;
            this.guiGroupCardAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiGroupCardAttributes.Location = new System.Drawing.Point(12, 294);
            this.guiGroupCardAttributes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupCardAttributes.Name = "guiGroupCardAttributes";
            this.guiGroupCardAttributes.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupCardAttributes.Size = new System.Drawing.Size(1280, 292);
            this.guiGroupCardAttributes.TabIndex = 1;
            this.guiGroupCardAttributes.TabStop = false;
            this.guiGroupCardAttributes.Text = "Card Attributes";
            // 
            // guiGetAttribute
            // 
            this.guiGetAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiGetAttribute.Location = new System.Drawing.Point(624, 37);
            this.guiGetAttribute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGetAttribute.Name = "guiGetAttribute";
            this.guiGetAttribute.Size = new System.Drawing.Size(180, 44);
            this.guiGetAttribute.TabIndex = 1;
            this.guiGetAttribute.Text = "Get attribute";
            this.guiGetAttribute.UseVisualStyleBackColor = true;
            this.guiGetAttribute.Click += new System.EventHandler(this.guiGetAttribute_Click);
            // 
            // labelStringAttribute
            // 
            this.labelStringAttribute.AutoSize = true;
            this.labelStringAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStringAttribute.Location = new System.Drawing.Point(618, 87);
            this.labelStringAttribute.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStringAttribute.Name = "labelStringAttribute";
            this.labelStringAttribute.Size = new System.Drawing.Size(200, 25);
            this.labelStringAttribute.TabIndex = 4;
            this.labelStringAttribute.Text = "String interpretation";
            // 
            // labelRawAttribute
            // 
            this.labelRawAttribute.AutoSize = true;
            this.labelRawAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawAttribute.Location = new System.Drawing.Point(12, 88);
            this.labelRawAttribute.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRawAttribute.Name = "labelRawAttribute";
            this.labelRawAttribute.Size = new System.Drawing.Size(140, 25);
            this.labelRawAttribute.TabIndex = 2;
            this.labelRawAttribute.Text = "Raw Attribute";
            // 
            // guiStringAttribute
            // 
            this.guiStringAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiStringAttribute.Location = new System.Drawing.Point(624, 119);
            this.guiStringAttribute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiStringAttribute.Multiline = true;
            this.guiStringAttribute.Name = "guiStringAttribute";
            this.guiStringAttribute.ReadOnly = true;
            this.guiStringAttribute.Size = new System.Drawing.Size(596, 112);
            this.guiStringAttribute.TabIndex = 5;
            this.guiStringAttribute.TabStop = false;
            // 
            // guiRawAttribute
            // 
            this.guiRawAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiRawAttribute.Location = new System.Drawing.Point(12, 119);
            this.guiRawAttribute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiRawAttribute.Multiline = true;
            this.guiRawAttribute.Name = "guiRawAttribute";
            this.guiRawAttribute.ReadOnly = true;
            this.guiRawAttribute.Size = new System.Drawing.Size(596, 112);
            this.guiRawAttribute.TabIndex = 3;
            this.guiRawAttribute.TabStop = false;
            // 
            // guiAttribute
            // 
            this.guiAttribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiAttribute.FormattingEnabled = true;
            this.guiAttribute.Location = new System.Drawing.Point(12, 42);
            this.guiAttribute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiAttribute.Name = "guiAttribute";
            this.guiAttribute.Size = new System.Drawing.Size(596, 33);
            this.guiAttribute.TabIndex = 0;
            // 
            // guiStatus
            // 
            this.guiStatus.Dock = System.Windows.Forms.DockStyle.None;
            this.guiStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiStatus.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.guiStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiLastError});
            this.guiStatus.Location = new System.Drawing.Point(0, 0);
            this.guiStatus.Name = "guiStatus";
            this.guiStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.guiStatus.Size = new System.Drawing.Size(1574, 30);
            this.guiStatus.TabIndex = 0;
            // 
            // guiLastError
            // 
            this.guiLastError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLastError.Name = "guiLastError";
            this.guiLastError.Size = new System.Drawing.Size(144, 25);
            this.guiLastError.Text = "Last Error: {0}";
            // 
            // guiGroupBoxLoadedPlugins
            // 
            this.guiGroupBoxLoadedPlugins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guiGroupBoxLoadedPlugins.Controls.Add(this.guiLoadedPlugins);
            this.guiGroupBoxLoadedPlugins.Dock = System.Windows.Forms.DockStyle.Left;
            this.guiGroupBoxLoadedPlugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiGroupBoxLoadedPlugins.Location = new System.Drawing.Point(6, 6);
            this.guiGroupBoxLoadedPlugins.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupBoxLoadedPlugins.Name = "guiGroupBoxLoadedPlugins";
            this.guiGroupBoxLoadedPlugins.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiGroupBoxLoadedPlugins.Size = new System.Drawing.Size(400, 951);
            this.guiGroupBoxLoadedPlugins.TabIndex = 0;
            this.guiGroupBoxLoadedPlugins.TabStop = false;
            this.guiGroupBoxLoadedPlugins.Text = "Loaded plugins";
            // 
            // guiLoadedPlugins
            // 
            this.guiLoadedPlugins.Dock = System.Windows.Forms.DockStyle.Left;
            this.guiLoadedPlugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLoadedPlugins.FormattingEnabled = true;
            this.guiLoadedPlugins.ItemHeight = 25;
            this.guiLoadedPlugins.Location = new System.Drawing.Point(6, 30);
            this.guiLoadedPlugins.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiLoadedPlugins.Name = "guiLoadedPlugins";
            this.guiLoadedPlugins.Size = new System.Drawing.Size(372, 915);
            this.guiLoadedPlugins.TabIndex = 0;
            this.guiLoadedPlugins.SelectedIndexChanged += new System.EventHandler(this.guiLoadedPlugins_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Class Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Path to DLL";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.guiPluginDescription);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.guiPluginClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.guiPluginName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(418, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(868, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plugin Description";
            // 
            // guiPluginPathToDll
            // 
            this.guiPluginPathToDll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiPluginPathToDll.Location = new System.Drawing.Point(12, 129);
            this.guiPluginPathToDll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiPluginPathToDll.Name = "guiPluginPathToDll";
            this.guiPluginPathToDll.ReadOnly = true;
            this.guiPluginPathToDll.Size = new System.Drawing.Size(844, 31);
            this.guiPluginPathToDll.TabIndex = 7;
            // 
            // guiPluginClassName
            // 
            this.guiPluginClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiPluginClassName.Location = new System.Drawing.Point(12, 129);
            this.guiPluginClassName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiPluginClassName.Name = "guiPluginClassName";
            this.guiPluginClassName.ReadOnly = true;
            this.guiPluginClassName.Size = new System.Drawing.Size(844, 31);
            this.guiPluginClassName.TabIndex = 3;
            // 
            // guiPluginName
            // 
            this.guiPluginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiPluginName.Location = new System.Drawing.Point(12, 61);
            this.guiPluginName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiPluginName.Name = "guiPluginName";
            this.guiPluginName.ReadOnly = true;
            this.guiPluginName.Size = new System.Drawing.Size(844, 31);
            this.guiPluginName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.guiPluginPathToDll);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.guiPluginAssemblyName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.guiPluginAssemblyVersion);
            this.groupBox2.Controls.Add(this.guiPluginAssemblyDescription);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(418, 324);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(868, 374);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plugin Assembly Informations";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 234);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 25);
            this.label15.TabIndex = 4;
            this.label15.Text = "Description";
            // 
            // guiPluginAssemblyName
            // 
            this.guiPluginAssemblyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiPluginAssemblyName.Location = new System.Drawing.Point(12, 61);
            this.guiPluginAssemblyName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiPluginAssemblyName.Name = "guiPluginAssemblyName";
            this.guiPluginAssemblyName.ReadOnly = true;
            this.guiPluginAssemblyName.Size = new System.Drawing.Size(844, 31);
            this.guiPluginAssemblyName.TabIndex = 3;
            // 
            // guiPluginAssemblyVersion
            // 
            this.guiPluginAssemblyVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiPluginAssemblyVersion.Location = new System.Drawing.Point(12, 197);
            this.guiPluginAssemblyVersion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiPluginAssemblyVersion.Name = "guiPluginAssemblyVersion";
            this.guiPluginAssemblyVersion.ReadOnly = true;
            this.guiPluginAssemblyVersion.Size = new System.Drawing.Size(844, 31);
            this.guiPluginAssemblyVersion.TabIndex = 1;
            // 
            // guiPluginAssemblyDescription
            // 
            this.guiPluginAssemblyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiPluginAssemblyDescription.Location = new System.Drawing.Point(12, 265);
            this.guiPluginAssemblyDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiPluginAssemblyDescription.Multiline = true;
            this.guiPluginAssemblyDescription.Name = "guiPluginAssemblyDescription";
            this.guiPluginAssemblyDescription.ReadOnly = true;
            this.guiPluginAssemblyDescription.Size = new System.Drawing.Size(844, 73);
            this.guiPluginAssemblyDescription.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.guiLayerAssemblyDescription);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.guiLayerAssemblyName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.guiLayerAssemblyVersion);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(424, 385);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(868, 321);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Layer Assembly Informations";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 181);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Description";
            // 
            // guiLayerAssemblyDescription
            // 
            this.guiLayerAssemblyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLayerAssemblyDescription.Location = new System.Drawing.Point(12, 212);
            this.guiLayerAssemblyDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiLayerAssemblyDescription.Multiline = true;
            this.guiLayerAssemblyDescription.Name = "guiLayerAssemblyDescription";
            this.guiLayerAssemblyDescription.ReadOnly = true;
            this.guiLayerAssemblyDescription.Size = new System.Drawing.Size(844, 73);
            this.guiLayerAssemblyDescription.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // guiLayerAssemblyName
            // 
            this.guiLayerAssemblyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLayerAssemblyName.Location = new System.Drawing.Point(12, 137);
            this.guiLayerAssemblyName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiLayerAssemblyName.Name = "guiLayerAssemblyName";
            this.guiLayerAssemblyName.ReadOnly = true;
            this.guiLayerAssemblyName.Size = new System.Drawing.Size(844, 31);
            this.guiLayerAssemblyName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Version";
            // 
            // guiLayerAssemblyVersion
            // 
            this.guiLayerAssemblyVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLayerAssemblyVersion.Location = new System.Drawing.Point(12, 62);
            this.guiLayerAssemblyVersion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiLayerAssemblyVersion.Name = "guiLayerAssemblyVersion";
            this.guiLayerAssemblyVersion.ReadOnly = true;
            this.guiLayerAssemblyVersion.Size = new System.Drawing.Size(844, 31);
            this.guiLayerAssemblyVersion.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.guiLayerPathToDll);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.guiLayerClassName);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.guiLayerDLL);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.guiLayerName);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(424, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(868, 354);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Layer Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 256);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Path to DLL";
            // 
            // guiLayerPathToDll
            // 
            this.guiLayerPathToDll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLayerPathToDll.Location = new System.Drawing.Point(12, 287);
            this.guiLayerPathToDll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiLayerPathToDll.Name = "guiLayerPathToDll";
            this.guiLayerPathToDll.ReadOnly = true;
            this.guiLayerPathToDll.Size = new System.Drawing.Size(844, 31);
            this.guiLayerPathToDll.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Class Name";
            // 
            // guiLayerClassName
            // 
            this.guiLayerClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLayerClassName.Location = new System.Drawing.Point(12, 137);
            this.guiLayerClassName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiLayerClassName.Name = "guiLayerClassName";
            this.guiLayerClassName.ReadOnly = true;
            this.guiLayerClassName.Size = new System.Drawing.Size(844, 31);
            this.guiLayerClassName.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 181);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "DLL";
            // 
            // guiLayerDLL
            // 
            this.guiLayerDLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLayerDLL.Location = new System.Drawing.Point(12, 212);
            this.guiLayerDLL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiLayerDLL.Name = "guiLayerDLL";
            this.guiLayerDLL.ReadOnly = true;
            this.guiLayerDLL.Size = new System.Drawing.Size(844, 31);
            this.guiLayerDLL.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Name";
            // 
            // guiLayerName
            // 
            this.guiLayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLayerName.Location = new System.Drawing.Point(12, 62);
            this.guiLayerName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiLayerName.Name = "guiLayerName";
            this.guiLayerName.ReadOnly = true;
            this.guiLayerName.Size = new System.Drawing.Size(844, 31);
            this.guiLayerName.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.guiLoadedContextLayers);
            this.groupBox5.Controls.Add(this.guiLoadedChannelLayers);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Size = new System.Drawing.Size(400, 1420);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Loaded layers";
            // 
            // guiLoadedContextLayers
            // 
            this.guiLoadedContextLayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLoadedContextLayers.FormattingEnabled = true;
            this.guiLoadedContextLayers.ItemHeight = 25;
            this.guiLoadedContextLayers.Location = new System.Drawing.Point(6, 456);
            this.guiLoadedContextLayers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiLoadedContextLayers.Name = "guiLoadedContextLayers";
            this.guiLoadedContextLayers.Size = new System.Drawing.Size(378, 404);
            this.guiLoadedContextLayers.TabIndex = 1;
            this.guiLoadedContextLayers.SelectedIndexChanged += new System.EventHandler(this.guiLoadedContextLayers_SelectedIndexChanged);
            // 
            // guiLoadedChannelLayers
            // 
            this.guiLoadedChannelLayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLoadedChannelLayers.FormattingEnabled = true;
            this.guiLoadedChannelLayers.ItemHeight = 25;
            this.guiLoadedChannelLayers.Location = new System.Drawing.Point(6, 37);
            this.guiLoadedChannelLayers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiLoadedChannelLayers.Name = "guiLoadedChannelLayers";
            this.guiLoadedChannelLayers.Size = new System.Drawing.Size(378, 404);
            this.guiLoadedChannelLayers.TabIndex = 0;
            this.guiLoadedChannelLayers.SelectedIndexChanged += new System.EventHandler(this.guiLoadedChannelLayers_SelectedIndexChanged);
            // 
            // guiTabs
            // 
            this.guiTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiTabs.Controls.Add(this.guiTabConnection);
            this.guiTabs.Controls.Add(this.guiTabLogs);
            this.guiTabs.Controls.Add(this.guiTabPlugins);
            this.guiTabs.Controls.Add(this.tabPage1);
            this.guiTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiTabs.HotTrack = true;
            this.guiTabs.Location = new System.Drawing.Point(240, 6);
            this.guiTabs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiTabs.Multiline = true;
            this.guiTabs.Name = "guiTabs";
            this.guiTabs.SelectedIndex = 0;
            this.guiTabs.Size = new System.Drawing.Size(1344, 1010);
            this.guiTabs.TabIndex = 1;
            // 
            // guiTabLogs
            // 
            this.guiTabLogs.Controls.Add(this.guiLogsView);
            this.guiTabLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiTabLogs.Location = new System.Drawing.Point(8, 39);
            this.guiTabLogs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiTabLogs.Name = "guiTabLogs";
            this.guiTabLogs.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiTabLogs.Size = new System.Drawing.Size(1892, 1432);
            this.guiTabLogs.TabIndex = 4;
            this.guiTabLogs.Text = "Logs";
            this.guiTabLogs.UseVisualStyleBackColor = true;
            // 
            // guiLogsView
            // 
            this.guiLogsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiLogsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiLogsView.Location = new System.Drawing.Point(12, 12);
            this.guiLogsView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiLogsView.Name = "guiLogsView";
            this.guiLogsView.Size = new System.Drawing.Size(1278, 908);
            this.guiLogsView.TabIndex = 0;
            this.guiLogsView.Text = "";
            this.guiLogsView.WordWrap = false;
            // 
            // guiTabPlugins
            // 
            this.guiTabPlugins.Controls.Add(this.groupBox2);
            this.guiTabPlugins.Controls.Add(this.groupBox1);
            this.guiTabPlugins.Controls.Add(this.guiGroupBoxLoadedPlugins);
            this.guiTabPlugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiTabPlugins.Location = new System.Drawing.Point(8, 39);
            this.guiTabPlugins.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiTabPlugins.Name = "guiTabPlugins";
            this.guiTabPlugins.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiTabPlugins.Size = new System.Drawing.Size(1328, 963);
            this.guiTabPlugins.TabIndex = 5;
            this.guiTabPlugins.Text = "Plugins";
            this.guiTabPlugins.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1892, 1432);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Layers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.guiStatus);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.guiTabs);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.guiGroupCard);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.guiGroupContext);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1574, 1066);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1574, 1129);
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
            this.guiMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.guiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiFileMenuItem,
            this.guiPluginsMenuItem,
            this.guiHelpMenuItem});
            this.guiMenu.Location = new System.Drawing.Point(0, 0);
            this.guiMenu.Name = "guiMenu";
            this.guiMenu.Size = new System.Drawing.Size(1574, 33);
            this.guiMenu.TabIndex = 0;
            this.guiMenu.Text = "menuStrip1";
            // 
            // guiFileMenuItem
            // 
            this.guiFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiQuit});
            this.guiFileMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiFileMenuItem.Name = "guiFileMenuItem";
            this.guiFileMenuItem.Size = new System.Drawing.Size(59, 29);
            this.guiFileMenuItem.Text = "&File";
            // 
            // guiQuit
            // 
            this.guiQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiQuit.Name = "guiQuit";
            this.guiQuit.Size = new System.Drawing.Size(147, 38);
            this.guiQuit.Text = "&Quit";
            this.guiQuit.Click += new System.EventHandler(this.guiQuit_Click);
            // 
            // guiPluginsMenuItem
            // 
            this.guiPluginsMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiPluginsMenuItem.Name = "guiPluginsMenuItem";
            this.guiPluginsMenuItem.Size = new System.Drawing.Size(95, 29);
            this.guiPluginsMenuItem.Text = "Plugins";
            // 
            // guiHelpMenuItem
            // 
            this.guiHelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiAboutWinSCardGUI});
            this.guiHelpMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiHelpMenuItem.Name = "guiHelpMenuItem";
            this.guiHelpMenuItem.Size = new System.Drawing.Size(68, 29);
            this.guiHelpMenuItem.Text = "&Help";
            // 
            // guiAboutWinSCardGUI
            // 
            this.guiAboutWinSCardGUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiAboutWinSCardGUI.Name = "guiAboutWinSCardGUI";
            this.guiAboutWinSCardGUI.Size = new System.Drawing.Size(324, 38);
            this.guiAboutWinSCardGUI.Text = "&About WinSCard GUI";
            this.guiAboutWinSCardGUI.Click += new System.EventHandler(this.guiAboutWinSCardGUI_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Found: 0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 166);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 25);
            this.label16.TabIndex = 5;
            this.label16.Text = "Description";
            // 
            // guiPluginDescription
            // 
            this.guiPluginDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiPluginDescription.Location = new System.Drawing.Point(12, 197);
            this.guiPluginDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guiPluginDescription.Multiline = true;
            this.guiPluginDescription.Name = "guiPluginDescription";
            this.guiPluginDescription.ReadOnly = true;
            this.guiPluginDescription.Size = new System.Drawing.Size(844, 73);
            this.guiPluginDescription.TabIndex = 6;
            // 
            // WinSCardGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1574, 1129);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.guiMenu;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WinSCardGui";
            this.Text = "WinSCard GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinSCardGUI_FormClosing);
            this.guiGroupCard.ResumeLayout(false);
            this.guiGroupContext.ResumeLayout(false);
            this.guiTabConnection.ResumeLayout(false);
            this.guiTabConnection.PerformLayout();
            this.guiGroupCardInformations.ResumeLayout(false);
            this.guiGroupCardInformations.PerformLayout();
            this.guiGroupCardConnection.ResumeLayout(false);
            this.guiGroupCardConnection.PerformLayout();
            this.guiGroupCardAttributes.ResumeLayout(false);
            this.guiGroupCardAttributes.PerformLayout();
            this.guiStatus.ResumeLayout(false);
            this.guiStatus.PerformLayout();
            this.guiGroupBoxLoadedPlugins.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox guiGroupCard;
        private System.Windows.Forms.GroupBox guiGroupContext;
        private System.Windows.Forms.TabPage guiTabConnection;
        private System.Windows.Forms.Label labelReaderInUser;
        private System.Windows.Forms.Label labelCardChannel;
        private System.Windows.Forms.Label labelContext;
        private System.Windows.Forms.Label labelDisposition;
        private System.Windows.Forms.Label labelShareMode;
        private System.Windows.Forms.Label labelProtocol;
        private System.Windows.Forms.Label labelStringAttribute;
        private System.Windows.Forms.Label labelRawAttribute;
        private System.Windows.Forms.StatusStrip guiStatus;
        private System.Windows.Forms.GroupBox guiGroupBoxLoadedPlugins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox guiPluginAssemblyDescription;
        private System.Windows.Forms.TextBox guiPluginDescription;
        private System.Windows.Forms.Label label16;
    }
}

