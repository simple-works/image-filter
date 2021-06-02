namespace ImageFilter
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel_main = new System.Windows.Forms.Panel();
            this.listBox_filters = new System.Windows.Forms.ListBox();
            this.textBox_filePath = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button_processing = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_appliedFilters = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_openFile = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.button_about);
            this.panel_main.Controls.Add(this.button_appliedFilters);
            this.panel_main.Controls.Add(this.listBox_filters);
            this.panel_main.Controls.Add(this.button_reset);
            this.panel_main.Controls.Add(this.button_save);
            this.panel_main.Controls.Add(this.textBox_filePath);
            this.panel_main.Controls.Add(this.button_openFile);
            this.panel_main.Controls.Add(this.button_apply);
            this.panel_main.Location = new System.Drawing.Point(436, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(348, 466);
            this.panel_main.TabIndex = 0;
            // 
            // listBox_filters
            // 
            this.listBox_filters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_filters.FormattingEnabled = true;
            this.listBox_filters.Location = new System.Drawing.Point(17, 48);
            this.listBox_filters.Name = "listBox_filters";
            this.listBox_filters.Size = new System.Drawing.Size(312, 342);
            this.listBox_filters.TabIndex = 1;
            this.listBox_filters.DoubleClick += new System.EventHandler(this.listBox_filters_DoubleClick);
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_filePath.Location = new System.Drawing.Point(17, 13);
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.ReadOnly = true;
            this.textBox_filePath.Size = new System.Drawing.Size(206, 20);
            this.textBox_filePath.TabIndex = 5;
            this.textBox_filePath.Text = "No File";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.b" +
    "mp";
            this.openFileDialog.Title = "Open Image File";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.b" +
    "mp";
            // 
            // button_processing
            // 
            this.button_processing.BackColor = System.Drawing.Color.Green;
            this.button_processing.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button_processing.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_processing.FlatAppearance.BorderSize = 2;
            this.button_processing.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_processing.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_processing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_processing.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button_processing.ForeColor = System.Drawing.Color.White;
            this.button_processing.Image = global::ImageFilter.Properties.Resources.arrow_refresh;
            this.button_processing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_processing.Location = new System.Drawing.Point(31, 31);
            this.button_processing.Name = "button_processing";
            this.button_processing.Size = new System.Drawing.Size(141, 32);
            this.button_processing.TabIndex = 6;
            this.button_processing.Text = "Processing...";
            this.button_processing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_processing.UseVisualStyleBackColor = false;
            // 
            // button_about
            // 
            this.button_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Image = global::ImageFilter.Properties.Resources.help;
            this.button_about.Location = new System.Drawing.Point(313, 396);
            this.button_about.Margin = new System.Windows.Forms.Padding(0);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(16, 23);
            this.button_about.TabIndex = 7;
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_appliedFilters
            // 
            this.button_appliedFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_appliedFilters.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_appliedFilters.FlatAppearance.BorderSize = 0;
            this.button_appliedFilters.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_appliedFilters.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_appliedFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_appliedFilters.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button_appliedFilters.Image = global::ImageFilter.Properties.Resources.filter;
            this.button_appliedFilters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_appliedFilters.Location = new System.Drawing.Point(17, 396);
            this.button_appliedFilters.Margin = new System.Windows.Forms.Padding(0);
            this.button_appliedFilters.Name = "button_appliedFilters";
            this.button_appliedFilters.Size = new System.Drawing.Size(222, 23);
            this.button_appliedFilters.TabIndex = 6;
            this.button_appliedFilters.Text = "  0  Applied Filters";
            this.button_appliedFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_appliedFilters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_appliedFilters.UseVisualStyleBackColor = true;
            // 
            // button_reset
            // 
            this.button_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_reset.Enabled = false;
            this.button_reset.Image = global::ImageFilter.Properties.Resources.undo;
            this.button_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reset.Location = new System.Drawing.Point(123, 429);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(100, 23);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_save.Enabled = false;
            this.button_save.Image = global::ImageFilter.Properties.Resources.diskette;
            this.button_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_save.Location = new System.Drawing.Point(229, 429);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_openFile
            // 
            this.button_openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_openFile.Image = global::ImageFilter.Properties.Resources.folder_image;
            this.button_openFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_openFile.Location = new System.Drawing.Point(229, 12);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(100, 23);
            this.button_openFile.TabIndex = 0;
            this.button_openFile.Text = "Open";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // button_apply
            // 
            this.button_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_apply.Enabled = false;
            this.button_apply.Image = global::ImageFilter.Properties.Resources.accept_button;
            this.button_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_apply.Location = new System.Drawing.Point(17, 429);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(100, 23);
            this.button_apply.TabIndex = 2;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_photo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox_photo.BackgroundImage = global::ImageFilter.Properties.Resources.background;
            this.pictureBox_photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_photo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(418, 466);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_photo.TabIndex = 0;
            this.pictureBox_photo.TabStop = false;
            this.pictureBox_photo.DoubleClick += new System.EventHandler(this.pictureBox_photo_DoubleClick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 490);
            this.Controls.Add(this.button_processing);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.pictureBox_photo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Filter";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TextBox textBox_filePath;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_reset;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox listBox_filters;
        private System.Windows.Forms.Button button_appliedFilters;
        private System.Windows.Forms.Button button_processing;
        private System.Windows.Forms.Button button_about;
    }
}

