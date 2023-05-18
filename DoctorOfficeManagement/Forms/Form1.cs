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
namespace DoctorOfficeManagement
{
    public partial class Form1 : MetroForm
    {

        public Form1()
        {

            InitializeComponent();
        }

        DateTime strToDateTime(string Date, string Time)
        {
            PersianCalendar calendar = new PersianCalendar();
            DateTime dateTime = calendar.ToDateTime(int.Parse(Date.Split('/')[0]), int.Parse(Date.Split('/')[1]), int.Parse(Date.Split('/')[2]), int.Parse(Time.Split(':')[0]), int.Parse(Time.Split(':')[1]), 0, 0);
            return dateTime;
        }

        void Refresh(Expression<Func<Visit, bool>> where = null)
        {
            List<PersonAndVisitViewModel> visits = new List<PersonAndVisitViewModel>();

            dataGridViewVisits.DataSource = null;

            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {

                foreach (Visit visit in db.VisitRepository.Get(where))
                {
                    visits.Add(new PersonAndVisitViewModel(visit));
                }
            }

            visits = visits.OrderBy(v => strToDateTime(v.Date, v.Time)).ToList();

            dataGridViewVisits.DataSource = visits;


            dataGridViewVisits.Columns[0].HeaderText = "ایدی";
            dataGridViewVisits.Columns[0].Visible = false;
            dataGridViewVisits.Columns[1].HeaderText = "نام و نام خانوادگی";
            dataGridViewVisits.Columns[2].HeaderText = "زمان";
            dataGridViewVisits.Columns[3].HeaderText = "تاریخ";
            dataGridViewVisits.Columns[4].HeaderText = "سوختن نوبت";
        }


        string getPersianDateNow()
        {
            PersianCalendar calendar = new PersianCalendar();
            string date = calendar.GetYear(DateTime.Now) + "/" + calendar.GetMonth(DateTime.Now) + "/" + calendar.GetDayOfMonth(DateTime.Now);
            return date;
        }

        void SetDateTimeLabels()
        {

            string[] months = { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
            PersianCalendar calendar = new PersianCalendar();
            metroLabelDay.Text = calendar.GetDayOfMonth(DateTime.Now).ToString();
            metroLabelMonth.Text = months[calendar.GetMonth(DateTime.Now) - 1];
            metroLabelYear.Text = calendar.GetYear(DateTime.Now).ToString();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " | کاربر " + Identity.User.FullName;
            SetDateTimeLabels();
            string date = getPersianDateNow();
            Refresh(v => v.Date == date);
        }

        private void toolStripButtonVisits_Click(object sender, EventArgs e)
        {
            FormManageVisits form = new FormManageVisits();
            form.ShowDialog();
            string date = getPersianDateNow();
            Refresh(v => v.Date == date);
        }

        private void toolStripButtonPersons_Click(object sender, EventArgs e)
        {
            FormManagePersons form = new FormManagePersons();
            form.ShowDialog();
            string date = getPersianDateNow();
            Refresh(v => v.Date == date);
        }

        private void toolStripButtonFiles_Click(object sender, EventArgs e)
        {
            FormSelectPerson form = new FormSelectPerson();
            if (form.ShowDialog() == DialogResult.OK)
            {

                FormSelectFile frm = new FormSelectFile((int)FormsTerminal.TerminalObject, true);
                frm.ShowDialog();
                string date = getPersianDateNow();
                Refresh(v => v.Date == date);
            }



        }

        private void toolStripButtonTasks_Click(object sender, EventArgs e)
        {
            FormManageTasks form = new FormManageTasks();
            form.ShowDialog();
        }

        private void toolStripButtonReport_Click(object sender, EventArgs e)
        {
            if (Identity.User.IsAdmin)
            {
                FormReport frm = new FormReport();
                frm.ShowDialog();
            }
            else
            {
                RtlMessageBox.Show("دسترسی به این بخش برای شما امکان پذیر نمی باشد", "دسترسی ممکن نیست", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void toolStripButtonCalculate_Click(object sender, EventArgs e)
        {

            if (Identity.User.IsAdmin)
            {
                FormCalculate frm = new FormCalculate();
                frm.ShowDialog();
            }
            else
            {
                RtlMessageBox.Show("دسترسی به این بخش برای شما امکان پذیر نمی باشد", "دسترسی ممکن نیست", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {

            if (Identity.User.IsAdmin)
            {
                FormSettings frm = new FormSettings();
                frm.ShowDialog();
            }
            else
            {
                RtlMessageBox.Show("دسترسی به این بخش برای شما امکان پذیر نمی باشد", "دسترسی ممکن نیست", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
  

        }
    }
}
