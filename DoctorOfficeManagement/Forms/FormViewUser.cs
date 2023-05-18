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
    public partial class FormViewUser : MetroForm
    {
        User _user;

        public FormViewUser(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void metroButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        void InizializeComponentsValue()
        {
            metroTextBoxFullName.Text = _user.FullName;
            metroTextBoxUserName.Text = _user.UserName;
            metroTextBoxEmail.Text = _user.Email;
            metroTextBoxPhoneNumber.Text = _user.PhoneNumber;
        }

        private void FormViewUser_Load(object sender, EventArgs e)
        {
            InizializeComponentsValue();
        }
    }
}
