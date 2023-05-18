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
    public partial class FormCalculate : MetroForm
    {
        UnitOfWorkDB db;


        List<PersonAndVisitViewModel> InizializePersonANdVisistViewMode()
        {
            List<PersonAndVisitViewModel> PersonAndvisits = new List<PersonAndVisitViewModel>();
            List<Visit> visits = db.VisitRepository.Get(v => (!v.IsFailed) && (!v.IsPayment)).ToList();
            foreach (var item in visits)
            {
                PersonAndvisits.Add(new PersonAndVisitViewModel(item));
            }

            return PersonAndvisits;
        }

        public FormCalculate()
        {

            db = new UnitOfWorkDB();
            InitializeComponent();
        }

        private void toolStripButtonConfirmVisitPayment_Click(object sender, EventArgs e)
        {

            FormSelectVisit frm = new FormSelectVisit(InizializePersonANdVisistViewMode());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int Id = (int)FormsTerminal.TerminalObject;
                Visit visit = db.VisitRepository.GetByPrimaryKey(Id);

                int Price = default(int);
                string Title = string.Empty;
                if (visit.DoctorTasks.Count > 0)
                {
                    foreach (var doctortask in visit.DoctorTasks.ToList())
                    {
                        Title += " - " + doctortask.Task.Task1;
                        Price += doctortask.Task.Price;
                    }
                }
                else
                {
                    if (db.VisitPriceRepository.Get().Any())
                    {
                        Title = "معاینه";
                        Price = db.VisitPriceRepository.Get().First().Price;
                    }
                    else
                    {
                        RtlMessageBox.Show("هیچ مبلغی برای معاینه در سیستم ثبت نشده است لطفا ابتدا از بخش تنظیمات مبلغ معاینه را وارد نمایید","اطلاعات وجود ندارد",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }

                }


                visit.IsPayment = true;

                Revenues revenues = new Revenues()
                {
                    Title = Title,
                    Date = visit.Date,
                    Price = Price

                };

                db.RevenuesRepository.Insert(revenues);

                if (db.Save())
                {
                    RtlMessageBox.Show("پرداخت نوبت انتخاب شده تایید شد ", "انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void metroButtonCalculateRevenuese_Click(object sender, EventArgs e)
        {
            FormSelectDate frm = new FormSelectDate();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PersianCalendar calendar = new PersianCalendar();
                string TerminalDate = (string)FormsTerminal.TerminalObject;
                int Year = int.Parse(TerminalDate.Split('/')[0]);
                int Month = int.Parse(TerminalDate.Split('/')[1]);
                int Day = int.Parse(TerminalDate.Split('/')[2]);

                DateTime dateTime = calendar.ToDateTime(Year, Month, Day, 0, 0, 0, 0);




                List<Revenues> revenueses = new List<Revenues>();

                foreach (Revenues revenues in db.RevenuesRepository.Get().ToList())
                {

                    DateTime revenuesDate = calendar.ToDateTime(int.Parse(revenues.Date.Split('/')[0]), int.Parse(revenues.Date.Split('/')[1]), int.Parse(revenues.Date.Split('/')[2]), 0, 0, 0, 0);

                    if (revenuesDate >= dateTime)
                    {
                        revenueses.Add(revenues);
                    }

                }

                int TotalRevenues = revenueses.Sum(r => r.Price);


                RtlMessageBox.Show($"{TotalRevenues} کل مبلغ درآمد : ", "محاسبه انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int TotalRevenues = db.RevenuesRepository.Get().Sum(r => r.Price);


                RtlMessageBox.Show($"{TotalRevenues} کل مبلغ درآمد : ", "محاسبه انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void toolStripButtonAddPayment_Click(object sender, EventArgs e)
        {
            FormInsertPayment frm = new FormInsertPayment();
            frm.ShowDialog();
        }

        private void metroButtonCalculateAllPayments_Click(object sender, EventArgs e)
        {
            FormSelectDate frm = new FormSelectDate();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PersianCalendar calendar = new PersianCalendar();
                string TerminalDate = (string)FormsTerminal.TerminalObject;
                int Year = int.Parse(TerminalDate.Split('/')[0]);
                int Month = int.Parse(TerminalDate.Split('/')[1]);
                int Day = int.Parse(TerminalDate.Split('/')[2]);

                DateTime dateTime = calendar.ToDateTime(Year, Month, Day, 0, 0, 0, 0);




                List<Payment> Payments = new List<Payment>();

                foreach (Payment payment in db.PaymentRepository.Get().ToList())
                {

                    DateTime revenuesDate = calendar.ToDateTime(int.Parse(payment.Date.Split('/')[0]), int.Parse(payment.Date.Split('/')[1]), int.Parse(payment.Date.Split('/')[2]), 0, 0, 0, 0);

                    if (revenuesDate >= dateTime)
                    {
                        Payments.Add(payment);
                    }

                }

                int TotalPayments = Payments.Sum(p => p.Price);


                RtlMessageBox.Show($"{TotalPayments} کل مبلغ هزینه : ", "محاسبه انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int TotalPayments = db.PaymentRepository.Get().Sum(p => p.Price);


                RtlMessageBox.Show($"{TotalPayments} کل مبلغ هزینه : ", "محاسبه انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void metroButtonCalculateAllRevenuese_Click(object sender, EventArgs e)
        {


            FormSelectDate frm = new FormSelectDate();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PersianCalendar calendar = new PersianCalendar();
                string TerminalDate = (string)FormsTerminal.TerminalObject;
                int Year = int.Parse(TerminalDate.Split('/')[0]);
                int Month = int.Parse(TerminalDate.Split('/')[1]);
                int Day = int.Parse(TerminalDate.Split('/')[2]);

                DateTime dateTime = calendar.ToDateTime(Year, Month, Day, 0, 0, 0, 0);




                List<Payment> Payments = new List<Payment>();
                List<Revenues> Revenueses = new List<Revenues>();


                foreach (Payment payment in db.PaymentRepository.Get().ToList())
                {

                    DateTime revenuesDate = calendar.ToDateTime(int.Parse(payment.Date.Split('/')[0]), int.Parse(payment.Date.Split('/')[1]), int.Parse(payment.Date.Split('/')[2]), 0, 0, 0, 0);

                    if (revenuesDate >= dateTime)
                    {
                        Payments.Add(payment);
                    }

                }

                foreach (Revenues revenues in db.RevenuesRepository.Get().ToList())
                {

                    DateTime revenuesDate = calendar.ToDateTime(int.Parse(revenues.Date.Split('/')[0]), int.Parse(revenues.Date.Split('/')[1]), int.Parse(revenues.Date.Split('/')[2]), 0, 0, 0, 0);

                    if (revenuesDate >= dateTime)
                    {
                        Revenueses.Add(revenues);
                    }

                }




                int TotalPayments = Payments.Sum(p => p.Price);
                int TotalRevenues = Revenueses.Sum(r => r.Price);

                RtlMessageBox.Show($"{(TotalRevenues - TotalPayments)} کل مبلغ درآمد : ", "محاسبه انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int TotalPayments = db.PaymentRepository.Get().Sum(p => p.Price);
                int TotalRevenues = db.RevenuesRepository.Get().Sum(r => r.Price);

                RtlMessageBox.Show($"{(TotalRevenues - TotalPayments)} کل مبلغ درآمد : ", "محاسبه انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
    }
}
