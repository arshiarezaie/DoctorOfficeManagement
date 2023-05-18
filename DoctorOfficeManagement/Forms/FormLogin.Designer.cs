namespace DoctorOfficeManagement.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonClose = new MetroFramework.Controls.MetroButton();
            this.metroButtonResetPassword = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonLogin
            // 
            this.metroButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButtonLogin.Location = new System.Drawing.Point(121, 143);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(110, 23);
            this.metroButtonLogin.TabIndex = 0;
            this.metroButtonLogin.Text = "ورود";
            this.metroButtonLogin.UseCustomBackColor = true;
            this.metroButtonLogin.UseSelectable = true;
            this.metroButtonLogin.Click += new System.EventHandler(this.metroButtonLogin_Click);
            // 
            // metroTextBoxUserName
            // 
            // 
            // 
            // 
            this.metroTextBoxUserName.CustomButton.Image = null;
            this.metroTextBoxUserName.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.metroTextBoxUserName.CustomButton.Name = "";
            this.metroTextBoxUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUserName.CustomButton.TabIndex = 1;
            this.metroTextBoxUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUserName.CustomButton.UseSelectable = true;
            this.metroTextBoxUserName.CustomButton.Visible = false;
            this.metroTextBoxUserName.Lines = new string[0];
            this.metroTextBoxUserName.Location = new System.Drawing.Point(121, 76);
            this.metroTextBoxUserName.MaxLength = 32767;
            this.metroTextBoxUserName.Name = "metroTextBoxUserName";
            this.metroTextBoxUserName.PasswordChar = '\0';
            this.metroTextBoxUserName.PromptText = "نام کاربری";
            this.metroTextBoxUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUserName.SelectedText = "";
            this.metroTextBoxUserName.SelectionLength = 0;
            this.metroTextBoxUserName.SelectionStart = 0;
            this.metroTextBoxUserName.ShortcutsEnabled = true;
            this.metroTextBoxUserName.Size = new System.Drawing.Size(232, 23);
            this.metroTextBoxUserName.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUserName.TabIndex = 1;
            this.metroTextBoxUserName.UseSelectable = true;
            this.metroTextBoxUserName.UseStyleColors = true;
            this.metroTextBoxUserName.WaterMark = "نام کاربری";
            this.metroTextBoxUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(121, 114);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '*';
            this.metroTextBoxPassword.PromptText = "کلمه عبور";
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(232, 23);
            this.metroTextBoxPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.TabIndex = 1;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.UseStyleColors = true;
            this.metroTextBoxPassword.WaterMark = "کلمه عبور";
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonClose
            // 
            this.metroButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroButtonClose.Location = new System.Drawing.Point(243, 143);
            this.metroButtonClose.Name = "metroButtonClose";
            this.metroButtonClose.Size = new System.Drawing.Size(110, 23);
            this.metroButtonClose.TabIndex = 0;
            this.metroButtonClose.Text = "خروج";
            this.metroButtonClose.UseCustomBackColor = true;
            this.metroButtonClose.UseSelectable = true;
            this.metroButtonClose.Click += new System.EventHandler(this.metroButtonClose_Click);
            // 
            // metroButtonResetPassword
            // 
            this.metroButtonResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroButtonResetPassword.Location = new System.Drawing.Point(121, 172);
            this.metroButtonResetPassword.Name = "metroButtonResetPassword";
            this.metroButtonResetPassword.Size = new System.Drawing.Size(232, 23);
            this.metroButtonResetPassword.TabIndex = 0;
            this.metroButtonResetPassword.Text = "بازیابی رمز عبور ";
            this.metroButtonResetPassword.UseCustomBackColor = true;
            this.metroButtonResetPassword.UseSelectable = true;
            this.metroButtonResetPassword.Click += new System.EventHandler(this.metroButtonResetPassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoctorOfficeManagement.Properties.Resources.doctor1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 209);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroTextBoxUserName);
            this.Controls.Add(this.metroButtonClose);
            this.Controls.Add(this.metroButtonResetPassword);
            this.Controls.Add(this.metroButtonLogin);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ورود به سیستم ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonLogin;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUserName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroButton metroButtonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButtonResetPassword;
    }
}