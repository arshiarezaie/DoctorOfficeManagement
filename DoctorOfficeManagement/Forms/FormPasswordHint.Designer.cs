namespace DoctorOfficeManagement.Forms
{
    partial class FormPasswordHint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasswordHint));
            this.metroTextBoxPasswordHint = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonSubmit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBoxPasswordHint
            // 
            // 
            // 
            // 
            this.metroTextBoxPasswordHint.CustomButton.Image = null;
            this.metroTextBoxPasswordHint.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.metroTextBoxPasswordHint.CustomButton.Name = "";
            this.metroTextBoxPasswordHint.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPasswordHint.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPasswordHint.CustomButton.TabIndex = 1;
            this.metroTextBoxPasswordHint.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPasswordHint.CustomButton.UseSelectable = true;
            this.metroTextBoxPasswordHint.CustomButton.Visible = false;
            this.metroTextBoxPasswordHint.Lines = new string[0];
            this.metroTextBoxPasswordHint.Location = new System.Drawing.Point(24, 83);
            this.metroTextBoxPasswordHint.MaxLength = 32767;
            this.metroTextBoxPasswordHint.Name = "metroTextBoxPasswordHint";
            this.metroTextBoxPasswordHint.PasswordChar = '\0';
            this.metroTextBoxPasswordHint.PromptText = "رمزعبور پشتیبان";
            this.metroTextBoxPasswordHint.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPasswordHint.SelectedText = "";
            this.metroTextBoxPasswordHint.SelectionLength = 0;
            this.metroTextBoxPasswordHint.SelectionStart = 0;
            this.metroTextBoxPasswordHint.ShortcutsEnabled = true;
            this.metroTextBoxPasswordHint.Size = new System.Drawing.Size(321, 23);
            this.metroTextBoxPasswordHint.TabIndex = 0;
            this.metroTextBoxPasswordHint.UseSelectable = true;
            this.metroTextBoxPasswordHint.WaterMark = "رمزعبور پشتیبان";
            this.metroTextBoxPasswordHint.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPasswordHint.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonSubmit
            // 
            this.metroButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButtonSubmit.Location = new System.Drawing.Point(121, 112);
            this.metroButtonSubmit.Name = "metroButtonSubmit";
            this.metroButtonSubmit.Size = new System.Drawing.Size(134, 27);
            this.metroButtonSubmit.TabIndex = 1;
            this.metroButtonSubmit.Text = "برسی";
            this.metroButtonSubmit.UseCustomBackColor = true;
            this.metroButtonSubmit.UseSelectable = true;
            this.metroButtonSubmit.Click += new System.EventHandler(this.metroButtonSubmit_Click);
            // 
            // FormPasswordHint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 157);
            this.Controls.Add(this.metroButtonSubmit);
            this.Controls.Add(this.metroTextBoxPasswordHint);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPasswordHint";
            this.Text = "ورود رمز عبور پشتیبان";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxPasswordHint;
        private MetroFramework.Controls.MetroButton metroButtonSubmit;
    }
}