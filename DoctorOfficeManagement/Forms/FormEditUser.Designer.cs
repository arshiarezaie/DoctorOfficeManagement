namespace DoctorOfficeManagement.Forms
{
    partial class FormEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditUser));
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroButtonSubmit = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxPassWordHint = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFullName = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroPanel2.Controls.Add(this.metroButtonCancel);
            this.metroPanel2.Controls.Add(this.metroButtonSubmit);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 245);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(310, 90);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroButtonCancel.Location = new System.Drawing.Point(8, 47);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(287, 31);
            this.metroButtonCancel.TabIndex = 2;
            this.metroButtonCancel.Text = "لغو";
            this.metroButtonCancel.UseCustomBackColor = true;
            this.metroButtonCancel.UseSelectable = true;
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // metroButtonSubmit
            // 
            this.metroButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButtonSubmit.Location = new System.Drawing.Point(8, 13);
            this.metroButtonSubmit.Name = "metroButtonSubmit";
            this.metroButtonSubmit.Size = new System.Drawing.Size(287, 28);
            this.metroButtonSubmit.TabIndex = 2;
            this.metroButtonSubmit.Text = "ویرایش";
            this.metroButtonSubmit.UseCustomBackColor = true;
            this.metroButtonSubmit.UseSelectable = true;
            this.metroButtonSubmit.Click += new System.EventHandler(this.metroButtonSubmit_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(226)))), ((int)(((byte)(237)))));
            this.metroPanel1.Controls.Add(this.metroTextBoxPassWordHint);
            this.metroPanel1.Controls.Add(this.metroTextBoxPhoneNumber);
            this.metroPanel1.Controls.Add(this.metroTextBoxPassword);
            this.metroPanel1.Controls.Add(this.metroTextBoxEmail);
            this.metroPanel1.Controls.Add(this.metroTextBoxFullName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(310, 176);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxPassWordHint
            // 
            // 
            // 
            // 
            this.metroTextBoxPassWordHint.CustomButton.Image = null;
            this.metroTextBoxPassWordHint.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.metroTextBoxPassWordHint.CustomButton.Name = "";
            this.metroTextBoxPassWordHint.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPassWordHint.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassWordHint.CustomButton.TabIndex = 1;
            this.metroTextBoxPassWordHint.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassWordHint.CustomButton.UseSelectable = true;
            this.metroTextBoxPassWordHint.CustomButton.Visible = false;
            this.metroTextBoxPassWordHint.Lines = new string[0];
            this.metroTextBoxPassWordHint.Location = new System.Drawing.Point(11, 74);
            this.metroTextBoxPassWordHint.MaxLength = 32767;
            this.metroTextBoxPassWordHint.Name = "metroTextBoxPassWordHint";
            this.metroTextBoxPassWordHint.PasswordChar = '\0';
            this.metroTextBoxPassWordHint.PromptText = "رمزعبور پشتیبان";
            this.metroTextBoxPassWordHint.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassWordHint.SelectedText = "";
            this.metroTextBoxPassWordHint.SelectionLength = 0;
            this.metroTextBoxPassWordHint.SelectionStart = 0;
            this.metroTextBoxPassWordHint.ShortcutsEnabled = true;
            this.metroTextBoxPassWordHint.Size = new System.Drawing.Size(288, 23);
            this.metroTextBoxPassWordHint.TabIndex = 2;
            this.metroTextBoxPassWordHint.UseSelectable = true;
            this.metroTextBoxPassWordHint.WaterMark = "رمزعبور پشتیبان";
            this.metroTextBoxPassWordHint.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassWordHint.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxPhoneNumber
            // 
            // 
            // 
            // 
            this.metroTextBoxPhoneNumber.CustomButton.Image = null;
            this.metroTextBoxPhoneNumber.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.metroTextBoxPhoneNumber.CustomButton.Name = "";
            this.metroTextBoxPhoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPhoneNumber.CustomButton.TabIndex = 1;
            this.metroTextBoxPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPhoneNumber.CustomButton.UseSelectable = true;
            this.metroTextBoxPhoneNumber.CustomButton.Visible = false;
            this.metroTextBoxPhoneNumber.Lines = new string[0];
            this.metroTextBoxPhoneNumber.Location = new System.Drawing.Point(11, 132);
            this.metroTextBoxPhoneNumber.MaxLength = 32767;
            this.metroTextBoxPhoneNumber.Name = "metroTextBoxPhoneNumber";
            this.metroTextBoxPhoneNumber.PasswordChar = '\0';
            this.metroTextBoxPhoneNumber.PromptText = "شماره تماس";
            this.metroTextBoxPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPhoneNumber.SelectedText = "";
            this.metroTextBoxPhoneNumber.SelectionLength = 0;
            this.metroTextBoxPhoneNumber.SelectionStart = 0;
            this.metroTextBoxPhoneNumber.ShortcutsEnabled = true;
            this.metroTextBoxPhoneNumber.Size = new System.Drawing.Size(288, 23);
            this.metroTextBoxPhoneNumber.TabIndex = 2;
            this.metroTextBoxPhoneNumber.UseSelectable = true;
            this.metroTextBoxPhoneNumber.WaterMark = "شماره تماس";
            this.metroTextBoxPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(11, 44);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '*';
            this.metroTextBoxPassword.PromptText = "رمز عبور";
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(288, 23);
            this.metroTextBoxPassword.TabIndex = 2;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMark = "رمز عبور";
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxEmail
            // 
            // 
            // 
            // 
            this.metroTextBoxEmail.CustomButton.Image = null;
            this.metroTextBoxEmail.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.metroTextBoxEmail.CustomButton.Name = "";
            this.metroTextBoxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmail.CustomButton.TabIndex = 1;
            this.metroTextBoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmail.CustomButton.UseSelectable = true;
            this.metroTextBoxEmail.CustomButton.Visible = false;
            this.metroTextBoxEmail.Lines = new string[0];
            this.metroTextBoxEmail.Location = new System.Drawing.Point(11, 103);
            this.metroTextBoxEmail.MaxLength = 32767;
            this.metroTextBoxEmail.Name = "metroTextBoxEmail";
            this.metroTextBoxEmail.PasswordChar = '\0';
            this.metroTextBoxEmail.PromptText = "ایمیل";
            this.metroTextBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmail.SelectedText = "";
            this.metroTextBoxEmail.SelectionLength = 0;
            this.metroTextBoxEmail.SelectionStart = 0;
            this.metroTextBoxEmail.ShortcutsEnabled = true;
            this.metroTextBoxEmail.Size = new System.Drawing.Size(288, 23);
            this.metroTextBoxEmail.TabIndex = 2;
            this.metroTextBoxEmail.UseSelectable = true;
            this.metroTextBoxEmail.WaterMark = "ایمیل";
            this.metroTextBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxFullName
            // 
            // 
            // 
            // 
            this.metroTextBoxFullName.CustomButton.Image = null;
            this.metroTextBoxFullName.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.metroTextBoxFullName.CustomButton.Name = "";
            this.metroTextBoxFullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFullName.CustomButton.TabIndex = 1;
            this.metroTextBoxFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFullName.CustomButton.UseSelectable = true;
            this.metroTextBoxFullName.CustomButton.Visible = false;
            this.metroTextBoxFullName.Lines = new string[0];
            this.metroTextBoxFullName.Location = new System.Drawing.Point(11, 15);
            this.metroTextBoxFullName.MaxLength = 32767;
            this.metroTextBoxFullName.Name = "metroTextBoxFullName";
            this.metroTextBoxFullName.PasswordChar = '\0';
            this.metroTextBoxFullName.PromptText = "نام کامل";
            this.metroTextBoxFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFullName.SelectedText = "";
            this.metroTextBoxFullName.SelectionLength = 0;
            this.metroTextBoxFullName.SelectionStart = 0;
            this.metroTextBoxFullName.ShortcutsEnabled = true;
            this.metroTextBoxFullName.Size = new System.Drawing.Size(288, 23);
            this.metroTextBoxFullName.TabIndex = 2;
            this.metroTextBoxFullName.UseSelectable = true;
            this.metroTextBoxFullName.WaterMark = "نام کامل";
            this.metroTextBoxFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 356);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ویرایش پروفایل";
            this.Load += new System.EventHandler(this.FormEditUser_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private MetroFramework.Controls.MetroButton metroButtonSubmit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassWordHint;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPhoneNumber;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEmail;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFullName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
    }
}