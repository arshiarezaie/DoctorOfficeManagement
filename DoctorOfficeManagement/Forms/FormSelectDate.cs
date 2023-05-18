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
    public partial class FormSelectDate : MetroForm
    {
        public FormSelectDate()
        {
            InitializeComponent();
        }


        bool inputValidates()
        {
            if (metroComboBoxYear.SelectedItem != null && metroComboBoxMonth.SelectedItem != null && metroComboBoxDay.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void metroButtonSubmit_Click(object sender, EventArgs e)
        {
            if (inputValidates())
            {

                string date = metroComboBoxYear.Items[metroComboBoxYear.SelectedIndex] + "/" + (metroComboBoxMonth.SelectedIndex + 1) + "/" + metroComboBoxDay.Items[metroComboBoxDay.SelectedIndex];

                FormsTerminal.ResetTerminalObject();
                FormsTerminal.TerminalObject = date;
                DialogResult = DialogResult.OK;
            }
            else
            {
                RtlMessageBox.Show("اطلاعات ورودی ناقص است تاریخ را درست انتخاب نمایید ", "اطلاعات ناقص", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
;
        }
    }
}
