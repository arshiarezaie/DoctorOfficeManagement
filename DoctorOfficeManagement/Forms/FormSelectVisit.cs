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
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Fonts;
using MetroFramework.Drawing;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using MetroFramework.Native;
using MetroFramework.Properties;
using MetroFramework;
using DataLayer.Models;
using DataLayer.Repository;
using DoctorOfficeManagement.Classes.ViewModels;
using UnitOfWork;
using System.Linq.Expressions;
using System.Globalization;
using DoctorOfficeManagement.Classes;

namespace DoctorOfficeManagement.Forms
{
    public partial class FormSelectVisit : MetroForm
    {
        List<PersonAndVisitViewModel> visits;



        void refresh()
        {
            dataGridViewVisits.DataSource = visits;

            dataGridViewVisits.Columns[0].HeaderText = "ایدی";
            dataGridViewVisits.Columns[0].Visible = false;
            dataGridViewVisits.Columns[1].HeaderText = "نام و نام خانوادگی";
            dataGridViewVisits.Columns[2].HeaderText = "زمان";
            dataGridViewVisits.Columns[3].HeaderText = "تاریخ";
            dataGridViewVisits.Columns[4].HeaderText = "سوختن نوبت";
        }


        public FormSelectVisit(List<PersonAndVisitViewModel> visits)
        {
            this.visits = visits;
            InitializeComponent();
        }

        private void dataGridViewVisits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int Id = int.Parse(dataGridViewVisits.CurrentRow.Cells[0].Value.ToString());
                FormsTerminal.ResetTerminalObject();
                FormsTerminal.TerminalObject = Id;
                DialogResult = DialogResult.OK;
            }
            catch
            {
                RtlMessageBox.Show("لطفا یک نوبت را انتخاب نمایید ","نوبتی انتخاب نشده است ",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSelectVisit_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
