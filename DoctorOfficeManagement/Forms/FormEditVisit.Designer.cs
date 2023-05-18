namespace DoctorOfficeManagement.Forms
{
    partial class FormEditVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditVisit));
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroComboBoxYear = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxMinute = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxMonth = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxDay = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxHour = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroButtonSubmit = new MetroFramework.Controls.MetroButton();
            this.listBoxDoctortasks = new System.Windows.Forms.ListBox();
            this.metroButtonDeleteTask = new MetroFramework.Controls.MetroButton();
            this.metroButtonAddTask = new MetroFramework.Controls.MetroButton();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel2.Controls.Add(this.pictureBox2);
            this.metroPanel2.Controls.Add(this.metroComboBoxYear);
            this.metroPanel2.Controls.Add(this.metroComboBoxMinute);
            this.metroPanel2.Controls.Add(this.metroComboBoxMonth);
            this.metroPanel2.Controls.Add(this.metroComboBoxDay);
            this.metroPanel2.Controls.Add(this.metroComboBoxHour);
            this.metroPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(28, 257);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(499, 109);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoctorOfficeManagement.Properties.Resources.kindpng_604225;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(9, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
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
            this.metroComboBoxYear.Location = new System.Drawing.Point(9, 59);
            this.metroComboBoxYear.Name = "metroComboBoxYear";
            this.metroComboBoxYear.PromptText = "سال";
            this.metroComboBoxYear.Size = new System.Drawing.Size(153, 29);
            this.metroComboBoxYear.TabIndex = 3;
            this.metroComboBoxYear.UseSelectable = true;
            // 
            // metroComboBoxMinute
            // 
            this.metroComboBoxMinute.FormattingEnabled = true;
            this.metroComboBoxMinute.ItemHeight = 23;
            this.metroComboBoxMinute.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "00"});
            this.metroComboBoxMinute.Location = new System.Drawing.Point(51, 24);
            this.metroComboBoxMinute.Name = "metroComboBoxMinute";
            this.metroComboBoxMinute.PromptText = "دقیقه";
            this.metroComboBoxMinute.Size = new System.Drawing.Size(186, 29);
            this.metroComboBoxMinute.TabIndex = 3;
            this.metroComboBoxMinute.UseSelectable = true;
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
            this.metroComboBoxMonth.Location = new System.Drawing.Point(168, 59);
            this.metroComboBoxMonth.Name = "metroComboBoxMonth";
            this.metroComboBoxMonth.PromptText = "ماه";
            this.metroComboBoxMonth.Size = new System.Drawing.Size(153, 29);
            this.metroComboBoxMonth.TabIndex = 3;
            this.metroComboBoxMonth.UseSelectable = true;
            this.metroComboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxMonth_SelectedIndexChanged);
            // 
            // metroComboBoxDay
            // 
            this.metroComboBoxDay.FormattingEnabled = true;
            this.metroComboBoxDay.ItemHeight = 23;
            this.metroComboBoxDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            this.metroComboBoxDay.Location = new System.Drawing.Point(328, 59);
            this.metroComboBoxDay.Name = "metroComboBoxDay";
            this.metroComboBoxDay.PromptText = "روز";
            this.metroComboBoxDay.Size = new System.Drawing.Size(168, 29);
            this.metroComboBoxDay.TabIndex = 3;
            this.metroComboBoxDay.UseSelectable = true;
            // 
            // metroComboBoxHour
            // 
            this.metroComboBoxHour.FormattingEnabled = true;
            this.metroComboBoxHour.ItemHeight = 23;
            this.metroComboBoxHour.Items.AddRange(new object[] {
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
            "24"});
            this.metroComboBoxHour.Location = new System.Drawing.Point(243, 24);
            this.metroComboBoxHour.Name = "metroComboBoxHour";
            this.metroComboBoxHour.PromptText = "ساعت";
            this.metroComboBoxHour.Size = new System.Drawing.Size(253, 29);
            this.metroComboBoxHour.TabIndex = 3;
            this.metroComboBoxHour.UseSelectable = true;
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroButtonCancel.Location = new System.Drawing.Point(284, 372);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(243, 30);
            this.metroButtonCancel.TabIndex = 3;
            this.metroButtonCancel.Text = "لغو";
            this.metroButtonCancel.UseCustomBackColor = true;
            this.metroButtonCancel.UseSelectable = true;
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // metroButtonSubmit
            // 
            this.metroButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButtonSubmit.Location = new System.Drawing.Point(28, 372);
            this.metroButtonSubmit.Name = "metroButtonSubmit";
            this.metroButtonSubmit.Size = new System.Drawing.Size(240, 30);
            this.metroButtonSubmit.TabIndex = 3;
            this.metroButtonSubmit.Text = "ویرایش";
            this.metroButtonSubmit.UseCustomBackColor = true;
            this.metroButtonSubmit.UseSelectable = true;
            this.metroButtonSubmit.Click += new System.EventHandler(this.metroButtonSubmit_Click);
            // 
            // listBoxDoctortasks
            // 
            this.listBoxDoctortasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxDoctortasks.FormattingEnabled = true;
            this.listBoxDoctortasks.Location = new System.Drawing.Point(28, 63);
            this.listBoxDoctortasks.Name = "listBoxDoctortasks";
            this.listBoxDoctortasks.Size = new System.Drawing.Size(499, 147);
            this.listBoxDoctortasks.TabIndex = 4;
            // 
            // metroButtonDeleteTask
            // 
            this.metroButtonDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroButtonDeleteTask.Location = new System.Drawing.Point(284, 213);
            this.metroButtonDeleteTask.Name = "metroButtonDeleteTask";
            this.metroButtonDeleteTask.Size = new System.Drawing.Size(243, 30);
            this.metroButtonDeleteTask.TabIndex = 3;
            this.metroButtonDeleteTask.Text = "حذف";
            this.metroButtonDeleteTask.UseCustomBackColor = true;
            this.metroButtonDeleteTask.UseSelectable = true;
            this.metroButtonDeleteTask.Click += new System.EventHandler(this.metroButtonDeleteTask_Click);
            // 
            // metroButtonAddTask
            // 
            this.metroButtonAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroButtonAddTask.Location = new System.Drawing.Point(28, 213);
            this.metroButtonAddTask.Name = "metroButtonAddTask";
            this.metroButtonAddTask.Size = new System.Drawing.Size(240, 30);
            this.metroButtonAddTask.TabIndex = 3;
            this.metroButtonAddTask.Text = "افزودن وظیفه دکتر";
            this.metroButtonAddTask.UseCustomBackColor = true;
            this.metroButtonAddTask.UseSelectable = true;
            this.metroButtonAddTask.Click += new System.EventHandler(this.metroButtonAddTask_Click);
            // 
            // FormEditVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 421);
            this.Controls.Add(this.listBoxDoctortasks);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroButtonAddTask);
            this.Controls.Add(this.metroButtonSubmit);
            this.Controls.Add(this.metroButtonDeleteTask);
            this.Controls.Add(this.metroButtonCancel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditVisit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ویرایش نوبت";
            this.Load += new System.EventHandler(this.FormEditVisit_Load);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxYear;
        private MetroFramework.Controls.MetroComboBox metroComboBoxMinute;
        private MetroFramework.Controls.MetroComboBox metroComboBoxMonth;
        private MetroFramework.Controls.MetroComboBox metroComboBoxDay;
        private MetroFramework.Controls.MetroComboBox metroComboBoxHour;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private MetroFramework.Controls.MetroButton metroButtonSubmit;
        private System.Windows.Forms.ListBox listBoxDoctortasks;
        private MetroFramework.Controls.MetroButton metroButtonDeleteTask;
        private MetroFramework.Controls.MetroButton metroButtonAddTask;
    }
}