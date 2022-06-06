namespace achievementTranslatorForSteam
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.ofdLoadFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.sfdSaveTranslation = new System.Windows.Forms.SaveFileDialog();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoadedAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.flpTranslate = new System.Windows.Forms.FlowLayoutPanel();
            this.stsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFile.Location = new System.Drawing.Point(500, 12);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "load file";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFile.Location = new System.Drawing.Point(12, 14);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.ReadOnly = true;
            this.txtSourceFile.Size = new System.Drawing.Size(482, 20);
            this.txtSourceFile.TabIndex = 1;
            // 
            // ofdLoadFile
            // 
            this.ofdLoadFile.Filter = ".vdf|*.vdf";
            this.ofdLoadFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdLoadFile_FileOk);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sfdSaveTranslation
            // 
            this.sfdSaveTranslation.Filter = ".vdf|*.vdf";
            this.sfdSaveTranslation.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdSaveTranslation_FileOk);
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersion,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.lblLoadedAmount});
            this.stsMain.Location = new System.Drawing.Point(0, 367);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(587, 22);
            this.stsMain.TabIndex = 4;
            this.stsMain.Text = "statusStrip1";
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(40, 17);
            this.lblVersion.Text = "0.0.0.0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // lblLoadedAmount
            // 
            this.lblLoadedAmount.Name = "lblLoadedAmount";
            this.lblLoadedAmount.Size = new System.Drawing.Size(13, 17);
            this.lblLoadedAmount.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel2.Text = "Loaded:";
            // 
            // flpTranslate
            // 
            this.flpTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTranslate.AutoScroll = true;
            this.flpTranslate.Location = new System.Drawing.Point(12, 40);
            this.flpTranslate.Name = "flpTranslate";
            this.flpTranslate.Size = new System.Drawing.Size(563, 295);
            this.flpTranslate.TabIndex = 2;
            this.flpTranslate.SizeChanged += new System.EventHandler(this.flpTranslate_SizeChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 389);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.flpTranslate);
            this.Controls.Add(this.txtSourceFile);
            this.Controls.Add(this.btnLoadFile);
            this.Name = "frmMain";
            this.Text = "Achievement Translator For Steam";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.OpenFileDialog ofdLoadFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfdSaveTranslation;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblLoadedAmount;
        private System.Windows.Forms.FlowLayoutPanel flpTranslate;
    }
}

