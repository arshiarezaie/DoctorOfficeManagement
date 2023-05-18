namespace DoctorOfficeManagement.Forms
{
    partial class FormInsertPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsertPayment));
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroComboBoxYear = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxMonth = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxDay = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonSubmit = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel2.Controls.Add(this.metroComboBoxYear);
            this.metroPanel2.Controls.Add(this.metroComboBoxMonth);
            this.metroPanel2.Controls.Add(this.metroComboBoxDay);
            this.metroPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(5, 146);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(320, 36);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroComboBoxYear
            // 
            this.metroComboBoxYear.FormattingEnabled = true;
            this.metroComboBoxYear.ItemHeight = 23;
            this.metroComboBoxYear.Items.AddRange(new object[] {
            "1401",
            "1402",
            "1403",
            "1404",
            "1405",
            "1406",
            "1407",
            "1408",
            "1409",
            "1410",
            "1411",
            "1412",
            "1413",
            "1414",
            "1415",
            "1416",
            "1417",
            "1418",
            "1419",
            "1420",
            "1421",
            "1422",
            "1423",
            "1424",
            "1425",
            "1426",
            "1427",
            "1428",
            "1429",
            "1430",
            "1431",
            "1432",
            "1433",
            "1434",
            "1435",
            "1436"});
            this.metroComboBoxYear.Location = new System.Drawing.Point(9, 3);
            this.metroComboBoxYear.Name = "metroComboBoxYear";
            this.metroComboBoxYear.PromptText = "سال";
            this.metroComboBoxYear.Size = new System.Drawing.Size(96, 29);
            this.metroComboBoxYear.TabIndex = 3;
            this.metroComboBoxYear.UseSelectable = true;
            // 
            // metroComboBoxMonth
            // 
            this.metroComboBoxMonth.FormattingEnabled = true;
            this.metroComboBoxMonth.ItemHeight = 23;
            this.metroComboBoxMonth.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
            this.metroComboBoxMonth.Location = new System.Drawing.Point(111, 3);
            this.metroComboBoxMonth.Name = "metroComboBoxMonth";
            this.metroComboBoxMonth.PromptText = "ماه";
            this.metroComboBoxMonth.Size = new System.Drawing.Size(96, 29);
            this.metroComboBoxMonth.TabIndex = 3;
            this.metroComboBoxMonth.UseSelectable = true;
            // 
            // metroComboBoxDay
            // 
            this.metroComboBoxDay.FormattingEnabled = true;
            this.metroComboBoxDay.ItemHeight = 23;
            this.metroComboBoxDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.metroComboBoxDay.Location = new System.Drawing.Point(213, 3);
            this.metroComboBoxDay.Name = "metroComboBoxDay";
            this.metroComboBoxDay.PromptText = "روز";
            this.metroComboBoxDay.Size = new System.Drawing.Size(96, 29);
            this.metroComboBoxDay.TabIndex = 3;
            this.metroComboBoxDay.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroPanel1.Controls.Add(this.metroTextBoxPrice);
            this.metroPanel1.Controls.Add(this.metroTextBoxTitle);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(5, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(320, 76);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxPrice
            // 
            // 
            // 
            // 
            this.metroTextBoxPrice.CustomButton.Image = null;
            this.metroTextBoxPrice.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.metroTextBoxPrice.CustomButton.Name = "";
            this.metroTextBoxPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPrice.CustomButton.TabIndex = 1;
            this.metroTextBoxPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPrice.CustomButton.UseSelectable = true;
            this.metroTextBoxPrice.CustomButton.Visible = false;
            this.metroTextBoxPrice.Lines = new string[0];
            this.metroTextBoxPrice.Location = new System.Drawing.Point(9, 42);
            this.metroTextBoxPrice.MaxLength = 32767;
            this.metroTextBoxPrice.Name = "metroTextBoxPrice";
            this.metroTextBoxPrice.PasswordChar = '\0';
            this.metroTextBoxPrice.PromptText = "مبلغ";
            this.metroTextBoxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrice.SelectedText = "";
            this.metroTextBoxPrice.SelectionLength = 0;
            this.metroTextBoxPrice.SelectionStart = 0;
            this.metroTextBoxPrice.ShortcutsEnabled = true;
            this.metroTextBoxPrice.Size = new System.Drawing.Size(300, 23);
            this.metroTextBoxPrice.TabIndex = 5;
            this.metroTextBoxPrice.UseSelectable = true;
            this.metroTextBoxPrice.WaterMark = "مبلغ";
            this.metroTextBoxPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxPrice_KeyPress);
            // 
            // metroTextBoxTitle
            // 
            // 
            // 
            // 
            this.metroTextBoxTitle.CustomButton.Image = null;
            this.metroTextBoxTitle.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.metroTextBoxTitle.CustomButton.Name = "";
            this.metroTextBoxTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTitle.CustomButton.TabIndex = 1;
            this.metroTextBoxTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTitle.CustomButton.UseSelectable = true;
            this.metroTextBoxTitle.CustomButton.Visible = false;
            this.metroTextBoxTitle.Lines = new string[0];
            this.metroTextBoxTitle.Location = new System.Drawing.Point(9, 13);
            this.metroTextBoxTitle.MaxLength = 32767;
            this.metroTextBoxTitle.Name = "metroTextBoxTitle";
            this.metroTextBoxTitle.PasswordChar = '\0';
            this.metroTextBoxTitle.PromptText = "عنوان";
            this.metroTextBoxTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTitle.SelectedText = "";
            this.metroTextBoxTitle.SelectionLength = 0;
            this.metroTextBoxTitle.SelectionStart = 0;
            this.metroTextBoxTitle.ShortcutsEnabled = true;
            this.metroTextBoxTitle.Size = new System.Drawing.Size(300, 23);
            this.metroTextBoxTitle.TabIndex = 5;
            this.metroTextBoxTitle.UseSelectable = true;
            this.metroTextBoxTitle.WaterMark = "عنوان";
            this.metroTextBoxTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonSubmit
            // 
            this.metroButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButtonSubmit.Location = new System.Drawing.Point(5, 189);
            this.metroButtonSubmit.Name = "metroButtonSubmit";
            this.metroButtonSubmit.Size = new System.Drawing.Size(320, 41);
            this.metroButtonSubmit.TabIndex = 5;
            this.metroButtonSubmit.Text = "ثبت";
            this.metroButtonSubmit.UseCustomBackColor = true;
            this.metroButtonSubmit.UseSelectable = true;
            this.metroButtonSubmit.Click += new System.EventHandler(this.metroButtonSubmit_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroButtonCancel.Location = new System.Drawing.Point(5, 236);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(320, 41);
            this.metroButtonCancel.TabIndex = 5;
            this.metroButtonCancel.Text = "لغو";
            this.metroButtonCancel.UseCustomBackColor = true;
            this.metroButtonCancel.UseSelectable = true;
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // FormInsertPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 293);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroButtonSubmit);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInsertPayment";
            this.Text = "درج هزینه ";
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxYear;
        private MetroFramework.Controls.MetroComboBox metroComboBoxMonth;
        private MetroFramework.Controls.MetroComboBox metroComboBoxDay;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrice;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTitle;
        private MetroFramework.Controls.MetroButton metroButtonSubmit;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
    }
}