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
    public partial class FormVisitPrice : MetroForm
    {
        UnitOfWorkDB db;
        ActionMaker maker = new ActionMaker();
        public FormVisitPrice()
        {
            db = new UnitOfWorkDB();
            InitializeComponent();
        }

        private void FormVisitPrice_Load(object sender, EventArgs e)
        {
            if (db.VisitPriceRepository.Get().Any())
            {
                numericUpDownVisitPrice.Value = db.VisitPriceRepository.Get().First().Price;
            }
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void metroButtonSubmit_Click(object sender, EventArgs e)
        {
            if (numericUpDownVisitPrice.Value != 0)
            {
                VisitPrice visit = new VisitPrice()
                {
                    Price = (int)numericUpDownVisitPrice.Value
                };
                db.VisitPriceRepository.Clear();
                db.VisitPriceRepository.Insert(visit);
                db.UserActionRepository.Insert(maker.GetAction("مبلغ معاینه ثبت شد "));
                DialogResult = db.Save() ? DialogResult.OK : DialogResult.None;
            }
            else
            {
                RtlMessageBox.Show("برای ثبت باید مبلغی وارد نمایید مبلغ نمیتواند صفر باشد ", "مبلغی صفر", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
