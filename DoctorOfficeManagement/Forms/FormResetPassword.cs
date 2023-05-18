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
    public partial class FormResetPassword : MetroForm
    {
        List<User> users;
        public FormResetPassword()
        {
            InitializeComponent();
        }

        void GetUsers()
        {
            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {
                users = db.UserRepository.Get().ToList();
                foreach (User user in users)
                {
                    UserBox.Items.Add(user.UserName);
                }
            }
        }

        private void FormResetPassword_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void UserBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FormPasswordHint frm = new FormPasswordHint(users[UserBox.SelectedIndex]);
                frm.ShowDialog();
            }
            catch
            {

            }

        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
