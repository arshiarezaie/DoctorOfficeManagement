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
using DataLayer.Models;
using DataLayer.Repository;
using UnitOfWork;
using DoctorOfficeManagement.Classes;
using System.IO;


namespace DoctorOfficeManagement.Forms
{

    public partial class FormEditVisit : MetroForm
    {
        UnitOfWorkDB db;
        Visit visit;
        DoctorTask[] doctorTasks;
        ActionMaker maker = new ActionMaker();
        public FormEditVisit(int Id)
        {
            db = new UnitOfWorkDB();
            visit = db.VisitRepository.GetByPrimaryKey(Id);
            doctorTasks = visit.DoctorTasks.ToArray();
            InitializeComponent();
        }


        private void FormEditVisit_Load(object sender, EventArgs e)
        {
            PersianCalendar calendar = new PersianCalendar();
            string[] dateSplited = visit.Date.Split('/');
            int DayIndex = int.Parse(dateSplited[2]) - 1;
            int MonthIndex = int.Parse(dateSplited[1]) - 1;
            metroComboBoxDay.SelectedIndex = DayIndex;
            metroComboBoxMonth.SelectedIndex = MonthIndex;
            metroComboBoxYear.SelectedIndex = metroComboBoxYear.Items.IndexOf(dateSplited[0]);

            string[] timeSplited = visit.Time.Split(':');

            bool IsAM = calendar.ToDateTime(int.Parse(dateSplited[0]), int.Parse(dateSplited[1]), int.Parse(dateSplited[2]), int.Parse(timeSplited[0]) , int.Parse(timeSplited[1]),0,0).ToLongTimeString().Contains("AM") ? true : false;

            int HourIndex = int.Parse(timeSplited[0]);

            HourIndex = HourIndex < 12 && !IsAM ? (HourIndex + 12) - 1 : HourIndex - 1;
            int MinutesIndex = int.Parse(timeSplited[1]) - 1;
            metroComboBoxHour.SelectedIndex = HourIndex;
            metroComboBoxMinute.SelectedIndex = MinutesIndex;

            foreach (DoctorTask doctorTask in doctorTasks)
            {
                listBoxDoctortasks.Items.Add(doctorTask.Task.Task1);
            }

        }

        private void metroComboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBoxMonth.SelectedIndex + 1 > 6)
            {
                if (metroComboBoxDay.Items.Count == 31)
                {
                    metroComboBoxDay.Items.RemoveAt(30);
                }
            }

            if (metroComboBoxMonth.SelectedIndex + 1 == 12)
            {
                if (metroComboBoxDay.Items.Count == 30)
                {
                    metroComboBoxDay.Items.RemoveAt(29);
                }

            }

            if (metroComboBoxMonth.SelectedIndex + 1 < 6)
            {
                if (metroComboBoxDay.Items.Count != 31)
                {
                    metroComboBoxDay.Items.Add("31");
                }

            }
        }




        void AssembleObjetsDataAndUpdateVisit()
        {

            visit.Date = metroComboBoxYear.Items[metroComboBoxYear.SelectedIndex] + "/" + (metroComboBoxMonth.SelectedIndex + 1) + "/" + metroComboBoxDay.Items[metroComboBoxDay.SelectedIndex];
            visit.Time = metroComboBoxHour.Items[metroComboBoxHour.SelectedIndex] + ":" + metroComboBoxMinute.Items[metroComboBoxMinute.SelectedIndex];

            db.DoctorTaskRepository.Clear(d=>d.VisistID==visit.ID);
            foreach (DoctorTask doctorTask in doctorTasks)
            {
                DoctorTask localDoctorTask = new DoctorTask()
                {
                    PersonID = visit.PersonID,
                    VisistID = visit.ID,
                    TaskID = doctorTask.TaskID
                };

                db.DoctorTaskRepository.Insert(localDoctorTask);
            }
            db.VisitRepository.Update(visit);
            db.UserActionRepository.Insert(maker.GetAction("ویرایش نوبت بیمار "));
            db.Save();


        }

        private void metroButtonSubmit_Click(object sender, EventArgs e)
        {
            AssembleObjetsDataAndUpdateVisit();
            DialogResult = DialogResult.OK;
        }

        private void metroButtonDeleteTask_Click(object sender, EventArgs e)
        {
            doctorTasks = doctorTasks.Where(d => d.ID != doctorTasks[listBoxDoctortasks.SelectedIndex].ID).ToArray();
            listBoxDoctortasks.Items.RemoveAt(listBoxDoctortasks.SelectedIndex);
        }

        private void metroButtonAddTask_Click(object sender, EventArgs e)
        {

            if (FormsTerminal.TerminalObject != new List<DataLayer.Models.Task>())
            {
                FormsTerminal.ResetTerminalObject();
            }

            FormsTerminal.TerminalObject = new List<DataLayer.Models.Task>();

            FormSelectTask frm = new FormSelectTask();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                foreach (DataLayer.Models.Task item in (List<DataLayer.Models.Task>)FormsTerminal.TerminalObject)
                {
                    DoctorTask doctorTask = new DoctorTask()
                    {
                        PersonID = visit.PersonID,
                        VisistID = visit.ID,
                        TaskID = item.ID
                    };


                    List<DoctorTask> localdoctorTasks = doctorTasks.ToList();
                    localdoctorTasks.Add(doctorTask);
                    doctorTasks = null;
                    doctorTasks= localdoctorTasks.ToArray();
                    listBoxDoctortasks.Items.Add(item.Task1);
                }

            }
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
