namespace DoctorOfficeManagement.Forms
{
    partial class FormManagePersons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagePersons));
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEditPerson = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeletePerson = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridViewPersons = new System.Windows.Forms.DataGridView();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEditPerson,
            this.toolStripButtonDeletePerson,
            this.toolStripSeparator1,
            this.toolStripButtonRefresh,
            this.toolStripLabel1,
            this.toolStripTextBoxSearch});
            this.toolStrip3.Location = new System.Drawing.Point(20, 60);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(760, 54);
            this.toolStrip3.TabIndex = 5;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButtonEditPerson
            // 
            this.toolStripButtonEditPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditPerson.Image = global::DoctorOfficeManagement.Properties.Resources.Notepad_icon_svg;
            this.toolStripButtonEditPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditPerson.Name = "toolStripButtonEditPerson";
            this.toolStripButtonEditPerson.Size = new System.Drawing.Size(54, 51);
            this.toolStripButtonEditPerson.ToolTipText = "ویرایش نوبت";
            this.toolStripButtonEditPerson.Click += new System.EventHandler(this.toolStripButtonEditPerson_Click);
            // 
            // toolStripButtonDeletePerson
            // 
            this.toolStripButtonDeletePerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeletePerson.Image = global::DoctorOfficeManagement.Properties.Resources.delete_icon_png_19;
            this.toolStripButtonDeletePerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeletePerson.Name = "toolStripButtonDeletePerson";
            this.toolStripButtonDeletePerson.Size = new System.Drawing.Size(54, 51);
            this.toolStripButtonDeletePerson.ToolTipText = "حذف نوبت";
            this.toolStripButtonDeletePerson.Click += new System.EventHandler(this.toolStripButtonDeletePerson_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 51);
            this.toolStripLabel1.Text = "جستجو:";
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 54);
            this.toolStripTextBoxSearch.TextChanged += new System.EventHandler(this.toolStripTextBoxSearch_TextChanged);
            // 
            // dataGridViewPersons
            // 
            this.dataGridViewPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersons.Location = new System.Drawing.Point(23, 118);
            this.dataGridViewPersons.Name = "dataGridViewPersons";
            this.dataGridViewPersons.Size = new System.Drawing.Size(753, 309);
            this.dataGridViewPersons.TabIndex = 6;
            // 
            // FormManagePersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPersons);
            this.Controls.Add(this.toolStrip3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManagePersons";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت بیماران";
            this.Load += new System.EventHandler(this.FormManagePersons_Load);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditPerson;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeletePerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewPersons;
    }
}