namespace DoctorOfficeManagement.Forms
{
    partial class FormAddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTask));
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroButtonSubmit = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxTaskDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTaskPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTaskTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroPanel2.Controls.Add(this.metroButtonCancel);
            this.metroPanel2.Controls.Add(this.metroButtonSubmit);
            this.metroPanel2.Controls.Add(this.metroTextBoxTaskDescription);
            this.metroPanel2.Controls.Add(this.metroTextBoxTaskPrice);
            this.metroPanel2.Controls.Add(this.metroTextBoxTaskTitle);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(8, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(269, 317);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroButtonCancel.Location = new System.Drawing.Point(15, 285);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(247, 29);
            this.metroButtonCancel.TabIndex = 3;
            this.metroButtonCancel.Text = "لغو";
            this.metroButtonCancel.UseCustomBackColor = true;
            this.metroButtonCancel.UseSelectable = true;
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // metroButtonSubmit
            // 
            this.metroButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButtonSubmit.Location = new System.Drawing.Point(15, 250);
            this.metroButtonSubmit.Name = "metroButtonSubmit";
            this.metroButtonSubmit.Size = new System.Drawing.Size(247, 29);
            this.metroButtonSubmit.TabIndex = 3;
            this.metroButtonSubmit.Text = "افزودن";
            this.metroButtonSubmit.UseCustomBackColor = true;
            this.metroButtonSubmit.UseSelectable = true;
            this.metroButtonSubmit.Click += new System.EventHandler(this.metroButtonSubmit_Click);
            // 
            // metroTextBoxTaskDescription
            // 
            // 
            // 
            // 
            this.metroTextBoxTaskDescription.CustomButton.Image = null;
            this.metroTextBoxTaskDescription.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.metroTextBoxTaskDescription.CustomButton.Name = "";
            this.metroTextBoxTaskDescription.CustomButton.Size = new System.Drawing.Size(165, 165);
            this.metroTextBoxTaskDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTaskDescription.CustomButton.TabIndex = 1;
            this.metroTextBoxTaskDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTaskDescription.CustomButton.UseSelectable = true;
            this.metroTextBoxTaskDescription.CustomButton.Visible = false;
            this.metroTextBoxTaskDescription.Lines = new string[0];
            this.metroTextBoxTaskDescription.Location = new System.Drawing.Point(15, 76);
            this.metroTextBoxTaskDescription.MaxLength = 32767;
            this.metroTextBoxTaskDescription.Multiline = true;
            this.metroTextBoxTaskDescription.Name = "metroTextBoxTaskDescription";
            this.metroTextBoxTaskDescription.PasswordChar = '\0';
            this.metroTextBoxTaskDescription.PromptText = "توضیحات";
            this.metroTextBoxTaskDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTaskDescription.SelectedText = "";
            this.metroTextBoxTaskDescription.SelectionLength = 0;
            this.metroTextBoxTaskDescription.SelectionStart = 0;
            this.metroTextBoxTaskDescription.ShortcutsEnabled = true;
            this.metroTextBoxTaskDescription.Size = new System.Drawing.Size(247, 167);
            this.metroTextBoxTaskDescription.TabIndex = 2;
            this.metroTextBoxTaskDescription.UseSelectable = true;
            this.metroTextBoxTaskDescription.WaterMark = "توضیحات";
            this.metroTextBoxTaskDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTaskDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxTaskPrice
            // 
            // 
            // 
            // 
            this.metroTextBoxTaskPrice.CustomButton.Image = null;
            this.metroTextBoxTaskPrice.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.metroTextBoxTaskPrice.CustomButton.Name = "";
            this.metroTextBoxTaskPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTaskPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTaskPrice.CustomButton.TabIndex = 1;
            this.metroTextBoxTaskPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTaskPrice.CustomButton.UseSelectable = true;
            this.metroTextBoxTaskPrice.CustomButton.Visible = false;
            this.metroTextBoxTaskPrice.Lines = new string[0];
            this.metroTextBoxTaskPrice.Location = new System.Drawing.Point(15, 47);
            this.metroTextBoxTaskPrice.MaxLength = 32767;
            this.metroTextBoxTaskPrice.Name = "metroTextBoxTaskPrice";
            this.metroTextBoxTaskPrice.PasswordChar = '\0';
            this.metroTextBoxTaskPrice.PromptText = "قیمت";
            this.metroTextBoxTaskPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTaskPrice.SelectedText = "";
            this.metroTextBoxTaskPrice.SelectionLength = 0;
            this.metroTextBoxTaskPrice.SelectionStart = 0;
            this.metroTextBoxTaskPrice.ShortcutsEnabled = true;
            this.metroTextBoxTaskPrice.Size = new System.Drawing.Size(247, 23);
            this.metroTextBoxTaskPrice.TabIndex = 2;
            this.metroTextBoxTaskPrice.UseSelectable = true;
            this.metroTextBoxTaskPrice.WaterMark = "قیمت";
            this.metroTextBoxTaskPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTaskPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxTaskPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxTaskPrice_KeyPress);
            // 
            // metroTextBoxTaskTitle
            // 
            // 
            // 
            // 
            this.metroTextBoxTaskTitle.CustomButton.Image = null;
            this.metroTextBoxTaskTitle.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.metroTextBoxTaskTitle.CustomButton.Name = "";
            this.metroTextBoxTaskTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTaskTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTaskTitle.CustomButton.TabIndex = 1;
            this.metroTextBoxTaskTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTaskTitle.CustomButton.UseSelectable = true;
            this.metroTextBoxTaskTitle.CustomButton.Visible = false;
            this.metroTextBoxTaskTitle.Lines = new string[0];
            this.metroTextBoxTaskTitle.Location = new System.Drawing.Point(15, 18);
            this.metroTextBoxTaskTitle.MaxLength = 32767;
            this.metroTextBoxTaskTitle.Name = "metroTextBoxTaskTitle";
            this.metroTextBoxTaskTitle.PasswordChar = '\0';
            this.metroTextBoxTaskTitle.PromptText = "عنوان وظیفه";
            this.metroTextBoxTaskTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTaskTitle.SelectedText = "";
            this.metroTextBoxTaskTitle.SelectionLength = 0;
            this.metroTextBoxTaskTitle.SelectionStart = 0;
            this.metroTextBoxTaskTitle.ShortcutsEnabled = true;
            this.metroTextBoxTaskTitle.Size = new System.Drawing.Size(247, 23);
            this.metroTextBoxTaskTitle.TabIndex = 2;
            this.metroTextBoxTaskTitle.UseSelectable = true;
            this.metroTextBoxTaskTitle.WaterMark = "عنوان وظیفه";
            this.metroTextBoxTaskTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTaskTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 393);
            this.Controls.Add(this.metroPanel2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddTask";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "افزودن وظیفه پزشک ";
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButtonSubmit;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTaskDescription;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTaskPrice;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTaskTitle;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
    }
}