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
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void metroButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {
                User user = db.UserRepository.Get(u => u.UserName == metroTextBoxUserName.Text.Trim() && u.PassWord == metroTextBoxPassword.Text.Trim()).FirstOrDefault();
                if (user != null)
                {
                    Identity.User = user;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("نام کاربری و یا رمز عبور نادرست میباشد ", "اطلاعات نادرست", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroButtonResetPassword_Click(object sender, EventArgs e)
        {
            FormResetPassword frm = new FormResetPassword();
            frm.ShowDialog();
        }
    }
}
