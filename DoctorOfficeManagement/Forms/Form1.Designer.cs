namespace DoctorOfficeManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonVisits = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPersons = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFiles = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTasks = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCalculate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDay = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMonth = new MetroFramework.Controls.MetroLabel();
            this.metroLabelYear = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxBaner = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaner)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonVisits,
            this.toolStripButtonPersons,
            this.toolStripButtonFiles,
            this.toolStripButtonTasks,
            this.toolStripButtonReport,
            this.toolStripButtonCalculate,
            this.toolStripButtonSettings});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(802, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonVisits
            // 
            this.toolStripButtonVisits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonVisits.Image = global::DoctorOfficeManagement.Properties.Resources.calandar;
            this.toolStripButtonVisits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVisits.Margin = new System.Windows.Forms.Padding(10, 0, 160, 0);
            this.toolStripButtonVisits.Name = "toolStripButtonVisits";
            this.toolStripButtonVisits.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonVisits.ToolTipText = "نوبت ها";
            this.toolStripButtonVisits.Click += new System.EventHandler(this.toolStripButtonVisits_Click);
            // 
            // toolStripButtonPersons
            // 
            this.toolStripButtonPersons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonPersons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPersons.Image = global::DoctorOfficeManagement.Properties.Resources.Patent;
            this.toolStripButtonPersons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPersons.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripButtonPersons.Name = "toolStripButtonPersons";
            this.toolStripButtonPersons.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonPersons.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButtonPersons.ToolTipText = "بیماران";
            this.toolStripButtonPersons.Click += new System.EventHandler(this.toolStripButtonPersons_Click);
            // 
            // toolStripButtonFiles
            // 
            this.toolStripButtonFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFiles.Image = global::DoctorOfficeManagement.Properties.Resources.File;
            this.toolStripButtonFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiles.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripButtonFiles.Name = "toolStripButtonFiles";
            this.toolStripButtonFiles.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonFiles.Text = "پرونده ها";
            this.toolStripButtonFiles.Click += new System.EventHandler(this.toolStripButtonFiles_Click);
            // 
            // toolStripButtonTasks
            // 
            this.toolStripButtonTasks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTasks.Image = global::DoctorOfficeManagement.Properties.Resources.task;
            this.toolStripButtonTasks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTasks.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripButtonTasks.Name = "toolStripButtonTasks";
            this.toolStripButtonTasks.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonTasks.Text = "toolStripButton3";
            this.toolStripButtonTasks.ToolTipText = "وظایف پزشک";
            this.toolStripButtonTasks.Click += new System.EventHandler(this.toolStripButtonTasks_Click);
            // 
            // toolStripButtonReport
            // 
            this.toolStripButtonReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReport.Image = global::DoctorOfficeManagement.Properties.Resources.Report;
            this.toolStripButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReport.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripButtonReport.Name = "toolStripButtonReport";
            this.toolStripButtonReport.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonReport.ToolTipText = "گزارش گیری ";
            this.toolStripButtonReport.Click += new System.EventHandler(this.toolStripButtonReport_Click);
            // 
            // toolStripButtonCalculate
            // 
            this.toolStripButtonCalculate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCalculate.Image = global::DoctorOfficeManagement.Properties.Resources.Money;
            this.toolStripButtonCalculate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCalculate.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripButtonCalculate.Name = "toolStripButtonCalculate";
            this.toolStripButtonCalculate.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonCalculate.ToolTipText = "حسابداری";
            this.toolStripButtonCalculate.Click += new System.EventHandler(this.toolStripButtonCalculate_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = global::DoctorOfficeManagement.Properties.Resources.settings;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonSettings.ToolTipText = "تنظیمات";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(794, 77);
            this.label3.TabIndex = 6;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Silver;
            this.metroPanel1.Controls.Add(this.dataGridViewVisits);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 220);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(799, 167);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVisits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewVisits.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.Size = new System.Drawing.Size(796, 161);
            this.dataGridViewVisits.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(338, 162);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "تاریخ امروز ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabelDay
            // 
            this.metroLabelDay.AutoSize = true;
            this.metroLabelDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroLabelDay.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelDay.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelDay.Location = new System.Drawing.Point(286, 162);
            this.metroLabelDay.Name = "metroLabelDay";
            this.metroLabelDay.Size = new System.Drawing.Size(22, 25);
            this.metroLabelDay.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabelDay.TabIndex = 10;
            this.metroLabelDay.Text = "4";
            this.metroLabelDay.UseCustomBackColor = true;
            this.metroLabelDay.UseStyleColors = true;
            // 
            // metroLabelMonth
            // 
            this.metroLabelMonth.AutoSize = true;
            this.metroLabelMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroLabelMonth.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMonth.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelMonth.Location = new System.Drawing.Point(228, 162);
            this.metroLabelMonth.Name = "metroLabelMonth";
            this.metroLabelMonth.Size = new System.Drawing.Size(52, 25);
            this.metroLabelMonth.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabelMonth.TabIndex = 10;
            this.metroLabelMonth.Text = "خرداد";
            this.metroLabelMonth.UseCustomBackColor = true;
            this.metroLabelMonth.UseStyleColors = true;
            // 
            // metroLabelYear
            // 
            this.metroLabelYear.AutoSize = true;
            this.metroLabelYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroLabelYear.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelYear.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelYear.Location = new System.Drawing.Point(170, 162);
            this.metroLabelYear.Name = "metroLabelYear";
            this.metroLabelYear.Size = new System.Drawing.Size(52, 25);
            this.metroLabelYear.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabelYear.TabIndex = 10;
            this.metroLabelYear.Text = "1401";
            this.metroLabelYear.UseCustomBackColor = true;
            this.metroLabelYear.UseStyleColors = true;
            // 
            // pictureBoxBaner
            // 
            this.pictureBoxBaner.Image = global::DoctorOfficeManagement.Properties.Resources.doctor___Copy1;
            this.pictureBoxBaner.Location = new System.Drawing.Point(546, 139);
            this.pictureBoxBaner.Name = "pictureBoxBaner";
            this.pictureBoxBaner.Size = new System.Drawing.Size(272, 74);
            this.pictureBoxBaner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBaner.TabIndex = 11;
            this.pictureBoxBaner.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Image = global::DoctorOfficeManagement.Properties.Resources.bluebar;
            this.label1.Location = new System.Drawing.Point(20, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 23);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(842, 415);
            this.Controls.Add(this.pictureBoxBaner);
            this.Controls.Add(this.metroLabelYear);
            this.Controls.Add(this.metroLabelMonth);
            this.Controls.Add(this.metroLabelDay);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت مطب پزشک ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonVisits;
        private System.Windows.Forms.ToolStripButton toolStripButtonPersons;
        private System.Windows.Forms.ToolStripButton toolStripButtonTasks;
        private System.Windows.Forms.ToolStripButton toolStripButtonReport;
        private System.Windows.Forms.ToolStripButton toolStripButtonCalculate;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiles;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelDay;
        private MetroFramework.Controls.MetroLabel metroLabelMonth;
        private MetroFramework.Controls.MetroLabel metroLabelYear;
        private System.Windows.Forms.PictureBox pictureBoxBaner;
    }
}

