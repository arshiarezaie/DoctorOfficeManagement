namespace DoctorOfficeManagement.Forms
{
    partial class FormSelectFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectFile));
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonShowFilesImages = new MetroFramework.Controls.MetroButton();
            this.metroButtonShowPDFfiles = new MetroFramework.Controls.MetroButton();
            this.metroButtonSubmit = new MetroFramework.Controls.MetroButton();
            this.metroButtonDeleteFile = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxFileDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFileTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(255, 60);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(224, 505);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel2.Controls.Add(this.metroButtonShowFilesImages);
            this.metroPanel2.Controls.Add(this.metroButtonShowPDFfiles);
            this.metroPanel2.Controls.Add(this.metroButtonSubmit);
            this.metroPanel2.Controls.Add(this.metroButtonDeleteFile);
            this.metroPanel2.Controls.Add(this.metroButtonCancel);
            this.metroPanel2.Controls.Add(this.metroTextBoxFileDescription);
            this.metroPanel2.Controls.Add(this.metroTextBoxFileTitle);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(234, 505);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButtonShowFilesImages
            // 
            this.metroButtonShowFilesImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroButtonShowFilesImages.Enabled = false;
            this.metroButtonShowFilesImages.Location = new System.Drawing.Point(5, 330);
            this.metroButtonShowFilesImages.Name = "metroButtonShowFilesImages";
            this.metroButtonShowFilesImages.Size = new System.Drawing.Size(226, 29);
            this.metroButtonShowFilesImages.TabIndex = 3;
            this.metroButtonShowFilesImages.Text = "مشاهده تصاویر مربوط به پرونده ";
            this.metroButtonShowFilesImages.UseCustomBackColor = true;
            this.metroButtonShowFilesImages.UseSelectable = true;
            this.metroButtonShowFilesImages.Click += new System.EventHandler(this.metroButtonShowFilesImages_Click);
            // 
            // metroButtonShowPDFfiles
            // 
            this.metroButtonShowPDFfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.metroButtonShowPDFfiles.Enabled = false;
            this.metroButtonShowPDFfiles.Location = new System.Drawing.Point(5, 365);
            this.metroButtonShowPDFfiles.Name = "metroButtonShowPDFfiles";
            this.metroButtonShowPDFfiles.Size = new System.Drawing.Size(226, 29);
            this.metroButtonShowPDFfiles.TabIndex = 3;
            this.metroButtonShowPDFfiles.Text = "مشاهده فایل های پی دی اف";
            this.metroButtonShowPDFfiles.UseCustomBackColor = true;
            this.metroButtonShowPDFfiles.UseSelectable = true;
            this.metroButtonShowPDFfiles.Click += new System.EventHandler(this.metroButtonShowPDFfiles_Click);
            // 
            // metroButtonSubmit
            // 
            this.metroButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButtonSubmit.Location = new System.Drawing.Point(5, 433);
            this.metroButtonSubmit.Name = "metroButtonSubmit";
            this.metroButtonSubmit.Size = new System.Drawing.Size(226, 29);
            this.metroButtonSubmit.TabIndex = 3;
            this.metroButtonSubmit.Text = "تایید پرونده انتخاب شده";
            this.metroButtonSubmit.UseCustomBackColor = true;
            this.metroButtonSubmit.UseSelectable = true;
            this.metroButtonSubmit.Click += new System.EventHandler(this.metroButtonSubmit_Click);
            // 
            // metroButtonDeleteFile
            // 
            this.metroButtonDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroButtonDeleteFile.Location = new System.Drawing.Point(5, 398);
            this.metroButtonDeleteFile.Name = "metroButtonDeleteFile";
            this.metroButtonDeleteFile.Size = new System.Drawing.Size(226, 29);
            this.metroButtonDeleteFile.TabIndex = 3;
            this.metroButtonDeleteFile.Text = "حذف";
            this.metroButtonDeleteFile.UseCustomBackColor = true;
            this.metroButtonDeleteFile.UseSelectable = true;
            this.metroButtonDeleteFile.Click += new System.EventHandler(this.metroButtonDeleteFile_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroButtonCancel.Location = new System.Drawing.Point(5, 468);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(226, 29);
            this.metroButtonCancel.TabIndex = 3;
            this.metroButtonCancel.Text = "لغو";
            this.metroButtonCancel.UseCustomBackColor = true;
            this.metroButtonCancel.UseSelectable = true;
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // metroTextBoxFileDescription
            // 
            // 
            // 
            // 
            this.metroTextBoxFileDescription.CustomButton.Image = null;
            this.metroTextBoxFileDescription.CustomButton.Location = new System.Drawing.Point(-46, 1);
            this.metroTextBoxFileDescription.CustomButton.Name = "";
            this.metroTextBoxFileDescription.CustomButton.Size = new System.Drawing.Size(271, 271);
            this.metroTextBoxFileDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFileDescription.CustomButton.TabIndex = 1;
            this.metroTextBoxFileDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFileDescription.CustomButton.UseSelectable = true;
            this.metroTextBoxFileDescription.CustomButton.Visible = false;
            this.metroTextBoxFileDescription.Enabled = false;
            this.metroTextBoxFileDescription.Lines = new string[0];
            this.metroTextBoxFileDescription.Location = new System.Drawing.Point(5, 50);
            this.metroTextBoxFileDescription.MaxLength = 32767;
            this.metroTextBoxFileDescription.Multiline = true;
            this.metroTextBoxFileDescription.Name = "metroTextBoxFileDescription";
            this.metroTextBoxFileDescription.PasswordChar = '\0';
            this.metroTextBoxFileDescription.PromptText = "توضیحات";
            this.metroTextBoxFileDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFileDescription.SelectedText = "";
            this.metroTextBoxFileDescription.SelectionLength = 0;
            this.metroTextBoxFileDescription.SelectionStart = 0;
            this.metroTextBoxFileDescription.ShortcutsEnabled = true;
            this.metroTextBoxFileDescription.Size = new System.Drawing.Size(226, 273);
            this.metroTextBoxFileDescription.TabIndex = 2;
            this.metroTextBoxFileDescription.UseSelectable = true;
            this.metroTextBoxFileDescription.WaterMark = "توضیحات";
            this.metroTextBoxFileDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFileDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxFileTitle
            // 
            // 
            // 
            // 
            this.metroTextBoxFileTitle.CustomButton.Image = null;
            this.metroTextBoxFileTitle.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.metroTextBoxFileTitle.CustomButton.Name = "";
            this.metroTextBoxFileTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFileTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFileTitle.CustomButton.TabIndex = 1;
            this.metroTextBoxFileTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFileTitle.CustomButton.UseSelectable = true;
            this.metroTextBoxFileTitle.CustomButton.Visible = false;
            this.metroTextBoxFileTitle.Enabled = false;
            this.metroTextBoxFileTitle.Lines = new string[0];
            this.metroTextBoxFileTitle.Location = new System.Drawing.Point(5, 21);
            this.metroTextBoxFileTitle.MaxLength = 32767;
            this.metroTextBoxFileTitle.Name = "metroTextBoxFileTitle";
            this.metroTextBoxFileTitle.PasswordChar = '\0';
            this.metroTextBoxFileTitle.PromptText = "عنوان";
            this.metroTextBoxFileTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFileTitle.SelectedText = "";
            this.metroTextBoxFileTitle.SelectionLength = 0;
            this.metroTextBoxFileTitle.SelectionStart = 0;
            this.metroTextBoxFileTitle.ShortcutsEnabled = true;
            this.metroTextBoxFileTitle.Size = new System.Drawing.Size(226, 23);
            this.metroTextBoxFileTitle.TabIndex = 2;
            this.metroTextBoxFileTitle.UseSelectable = true;
            this.metroTextBoxFileTitle.WaterMark = "عنوان";
            this.metroTextBoxFileTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFileTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormSelectFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 585);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.listBoxFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectFile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب پرونده های بیمار";
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFiles;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFileTitle;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFileDescription;
        private MetroFramework.Controls.MetroButton metroButtonShowPDFfiles;
        private MetroFramework.Controls.MetroButton metroButtonSubmit;
        private MetroFramework.Controls.MetroButton metroButtonShowFilesImages;
        private MetroFramework.Controls.MetroButton metroButtonDeleteFile;
    }
}