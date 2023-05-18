namespace DoctorOfficeManagement.Forms
{
    partial class FormVisitPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisitPrice));
            this.metroButtonSubmit = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.numericUpDownVisitPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonSubmit
            // 
            this.metroButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButtonSubmit.Location = new System.Drawing.Point(23, 96);
            this.metroButtonSubmit.Name = "metroButtonSubmit";
            this.metroButtonSubmit.Size = new System.Drawing.Size(172, 38);
            this.metroButtonSubmit.TabIndex = 1;
            this.metroButtonSubmit.Text = "ثبت";
            this.metroButtonSubmit.UseCustomBackColor = true;
            this.metroButtonSubmit.UseSelectable = true;
            this.metroButtonSubmit.Click += new System.EventHandler(this.metroButtonSubmit_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroButtonCancel.Location = new System.Drawing.Point(201, 95);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(186, 38);
            this.metroButtonCancel.TabIndex = 1;
            this.metroButtonCancel.Text = "لغو";
            this.metroButtonCancel.UseCustomBackColor = true;
            this.metroButtonCancel.UseSelectable = true;
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // numericUpDownVisitPrice
            // 
            this.numericUpDownVisitPrice.Location = new System.Drawing.Point(23, 63);
            this.numericUpDownVisitPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownVisitPrice.Name = "numericUpDownVisitPrice";
            this.numericUpDownVisitPrice.Size = new System.Drawing.Size(364, 21);
            this.numericUpDownVisitPrice.TabIndex = 2;
            // 
            // FormVisitPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 153);
            this.Controls.Add(this.numericUpDownVisitPrice);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroButtonSubmit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVisitPrice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "درج مبلغ معاینه";
            this.Load += new System.EventHandler(this.FormVisitPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisitPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonSubmit;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownVisitPrice;
    }
}