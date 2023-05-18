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
    public partial class FormManageTasks : MetroForm
    {
        UnitOfWorkDB db;
        List<DataLayer.Models.Task> tasks;
        ActionMaker maker = new ActionMaker();
        public FormManageTasks()
        {
            db = new UnitOfWorkDB();
            InitializeComponent();
        }

        void refresh()
        {
            TaskBox.Items.Clear();
            tasks = db.TaskRepository.Get().ToList();
            foreach (var task in tasks)
            {
                TaskBox.Items.Add(task.Task1);
            }
        }


        private void toolStripButtonEraser_Click(object sender, EventArgs e)
        {
            metroTextBoxTaskTitle.Text = string.Empty;
            metroTextBoxTaskDescription.Text = string.Empty;
            metroTextBoxTaskPrice.Text = string.Empty;
        }

        private void metroTextBoxTaskPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormManageTasks_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void TaskBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                metroLabelStatus.Text = tasks[TaskBox.SelectedIndex].DoctorTasks.Count > 0 ? "استفاده شده توسط بیماران" : string.Empty;
                metroTextBoxTaskTitle.Text = tasks[TaskBox.SelectedIndex].Task1;
                metroTextBoxTaskDescription.Text = tasks[TaskBox.SelectedIndex].Description;
                metroTextBoxTaskPrice.Text = tasks[TaskBox.SelectedIndex].Price.ToString();
            }
            catch
            {
               
            }
        }


        bool IsValidateInputs()
        {
            if (metroTextBoxTaskTitle.Text != string.Empty && metroTextBoxTaskDescription.Text != string.Empty && metroTextBoxTaskPrice.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void metroButtonEditTask_Click(object sender, EventArgs e)
        {
            if (IsValidateInputs())
            {
                DataLayer.Models.Task selectedTask = tasks[TaskBox.SelectedIndex];
                selectedTask.Task1 = metroTextBoxTaskTitle.Text;
                selectedTask.Description = metroTextBoxTaskDescription.Text;
                selectedTask.Price = int.Parse(metroTextBoxTaskPrice.Text);

                db.TaskRepository.Update(selectedTask);
                db.UserActionRepository.Insert(maker.GetAction("ویرایش وظیفه پزشک "));
                if (db.Save())
                {
                    refresh();
                }

            }
            else
            {

            }
        }

        bool Delete()
        {
            DataLayer.Models.Task selectedTask = tasks[TaskBox.SelectedIndex];

            foreach (DoctorTask doctortask in selectedTask.DoctorTasks.ToList())
            {
                db.DoctorTaskRepository.Delete(doctortask);
            }
            db.TaskRepository.Delete(selectedTask);
            db.UserActionRepository.Insert(maker.GetAction("جذف وظیفه پزشک"));
            return db.Save();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tasks[TaskBox.SelectedIndex].DoctorTasks.Count > 0)
            {

                DialogResult result = RtlMessageBox.Show("این وظیفه از قبل در پرونده برخی بیماران موجود است با حذف آن از لیست وظایف  پزشک برای بیماران نیز حذف خواهد شد ادامه میدهید ؟", "هشدار مهم", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    if (Delete())
                    {
                        refresh();
                    }
                }

            }
            else
            {
                if (Delete())
                {
                    refresh();
                }
            }


        }

        private void toolStripButtonSelectPerson_Click(object sender, EventArgs e)
        {
            FormAddTask frm = new FormAddTask();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                refresh();
            }
        }
    }
}
