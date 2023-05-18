namespace DoctorOfficeManagement.Forms
{
    partial class FormViewImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewImages));
            this.metroButtonNext = new MetroFramework.Controls.MetroButton();
            this.metroButtonPreviews = new MetroFramework.Controls.MetroButton();
            this.pictureBoxImages = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImages)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonNext
            // 
            this.metroButtonNext.BackgroundImage = global::DoctorOfficeManagement.Properties.Resources.blue_arrow_png_36989___Copy__2_;
            this.metroButtonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButtonNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroButtonNext.Location = new System.Drawing.Point(20, 60);
            this.metroButtonNext.Name = "metroButtonNext";
            this.metroButtonNext.Size = new System.Drawing.Size(101, 370);
            this.metroButtonNext.TabIndex = 1;
            this.metroButtonNext.UseSelectable = true;
            this.metroButtonNext.Click += new System.EventHandler(this.metroButtonNext_Click);
            // 
            // metroButtonPreviews
            // 
            this.metroButtonPreviews.BackgroundImage = global::DoctorOfficeManagement.Properties.Resources.blue_arrow_png_36989___Copy__2____Copy;
            this.metroButtonPreviews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButtonPreviews.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroButtonPreviews.Location = new System.Drawing.Point(679, 60);
            this.metroButtonPreviews.Name = "metroButtonPreviews";
            this.metroButtonPreviews.Size = new System.Drawing.Size(101, 370);
            this.metroButtonPreviews.TabIndex = 0;
            this.metroButtonPreviews.UseSelectable = true;
            this.metroButtonPreviews.Click += new System.EventHandler(this.metroButtonPreviews_Click);
            // 
            // pictureBoxImages
            // 
            this.pictureBoxImages.Location = new System.Drawing.Point(127, 60);
            this.pictureBoxImages.Name = "pictureBoxImages";
            this.pictureBoxImages.Size = new System.Drawing.Size(545, 370);
            this.pictureBoxImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImages.TabIndex = 2;
            this.pictureBoxImages.TabStop = false;
            // 
            // FormViewImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxImages);
            this.Controls.Add(this.metroButtonNext);
            this.Controls.Add(this.metroButtonPreviews);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormViewImages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مشاهده تصاویر";
            this.Load += new System.EventHandler(this.FormViewImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonPreviews;
        private MetroFramework.Controls.MetroButton metroButtonNext;
        private System.Windows.Forms.PictureBox pictureBoxImages;
    }
}