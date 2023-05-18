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
using DataLayer.Models;
using DataLayer.Repository;
using UnitOfWork;
using DoctorOfficeManagement.Classes;

namespace DoctorOfficeManagement.Forms
{
    public partial class FormSelectTask : MetroForm
    {
        List<DataLayer.Models.Task> tasks = new List<DataLayer.Models.Task>();
        public FormSelectTask()
        {
            InitializeComponent();
        }

        private void FormSelectTask_Load(object sender, EventArgs e)
        {
            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {
                tasks = db.TaskRepository.Get().ToList();
            }

            foreach (DataLayer.Models.Task task in tasks)
            {
                TaskBox.Items.Add(task.Task1);
            }


        }

        private void TaskBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                metroTextBoxTaskTitle.Text = tasks[TaskBox.SelectedIndex].Task1;
                metroTextBoxTaskDescription.Text = tasks[TaskBox.SelectedIndex].Description;
                metroTextBoxTaskPrice.Text = tasks[TaskBox.SelectedIndex].Price.ToString();
            }
            catch
            {
               
            }


        }

        private void metroButtonSubmit_Click(object sender, EventArgs e)
        {

            List<DataLayer.Models.Task> localtasks = (List<DataLayer.Models.Task>)FormsTerminal.TerminalObject;

            localtasks.Add(tasks[TaskBox.SelectedIndex]);

            DialogResult = DialogResult.OK;
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
