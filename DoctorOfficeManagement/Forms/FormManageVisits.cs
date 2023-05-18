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
    public partial class FormManageVisits : MetroForm
    {
        PersonAndVisitViewModel _currentvisit;
        List<PersonAndVisitViewModel> _visits;
        List<PersonAndVisitViewModel> OrderedVisists;
        ActionMaker maker = new ActionMaker();
        void Refresh(Expression<Func<Visit, bool>> where = null)
        {
            _visits.Clear();
            dataGridViewVisits.DataSource = null;
            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {

                foreach (Visit visit in db.VisitRepository.Get(where))
                {
                    _visits.Add(new PersonAndVisitViewModel(visit));
                }
            }

            _visits = _visits.OrderBy(v => strToDateTime(v.Date, v.Time)).ToList();

            dataGridViewVisits.DataSource = _visits;

            dataGridViewVisits.Columns[0].HeaderText = "ایدی";
            dataGridViewVisits.Columns[0].Visible = false;
            dataGridViewVisits.Columns[1].HeaderText = "نام و نام خانوادگی";
            dataGridViewVisits.Columns[2].HeaderText = "زمان";
            dataGridViewVisits.Columns[3].HeaderText = "تاریخ";
            dataGridViewVisits.Columns[4].HeaderText = "سوختن نوبت";


            foreach (DataGridViewRow row in dataGridViewVisits.Rows)
            {
                if (row.Cells[4].Value.ToString() == "نوبت سوخته")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
                }
            }



        }


        void SetVisitPanelDeafult()
        {
            metroLabelVisitNumber.Text = "شماره نوبت : ";
            metroLabelPersonFullName.Text = "نام و و نام خانوادگی : ";
            metroLabelVisitTime.Text = "ساعت ورود : ";
            _currentvisit = null;
        }


        string getPersianDateNow()
        {
            PersianCalendar calendar = new PersianCalendar();
            string date = calendar.GetYear(DateTime.Now) + "/" + calendar.GetMonth(DateTime.Now) + "/" + calendar.GetDayOfMonth(DateTime.Now);
            return date;
        }


        public FormManageVisits()
        {
            _visits = new List<PersonAndVisitViewModel>();
            InitializeComponent();
        }

        private void FormManageVisits_Load(object sender, EventArgs e)
        {
            string date = getPersianDateNow();
            Refresh(v => v.Date == date);
        }

        private void toolStripButtonAddVisit_Click(object sender, EventArgs e)
        {
            AutoSecretarytimer.Stop();
            FormAddVisit frm = new FormAddVisit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string date = getPersianDateNow();
                Refresh(v => v.Date == date);
            }
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            string date = getPersianDateNow();
            Refresh(v => v.Date == date);
        }

        private void toolStripButtonEditVisit_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisits.CurrentRow != null)
            {
                FormEditVisit form = new FormEditVisit(int.Parse(dataGridViewVisits.CurrentRow.Cells[0].Value.ToString()));
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string date = getPersianDateNow();
                    Refresh(v => v.Date == date);
                }
            }
            else
            {
                RtlMessageBox.Show("برای ویرایش باید یک نوبت را انتخاب نمایید ", "هیچ نوبتی انتخاب نشده", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButtonDeleteVisit_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisits.CurrentRow != null)
            {

                DialogResult result = RtlMessageBox.Show($"ایا از حذف نوبت اقا/خانم {dataGridViewVisits.CurrentRow.Cells[1].Value} اطمینان دارید ؟", "حذف شود ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (UnitOfWorkDB db = new UnitOfWorkDB())
                    {
                        int Id = int.Parse(dataGridViewVisits.CurrentRow.Cells[0].Value.ToString());
                        db.DoctorTaskRepository.Clear(d => d.VisistID == Id);
                        db.VisitRepository.DeleteByPrimarykey(Id);
                        db.UserActionRepository.Insert(maker.GetAction("حذف نوبت"));
                        if (db.Save())
                        {
                            string date = getPersianDateNow();
                            Refresh(v => v.Date == date);
                        }
                        else
                        {
                            string exception = "\n" + db.Exception.ToString();
                            RtlMessageBox.Show("مشکلی پیش آمده " + exception, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }
        }

        private void toolStripButtonBurnVisit_Click(object sender, EventArgs e)
        {
            if (_currentvisit == null)
            {
                if (dataGridViewVisits.CurrentRow != null)
                {
                    using (UnitOfWorkDB db = new UnitOfWorkDB())
                    {
                        Visit visit = db.VisitRepository.GetByPrimaryKey(int.Parse(dataGridViewVisits.CurrentRow.Cells[0].Value.ToString()));
                        visit.IsFailed = true;
                        db.VisitRepository.Update(visit);
                        db.UserActionRepository.Insert(maker.GetAction("سوزاندن نوبت "));
                        if (db.Save())
                        {
                            string date = getPersianDateNow();
                            Refresh(v => v.Date == date);
                        }
                    }
                }
                else
                {
                    RtlMessageBox.Show("لطفا ابتدا نوبتی را انتخاب نمایید ", "هیچ موردی انتخاب نشده ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                RtlMessageBox.Show("درحالت روشن بودن منشی خودکار امکان سوزاندن نوبت یا ازاد کردن نوبت از لیست وجود ندارد ", "منشی خودکار روشن است ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButtonUnBurnVisit_Click(object sender, EventArgs e)
        {
            if (_currentvisit == null)
            {
                if (dataGridViewVisits.CurrentRow != null)
                {
                    using (UnitOfWorkDB db = new UnitOfWorkDB())
                    {
                        Visit visit = db.VisitRepository.GetByPrimaryKey(int.Parse(dataGridViewVisits.CurrentRow.Cells[0].Value.ToString()));
                        visit.IsFailed = false;
                        db.VisitRepository.Update(visit);
                        db.UserActionRepository.Insert(maker.GetAction("آزاد کردن نوبت"));
                        if (db.Save())
                        {
                            string date = getPersianDateNow();
                            Refresh(v => v.Date == date);
                        }
                    }
                }
                else
                {
                    RtlMessageBox.Show("لطفا ابتدا نوبتی را انتخاب نمایید ", "هیچ موردی انتخاب نشده ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                RtlMessageBox.Show("درحالت روشن بودن منشی خودکار امکان سوزاندن نوبت یا ازاد کردن نوبت از لیست وجود ندارد ", "منشی خودکار روشن است ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void toolStripButtonViewAllVisits_Click(object sender, EventArgs e)
        {
            AutoSecretarytimer.Stop();
            Refresh();
        }


        DateTime strToDateTime(string Date, string Time)
        {
            PersianCalendar calendar = new PersianCalendar();
            DateTime dateTime = calendar.ToDateTime(int.Parse(Date.Split('/')[0]), int.Parse(Date.Split('/')[1]), int.Parse(Date.Split('/')[2]), int.Parse(Time.Split(':')[0]), int.Parse(Time.Split(':')[1]), 0, 0);
            return dateTime;
        }


        VisitTimeSpan GetTimeSpan(PersonAndVisitViewModel visit1, PersonAndVisitViewModel visit2)
        {

            VisitTimeSpan span = new VisitTimeSpan();

            span.Time1 = strToDateTime(visit1.Date, visit1.Time);
            span.Time2 = strToDateTime(visit2.Date, visit2.Time);

            return span;
        }


        private void toolStripButtonAutoSecretary_Click(object sender, EventArgs e)
        {
            if (toolStripButtonAutoSecretary.BackColor != Color.FromArgb(255, 128, 128))
            {
                toolStripButtonAutoSecretary.BackColor = Color.FromArgb(255, 128, 128);
                toolStripButtonAutoSecretary.Image = Image.FromFile(Application.StartupPath + "/Images/SecretaryRED.png");
                AutoSecretarytimer.Start();
            }
            else
            {
                toolStripButtonAutoSecretary.BackColor = Color.White;
                toolStripButtonAutoSecretary.Image = Image.FromFile(Application.StartupPath + "/Images/Secretary.jpg");
                AutoSecretarytimer.Stop();
                SetVisitPanelDeafult();
            }


        }


        void SetCurrentVisit(PersonAndVisitViewModel visit)
        {
            metroLabelVisitNumber.Text = "شماره نوبت : " + visit.ID;
            metroLabelPersonFullName.Text = "نام و و نام خانوادگی : " + visit.FullName;
            metroLabelVisitTime.Text = "ساعت ورود : " + visit.Time;
        }





        private void AutoSecretarytimer_Tick(object sender, EventArgs e)
        {
            OrderedVisists = _visits.Where(v => !v.isFailed).OrderBy(v => strToDateTime(v.Date, v.Time)).ToList();

            for (int i = 0; i < OrderedVisists.Count; i++)
            {

                PersonAndVisitViewModel visit = OrderedVisists[i];
                PersonAndVisitViewModel Nextvisit = i < OrderedVisists.Count - 1 ? OrderedVisists[i + 1] : null;

                DateTime visitDateTime = strToDateTime(visit.Date, visit.Time);

                if (Nextvisit != null)
                {
                    VisitTimeSpan span = GetTimeSpan(visit, Nextvisit);


                    if (visitDateTime >= span.Time1 && visitDateTime <= span.Time2 && DateTime.Now <= span.Time2 && DateTime.Now >= span.Time1)
                    {
                        _currentvisit = visit;

                        AutoSecretarytimer.Interval = 10000;
                        SetCurrentVisit(_currentvisit);
                        break;
                    }
                }
                else
                {

                    _currentvisit = visit;
                    SetCurrentVisit(_currentvisit);
                    AutoSecretarytimer.Stop();


                }

            }


        }

        private void metroButtonBurnVisit_Click(object sender, EventArgs e)
        {
            if (_currentvisit != null && OrderedVisists.IndexOf(_currentvisit) != (OrderedVisists.Count - 1))
            {

                FormSelectVisit frm = new FormSelectVisit(OrderedVisists.Where(v => v != _currentvisit).ToList());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    AutoSecretarytimer.Stop();
                    using (UnitOfWorkDB db = new UnitOfWorkDB())
                    {
                        Visit FailedVisit = db.VisitRepository.GetByPrimaryKey(_currentvisit.ID);
                        FailedVisit.IsFailed = true;
                        db.VisitRepository.Update(FailedVisit);


                        Visit ReplcaedVisit = db.VisitRepository.GetByPrimaryKey((int)FormsTerminal.TerminalObject);
                        ReplcaedVisit.Time = _currentvisit.Time;
                        db.VisitRepository.Update(ReplcaedVisit);

                        db.Save();

                    }


                    string date = getPersianDateNow();
                    Refresh(v => v.Date == date);
                    AutoSecretarytimer.Interval = 100;
                    AutoSecretarytimer.Start();


                }
            }
        }
    }
}
