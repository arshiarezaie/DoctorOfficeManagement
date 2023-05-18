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
    public partial class FormAddVisit : MetroForm
    {
        ActionMaker maker = new ActionMaker();
        UnitOfWorkDB db;
        List<Province> provinces = new List<Province>();

        string[] FileImages;
        Person person;
        DataLayer.Models.File file;

        List<DataLayer.Models.Task> tasks = new List<DataLayer.Models.Task>();


        public FormAddVisit()
        {
            db = new UnitOfWorkDB();
            InitializeComponent();
        }


        DateTime strToDateTime(string Date, string Time)
        {
            PersianCalendar calendar = new PersianCalendar();
            DateTime dateTime = calendar.ToDateTime(int.Parse(Date.Split('/')[0]), int.Parse(Date.Split('/')[1]), int.Parse(Date.Split('/')[2]), int.Parse(Time.Split(':')[0]), int.Parse(Time.Split(':')[1]), 0, 0);
            return dateTime;
        }



        void LoadPersonFromID(int Id)
        {
            person = db.PersonRepository.GetByPrimaryKey(Id);
            metroTextBoxPersonName.Enabled = false;
            metroTextBoxPersonPhoneNumber.Enabled = false;
            metroTextBoxPersonEmail.Enabled = false;
            metroTextBoxPersonAge.Enabled = false;
            metroTextBoxPersonAddress.Enabled = false;
            metroComboBoxProvince.Enabled = false;
            metroComboBoxCity.Enabled = false;
            metroTextBoxFileTitle.Enabled = false;
            metroTextBoxFileDescription.Enabled = false;
            metroButtonSelectPersonImage.Enabled = false;

            pictureBoxPersonImage.ImageLocation = person.ProfilePicture != null ? person.ProfilePicture : Application.StartupPath + "/Images/Patent.jpg";

            metroTextBoxPersonName.Text = person.FullName;
            metroTextBoxPersonPhoneNumber.Text = person.PhoneNumber;
            metroTextBoxPersonEmail.Text = person.Email;
            metroTextBoxPersonAge.Text = person.Age.ToString();
            metroTextBoxPersonAddress.Text = person.Address;
            metroComboBoxProvince.SelectedIndex = provinces.IndexOf(provinces.Where(p => p.ID == person.City.ProvinceID).First());
            metroComboBoxCity.Items.Clear();

            foreach (City city in db.CityRepository.Get(c => c.ProvinceID == person.City.ProvinceID))
            {
                metroComboBoxCity.Items.Add(city.City1);
            }


            metroComboBoxCity.SelectedIndex = metroComboBoxCity.Items.IndexOf(person.City.City1);



            file = person.Files.FirstOrDefault();
            if (file != default(DataLayer.Models.File))
            {
                metroTextBoxFileTitle.Text = file.Title;
                metroTextBoxFileDescription.Text = file.Description;
                metroButtonBrowseFile.Enabled = true;

            }





        }


        void ClearFormComponenetsAndDeletePerson()
        {
            person = null;
            file = null;
            metroTextBoxPersonName.Enabled = true;
            metroTextBoxPersonPhoneNumber.Enabled = true;
            metroTextBoxPersonEmail.Enabled = true;
            metroTextBoxPersonAge.Enabled = true;
            metroTextBoxPersonAddress.Enabled = true;
            metroComboBoxProvince.Enabled = true;
            metroComboBoxCity.Enabled = true;
            metroTextBoxFileTitle.Enabled = true;
            metroTextBoxFileDescription.Enabled = true;
            metroButtonBrowseFile.Enabled = false;

            metroButtonSelectPersonImage.Enabled = true;
            pictureBoxPersonImage.ImageLocation = Application.StartupPath + "/Images/Patent.jpg";


            metroTextBoxPersonName.Text = string.Empty;
            metroTextBoxPersonPhoneNumber.Text = string.Empty;
            metroTextBoxPersonEmail.Text = string.Empty;
            metroTextBoxPersonAge.Text = string.Empty;
            metroTextBoxPersonAddress.Text = string.Empty;
            metroTextBoxFileTitle.Text = string.Empty;
            metroTextBoxFileDescription.Text = string.Empty;

        }



        void ClearFormFilds()
        {
            metroComboBoxCity.Items.Clear();
            pictureBoxPersonImage.ImageLocation = Application.StartupPath + "/Images/Patent.jpg";
            metroComboBoxDay.SelectedItem = null;
            metroComboBoxMonth.SelectedItem = null;
            metroComboBoxYear.SelectedItem = null;
            metroComboBoxHour.SelectedItem = null;
            metroComboBoxMinute.SelectedItem = null;
            FileImages = null;
            listBoxTasks.Items.Clear();
            tasks.Clear();
            FormsTerminal.TerminalObject = tasks;
            ClearFormComponenetsAndDeletePerson();
        }





        string SavePersonProfilePicture()
        {

            string _File = pictureBoxPersonImage.ImageLocation;
            string name = Path.GetFileName(_File);
            string extenion = Path.GetExtension(name);
            name = Guid.NewGuid() + extenion;

            string path = Application.StartupPath + "/FilesAndPersonsImages/" + name;

            pictureBoxPersonImage.Image.Save(path);

            return path;
        }



        void InizializeProvinces()
        {

            foreach (Province province in db.ProvinceRepository.Get())
            {
                provinces.Add(province);
                metroComboBoxProvince.Items.Add(province.Province1);
            }

        }

        void SetDateTimeNow()
        {
            PersianCalendar calendar = new PersianCalendar();
            string year = calendar.GetYear(DateTime.Now).ToString();
            metroComboBoxYear.SelectedIndex = metroComboBoxYear.Items.IndexOf(year);
            int month = int.Parse(calendar.GetMonth(DateTime.Now).ToString());
            metroComboBoxMonth.SelectedIndex = (month - 1);
            if (month > 6)
            {
                metroComboBoxMonth.Items.RemoveAt(30);
                if (month == 12)
                {
                    metroComboBoxMonth.Items.RemoveAt(29);
                }
            }

            int day = int.Parse(calendar.GetDayOfMonth(DateTime.Now).ToString());
            metroComboBoxDay.SelectedIndex = (day - 1);
            bool IsAM = DateTime.Now.ToLongTimeString().Contains("AM") ? true : false;
            int hour = int.Parse(calendar.GetHour(DateTime.Now).ToString());
            hour = hour < 12 && !IsAM ? hour + 12 : hour;
            metroComboBoxHour.SelectedIndex = (hour - 1);

            int minute = int.Parse(calendar.GetMinute(DateTime.Now).ToString());
            metroComboBoxMinute.SelectedIndex = (minute - 1);

        }

        void InzializeObjectFromThisComponnetsDataAndInsert()
        {

            if (person == null)
            {
                person = new Person()
                {
                    FullName = metroTextBoxPersonName.Text,
                    Email = metroTextBoxPersonEmail.Text,
                    Address = metroTextBoxPersonAddress.Text,
                    Age = Convert.ToInt16(metroTextBoxPersonAge.Text),
                    PhoneNumber = metroTextBoxPersonPhoneNumber.Text,
                    ProfilePicture = pictureBoxPersonImage.ImageLocation == Application.StartupPath + "/Images/Patent.jpg" ? null : SavePersonProfilePicture(),
                    CityID = provinces[metroComboBoxProvince.SelectedIndex].Cities.ToList()[metroComboBoxCity.SelectedIndex].ID

                };

                db.PersonRepository.Insert(person);
            }

            Visit visit = new Visit()
            {
                Person = person,
                Date = metroComboBoxYear.Items[metroComboBoxYear.SelectedIndex] + "/" + (metroComboBoxMonth.SelectedIndex + 1) + "/" + metroComboBoxDay.Items[metroComboBoxDay.SelectedIndex],
                IsFailed = false,
                Time = metroComboBoxHour.Items[metroComboBoxHour.SelectedIndex] + ":" + metroComboBoxMinute.Items[metroComboBoxMinute.SelectedIndex]
            };

            db.VisitRepository.Insert(visit);

            if (tasks.Count > 0)
            {


                foreach (DataLayer.Models.Task task in tasks)
                {
                    DoctorTask doctorTask = new DoctorTask()
                    {
                        TaskID = task.ID,
                        Person = person,
                        Visit = visit
                    };
                    db.DoctorTaskRepository.Insert(doctorTask);
                }


            }
            if (file == null)
            {
                file = new DataLayer.Models.File()
                {
                    Title = metroTextBoxFileTitle.Text,
                    Description = metroTextBoxFileDescription.Text,
                    Person = person
                };


                PDFgenerator generator = new PDFgenerator();

                DigitalFile digitalfile = new DigitalFile()
                {
                    File = file,
                    DigitalAddress = generator.GeneratePDfFile(person, file, visit, tasks, FileImages)
                };

                db.FileRepository.Insert(file);

                db.DigitalFileRepository.Insert(digitalfile);

                if (FileImages != null)
                {
                    foreach (string imagePath in FileImages)
                    {
                        ImagesOfFile image = new ImagesOfFile()
                        {
                            ImageAddress = imagePath,
                            File = file
                        };
                        db.ImagesOfFileRepository.Insert(image);
                    }
                }
            }





            db.UserActionRepository.Insert(maker.GetAction("درج نوبت جدید"));



            



            if (db.Save())
            {



                RtlMessageBox.Show("نوبت ثبت شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RtlMessageBox.Show("نوبت ثبت نشد", "ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        string getPersianDateNow()
        {
            PersianCalendar calendar = new PersianCalendar();
            string date = calendar.GetYear(DateTime.Now) + "/" + calendar.GetMonth(DateTime.Now) + "/" + calendar.GetDayOfMonth(DateTime.Now);
            return date;
        }


        private void FormAddVisit_Load(object sender, EventArgs e)
        {
            InizializeProvinces();
        }

        private void metroComboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroComboBoxCity.Items.Clear();
            foreach (City city in provinces[metroComboBoxProvince.SelectedIndex].Cities)
            {
                metroComboBoxCity.Items.Add(city.City1);
            }

        }

        private void metroButtonAddTask_Click(object sender, EventArgs e)
        {

            if (FormsTerminal.TerminalObject != new List<DataLayer.Models.Task>())
            {
                FormsTerminal.ResetTerminalObject();
            }

            FormsTerminal.TerminalObject = tasks;

            FormSelectTask form = new FormSelectTask();
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshTaskList();
            }
        }

        private void RefreshTaskList()
        {
            listBoxTasks.Items.Clear();
            foreach (DataLayer.Models.Task task in (List<DataLayer.Models.Task>)FormsTerminal.TerminalObject)
            {
                listBoxTasks.Items.Add(task.Task1);
            }
        }

        bool IsValidateInputs()
        {

            if (metroTextBoxPersonName.Text != string.Empty && metroTextBoxPersonEmail.Text != string.Empty && metroTextBoxPersonAddress.Text != string.Empty && metroTextBoxPersonAge.Text != string.Empty && metroTextBoxFileTitle.Text != string.Empty && metroTextBoxFileDescription.Text != string.Empty && metroComboBoxCity.SelectedItem != null && metroComboBoxProvince.SelectedItem != null && metroComboBoxMinute.SelectedItem != null && metroComboBoxHour.SelectedItem != null && metroComboBoxDay.SelectedItem != null && metroComboBoxMonth.SelectedItem != null && metroComboBoxYear.SelectedItem != null)
            {
                metroTextBoxPersonName.UseStyleColors = false;
                metroTextBoxPersonEmail.UseStyleColors = false;
                metroTextBoxPersonAddress.UseStyleColors = false;
                metroTextBoxPersonAge.UseStyleColors = false;
                metroTextBoxFileTitle.UseStyleColors = false;
                metroTextBoxFileDescription.UseStyleColors = false;
                metroComboBoxCity.UseStyleColors = false;
                metroComboBoxProvince.UseStyleColors = false;
                metroComboBoxMinute.UseStyleColors = false;
                metroComboBoxHour.UseStyleColors = false;
                metroComboBoxDay.UseStyleColors = false;
                metroComboBoxMonth.UseStyleColors = false;
                metroComboBoxYear.UseStyleColors = false;

                return true;
            }
            else
            {
                metroTextBoxPersonName.UseStyleColors = true;
                metroTextBoxPersonEmail.UseStyleColors = true;
                metroTextBoxPersonAddress.UseStyleColors = true;
                metroTextBoxPersonAge.UseStyleColors = true;
                metroTextBoxFileTitle.UseStyleColors = true;
                metroTextBoxFileDescription.UseStyleColors = true;
                metroComboBoxCity.UseStyleColors = true;
                metroComboBoxProvince.UseStyleColors = true;
                metroComboBoxMinute.UseStyleColors = true;
                metroComboBoxHour.UseStyleColors = true;
                metroComboBoxDay.UseStyleColors = true;
                metroComboBoxMonth.UseStyleColors = true;
                metroComboBoxYear.UseStyleColors = true;

                metroTextBoxPersonName.Style = MetroColorStyle.Red;
                metroTextBoxPersonEmail.Style = MetroColorStyle.Red;
                metroTextBoxPersonAddress.Style = MetroColorStyle.Red;
                metroTextBoxPersonAge.Style = MetroColorStyle.Red;
                metroTextBoxFileTitle.Style = MetroColorStyle.Red;
                metroTextBoxFileDescription.Style = MetroColorStyle.Red;
                metroComboBoxCity.Style = MetroColorStyle.Red;
                metroComboBoxProvince.Style = MetroColorStyle.Red;
                metroComboBoxMinute.Style = MetroColorStyle.Red;
                metroComboBoxHour.Style = MetroColorStyle.Red;
                metroComboBoxDay.Style = MetroColorStyle.Red;
                metroComboBoxMonth.Style = MetroColorStyle.Red;
                metroComboBoxYear.Style = MetroColorStyle.Red;


                return false;
            }

        }

        private void metroButtonAddVisit_Click(object sender, EventArgs e)
        {

            if (IsValidateInputs())
            {
                string SelectedDate = metroComboBoxYear.Items[metroComboBoxYear.SelectedIndex] + "/" + (metroComboBoxMonth.SelectedIndex + 1) + "/" + metroComboBoxDay.Items[metroComboBoxDay.SelectedIndex].ToString();
                string SelectedTime = metroComboBoxHour.Items[metroComboBoxHour.SelectedIndex] + ":" + metroComboBoxMinute.Items[metroComboBoxMinute.SelectedIndex].ToString();

                if (!db.VisitRepository.Get(v => v.Date == SelectedDate && v.Time == SelectedTime).Any() && strToDateTime(SelectedDate, SelectedTime) >= (DateTime.Now.Add(new TimeSpan(0,-1,0))))
                {
                    InzializeObjectFromThisComponnetsDataAndInsert();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("خطایی رخ داده ممکن است در بازه زمانی انتخاب شده نوبتی ثبت شده باشد یا بازه زمانی انتخاب شده مربوط به زمان گذشته باشد که در این صورت امکان درج نوبت در این بازه مقدور نمیباشد ", "بازه زمانی پر یا تاریخ گذشته است  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                RtlMessageBox.Show("ورودی های اجباری را پر نمایید ", "اطلاعات ناقص ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void metroButtonSelectPersonImage_Click(object sender, EventArgs e)
        {
            if (metroButtonSelectPersonImage.BackColor == Color.FromArgb(128, 255, 255))
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPersonImage.ImageLocation = open.FileName;
                    metroButtonSelectPersonImage.BackColor = Color.FromArgb(255, 128, 128);
                    metroButtonSelectPersonImage.Text = "حذف عکس انتخاب شده";
                }

            }
            else
            {
                metroButtonSelectPersonImage.BackColor = Color.FromArgb(128, 255, 255);
                metroButtonSelectPersonImage.Text = "انتخاب عکس بیمار";
                pictureBoxPersonImage.ImageLocation = Application.StartupPath + "/Images/Patent.jpg";

            }



        }

        private void metroButtonDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {

                tasks.Remove(tasks[listBoxTasks.SelectedIndex]);

                FormsTerminal.TerminalObject = tasks;
                RefreshTaskList();
            }
            else
            {
                RtlMessageBox.Show("لطفا در صورت نیاز به حذف وظیفه موردی را انتخاب نمایید ", "هیچ موردی انتخاب نشده است ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroButtonDeleteAllTasks_Click(object sender, EventArgs e)
        {

            DialogResult result = RtlMessageBox.Show("از حذف تمام وظیفه های پزشک اطمینان دارید ؟  در این صورت تنها هزینه معاینه برای بیمار در نظر گرفته میشود ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                tasks.Clear();
                FormsTerminal.TerminalObject = tasks;
                RefreshTaskList();
            }

        }

        private void metroButtonSelectFileImages_Click(object sender, EventArgs e)
        {
            if (metroButtonSelectFileImages.BackColor == Color.FromArgb(128, 255, 255))
            {

                OpenFileDialog open = new OpenFileDialog();
                open.Multiselect = true;
                open.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    metroButtonSelectFileImages.BackColor = Color.FromArgb(255, 128, 128);
                    metroButtonSelectFileImages.Text = "حذف عکس های انتخاب شده پرونده";
                    FileImages = new string[open.FileNames.Count()];

                    for (int i = 0; i < open.FileNames.Count(); i++)
                    {

                        string file = open.FileNames[i];
                        string newFileName = Guid.NewGuid().ToString();
                        System.IO.File.Copy(file, Application.StartupPath + "/FilesAndPersonsImages/" + newFileName + Path.GetExtension(file));
                        FileImages[i] = Application.StartupPath + "/FilesAndPersonsImages/" + newFileName + Path.GetExtension(file);
                    }

                }
            }
            else
            {
                FileImages = null;
                metroButtonSelectFileImages.BackColor = Color.FromArgb(128, 255, 255);
                metroButtonSelectFileImages.Text = "انتخاب تصویر یا تصاویر مربوط به پروند";
            }





        }

        private void toolStripButtonSelectPerson_Click(object sender, EventArgs e)
        {
            FormSelectPerson form = new FormSelectPerson();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPersonFromID((int)FormsTerminal.TerminalObject);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ClearFormComponenetsAndDeletePerson();
        }

        private void toolStripButtonEraser_Click(object sender, EventArgs e)
        {
            ClearFormFilds();
        }

        private void metroButtonBrowseFile_Click(object sender, EventArgs e)
        {
            FormSelectFile form = new FormSelectFile(person.ID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                file = db.FileRepository.GetByPrimaryKey((int)FormsTerminal.TerminalObject);
                metroTextBoxFileTitle.Text = file.Title;
                metroTextBoxFileDescription.Text = file.Description;
                metroButtonSelectFileImages.Enabled = false;
            }
        }

        private void metroButtonDeleteFile_Click(object sender, EventArgs e)
        {
            file = null;
            metroTextBoxFileTitle.Text = string.Empty;
            metroTextBoxFileDescription.Text = string.Empty;
            metroButtonSelectFileImages.Enabled = true;
            if (person != null)
            {
                metroButtonBrowseFile.Enabled = true;
                metroTextBoxFileTitle.Enabled = true;
                metroTextBoxFileDescription.Enabled = true;
            }
            else
            {
                metroButtonBrowseFile.Enabled = false;
            }
        }

        private void metroButtonSetDateTimeNow_Click(object sender, EventArgs e)
        {
            SetDateTimeNow();
        }

        private void metroComboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBoxMonth.SelectedIndex + 1 > 6)
            {
                metroComboBoxDay.Items.RemoveAt(30);
            }
            else
            {
                if (metroComboBoxDay.Items.Count == 30)
                {
                    metroComboBoxDay.Items.Add("31");
                }

            }
            if (metroComboBoxMonth.SelectedIndex + 1 == 12)
            {
                metroComboBoxDay.Items.RemoveAt(29);
            }
        }

        private void metroTextBoxPersonAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroTextBoxPersonPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
