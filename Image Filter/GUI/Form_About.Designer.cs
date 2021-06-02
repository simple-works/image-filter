namespace ImageFilter
{
    partial class Form_About
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.linkLabel_email = new System.Windows.Forms.LinkLabel();
            this.linkLabel_website = new System.Windows.Forms.LinkLabel();
            this.textBox_thirdPartyLicenses = new System.Windows.Forms.TextBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.Location = new System.Drawing.Point(203, 16);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(277, 23);
            this.label_name.TabIndex = 14;
            this.label_name.Text = "{ Name }";
            // 
            // label_copyright
            // 
            this.label_copyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_copyright.Location = new System.Drawing.Point(203, 39);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(277, 23);
            this.label_copyright.TabIndex = 16;
            this.label_copyright.Text = "{ Copyright }";
            // 
            // linkLabel_email
            // 
            this.linkLabel_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_email.Location = new System.Drawing.Point(203, 62);
            this.linkLabel_email.Name = "linkLabel_email";
            this.linkLabel_email.Size = new System.Drawing.Size(274, 23);
            this.linkLabel_email.TabIndex = 18;
            this.linkLabel_email.TabStop = true;
            this.linkLabel_email.Text = "{ Email }";
            // 
            // linkLabel_website
            // 
            this.linkLabel_website.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_website.Location = new System.Drawing.Point(203, 85);
            this.linkLabel_website.Name = "linkLabel_website";
            this.linkLabel_website.Size = new System.Drawing.Size(274, 23);
            this.linkLabel_website.TabIndex = 19;
            this.linkLabel_website.TabStop = true;
            this.linkLabel_website.Text = "{ Website }";
            // 
            // textBox_thirdPartyLicenses
            // 
            this.textBox_thirdPartyLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_thirdPartyLicenses.Location = new System.Drawing.Point(203, 111);
            this.textBox_thirdPartyLicenses.Multiline = true;
            this.textBox_thirdPartyLicenses.Name = "textBox_thirdPartyLicenses";
            this.textBox_thirdPartyLicenses.ReadOnly = true;
            this.textBox_thirdPartyLicenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_thirdPartyLicenses.Size = new System.Drawing.Size(271, 120);
            this.textBox_thirdPartyLicenses.TabIndex = 20;
            this.textBox_thirdPartyLicenses.Text = "{ ThirdPartyLicenses }";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_logo.Image = global::ImageFilter.Properties.Resources.logo;
            this.pictureBox_logo.Location = new System.Drawing.Point(9, 16);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(182, 215);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 13;
            this.pictureBox_logo.TabStop = false;
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 246);
            this.Controls.Add(this.textBox_thirdPartyLicenses);
            this.Controls.Add(this.linkLabel_website);
            this.Controls.Add(this.linkLabel_email);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About { Title }";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.LinkLabel linkLabel_email;
        private System.Windows.Forms.LinkLabel linkLabel_website;
        private System.Windows.Forms.TextBox textBox_thirdPartyLicenses;

    }
}
