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
    public partial class FormPasswordHint : MetroForm
    {
        User _user;
        public FormPasswordHint(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void metroButtonSubmit_Click(object sender, EventArgs e)
        {
            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {
                if (_user.PasswordHint.Trim() == metroTextBoxPasswordHint.Text.Trim())
                {
                    Clipboard.SetText(_user.PassWord);
                    RtlMessageBox.Show("کلمه عبور شما در حافظه کپی شد میتوانید به سیستم وارد شوید ", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RtlMessageBox.Show("رمز عبور پشتیبان اشتباه است ", "ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }
    }
}
