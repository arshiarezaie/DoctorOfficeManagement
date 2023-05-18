namespace DoctorOfficeManagement.Forms
{
    partial class FormManageTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageTasks));
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabelStatus = new MetroFramework.Controls.MetroLabel();
            this.metroButtonEditTask = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxTaskDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTaskPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTaskTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.TaskBox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSelectPerson = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEraser = new System.Windows.Forms.ToolStripButton();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroPanel2.Controls.Add(this.metroLabelStatus);
            this.metroPanel2.Controls.Add(this.metroButtonEditTask);
            this.metroPanel2.Controls.Add(this.metroTextBoxTaskDescription);
            this.metroPanel2.Controls.Add(this.metroTextBoxTaskPrice);
            this.metroPanel2.Controls.Add(this.metroTextBoxTaskTitle);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 88);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(269, 301);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabelStatus
            // 
            this.metroLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabelStatus.Location = new System.Drawing.Point(4, 10);
            this.metroLabelStatus.Name = "metroLabelStatus";
            this.metroLabelStatus.Size = new System.Drawing.Size(262, 23);
            this.metroLabelStatus.TabIndex = 4;
            this.metroLabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelStatus.UseCustomBackColor = true;
            this.metroLabelStatus.UseCustomForeColor = true;
            // 
            // metroButtonEditTask
            // 
            this.metroButtonEditTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroButtonEditTask.Location = new System.Drawing.Point(3, 267);
            this.metroButtonEditTask.Name = "metroButtonEditTask";
            this.metroButtonEditTask.Size = new System.Drawing.Size(263, 29);
            this.metroButtonEditTask.TabIndex = 3;
            this.metroButtonEditTask.Text = "ویرایش";
            this.metroButtonEditTask.UseCustomBackColor = true;
            this.metroButtonEditTask.UseSelectable = true;
            this.metroButtonEditTask.Click += new System.EventHandler(this.metroButtonEditTask_Click);
            // 
            // metroTextBoxTaskDescription
            // 
            // 
            // 
            // 
            this.metroTextBoxTaskDescription.CustomButton.Image = null;
            this.metroTextBoxTaskDescription.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.metroTextBoxTaskDescription.CustomButton.Name = "";
            this.metroTextBoxTaskDescription.CustomButton.Size = new System.Drawing.Size(165, 165);
            this.metroTextBoxTaskDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTaskDescription.CustomButton.TabIndex = 1;
            this.metroTextBoxTaskDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTaskDescription.CustomButton.UseSelectable = true;
            this.metroTextBoxTaskDescription.CustomButton.Visible = false;
            this.metroTextBoxTaskDescription.Lines = new string[0];
            this.metroTextBoxTaskDescription.Location = new System.Drawing.Point(3, 93);
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
            this.metroTextBoxTaskDescription.Size = new System.Drawing.Size(263, 167);
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
            this.metroTextBoxTaskPrice.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.metroTextBoxTaskPrice.CustomButton.Name = "";
            this.metroTextBoxTaskPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTaskPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTaskPrice.CustomButton.TabIndex = 1;
            this.metroTextBoxTaskPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTaskPrice.CustomButton.UseSelectable = true;
            this.metroTextBoxTaskPrice.CustomButton.Visible = false;
            this.metroTextBoxTaskPrice.Lines = new string[0];
            this.metroTextBoxTaskPrice.Location = new System.Drawing.Point(3, 64);
            this.metroTextBoxTaskPrice.MaxLength = 32767;
            this.metroTextBoxTaskPrice.Name = "metroTextBoxTaskPrice";
            this.metroTextBoxTaskPrice.PasswordChar = '\0';
            this.metroTextBoxTaskPrice.PromptText = "قیمت";
            this.metroTextBoxTaskPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTaskPrice.SelectedText = "";
            this.metroTextBoxTaskPrice.SelectionLength = 0;
            this.metroTextBoxTaskPrice.SelectionStart = 0;
            this.metroTextBoxTaskPrice.ShortcutsEnabled = true;
            this.metroTextBoxTaskPrice.Size = new System.Drawing.Size(263, 23);
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
            this.metroTextBoxTaskTitle.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.metroTextBoxTaskTitle.CustomButton.Name = "";
            this.metroTextBoxTaskTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTaskTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTaskTitle.CustomButton.TabIndex = 1;
            this.metroTextBoxTaskTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTaskTitle.CustomButton.UseSelectable = true;
            this.metroTextBoxTaskTitle.CustomButton.Visible = false;
            this.metroTextBoxTaskTitle.Lines = new string[0];
            this.metroTextBoxTaskTitle.Location = new System.Drawing.Point(3, 35);
            this.metroTextBoxTaskTitle.MaxLength = 32767;
            this.metroTextBoxTaskTitle.Name = "metroTextBoxTaskTitle";
            this.metroTextBoxTaskTitle.PasswordChar = '\0';
            this.metroTextBoxTaskTitle.PromptText = "عنوان وظیفه";
            this.metroTextBoxTaskTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTaskTitle.SelectedText = "";
            this.metroTextBoxTaskTitle.SelectionLength = 0;
            this.metroTextBoxTaskTitle.SelectionStart = 0;
            this.metroTextBoxTaskTitle.ShortcutsEnabled = true;
            this.metroTextBoxTaskTitle.Size = new System.Drawing.Size(263, 23);
            this.metroTextBoxTaskTitle.TabIndex = 2;
            this.metroTextBoxTaskTitle.UseSelectable = true;
            this.metroTextBoxTaskTitle.WaterMark = "عنوان وظیفه";
            this.metroTextBoxTaskTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTaskTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroPanel1.Controls.Add(this.TaskBox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(295, 88);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(235, 301);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // TaskBox
            // 
            this.TaskBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TaskBox.FormattingEnabled = true;
            this.TaskBox.Location = new System.Drawing.Point(14, 18);
            this.TaskBox.Name = "TaskBox";
            this.TaskBox.Size = new System.Drawing.Size(210, 277);
            this.TaskBox.TabIndex = 2;
            this.TaskBox.SelectedIndexChanged += new System.EventHandler(this.TaskBox_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSelectPerson,
            this.toolStripButton1,
            this.toolStripButtonEraser});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(510, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSelectPerson
            // 
            this.toolStripButtonSelectPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSelectPerson.Image = global::DoctorOfficeManagement.Properties.Resources.Add1;
            this.toolStripButtonSelectPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelectPerson.Name = "toolStripButtonSelectPerson";
            this.toolStripButtonSelectPerson.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSelectPerson.Text = "toolStripButtonAddVisit";
            this.toolStripButtonSelectPerson.ToolTipText = "انتخاب بیمار از لیست بیماران";
            this.toolStripButtonSelectPerson.Click += new System.EventHandler(this.toolStripButtonSelectPerson_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DoctorOfficeManagement.Properties.Resources.delete_icon_png_19;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButtonDeleteTask";
            this.toolStripButton1.ToolTipText = "حذف بیمار انتخاب شده";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonEraser
            // 
            this.toolStripButtonEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEraser.Image = global::DoctorOfficeManagement.Properties.Resources.PinClipart_com_free_office_clipart_1640578;
            this.toolStripButtonEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEraser.Name = "toolStripButtonEraser";
            this.toolStripButtonEraser.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEraser.Text = "toolStripButton2";
            this.toolStripButtonEraser.ToolTipText = "پاک کردن تمام فیلدهای فرم";
            this.toolStripButtonEraser.Click += new System.EventHandler(this.toolStripButtonEraser_Click);
            // 
            // FormManageTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 397);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManageTasks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت وظایف پزشک ";
            this.Load += new System.EventHandler(this.FormManageTasks_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTaskDescription;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTaskPrice;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTaskTitle;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ListBox TaskBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelectPerson;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEraser;
        private MetroFramework.Controls.MetroButton metroButtonEditTask;
        private MetroFramework.Controls.MetroLabel metroLabelStatus;
    }
}