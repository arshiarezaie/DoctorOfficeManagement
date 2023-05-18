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
    public partial class FormRegister : MetroForm
    {
        bool _isAdmin;
        public FormRegister(bool IsAdmin = false)
        {
            _isAdmin = IsAdmin;
            InitializeComponent();
        }

        bool IsValidInputs()
        {
            if (metroTextBoxUserName.Text != string.Empty && metroTextBoxEmail.Text != string.Empty && metroTextBoxFullName.Text != string.Empty && metroTextBoxPhoneNumber.Text != string.Empty && metroTextBoxPassword.Text != string.Empty && metroTextBoxPassWordHint.Text != string.Empty)
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
            if (IsValidInputs())
            {
                using (UnitOfWorkDB db = new UnitOfWorkDB())
                {
                    if (!db.UserRepository.Get(u => u.UserName == metroTextBoxUserName.Text && u.Email == metroTextBoxEmail.Text).Any())
                    {
                        User user = new User()
                        {
                            UserName = metroTextBoxUserName.Text.Trim(),
                            Email = metroTextBoxEmail.Text,
                            FullName = metroTextBoxFullName.Text,
                            PhoneNumber = metroTextBoxPhoneNumber.Text,
                            PassWord = metroTextBoxPassword.Text.Trim(),
                            IsAdmin = _isAdmin,
                            PasswordHint = metroTextBoxPassWordHint.Text.Trim()
                        };
                        db.UserRepository.Insert(user);
                        if (db.Save())
                        {
                            Identity.User = _isAdmin ? user : Identity.User;
                            DialogResult = DialogResult.OK;
                        }

                    }
                    else
                    {
                        RtlMessageBox.Show("این نام کاربری یا ایمیل از قبل استفاده شده است ", "اطلاعات تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("اطلاعات ورودی کامل نیست لطفا همه فیلد هارا پر نمایید ", "اطلاعات ناقص", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void metroTextBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroButtonClose_Click(object sender, EventArgs e)
        {
            if (_isAdmin)
            {
                Application.Exit();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }

        }
    }
}
