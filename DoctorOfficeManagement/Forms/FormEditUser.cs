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
    public partial class FormEditUser : MetroForm
    {
        User user;

        public FormEditUser()
        {
            InitializeComponent();
        }


        void InizializeUser()
        {
            user = Identity.User;
            metroTextBoxFullName.Text = user.FullName;
            metroTextBoxEmail.Text = user.Email;
            metroTextBoxPassword.Text = user.PassWord;
            metroTextBoxPassWordHint.Text = user.PasswordHint;
            metroTextBoxPhoneNumber.Text = user.PhoneNumber;
        }

        bool IsValidInputs()
        {

            if (metroTextBoxFullName.Text != string.Empty && metroTextBoxEmail.Text != string.Empty && metroTextBoxPassword.Text != string.Empty && metroTextBoxPassWordHint.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        bool update()
        {
         
                using (UnitOfWorkDB db = new UnitOfWorkDB())
                {

                    user.FullName = metroTextBoxFullName.Text.Trim();
                    user.Email = metroTextBoxEmail.Text.Trim();
                    user.PassWord = metroTextBoxPassword.Text.Trim();
                    user.PasswordHint = metroTextBoxPassWordHint.Text.Trim();

                    db.UserRepository.Update(user);

                    return db.Save();
                }
  

        }


        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void metroButtonSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidInputs())
            {
                DialogResult = update() ? DialogResult.OK : DialogResult.None;
            }
            else
            {
                RtlMessageBox.Show("اطلاعات ورودی ناقص است ","اطلاعات ناقص",MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            
            }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            InizializeUser();
        }
    }
}
