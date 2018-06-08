using System.Drawing;

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
            this.guiPluginDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guiPluginName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guiPluginClassName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.guiPluginDescription = new System.Windows.Forms.TextBox();
            this.guiPluginAssemblyInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guiPluginAssemblyName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guiPluginAssemblyPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guiPluginAssemblyVersion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.guiPluginAssemblyDescription = new System.Windows.Forms.TextBox();
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
            this.guiAvailablePlugins = new System.Windows.Forms.ListBox();
            this.guiLayerAssemblyInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.guiLayerAssemblyDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guiLayerAssemblyName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guiLayerAssemblyVersion = new System.Windows.Forms.TextBox();
            this.guiLayerDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guiLayerPathToDll = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guiLayerClassName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.guiLayerDLL = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.guiLayerName = new System.Windows.Forms.TextBox();
            this.guiAvailableLayersGroupBox = new System.Windows.Forms.GroupBox();
            this.guiAvailableContextLayers = new System.Windows.Forms.ListBox();
            this.guiAvailableChannelLayers = new System.Windows.Forms.ListBox();
            this.guiTabs = new System.Windows.Forms.TabControl();
            this.guiTabLogs = new System.Windows.Forms.TabPage();
            this.guiLogsView = new System.Windows.Forms.RichTextBox();
            this.guiTabPlugins = new System.Windows.Forms.TabPage();
            this.guiTabLayers = new System.Windows.Forms.TabPage();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.guiMenu = new System.Windows.Forms.MenuStrip();
            this.guiFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.guiPluginsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiAboutWinSCardGUI = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guiPluginDescriptionGroupBox.SuspendLayout();
            this.guiPluginAssemblyInfoGroupBox.SuspendLayout();
            this.guiGroupCard.SuspendLayout();
            this.guiGroupContext.SuspendLayout();
            this.guiTabConnection.SuspendLayout();
            this.guiGroupCardInformations.SuspendLayout();
            this.guiGroupCardConnection.SuspendLayout();
            this.guiGroupCardAttributes.SuspendLayout();
            this.guiStatus.SuspendLayout();
            this.guiGroupBoxLoadedPlugins.SuspendLayout();
            this.guiLayerAssemblyInfoGroupBox.SuspendLayout();
            this.guiLayerDescriptionGroupBox.SuspendLayout();
            this.guiAvailableLayersGroupBox.SuspendLayout();
            this.guiTabs.SuspendLayout();
            this.guiTabLogs.SuspendLayout();
            this.guiTabPlugins.SuspendLayout();
            this.guiTabLayers.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.guiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // guiPluginDescriptionGroupBox
            // 
            this.guiPluginDescriptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiPluginDescriptionGroupBox.Controls.Add(this.label2);
            this.guiPluginDescriptionGroupBox.Controls.Add(this.guiPluginName);
            this.guiPluginDescriptionGroupBox.Controls.Add(this.label4);
            this.guiPluginDescriptionGroupBox.Controls.Add(this.guiPluginClassName);
            this.guiPluginDescriptionGroupBox.Controls.Add(this.label16);
            this.guiPluginDescriptionGroupBox.Controls.Add(this.guiPluginDescription);
            this.guiPluginDescriptionGroupBox.Location = new System.Drawing.Point(209, 6);
            this.guiPluginDescriptionGroupBox.Name = "guiPluginDescriptionGroupBox";
            this.guiPluginDescriptionGroupBox.Size = new System.Drawing.Size(450, 169);
            this.guiPluginDescriptionGroupBox.TabIndex = 1;
            this.guiPluginDescriptionGroupBox.TabStop = false;
            this.guiPluginDescriptionGroupBox.Text = "Plugin Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // guiPluginName
            // 
            this.guiPluginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiPluginName.Location = new System.Drawing.Point(6, 32);
            this.guiPluginName.Name = "guiPluginName";
            this.guiPluginName.ReadOnly = true;
            this.guiPluginName.Size = new System.Drawing.Size(438, 20);
            this.guiPluginName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Class Name";
            // 
            // guiPluginClassName
            // 
            this.guiPluginClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiPluginClassName.Location = new System.Drawing.Point(6, 71);
            this.guiPluginClassName.Name = "guiPluginClassName";
            this.guiPluginClassName.ReadOnly = true;
            this.guiPluginClassName.Size = new System.Drawing.Size(438, 20);
            this.guiPluginClassName.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Description";
            // 
            // guiPluginDescription
            // 
            this.guiPluginDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiPluginDescription.Location = new System.Drawing.Point(6, 110);
            this.guiPluginDescription.Multiline = true;
            this.guiPluginDescription.Name = "guiPluginDescription";
            this.guiPluginDescription.ReadOnly = true;
            this.guiPluginDescription.Size = new System.Drawing.Size(438, 40);
            this.guiPluginDescription.TabIndex = 6;
            // 
            // guiPluginAssemblyInfoGroupBox
            // 
            this.guiPluginAssemblyInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiPluginAssemblyInfoGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guiPluginAssemblyInfoGroupBox.Controls.Add(this.label7);
            this.guiPluginAssemblyInfoGroupBox.Controls.Add(this.guiPluginAssemblyName);
            this.guiPluginAssemblyInfoGroupBox.Controls.Add(this.label5);
            this.guiPluginAssemblyInfoGroupBox.Controls.Add(this.guiPluginAssemblyPath);
            this.guiPluginAssemblyInfoGroupBox.Controls.Add(this.label6);
            this.guiPluginAssemblyInfoGroupBox.Controls.Add(this.guiPluginAssemblyVersion);
            this.guiPluginAssemblyInfoGroupBox.Controls.Add(this.label15);
            this.guiPluginAssemblyInfoGroupBox.Controls.Add(this.guiPluginAssemblyDescription);
            this.guiPluginAssemblyInfoGroupBox.Location = new System.Drawing.Point(209, 180);
            this.guiPluginAssemblyInfoGroupBox.Name = "guiPluginAssemblyInfoGroupBox";
            this.guiPluginAssemblyInfoGroupBox.Size = new System.Drawing.Size(450, 208);
            this.guiPluginAssemblyInfoGroupBox.TabIndex = 2;
            this.guiPluginAssemblyInfoGroupBox.TabStop = false;
            this.guiPluginAssemblyInfoGroupBox.Text = "Plugin Assembly Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name";
            // 
            // guiPluginAssemblyName
            // 
            this.guiPluginAssemblyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiPluginAssemblyName.Location = new System.Drawing.Point(6, 32);
            this.guiPluginAssemblyName.Name = "guiPluginAssemblyName";
            this.guiPluginAssemblyName.ReadOnly = true;
            this.guiPluginAssemblyName.Size = new System.Drawing.Size(438, 20);
            this.guiPluginAssemblyName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Path";
            // 
            // guiPluginAssemblyPath
            // 
            this.guiPluginAssemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiPluginAssemblyPath.Location = new System.Drawing.Point(6, 71);
            this.guiPluginAssemblyPath.Name = "guiPluginAssemblyPath";
            this.guiPluginAssemblyPath.ReadOnly = true;
            this.guiPluginAssemblyPath.Size = new System.Drawing.Size(438, 20);
            this.guiPluginAssemblyPath.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Version";
            // 
            // guiPluginAssemblyVersion
            // 
            this.guiPluginAssemblyVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiPluginAssemblyVersion.Location = new System.Drawing.Point(6, 110);
            this.guiPluginAssemblyVersion.Name = "guiPluginAssemblyVersion";
            this.guiPluginAssemblyVersion.ReadOnly = true;
            this.guiPluginAssemblyVersion.Size = new System.Drawing.Size(438, 20);
            this.guiPluginAssemblyVersion.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Description";
            // 
            // guiPluginAssemblyDescription
            // 
            this.guiPluginAssemblyDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiPluginAssemblyDescription.Location = new System.Drawing.Point(6, 149);
            this.guiPluginAssemblyDescription.Multiline = true;
            this.guiPluginAssemblyDescription.Name = "guiPluginAssemblyDescription";
            this.guiPluginAssemblyDescription.ReadOnly = true;
            this.guiPluginAssemblyDescription.Size = new System.Drawing.Size(438, 40);
            this.guiPluginAssemblyDescription.TabIndex = 5;
            // 
            // guiGroupCard
            // 
            this.guiGroupCard.AutoSize = true;
            this.guiGroupCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guiGroupCard.Controls.Add(this.guiCardConnect);
            this.guiGroupCard.Controls.Add(this.guiCardWarmReset);
            this.guiGroupCard.Controls.Add(this.guiCardUnpower);
            this.guiGroupCard.Controls.Add(this.guiCardColdReset);
            this.guiGroupCard.Location = new System.Drawing.Point(3, 99);
            this.guiGroupCard.Name = "guiGroupCard";
            this.guiGroupCard.Size = new System.Drawing.Size(102, 148);
            this.guiGroupCard.TabIndex = 1;
            this.guiGroupCard.TabStop = false;
            this.guiGroupCard.Text = "Quick Connect";
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
            this.guiGroupContext.AutoSize = true;
            this.guiGroupContext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guiGroupContext.Controls.Add(this.guiContextRelease);
            this.guiGroupContext.Controls.Add(this.guiContextEstablish);
            this.guiGroupContext.Location = new System.Drawing.Point(3, 3);
            this.guiGroupContext.Name = "guiGroupContext";
            this.guiGroupContext.Size = new System.Drawing.Size(102, 90);
            this.guiGroupContext.TabIndex = 0;
            this.guiGroupContext.TabStop = false;
            this.guiGroupContext.Text = "Context";
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
            this.guiTabConnection.Controls.Add(this.guiGroupCardInformations);
            this.guiTabConnection.Controls.Add(this.guiGroupCardConnection);
            this.guiTabConnection.Controls.Add(this.guiGroupCardAttributes);
            this.guiTabConnection.Location = new System.Drawing.Point(4, 22);
            this.guiTabConnection.Name = "guiTabConnection";
            this.guiTabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.guiTabConnection.Size = new System.Drawing.Size(665, 509);
            this.guiTabConnection.TabIndex = 0;
            this.guiTabConnection.Text = "Card Tools";
            this.guiTabConnection.UseVisualStyleBackColor = true;
            // 
            // guiGroupCardInformations
            // 
            this.guiGroupCardInformations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiGroupCardInformations.Controls.Add(this.guiReaderInUse);
            this.guiGroupCardInformations.Controls.Add(this.labelReaderInUser);
            this.guiGroupCardInformations.Controls.Add(this.guiChannelState);
            this.guiGroupCardInformations.Controls.Add(this.labelCardChannel);
            this.guiGroupCardInformations.Controls.Add(this.guiContextState);
            this.guiGroupCardInformations.Controls.Add(this.labelContext);
            this.guiGroupCardInformations.Location = new System.Drawing.Point(6, 300);
            this.guiGroupCardInformations.Name = "guiGroupCardInformations";
            this.guiGroupCardInformations.Size = new System.Drawing.Size(653, 81);
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
            this.labelReaderInUser.AutoSize = true;
            this.labelReaderInUser.Location = new System.Drawing.Point(198, 45);
            this.labelReaderInUser.Name = "labelReaderInUser";
            this.labelReaderInUser.Size = new System.Drawing.Size(76, 13);
            this.labelReaderInUser.TabIndex = 4;
            this.labelReaderInUser.Text = "Reader in use:";
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
            this.labelCardChannel.AutoSize = true;
            this.labelCardChannel.Location = new System.Drawing.Point(6, 45);
            this.labelCardChannel.Name = "labelCardChannel";
            this.labelCardChannel.Size = new System.Drawing.Size(73, 13);
            this.labelCardChannel.TabIndex = 2;
            this.labelCardChannel.Text = "Card channel:";
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
            this.labelContext.AutoSize = true;
            this.labelContext.Location = new System.Drawing.Point(6, 19);
            this.labelContext.Name = "labelContext";
            this.labelContext.Size = new System.Drawing.Size(46, 13);
            this.labelContext.TabIndex = 0;
            this.labelContext.Text = "Context:";
            // 
            // guiGroupCardConnection
            // 
            this.guiGroupCardConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.guiGroupCardConnection.Location = new System.Drawing.Point(6, 6);
            this.guiGroupCardConnection.Name = "guiGroupCardConnection";
            this.guiGroupCardConnection.Size = new System.Drawing.Size(653, 141);
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
            this.labelDisposition.AutoSize = true;
            this.labelDisposition.Location = new System.Drawing.Point(415, 56);
            this.labelDisposition.Name = "labelDisposition";
            this.labelDisposition.Size = new System.Drawing.Size(58, 13);
            this.labelDisposition.TabIndex = 8;
            this.labelDisposition.Text = "Disposition";
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
            this.labelShareMode.AutoSize = true;
            this.labelShareMode.Location = new System.Drawing.Point(6, 56);
            this.labelShareMode.Name = "labelShareMode";
            this.labelShareMode.Size = new System.Drawing.Size(64, 13);
            this.labelShareMode.TabIndex = 4;
            this.labelShareMode.Text = "Share mode";
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
            this.labelProtocol.AutoSize = true;
            this.labelProtocol.Location = new System.Drawing.Point(209, 56);
            this.labelProtocol.Name = "labelProtocol";
            this.labelProtocol.Size = new System.Drawing.Size(46, 13);
            this.labelProtocol.TabIndex = 6;
            this.labelProtocol.Text = "Protocol";
            // 
            // guiGroupCardAttributes
            // 
            this.guiGroupCardAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiGroupCardAttributes.Controls.Add(this.guiGetAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.labelStringAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.labelRawAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.guiStringAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.guiRawAttribute);
            this.guiGroupCardAttributes.Controls.Add(this.guiAttribute);
            this.guiGroupCardAttributes.Enabled = false;
            this.guiGroupCardAttributes.Location = new System.Drawing.Point(6, 153);
            this.guiGroupCardAttributes.Name = "guiGroupCardAttributes";
            this.guiGroupCardAttributes.Size = new System.Drawing.Size(653, 141);
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
            this.labelStringAttribute.AutoSize = true;
            this.labelStringAttribute.Location = new System.Drawing.Point(309, 45);
            this.labelStringAttribute.Name = "labelStringAttribute";
            this.labelStringAttribute.Size = new System.Drawing.Size(98, 13);
            this.labelStringAttribute.TabIndex = 4;
            this.labelStringAttribute.Text = "String interpretation";
            // 
            // labelRawAttribute
            // 
            this.labelRawAttribute.AutoSize = true;
            this.labelRawAttribute.Location = new System.Drawing.Point(6, 46);
            this.labelRawAttribute.Name = "labelRawAttribute";
            this.labelRawAttribute.Size = new System.Drawing.Size(71, 13);
            this.labelRawAttribute.TabIndex = 2;
            this.labelRawAttribute.Text = "Raw Attribute";
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
            this.guiStatus.Dock = System.Windows.Forms.DockStyle.None;
            this.guiStatus.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.guiStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiLastError});
            this.guiStatus.Location = new System.Drawing.Point(0, 0);
            this.guiStatus.Name = "guiStatus";
            this.guiStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.guiStatus.Size = new System.Drawing.Size(787, 22);
            this.guiStatus.TabIndex = 0;
            // 
            // guiLastError
            // 
            this.guiLastError.Name = "guiLastError";
            this.guiLastError.Size = new System.Drawing.Size(53, 17);
            this.guiLastError.Text = "LastError";
            // 
            // guiGroupBoxLoadedPlugins
            // 
            this.guiGroupBoxLoadedPlugins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guiGroupBoxLoadedPlugins.Controls.Add(this.guiAvailablePlugins);
            this.guiGroupBoxLoadedPlugins.Dock = System.Windows.Forms.DockStyle.Left;
            this.guiGroupBoxLoadedPlugins.Location = new System.Drawing.Point(3, 3);
            this.guiGroupBoxLoadedPlugins.Name = "guiGroupBoxLoadedPlugins";
            this.guiGroupBoxLoadedPlugins.Size = new System.Drawing.Size(200, 503);
            this.guiGroupBoxLoadedPlugins.TabIndex = 0;
            this.guiGroupBoxLoadedPlugins.TabStop = false;
            this.guiGroupBoxLoadedPlugins.Text = "Available Plugins";
            // 
            // guiAvailablePlugins
            // 
            this.guiAvailablePlugins.FormattingEnabled = true;
            this.guiAvailablePlugins.Location = new System.Drawing.Point(6, 19);
            this.guiAvailablePlugins.Name = "guiAvailablePlugins";
            this.guiAvailablePlugins.Size = new System.Drawing.Size(188, 472);
            this.guiAvailablePlugins.TabIndex = 0;
            this.guiAvailablePlugins.SelectedIndexChanged += new System.EventHandler(this.guiLoadedPlugins_SelectedIndexChanged);
            // 
            // guiLayerAssemblyInfoGroupBox
            // 
            this.guiLayerAssemblyInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiLayerAssemblyInfoGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guiLayerAssemblyInfoGroupBox.Controls.Add(this.label14);
            this.guiLayerAssemblyInfoGroupBox.Controls.Add(this.guiLayerAssemblyDescription);
            this.guiLayerAssemblyInfoGroupBox.Controls.Add(this.label8);
            this.guiLayerAssemblyInfoGroupBox.Controls.Add(this.guiLayerAssemblyName);
            this.guiLayerAssemblyInfoGroupBox.Controls.Add(this.label9);
            this.guiLayerAssemblyInfoGroupBox.Controls.Add(this.guiLayerAssemblyVersion);
            this.guiLayerAssemblyInfoGroupBox.Location = new System.Drawing.Point(209, 200);
            this.guiLayerAssemblyInfoGroupBox.Name = "guiLayerAssemblyInfoGroupBox";
            this.guiLayerAssemblyInfoGroupBox.Size = new System.Drawing.Size(450, 169);
            this.guiLayerAssemblyInfoGroupBox.TabIndex = 2;
            this.guiLayerAssemblyInfoGroupBox.TabStop = false;
            this.guiLayerAssemblyInfoGroupBox.Text = "Layer Assembly Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Description";
            // 
            // guiLayerAssemblyDescription
            // 
            this.guiLayerAssemblyDescription.Location = new System.Drawing.Point(6, 110);
            this.guiLayerAssemblyDescription.Multiline = true;
            this.guiLayerAssemblyDescription.Name = "guiLayerAssemblyDescription";
            this.guiLayerAssemblyDescription.ReadOnly = true;
            this.guiLayerAssemblyDescription.Size = new System.Drawing.Size(438, 40);
            this.guiLayerAssemblyDescription.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // guiLayerAssemblyName
            // 
            this.guiLayerAssemblyName.Location = new System.Drawing.Point(6, 71);
            this.guiLayerAssemblyName.Name = "guiLayerAssemblyName";
            this.guiLayerAssemblyName.ReadOnly = true;
            this.guiLayerAssemblyName.Size = new System.Drawing.Size(438, 20);
            this.guiLayerAssemblyName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Version";
            // 
            // guiLayerAssemblyVersion
            // 
            this.guiLayerAssemblyVersion.Location = new System.Drawing.Point(6, 32);
            this.guiLayerAssemblyVersion.Name = "guiLayerAssemblyVersion";
            this.guiLayerAssemblyVersion.ReadOnly = true;
            this.guiLayerAssemblyVersion.Size = new System.Drawing.Size(438, 20);
            this.guiLayerAssemblyVersion.TabIndex = 1;
            // 
            // guiLayerDescriptionGroupBox
            // 
            this.guiLayerDescriptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiLayerDescriptionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guiLayerDescriptionGroupBox.Controls.Add(this.label10);
            this.guiLayerDescriptionGroupBox.Controls.Add(this.guiLayerPathToDll);
            this.guiLayerDescriptionGroupBox.Controls.Add(this.label11);
            this.guiLayerDescriptionGroupBox.Controls.Add(this.guiLayerClassName);
            this.guiLayerDescriptionGroupBox.Controls.Add(this.label12);
            this.guiLayerDescriptionGroupBox.Controls.Add(this.guiLayerDLL);
            this.guiLayerDescriptionGroupBox.Controls.Add(this.label13);
            this.guiLayerDescriptionGroupBox.Controls.Add(this.guiLayerName);
            this.guiLayerDescriptionGroupBox.Location = new System.Drawing.Point(209, 6);
            this.guiLayerDescriptionGroupBox.Name = "guiLayerDescriptionGroupBox";
            this.guiLayerDescriptionGroupBox.Size = new System.Drawing.Size(450, 188);
            this.guiLayerDescriptionGroupBox.TabIndex = 1;
            this.guiLayerDescriptionGroupBox.TabStop = false;
            this.guiLayerDescriptionGroupBox.Text = "Layer Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Path to DLL";
            // 
            // guiLayerPathToDll
            // 
            this.guiLayerPathToDll.Location = new System.Drawing.Point(6, 149);
            this.guiLayerPathToDll.Name = "guiLayerPathToDll";
            this.guiLayerPathToDll.ReadOnly = true;
            this.guiLayerPathToDll.Size = new System.Drawing.Size(438, 20);
            this.guiLayerPathToDll.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Class Name";
            // 
            // guiLayerClassName
            // 
            this.guiLayerClassName.Location = new System.Drawing.Point(6, 71);
            this.guiLayerClassName.Name = "guiLayerClassName";
            this.guiLayerClassName.ReadOnly = true;
            this.guiLayerClassName.Size = new System.Drawing.Size(438, 20);
            this.guiLayerClassName.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "DLL";
            // 
            // guiLayerDLL
            // 
            this.guiLayerDLL.Location = new System.Drawing.Point(6, 110);
            this.guiLayerDLL.Name = "guiLayerDLL";
            this.guiLayerDLL.ReadOnly = true;
            this.guiLayerDLL.Size = new System.Drawing.Size(438, 20);
            this.guiLayerDLL.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Name";
            // 
            // guiLayerName
            // 
            this.guiLayerName.Location = new System.Drawing.Point(6, 32);
            this.guiLayerName.Name = "guiLayerName";
            this.guiLayerName.ReadOnly = true;
            this.guiLayerName.Size = new System.Drawing.Size(438, 20);
            this.guiLayerName.TabIndex = 1;
            // 
            // guiAvailableLayersGroupBox
            // 
            this.guiAvailableLayersGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guiAvailableLayersGroupBox.Controls.Add(this.guiAvailableContextLayers);
            this.guiAvailableLayersGroupBox.Controls.Add(this.guiAvailableChannelLayers);
            this.guiAvailableLayersGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.guiAvailableLayersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.guiAvailableLayersGroupBox.Name = "guiAvailableLayersGroupBox";
            this.guiAvailableLayersGroupBox.Size = new System.Drawing.Size(200, 503);
            this.guiAvailableLayersGroupBox.TabIndex = 0;
            this.guiAvailableLayersGroupBox.TabStop = false;
            this.guiAvailableLayersGroupBox.Text = "Available Layers";
            // 
            // guiAvailableContextLayers
            // 
            this.guiAvailableContextLayers.FormattingEnabled = true;
            this.guiAvailableContextLayers.Location = new System.Drawing.Point(6, 237);
            this.guiAvailableContextLayers.Name = "guiAvailableContextLayers";
            this.guiAvailableContextLayers.Size = new System.Drawing.Size(188, 212);
            this.guiAvailableContextLayers.TabIndex = 1;
            this.guiAvailableContextLayers.SelectedIndexChanged += new System.EventHandler(this.guiLoadedContextLayers_SelectedIndexChanged);
            // 
            // guiAvailableChannelLayers
            // 
            this.guiAvailableChannelLayers.FormattingEnabled = true;
            this.guiAvailableChannelLayers.Location = new System.Drawing.Point(6, 19);
            this.guiAvailableChannelLayers.Name = "guiAvailableChannelLayers";
            this.guiAvailableChannelLayers.Size = new System.Drawing.Size(188, 212);
            this.guiAvailableChannelLayers.TabIndex = 0;
            this.guiAvailableChannelLayers.SelectedIndexChanged += new System.EventHandler(this.guiLoadedChannelLayers_SelectedIndexChanged);
            // 
            // guiTabs
            // 
            this.guiTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiTabs.Controls.Add(this.guiTabConnection);
            this.guiTabs.Controls.Add(this.guiTabLogs);
            this.guiTabs.Controls.Add(this.guiTabPlugins);
            this.guiTabs.Controls.Add(this.guiTabLayers);
            this.guiTabs.HotTrack = true;
            this.guiTabs.Location = new System.Drawing.Point(111, 3);
            this.guiTabs.Multiline = true;
            this.guiTabs.Name = "guiTabs";
            this.guiTabs.SelectedIndex = 0;
            this.guiTabs.Size = new System.Drawing.Size(673, 535);
            this.guiTabs.TabIndex = 1;
            // 
            // guiTabLogs
            // 
            this.guiTabLogs.Controls.Add(this.guiLogsView);
            this.guiTabLogs.Location = new System.Drawing.Point(4, 22);
            this.guiTabLogs.Name = "guiTabLogs";
            this.guiTabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.guiTabLogs.Size = new System.Drawing.Size(665, 509);
            this.guiTabLogs.TabIndex = 4;
            this.guiTabLogs.Text = "Logs";
            this.guiTabLogs.UseVisualStyleBackColor = true;
            // 
            // guiLogsView
            // 
            this.guiLogsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiLogsView.Location = new System.Drawing.Point(6, 6);
            this.guiLogsView.Name = "guiLogsView";
            this.guiLogsView.Size = new System.Drawing.Size(653, 502);
            this.guiLogsView.TabIndex = 0;
            this.guiLogsView.Text = "";
            this.guiLogsView.WordWrap = false;
            // 
            // guiTabPlugins
            // 
            this.guiTabPlugins.Controls.Add(this.guiGroupBoxLoadedPlugins);
            this.guiTabPlugins.Controls.Add(this.guiPluginDescriptionGroupBox);
            this.guiTabPlugins.Controls.Add(this.guiPluginAssemblyInfoGroupBox);
            this.guiTabPlugins.Location = new System.Drawing.Point(4, 22);
            this.guiTabPlugins.Name = "guiTabPlugins";
            this.guiTabPlugins.Padding = new System.Windows.Forms.Padding(3);
            this.guiTabPlugins.Size = new System.Drawing.Size(665, 509);
            this.guiTabPlugins.TabIndex = 5;
            this.guiTabPlugins.Text = "Plugins";
            this.guiTabPlugins.UseVisualStyleBackColor = true;
            // 
            // guiTabLayers
            // 
            this.guiTabLayers.Controls.Add(this.guiLayerAssemblyInfoGroupBox);
            this.guiTabLayers.Controls.Add(this.guiLayerDescriptionGroupBox);
            this.guiTabLayers.Controls.Add(this.guiAvailableLayersGroupBox);
            this.guiTabLayers.Location = new System.Drawing.Point(4, 22);
            this.guiTabLayers.Name = "guiTabLayers";
            this.guiTabLayers.Padding = new System.Windows.Forms.Padding(3);
            this.guiTabLayers.Size = new System.Drawing.Size(665, 509);
            this.guiTabLayers.TabIndex = 6;
            this.guiTabLayers.Text = "Layers";
            this.guiTabLayers.UseVisualStyleBackColor = true;
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.guiGroupContext);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.guiGroupCard);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.guiTabs);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(787, 541);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(787, 587);
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
            this.guiMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.guiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiFileMenuItem,
            this.guiPluginsMenuItem,
            this.guiHelpMenuItem});
            this.guiMenu.Location = new System.Drawing.Point(0, 0);
            this.guiMenu.Name = "guiMenu";
            this.guiMenu.Size = new System.Drawing.Size(787, 24);
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
            this.ClientSize = new System.Drawing.Size(787, 587);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.guiMenu;
            this.Name = "WinSCardGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinSCard GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinSCardGUI_FormClosing);
            this.guiPluginDescriptionGroupBox.ResumeLayout(false);
            this.guiPluginDescriptionGroupBox.PerformLayout();
            this.guiPluginAssemblyInfoGroupBox.ResumeLayout(false);
            this.guiPluginAssemblyInfoGroupBox.PerformLayout();
            this.guiGroupCard.ResumeLayout(false);
            this.guiGroupContext.ResumeLayout(false);
            this.guiTabConnection.ResumeLayout(false);
            this.guiGroupCardInformations.ResumeLayout(false);
            this.guiGroupCardInformations.PerformLayout();
            this.guiGroupCardConnection.ResumeLayout(false);
            this.guiGroupCardConnection.PerformLayout();
            this.guiGroupCardAttributes.ResumeLayout(false);
            this.guiGroupCardAttributes.PerformLayout();
            this.guiStatus.ResumeLayout(false);
            this.guiStatus.PerformLayout();
            this.guiGroupBoxLoadedPlugins.ResumeLayout(false);
            this.guiLayerAssemblyInfoGroupBox.ResumeLayout(false);
            this.guiLayerAssemblyInfoGroupBox.PerformLayout();
            this.guiLayerDescriptionGroupBox.ResumeLayout(false);
            this.guiLayerDescriptionGroupBox.PerformLayout();
            this.guiAvailableLayersGroupBox.ResumeLayout(false);
            this.guiTabs.ResumeLayout(false);
            this.guiTabLogs.ResumeLayout(false);
            this.guiTabPlugins.ResumeLayout(false);
            this.guiTabLayers.ResumeLayout(false);
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
		private System.Windows.Forms.ListBox guiAvailablePlugins;
		private System.Windows.Forms.TextBox guiPluginName;
		private System.Windows.Forms.TextBox guiPluginClassName;
		private System.Windows.Forms.TextBox guiPluginAssemblyPath;
		private System.Windows.Forms.TextBox guiPluginAssemblyVersion;
		private System.Windows.Forms.TextBox guiPluginAssemblyName;
		private System.Windows.Forms.TabPage guiTabLayers;
		private System.Windows.Forms.TextBox guiLayerAssemblyName;
		private System.Windows.Forms.TextBox guiLayerAssemblyVersion;
		private System.Windows.Forms.TextBox guiLayerPathToDll;
		private System.Windows.Forms.TextBox guiLayerClassName;
		private System.Windows.Forms.TextBox guiLayerDLL;
		private System.Windows.Forms.TextBox guiLayerName;
		private System.Windows.Forms.ListBox guiAvailableChannelLayers;
		private System.Windows.Forms.ListBox guiAvailableContextLayers;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox guiLayerAssemblyInfoGroupBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox guiLayerDescriptionGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox guiAvailableLayersGroupBox;
        private System.Windows.Forms.TextBox guiPluginAssemblyDescription;
        private System.Windows.Forms.TextBox guiPluginDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox guiPluginDescriptionGroupBox;
        private System.Windows.Forms.GroupBox guiPluginAssemblyInfoGroupBox;
    }
}

