namespace DoctorOfficeManagement.Forms
{
    partial class FormManageVisits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageVisits));
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddVisit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditVisit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteVisit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAutoSecretary = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBurnVisit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnBurnVisit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonViewAllVisits = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.VisitPanel = new MetroFramework.Controls.MetroPanel();
            this.metroButtonBurnVisit = new MetroFramework.Controls.MetroButton();
            this.metroLabelVisitTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPersonFullName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelVisitNumber = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.AutoSecretarytimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            this.VisitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddVisit,
            this.toolStripButtonEditVisit,
            this.toolStripButtonDeleteVisit,
            this.toolStripSeparator1,
            this.toolStripButtonAutoSecretary,
            this.toolStripButtonBurnVisit,
            this.toolStripButtonUnBurnVisit,
            this.toolStripButtonRefresh,
            this.toolStripButtonViewAllVisits});
            this.toolStrip3.Location = new System.Drawing.Point(20, 60);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(760, 54);
            this.toolStrip3.TabIndex = 4;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButtonAddVisit
            // 
            this.toolStripButtonAddVisit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddVisit.Image = global::DoctorOfficeManagement.Properties.Resources.Add;
            this.toolStripButtonAddVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddVisit.Name = "toolStripButtonAddVisit";
            this.toolStripButtonAddVisit.Size = new System.Drawing.Size(54, 51);
            this.toolStripButtonAddVisit.ToolTipText = "افزودن نوبت جدید";
            this.toolStripButtonAddVisit.Click += new System.EventHandler(this.toolStripButtonAddVisit_Click);
            // 
            // toolStripButtonEditVisit
            // 
            this.toolStripButtonEditVisit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditVisit.Image = global::DoctorOfficeManagement.Properties.Resources.Notepad_icon_svg;
            this.toolStripButtonEditVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditVisit.Name = "toolStripButtonEditVisit";
            this.toolStripButtonEditVisit.Size = new System.Drawing.Size(54, 51);
            this.toolStripButtonEditVisit.ToolTipText = "ویرایش نوبت";
            this.toolStripButtonEditVisit.Click += new System.EventHandler(this.toolStripButtonEditVisit_Click);
            // 
            // toolStripButtonDeleteVisit
            // 
            this.toolStripButtonDeleteVisit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteVisit.Image = global::DoctorOfficeManagement.Properties.Resources.delete_icon_png_19;
            this.toolStripButtonDeleteVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteVisit.Name = "toolStripButtonDeleteVisit";
            this.toolStripButtonDeleteVisit.Size = new System.Drawing.Size(54, 51);
            this.toolStripButtonDeleteVisit.ToolTipText = "حذف نوبت";
            this.toolStripButtonDeleteVisit.Click += new System.EventHandler(this.toolStripButtonDeleteVisit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripButtonAutoSecretary
            // 
            this.toolStripButtonAutoSecretary.BackColor = System.Drawing.Color.White;
            this.toolStripButtonAutoSecretary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAutoSecretary.Image = global::DoctorOfficeManagement.Properties.Resources.Secretary;
            this.toolStripButtonAutoSecretary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAutoSecretary.Name = "toolStripButtonAutoSecretary";
            this.toolStripButtonAutoSecretary.Size = new System.Drawing.Size(54, 51);
            this.toolStripButtonAutoSecretary.Text = "منشی خودکار";
            this.toolStripButtonAutoSecretary.Click += new System.EventHandler(this.toolStripButtonAutoSecretary_Click);
            // 
            // toolStripButtonBurnVisit
            // 
            this.toolStripButtonBurnVisit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBurnVisit.Image = global::DoctorOfficeManagement.Properties.Resources.Remove;
            this.toolStripButtonBurnVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBurnVisit.Name = "toolStripButtonBurnVisit";
            this.toolStripButtonBurnVisit.Size = new System.Drawing.Size(54, 51);
            this.toolStripButtonBurnVisit.ToolTipText = "سوزوندن نوبت";
            this.toolStripButtonBurnVisit.Click += new System.EventHandler(this.toolStripButtonBurnVisit_Click);
            // 
            // toolStripButtonUnBurnVisit
            // 
            this.toolStripButtonUnBurnVisit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUnBurnVisit.Image = global::DoctorOfficeManagement.Properties.Resources.pngwing_com__2_;
            this.toolStripButtonUnBurnVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnBurnVisit.Name = "toolStripButtonUnBurnVisit";
            this.toolStripButtonUnBurnVisit.Size = new System.Drawing.Size(54, 51);
            this.toolStripButtonUnBurnVisit.ToolTipText = "خارج کردن نوبت از حالت سوخته";
            this.toolStripButtonUnBurnVisit.Click += new System.EventHandler(this.toolStripButtonUnBurnVisit_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::DoctorOfficeManagement.Properties.Resources.Refresh;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(54, 51);
            this.toolStripButtonRefresh.ToolTipText = "تازه سازی";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripButtonViewAllVisits
            // 
            this.toolStripButtonViewAllVisits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonViewAllVisits.Image = global::DoctorOfficeManagement.Properties.Resources.select_all;
            this.toolStripButtonViewAllVisits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonViewAllVisits.Name = "toolStripButtonViewAllVisits";
            this.toolStripButtonViewAllVisits.Size = new System.Drawing.Size(54, 51);
            this.toolStripButtonViewAllVisits.ToolTipText = "مشاهده همه نوبت ها";
            this.toolStripButtonViewAllVisits.Click += new System.EventHandler(this.toolStripButtonViewAllVisits_Click);
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewVisits.Location = new System.Drawing.Point(20, 188);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.Size = new System.Drawing.Size(760, 242);
            this.dataGridViewVisits.TabIndex = 5;
            // 
            // VisitPanel
            // 
            this.VisitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.VisitPanel.Controls.Add(this.metroButtonBurnVisit);
            this.VisitPanel.Controls.Add(this.metroLabelVisitTime);
            this.VisitPanel.Controls.Add(this.metroLabelPersonFullName);
            this.VisitPanel.Controls.Add(this.metroLabelVisitNumber);
            this.VisitPanel.Controls.Add(this.metroLabel1);
            this.VisitPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VisitPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitPanel.HorizontalScrollbarBarColor = true;
            this.VisitPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.VisitPanel.HorizontalScrollbarSize = 10;
            this.VisitPanel.Location = new System.Drawing.Point(20, 114);
            this.VisitPanel.Name = "VisitPanel";
            this.VisitPanel.Size = new System.Drawing.Size(760, 71);
            this.VisitPanel.TabIndex = 6;
            this.VisitPanel.UseCustomBackColor = true;
            this.VisitPanel.UseCustomForeColor = true;
            this.VisitPanel.VerticalScrollbarBarColor = true;
            this.VisitPanel.VerticalScrollbarHighlightOnWheel = false;
            this.VisitPanel.VerticalScrollbarSize = 10;
            // 
            // metroButtonBurnVisit
            // 
            this.metroButtonBurnVisit.BackgroundImage = global::DoctorOfficeManagement.Properties.Resources.error_handling_windows_xp_error_logo_11563210401mwwnodn9yn;
            this.metroButtonBurnVisit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButtonBurnVisit.Location = new System.Drawing.Point(3, 6);
            this.metroButtonBurnVisit.Name = "metroButtonBurnVisit";
            this.metroButtonBurnVisit.Size = new System.Drawing.Size(65, 65);
            this.metroButtonBurnVisit.TabIndex = 3;
            this.metroButtonBurnVisit.UseSelectable = true;
            this.metroButtonBurnVisit.Click += new System.EventHandler(this.metroButtonBurnVisit_Click);
            // 
            // metroLabelVisitTime
            // 
            this.metroLabelVisitTime.AutoSize = true;
            this.metroLabelVisitTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelVisitTime.Location = new System.Drawing.Point(515, 40);
            this.metroLabelVisitTime.Name = "metroLabelVisitTime";
            this.metroLabelVisitTime.Size = new System.Drawing.Size(88, 19);
            this.metroLabelVisitTime.TabIndex = 2;
            this.metroLabelVisitTime.Text = "ساعت ورود : ";
            this.metroLabelVisitTime.UseCustomBackColor = true;
            // 
            // metroLabelPersonFullName
            // 
            this.metroLabelPersonFullName.AutoSize = true;
            this.metroLabelPersonFullName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelPersonFullName.Location = new System.Drawing.Point(285, 12);
            this.metroLabelPersonFullName.Name = "metroLabelPersonFullName";
            this.metroLabelPersonFullName.Size = new System.Drawing.Size(139, 19);
            this.metroLabelPersonFullName.TabIndex = 2;
            this.metroLabelPersonFullName.Text = "نام و و نام خانوادگی : ";
            this.metroLabelPersonFullName.UseCustomBackColor = true;
            // 
            // metroLabelVisitNumber
            // 
            this.metroLabelVisitNumber.AutoSize = true;
            this.metroLabelVisitNumber.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelVisitNumber.Location = new System.Drawing.Point(536, 12);
            this.metroLabelVisitNumber.Name = "metroLabelVisitNumber";
            this.metroLabelVisitNumber.Size = new System.Drawing.Size(91, 19);
            this.metroLabelVisitNumber.TabIndex = 2;
            this.metroLabelVisitNumber.Text = "شماره نوبت : ";
            this.metroLabelVisitNumber.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(664, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "نوبت جاری ";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // AutoSecretarytimer
            // 
            this.AutoSecretarytimer.Tick += new System.EventHandler(this.AutoSecretarytimer_Tick);
            // 
            // FormManageVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VisitPanel);
            this.Controls.Add(this.dataGridViewVisits);
            this.Controls.Add(this.toolStrip3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManageVisits";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نوبت ها";
            this.Load += new System.EventHandler(this.FormManageVisits_Load);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            this.VisitPanel.ResumeLayout(false);
            this.VisitPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddVisit;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditVisit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteVisit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAutoSecretary;
        private System.Windows.Forms.ToolStripButton toolStripButtonBurnVisit;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private MetroFramework.Controls.MetroPanel VisitPanel;
        private MetroFramework.Controls.MetroLabel metroLabelVisitNumber;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelVisitTime;
        private MetroFramework.Controls.MetroLabel metroLabelPersonFullName;
        private MetroFramework.Controls.MetroButton metroButtonBurnVisit;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnBurnVisit;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewAllVisits;
        private System.Windows.Forms.Timer AutoSecretarytimer;
    }
}