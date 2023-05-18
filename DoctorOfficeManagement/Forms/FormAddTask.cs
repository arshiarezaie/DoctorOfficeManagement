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
    public partial class FormAddTask : MetroForm
    {
        ActionMaker maker = new ActionMaker();

        UnitOfWorkDB db;


        public FormAddTask()
        {
            db = new UnitOfWorkDB();
            InitializeComponent();
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



        bool IsValidate()
        {
            if (metroTextBoxTaskTitle.Text != string.Empty && metroTextBoxTaskPrice.Text != string.Empty && metroTextBoxTaskDescription.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool Insert()
        {
            if (IsValidate())
            {


                DataLayer.Models.Task task = new DataLayer.Models.Task()
                {
                    Task1 = metroTextBoxTaskTitle.Text,
                    Description = metroTextBoxTaskDescription.Text,
                    Price = int.Parse(metroTextBoxTaskPrice.Text)
                };


                db.TaskRepository.Insert(task);

         

                db.UserActionRepository.Insert(maker.GetAction("افزودن وظیفه پزشک"));




                return db.Save();



            }
            else
            {
                return false;
            }
        }

        private void metroButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Insert())
            {
   

                DialogResult = DialogResult.OK;
            }
        }

        private void metroTextBoxTaskPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
