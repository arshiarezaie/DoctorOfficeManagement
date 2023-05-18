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
using DoctorOfficeManagement.Classes.ViewModels;
using System.Linq.Expressions;
using System.Data.Entity;
namespace DoctorOfficeManagement.Forms
{
    public partial class FormEditPerson : MetroForm
    {
        UnitOfWorkDB db;
        List<Province> provinces;
        Person person;
        ActionMaker maker = new ActionMaker();
        void InizializeProvinces()
        {

            foreach (Province province in db.ProvinceRepository.Get())
            {
                provinces.Add(province);
                metroComboBoxProvince.Items.Add(province.Province1);
            }


        }

        void InizializeInputsFromPerson()
        {
            metroTextBoxPersonName.Text = person.FullName;
            metroTextBoxPersonPhoneNumber.Text = person.PhoneNumber != null ? person.PhoneNumber : string.Empty;
            metroTextBoxPersonEmail.Text = person.Email;
            metroTextBoxPersonAddress.Text = person.Address != null ? person.Address : string.Empty;
            metroTextBoxPersonAge.Text = person.Age.ToString();


            pictureBoxPersonImage.ImageLocation = !string.IsNullOrEmpty(person.ProfilePicture) && System.IO.File.Exists(person.ProfilePicture)? person.ProfilePicture :Application.StartupPath+ "/Images/Patent.jpg";

            metroComboBoxProvince.SelectedIndex = metroComboBoxProvince.Items.IndexOf(provinces.Where(p => p.ID == person.City.ProvinceID).First().Province1);
            metroComboBoxCity.SelectedIndex = metroComboBoxCity.Items.IndexOf(provinces[metroComboBoxProvince.SelectedIndex].Cities.Where(c => c.ID == person.CityID).First().City1);
        }

        public FormEditPerson(int Id)
        {
            db = new UnitOfWorkDB();
            provinces = new List<Province>();

            person = db.PersonRepository.GetByPrimaryKey(Id);

            InitializeComponent();
        }

        private void FormEditPerson_Load(object sender, EventArgs e)
        {
            InizializeProvinces();
            InizializeInputsFromPerson();
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

        private void metroComboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroComboBoxCity.Items.Clear();

            foreach (City city in provinces[metroComboBoxProvince.SelectedIndex].Cities)
            {
                metroComboBoxCity.Items.Add(city.City1);
            }



        }

        private void metroButtonSelectPersonImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPersonImage.ImageLocation = open.FileName;
            }
        }


        string ChangePicture(string name)
        {
            if (person.ProfilePicture != null)
            {
                System.IO.File.Delete(person.ProfilePicture);
            }

            string extention = System.IO.Path.GetExtension(name);
            string newname = Application.StartupPath + "/FilesAndPersonsImages/" + Guid.NewGuid() + extention;
            System.IO.File.Copy(name, newname);
            person.ProfilePicture = newname;
            return newname;
        }


        bool InizializepersonFrominputsAndInsert()
        {
            person.FullName = metroTextBoxPersonName.Text;
            person.Age = (short)int.Parse(metroTextBoxPersonAge.Text);
            person.Address = metroTextBoxPersonAddress.Text;
            person.Email = metroTextBoxPersonEmail.Text;
            person.PhoneNumber = metroTextBoxPersonPhoneNumber.Text;
            person.ProfilePicture = pictureBoxPersonImage.ImageLocation != Application.StartupPath + "/Images/Patent.jpg" && pictureBoxPersonImage.ImageLocation != person.ProfilePicture ? ChangePicture(pictureBoxPersonImage.ImageLocation) : null;
            person.CityID = provinces[metroComboBoxProvince.SelectedIndex].Cities.ToList()[metroComboBoxCity.SelectedIndex].ID;

            db.PersonRepository.Update(person);
            db.UserActionRepository.Insert(maker.GetAction("ویرایش اطلاعات بیمار "));
            return db.Save();

        }

        private void metroButtonSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = InizializepersonFrominputsAndInsert() ? DialogResult.OK : DialogResult.None;
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
