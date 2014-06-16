namespace WSCT.GUI.Plugins.LayerInteractive
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
            System.Windows.Forms.GroupBox groupBox4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.guiDoLoadReplayData = new System.Windows.Forms.Button();
            this.guiDoSaveRecordedData = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.guiUseFakeReader = new System.Windows.Forms.CheckBox();
            this.guiFakeReaderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.guiInteractiveMode = new System.Windows.Forms.ComboBox();
            this.guiSaveFileInteractive = new System.Windows.Forms.SaveFileDialog();
            this.guiOpenFileInteractive = new System.Windows.Forms.OpenFileDialog();
            groupBox4 = new System.Windows.Forms.GroupBox();
            groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.AutoSize = true;
            groupBox4.Controls.Add(this.guiDoLoadReplayData);
            groupBox4.Controls.Add(this.guiDoSaveRecordedData);
            groupBox4.Location = new System.Drawing.Point(12, 164);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(294, 61);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Interactive Records Import / Export";
            // 
            // guiDoLoadReplayData
            // 
            this.guiDoLoadReplayData.Location = new System.Drawing.Point(6, 19);
            this.guiDoLoadReplayData.Name = "guiDoLoadReplayData";
            this.guiDoLoadReplayData.Size = new System.Drawing.Size(125, 23);
            this.guiDoLoadReplayData.TabIndex = 8;
            this.guiDoLoadReplayData.Text = "Load Replay Data";
            this.guiDoLoadReplayData.UseVisualStyleBackColor = true;
            this.guiDoLoadReplayData.Click += new System.EventHandler(this.guiDoLoadReplayData_Click);
            // 
            // guiDoSaveRecordedData
            // 
            this.guiDoSaveRecordedData.Location = new System.Drawing.Point(163, 19);
            this.guiDoSaveRecordedData.Name = "guiDoSaveRecordedData";
            this.guiDoSaveRecordedData.Size = new System.Drawing.Size(125, 23);
            this.guiDoSaveRecordedData.TabIndex = 7;
            this.guiDoSaveRecordedData.Text = "Save Recorded Data";
            this.guiDoSaveRecordedData.UseVisualStyleBackColor = true;
            this.guiDoSaveRecordedData.Click += new System.EventHandler(this.guiDoSaveRecordedData_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 237);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(319, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // guiUseFakeReader
            // 
            this.guiUseFakeReader.AutoSize = true;
            this.guiUseFakeReader.Location = new System.Drawing.Point(6, 19);
            this.guiUseFakeReader.Name = "guiUseFakeReader";
            this.guiUseFakeReader.Size = new System.Drawing.Size(161, 17);
            this.guiUseFakeReader.TabIndex = 4;
            this.guiUseFakeReader.Text = "Use Fake Smartcard Reader";
            this.guiUseFakeReader.UseVisualStyleBackColor = true;
            this.guiUseFakeReader.CheckedChanged += new System.EventHandler(this.guiUseFakeReader_CheckedChanged);
            // 
            // guiFakeReaderName
            // 
            this.guiFakeReaderName.Location = new System.Drawing.Point(88, 42);
            this.guiFakeReaderName.Name = "guiFakeReaderName";
            this.guiFakeReaderName.Size = new System.Drawing.Size(200, 20);
            this.guiFakeReaderName.TabIndex = 5;
            this.guiFakeReaderName.TextChanged += new System.EventHandler(this.guiFakeReaderName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reader Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.guiFakeReaderName);
            this.groupBox1.Controls.Add(this.guiUseFakeReader);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interactive Smartcard Reader";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.guiInteractiveMode);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 59);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interactive Mode";
            // 
            // guiInteractiveMode
            // 
            this.guiInteractiveMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guiInteractiveMode.FormattingEnabled = true;
            this.guiInteractiveMode.Location = new System.Drawing.Point(6, 19);
            this.guiInteractiveMode.Name = "guiInteractiveMode";
            this.guiInteractiveMode.Size = new System.Drawing.Size(282, 21);
            this.guiInteractiveMode.TabIndex = 0;
            this.guiInteractiveMode.SelectedIndexChanged += new System.EventHandler(this.guiInteractiveMode_SelectedIndexChanged);
            // 
            // guiSaveFileInteractive
            // 
            this.guiSaveFileInteractive.DefaultExt = "xml";
            this.guiSaveFileInteractive.Filter = "XML Files|*.xml";
            this.guiSaveFileInteractive.RestoreDirectory = true;
            // 
            // guiOpenFileInteractive
            // 
            this.guiOpenFileInteractive.DefaultExt = "*.xml";
            this.guiOpenFileInteractive.Filter = "XML Files|*.xml";
            this.guiOpenFileInteractive.RestoreDirectory = true;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 259);
            this.Controls.Add(groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gui";
            this.Text = "Layer Interactive Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.CheckBox guiUseFakeReader;
        private System.Windows.Forms.TextBox guiFakeReaderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox guiInteractiveMode;
        private System.Windows.Forms.SaveFileDialog guiSaveFileInteractive;
        private System.Windows.Forms.Button guiDoSaveRecordedData;
        private System.Windows.Forms.OpenFileDialog guiOpenFileInteractive;
        private System.Windows.Forms.Button guiDoLoadReplayData;

    }
}

