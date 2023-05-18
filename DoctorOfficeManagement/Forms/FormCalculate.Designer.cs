namespace DoctorOfficeManagement.Forms
{
    partial class FormCalculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculate));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConfirmVisitPayment = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddPayment = new System.Windows.Forms.ToolStripButton();
            this.metroButtonCalculateRevenuese = new MetroFramework.Controls.MetroButton();
            this.metroButtonCalculateAllPayments = new MetroFramework.Controls.MetroButton();
            this.metroButtonCalculateAllRevenuese = new MetroFramework.Controls.MetroButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConfirmVisitPayment,
            this.toolStripButtonAddPayment});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(219, 54);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonConfirmVisitPayment
            // 
            this.toolStripButtonConfirmVisitPayment.Image = global::DoctorOfficeManagement.Properties.Resources.SVG_edit_logo1;
            this.toolStripButtonConfirmVisitPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConfirmVisitPayment.Name = "toolStripButtonConfirmVisitPayment";
            this.toolStripButtonConfirmVisitPayment.Size = new System.Drawing.Size(98, 51);
            this.toolStripButtonConfirmVisitPayment.Text = "تایید پرداخت نوبت";
            this.toolStripButtonConfirmVisitPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonConfirmVisitPayment.Click += new System.EventHandler(this.toolStripButtonConfirmVisitPayment_Click);
            // 
            // toolStripButtonAddPayment
            // 
            this.toolStripButtonAddPayment.Image = global::DoctorOfficeManagement.Properties.Resources.Add2;
            this.toolStripButtonAddPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddPayment.Name = "toolStripButtonAddPayment";
            this.toolStripButtonAddPayment.Size = new System.Drawing.Size(61, 51);
            this.toolStripButtonAddPayment.Text = "درج هزینه";
            this.toolStripButtonAddPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAddPayment.Click += new System.EventHandler(this.toolStripButtonAddPayment_Click);
            // 
            // metroButtonCalculateRevenuese
            // 
            this.metroButtonCalculateRevenuese.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroButtonCalculateRevenuese.Location = new System.Drawing.Point(20, 117);
            this.metroButtonCalculateRevenuese.Name = "metroButtonCalculateRevenuese";
            this.metroButtonCalculateRevenuese.Size = new System.Drawing.Size(218, 50);
            this.metroButtonCalculateRevenuese.TabIndex = 2;
            this.metroButtonCalculateRevenuese.Text = "محسابه درآمد بدون کسر هزینه ها";
            this.metroButtonCalculateRevenuese.UseCustomBackColor = true;
            this.metroButtonCalculateRevenuese.UseSelectable = true;
            this.metroButtonCalculateRevenuese.Click += new System.EventHandler(this.metroButtonCalculateRevenuese_Click);
            // 
            // metroButtonCalculateAllPayments
            // 
            this.metroButtonCalculateAllPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroButtonCalculateAllPayments.Location = new System.Drawing.Point(20, 173);
            this.metroButtonCalculateAllPayments.Name = "metroButtonCalculateAllPayments";
            this.metroButtonCalculateAllPayments.Size = new System.Drawing.Size(218, 50);
            this.metroButtonCalculateAllPayments.TabIndex = 2;
            this.metroButtonCalculateAllPayments.Text = "محسابه هزینه ها";
            this.metroButtonCalculateAllPayments.UseCustomBackColor = true;
            this.metroButtonCalculateAllPayments.UseSelectable = true;
            this.metroButtonCalculateAllPayments.Click += new System.EventHandler(this.metroButtonCalculateAllPayments_Click);
            // 
            // metroButtonCalculateAllRevenuese
            // 
            this.metroButtonCalculateAllRevenuese.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButtonCalculateAllRevenuese.Location = new System.Drawing.Point(20, 229);
            this.metroButtonCalculateAllRevenuese.Name = "metroButtonCalculateAllRevenuese";
            this.metroButtonCalculateAllRevenuese.Size = new System.Drawing.Size(218, 50);
            this.metroButtonCalculateAllRevenuese.TabIndex = 2;
            this.metroButtonCalculateAllRevenuese.Text = "محسابه کل درآمد";
            this.metroButtonCalculateAllRevenuese.UseCustomBackColor = true;
            this.metroButtonCalculateAllRevenuese.UseSelectable = true;
            this.metroButtonCalculateAllRevenuese.Click += new System.EventHandler(this.metroButtonCalculateAllRevenuese_Click);
            // 
            // FormCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 287);
            this.Controls.Add(this.metroButtonCalculateAllRevenuese);
            this.Controls.Add(this.metroButtonCalculateAllPayments);
            this.Controls.Add(this.metroButtonCalculateRevenuese);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "حسابداری";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonConfirmVisitPayment;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddPayment;
        private MetroFramework.Controls.MetroButton metroButtonCalculateRevenuese;
        private MetroFramework.Controls.MetroButton metroButtonCalculateAllPayments;
        private MetroFramework.Controls.MetroButton metroButtonCalculateAllRevenuese;
    }
}