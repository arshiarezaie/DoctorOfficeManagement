using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Animation;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using MetroFramework.Native;
using MetroFramework.Properties;
using System.Globalization;
using DoctorOfficeManagement.Forms;
using DataLayer.Models;
using DataLayer.Repository;
using UnitOfWork;
using System.Linq.Expressions;
using DoctorOfficeManagement.Classes.ViewModels;
using DoctorOfficeManagement.Classes;

namespace DoctorOfficeManagement.Forms
{
    public partial class FormInsertPayment : MetroForm
    {
        public FormInsertPayment()
        {
            InitializeComponent();
        }

        private void metroTextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        bool ValidateInputs()
        {
            if (metroTextBoxTitle.Text != string.Empty && metroTextBoxPrice.Text != string.Empty && metroComboBoxYear.SelectedItem != null && metroComboBoxMonth.SelectedItem != null && metroComboBoxDay.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void metroButtonSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Payment payment = new Payment()
                {
                    Title = metroTextBoxTitle.Text,
                    Price = int.Parse(metroTextBoxPrice.Text),
                    Date = metroComboBoxYear.Items[metroComboBoxYear.SelectedIndex] + "/" + (metroComboBoxMonth.SelectedIndex + 1) + "/" + metroComboBoxDay.Items[metroComboBoxDay.SelectedIndex]
                };

                using (UnitOfWorkDB db = new UnitOfWorkDB())
                {
                    db.PaymentRepository.Insert(payment);
                    DialogResult = db.Save() ? DialogResult.OK : DialogResult.None;
                }
            }
            else
            {
                RtlMessageBox.Show("اطلاعات ورودی ناقص است لطفا اطلاعات را به درستی وارد نمایید ", "اطلاعات ناقص", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
