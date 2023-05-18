namespace DoctorOfficeManagement.Forms
{
    partial class FormShowDigitalFiles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowDigitalFiles));
            this.metroListViewDigitalFiles = new MetroFramework.Controls.MetroListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroListViewDigitalFiles
            // 
            this.metroListViewDigitalFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroListViewDigitalFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroListViewDigitalFiles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListViewDigitalFiles.FullRowSelect = true;
            this.metroListViewDigitalFiles.LargeImageList = this.imageList1;
            this.metroListViewDigitalFiles.Location = new System.Drawing.Point(20, 60);
            this.metroListViewDigitalFiles.Name = "metroListViewDigitalFiles";
            this.metroListViewDigitalFiles.OwnerDraw = true;
            this.metroListViewDigitalFiles.Size = new System.Drawing.Size(237, 247);
            this.metroListViewDigitalFiles.TabIndex = 0;
            this.metroListViewDigitalFiles.UseCompatibleStateImageBehavior = false;
            this.metroListViewDigitalFiles.UseCustomBackColor = true;
            this.metroListViewDigitalFiles.UseSelectable = true;
            this.metroListViewDigitalFiles.DoubleClick += new System.EventHandler(this.metroListViewDigitalFiles_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pngwing.com (1).png");
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroButtonCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroButtonCancel.Location = new System.Drawing.Point(20, 313);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(237, 23);
            this.metroButtonCancel.TabIndex = 1;
            this.metroButtonCancel.Text = "لغو";
            this.metroButtonCancel.UseCustomBackColor = true;
            this.metroButtonCancel.UseSelectable = true;
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // FormShowDigitalFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 356);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroListViewDigitalFiles);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormShowDigitalFiles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "انتخاب فایل دیجیتال";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroListViewDigitalFiles;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
    }
}