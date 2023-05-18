namespace DoctorOfficeManagement.Forms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.metroButtonAddNewUser = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonEditProfile = new MetroFramework.Controls.MetroButton();
            this.metroButtonShowUserInformation = new MetroFramework.Controls.MetroButton();
            this.metroButtonInsertVisitPrice = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButtonAddNewUser
            // 
            this.metroButtonAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroButtonAddNewUser.Location = new System.Drawing.Point(23, 84);
            this.metroButtonAddNewUser.Name = "metroButtonAddNewUser";
            this.metroButtonAddNewUser.Size = new System.Drawing.Size(378, 70);
            this.metroButtonAddNewUser.TabIndex = 0;
            this.metroButtonAddNewUser.Text = "افزودن کاربر جدید";
            this.metroButtonAddNewUser.UseCustomBackColor = true;
            this.metroButtonAddNewUser.UseSelectable = true;
            this.metroButtonAddNewUser.Click += new System.EventHandler(this.metroButtonAddNewUser_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroButtonDelete.Location = new System.Drawing.Point(23, 160);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(378, 70);
            this.metroButtonDelete.TabIndex = 0;
            this.metroButtonDelete.Text = "حذف کاربر";
            this.metroButtonDelete.UseCustomBackColor = true;
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroButtonEditProfile
            // 
            this.metroButtonEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroButtonEditProfile.Location = new System.Drawing.Point(23, 236);
            this.metroButtonEditProfile.Name = "metroButtonEditProfile";
            this.metroButtonEditProfile.Size = new System.Drawing.Size(378, 70);
            this.metroButtonEditProfile.TabIndex = 0;
            this.metroButtonEditProfile.Text = "ویرایش پروفایل";
            this.metroButtonEditProfile.UseCustomBackColor = true;
            this.metroButtonEditProfile.UseSelectable = true;
            this.metroButtonEditProfile.Click += new System.EventHandler(this.metroButtonEditProfile_Click);
            // 
            // metroButtonShowUserInformation
            // 
            this.metroButtonShowUserInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroButtonShowUserInformation.Location = new System.Drawing.Point(23, 312);
            this.metroButtonShowUserInformation.Name = "metroButtonShowUserInformation";
            this.metroButtonShowUserInformation.Size = new System.Drawing.Size(378, 70);
            this.metroButtonShowUserInformation.TabIndex = 0;
            this.metroButtonShowUserInformation.Text = "مشاهده اطلاعات کاربر";
            this.metroButtonShowUserInformation.UseCustomBackColor = true;
            this.metroButtonShowUserInformation.UseSelectable = true;
            this.metroButtonShowUserInformation.Click += new System.EventHandler(this.metroButtonShowUserInformation_Click);
            // 
            // metroButtonInsertVisitPrice
            // 
            this.metroButtonInsertVisitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroButtonInsertVisitPrice.Location = new System.Drawing.Point(23, 388);
            this.metroButtonInsertVisitPrice.Name = "metroButtonInsertVisitPrice";
            this.metroButtonInsertVisitPrice.Size = new System.Drawing.Size(378, 70);
            this.metroButtonInsertVisitPrice.TabIndex = 0;
            this.metroButtonInsertVisitPrice.Text = "ثبت مبلغ معاینه ";
            this.metroButtonInsertVisitPrice.UseCustomBackColor = true;
            this.metroButtonInsertVisitPrice.UseSelectable = true;
            this.metroButtonInsertVisitPrice.Click += new System.EventHandler(this.metroButtonInsertVisitPrice_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 499);
            this.Controls.Add(this.metroButtonInsertVisitPrice);
            this.Controls.Add(this.metroButtonShowUserInformation);
            this.Controls.Add(this.metroButtonEditProfile);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonAddNewUser);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تنظیمات ";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonAddNewUser;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroButton metroButtonEditProfile;
        private MetroFramework.Controls.MetroButton metroButtonShowUserInformation;
        private MetroFramework.Controls.MetroButton metroButtonInsertVisitPrice;
    }
}