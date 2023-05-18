namespace DoctorOfficeManagement.Forms
{
    partial class FormSelectDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectDate));
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroComboBoxYear = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxMonth = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxDay = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonSubmit = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroPanel2.SuspendLayout();
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
            this.metroPanel2.Location = new System.Drawing.Point(12, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(320, 74);
            this.metroPanel2.TabIndex = 2;
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
            this.metroComboBoxYear.Location = new System.Drawing.Point(9, 23);
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
            this.metroComboBoxMonth.Location = new System.Drawing.Point(111, 23);
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
            this.metroComboBoxDay.Location = new System.Drawing.Point(213, 23);
            this.metroComboBoxDay.Name = "metroComboBoxDay";
            this.metroComboBoxDay.PromptText = "روز";
            this.metroComboBoxDay.Size = new System.Drawing.Size(96, 29);
            this.metroComboBoxDay.TabIndex = 3;
            this.metroComboBoxDay.UseSelectable = true;
            // 
            // metroButtonSubmit
            // 
            this.metroButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButtonSubmit.Location = new System.Drawing.Point(12, 143);
            this.metroButtonSubmit.Name = "metroButtonSubmit";
            this.metroButtonSubmit.Size = new System.Drawing.Size(320, 30);
            this.metroButtonSubmit.TabIndex = 3;
            this.metroButtonSubmit.Text = "تایید";
            this.metroButtonSubmit.UseCustomBackColor = true;
            this.metroButtonSubmit.UseSelectable = true;
            this.metroButtonSubmit.Click += new System.EventHandler(this.metroButtonSubmit_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.metroButtonCancel.Location = new System.Drawing.Point(12, 179);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(320, 30);
            this.metroButtonCancel.TabIndex = 3;
            this.metroButtonCancel.Text = "ادامه بدون تاریخ";
            this.metroButtonCancel.UseCustomBackColor = true;
            this.metroButtonCancel.UseSelectable = true;
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // FormSelectDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 227);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroButtonSubmit);
            this.Controls.Add(this.metroPanel2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectDate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "انتخاب تاریخ ";
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxYear;
        private MetroFramework.Controls.MetroComboBox metroComboBoxMonth;
        private MetroFramework.Controls.MetroComboBox metroComboBoxDay;
        private MetroFramework.Controls.MetroButton metroButtonSubmit;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
    }
}