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
    public partial class FormSettings : MetroForm
    {
        UnitOfWorkDB db;
        public FormSettings()
        {
            db = new UnitOfWorkDB();
            InitializeComponent();
        }

        private void metroButtonAddNewUser_Click(object sender, EventArgs e)
        {
            FormRegister frm = new FormRegister();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RtlMessageBox.Show("کاربر جدید با موفقییت ثبت شد ", "انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {

            FormSelectUser frm = new FormSelectUser();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                User user = db.UserRepository.GetByPrimaryKey((string)FormsTerminal.TerminalObject);

                DialogResult result = RtlMessageBox.Show($"ایا از حذف کاربر {user.FullName} اطمینان دارید ؟", "تایید حذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    db.UserRepository.Delete(user);
                    if (db.Save())
                    {
                        RtlMessageBox.Show("کاربر مورد نظر حذف گردید", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        RtlMessageBox.Show("چیزی حذف نشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }


        }

        private void metroButtonEditProfile_Click(object sender, EventArgs e)
        {
            FormEditUser frm = new FormEditUser();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RtlMessageBox.Show("پروفایل شما ویرایش شد ", "انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void metroButtonShowUserInformation_Click(object sender, EventArgs e)
        {
            FormSelectUser frm = new FormSelectUser();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                User user = db.UserRepository.GetByPrimaryKey((string)FormsTerminal.TerminalObject);
                FormViewUser form = new FormViewUser(user);
                form.ShowDialog();

            }
        }

        private void metroButtonInsertVisitPrice_Click(object sender, EventArgs e)
        {
            FormVisitPrice frm = new FormVisitPrice();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RtlMessageBox.Show("مبلغ معاینه ثبت گردید ","انجام شد ",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
    }
}
