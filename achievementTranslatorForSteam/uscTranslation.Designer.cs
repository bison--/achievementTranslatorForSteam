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
            this.uscLangRight = new achievementTranslatorForSteam.uscLanguage();
            this.uscLangLeft = new achievementTranslatorForSteam.uscLanguage();
            this.SuspendLayout();
            // 
            // btnNameToRight
            // 
            this.btnNameToRight.Location = new System.Drawing.Point(211, 30);
            this.btnNameToRight.Name = "btnNameToRight";
            this.btnNameToRight.Size = new System.Drawing.Size(30, 23);
            this.btnNameToRight.TabIndex = 2;
            this.btnNameToRight.Text = ">";
            this.btnNameToRight.UseVisualStyleBackColor = true;
            this.btnNameToRight.Click += new System.EventHandler(this.btnNameToRight_Click);
            // 
            // btnDescriptionToRight
            // 
            this.btnDescriptionToRight.Location = new System.Drawing.Point(211, 59);
            this.btnDescriptionToRight.Name = "btnDescriptionToRight";
            this.btnDescriptionToRight.Size = new System.Drawing.Size(30, 23);
            this.btnDescriptionToRight.TabIndex = 3;
            this.btnDescriptionToRight.Text = ">";
            this.btnDescriptionToRight.UseVisualStyleBackColor = true;
            this.btnDescriptionToRight.Click += new System.EventHandler(this.btnDescriptionToRight_Click);
            // 
            // btnDescriptionToLeft
            // 
            this.btnDescriptionToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescriptionToLeft.Location = new System.Drawing.Point(261, 59);
            this.btnDescriptionToLeft.Name = "btnDescriptionToLeft";
            this.btnDescriptionToLeft.Size = new System.Drawing.Size(30, 23);
            this.btnDescriptionToLeft.TabIndex = 5;
            this.btnDescriptionToLeft.Text = "<";
            this.btnDescriptionToLeft.UseVisualStyleBackColor = true;
            this.btnDescriptionToLeft.Click += new System.EventHandler(this.btnDescriptionToLeft_Click);
            // 
            // btnNameToLeft
            // 
            this.btnNameToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNameToLeft.Location = new System.Drawing.Point(261, 30);
            this.btnNameToLeft.Name = "btnNameToLeft";
            this.btnNameToLeft.Size = new System.Drawing.Size(30, 23);
            this.btnNameToLeft.TabIndex = 4;
            this.btnNameToLeft.Text = "<";
            this.btnNameToLeft.UseVisualStyleBackColor = true;
            this.btnNameToLeft.Click += new System.EventHandler(this.btnNameToLeft_Click);
            // 
            // uscLangRight
            // 
            this.uscLangRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uscLangRight.Location = new System.Drawing.Point(297, 3);
            this.uscLangRight.Name = "uscLangRight";
            this.uscLangRight.Size = new System.Drawing.Size(202, 84);
            this.uscLangRight.TabIndex = 1;
            // 
            // uscLangLeft
            // 
            this.uscLangLeft.Location = new System.Drawing.Point(3, 3);
            this.uscLangLeft.Name = "uscLangLeft";
            this.uscLangLeft.Size = new System.Drawing.Size(202, 84);
            this.uscLangLeft.TabIndex = 0;
            // 
            // uscTranslation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDescriptionToLeft);
            this.Controls.Add(this.btnNameToLeft);
            this.Controls.Add(this.btnDescriptionToRight);
            this.Controls.Add(this.btnNameToRight);
            this.Controls.Add(this.uscLangRight);
            this.Controls.Add(this.uscLangLeft);
            this.Name = "uscTranslation";
            this.Size = new System.Drawing.Size(502, 118);
            this.Load += new System.EventHandler(this.uscTranslation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private uscLanguage uscLangLeft;
        private uscLanguage uscLangRight;
        private System.Windows.Forms.Button btnNameToRight;
        private System.Windows.Forms.Button btnDescriptionToRight;
        private System.Windows.Forms.Button btnDescriptionToLeft;
        private System.Windows.Forms.Button btnNameToLeft;
    }
}
