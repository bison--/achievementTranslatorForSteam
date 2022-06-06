namespace achievementTranslatorForSteam
{
    partial class uscTranslation
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNameToRight = new System.Windows.Forms.Button();
            this.btnDescriptionToRight = new System.Windows.Forms.Button();
            this.btnDescriptionToLeft = new System.Windows.Forms.Button();
            this.btnNameToLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uscLangLeft = new achievementTranslatorForSteam.uscLanguage();
            this.uscLangRight = new achievementTranslatorForSteam.uscLanguage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNameToRight
            // 
            this.btnNameToRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNameToRight.Location = new System.Drawing.Point(215, 29);
            this.btnNameToRight.Name = "btnNameToRight";
            this.btnNameToRight.Size = new System.Drawing.Size(30, 23);
            this.btnNameToRight.TabIndex = 2;
            this.btnNameToRight.Text = ">";
            this.btnNameToRight.UseVisualStyleBackColor = true;
            this.btnNameToRight.Click += new System.EventHandler(this.btnNameToRight_Click);
            // 
            // btnDescriptionToRight
            // 
            this.btnDescriptionToRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescriptionToRight.Location = new System.Drawing.Point(215, 58);
            this.btnDescriptionToRight.Name = "btnDescriptionToRight";
            this.btnDescriptionToRight.Size = new System.Drawing.Size(30, 23);
            this.btnDescriptionToRight.TabIndex = 3;
            this.btnDescriptionToRight.Text = ">";
            this.btnDescriptionToRight.UseVisualStyleBackColor = true;
            this.btnDescriptionToRight.Click += new System.EventHandler(this.btnDescriptionToRight_Click);
            // 
            // btnDescriptionToLeft
            // 
            this.btnDescriptionToLeft.Location = new System.Drawing.Point(3, 58);
            this.btnDescriptionToLeft.Name = "btnDescriptionToLeft";
            this.btnDescriptionToLeft.Size = new System.Drawing.Size(30, 23);
            this.btnDescriptionToLeft.TabIndex = 5;
            this.btnDescriptionToLeft.Text = "<";
            this.btnDescriptionToLeft.UseVisualStyleBackColor = true;
            this.btnDescriptionToLeft.Click += new System.EventHandler(this.btnDescriptionToLeft_Click);
            // 
            // btnNameToLeft
            // 
            this.btnNameToLeft.Location = new System.Drawing.Point(3, 29);
            this.btnNameToLeft.Name = "btnNameToLeft";
            this.btnNameToLeft.Size = new System.Drawing.Size(30, 23);
            this.btnNameToLeft.TabIndex = 4;
            this.btnNameToLeft.Text = "<";
            this.btnNameToLeft.UseVisualStyleBackColor = true;
            this.btnNameToLeft.Click += new System.EventHandler(this.btnNameToLeft_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Key:";
            // 
            // lblKey
            // 
            this.lblKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(37, 103);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(10, 13);
            this.lblKey.TabIndex = 7;
            this.lblKey.Text = "-";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uscLangLeft);
            this.splitContainer1.Panel1.Controls.Add(this.btnNameToRight);
            this.splitContainer1.Panel1.Controls.Add(this.btnDescriptionToRight);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnNameToLeft);
            this.splitContainer1.Panel2.Controls.Add(this.btnDescriptionToLeft);
            this.splitContainer1.Panel2.Controls.Add(this.uscLangRight);
            this.splitContainer1.Size = new System.Drawing.Size(506, 90);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 8;
            // 
            // uscLangLeft
            // 
            this.uscLangLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscLangLeft.Location = new System.Drawing.Point(3, 3);
            this.uscLangLeft.Name = "uscLangLeft";
            this.uscLangLeft.Size = new System.Drawing.Size(201, 84);
            this.uscLangLeft.TabIndex = 0;
            // 
            // uscLangRight
            // 
            this.uscLangRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscLangRight.Location = new System.Drawing.Point(46, 3);
            this.uscLangRight.Name = "uscLangRight";
            this.uscLangRight.Size = new System.Drawing.Size(201, 84);
            this.uscLangRight.TabIndex = 1;
            // 
            // uscTranslation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(517, 133);
            this.Name = "uscTranslation";
            this.Size = new System.Drawing.Size(515, 131);
            this.Load += new System.EventHandler(this.uscTranslation_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uscLanguage uscLangLeft;
        private uscLanguage uscLangRight;
        private System.Windows.Forms.Button btnNameToRight;
        private System.Windows.Forms.Button btnDescriptionToRight;
        private System.Windows.Forms.Button btnDescriptionToLeft;
        private System.Windows.Forms.Button btnNameToLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
