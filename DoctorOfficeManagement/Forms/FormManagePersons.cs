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
namespace DoctorOfficeManagement.Forms
{
    public partial class FormManagePersons : MetroForm
    {

        List<PersonViewModel> persons = new List<PersonViewModel>();
        ActionMaker maker = new ActionMaker();
        public FormManagePersons()
        {

            InitializeComponent();
        }

        public void refresh(Expression<Func<Person, bool>> where = null)
        {
            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {
                dataGridViewPersons.DataSource = null;
                dataGridViewPersons.Columns.Clear();
                dataGridViewPersons.Refresh();
                persons.Clear();
                foreach (Person person in db.PersonRepository.Get(where))
                {
                    persons.Add(new PersonViewModel(person));

                }

                dataGridViewPersons.DataSource = persons.ToList();

                dataGridViewPersons.Columns[0].Visible = false;
                dataGridViewPersons.Columns[0].HeaderText = "ایدی";
                dataGridViewPersons.Columns[1].HeaderText = "نام و نام خانوادگی";
                dataGridViewPersons.Columns[2].HeaderText = "شماره تماس";
                dataGridViewPersons.Columns[3].HeaderText = "ایمیل";
                dataGridViewPersons.Columns[4].HeaderText = "ادرس";
                dataGridViewPersons.Columns[5].HeaderText = "سن";
                dataGridViewPersons.Columns[6].HeaderText = "شهر";
                dataGridViewPersons.Columns[7].HeaderText = "استان";
            }


        }


        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void FormManagePersons_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void toolStripButtonEditPerson_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersons.CurrentRow != null)
            {
                int Id = int.Parse(dataGridViewPersons.CurrentRow.Cells[0].Value.ToString());
                FormEditPerson form = new FormEditPerson(Id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    refresh();
                }
            }
            else
            {
                RtlMessageBox.Show("برای ویرایش باید ابتدا بیماری را انتخاب نمایید ", "هیچ بیماری انتخاب نشده", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        bool Delete()
        {

            int Id = int.Parse(dataGridViewPersons.CurrentRow.Cells[0].Value.ToString());

            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {
                Person person = db.PersonRepository.GetByPrimaryKey(Id);


                foreach (DataLayer.Models.File file in person.Files.ToList())
                {

                    foreach (DigitalFile digital in file.DigitalFiles.ToList())
                    {
                        if (System.IO.File.Exists(digital.DigitalAddress))
                        {
                            System.IO.File.Delete(digital.DigitalAddress);
                        }
                        db.DigitalFileRepository.Delete(digital);
                    }

                    foreach (ImagesOfFile image in file.ImagesOfFiles.ToList())
                    {
                        if (System.IO.File.Exists(image.ImageAddress))
                        {
                            System.IO.File.Delete(image.ImageAddress);
                        }

                        db.ImagesOfFileRepository.Delete(image);
                    }

                    db.FileRepository.Delete(file);

                }


                foreach (DoctorTask task in person.DoctorTasks.ToList())
                {
                    db.DoctorTaskRepository.Delete(task);
                }


                foreach (Visit visit in person.Visits.ToList())
                {
                    db.VisitRepository.Delete(visit);
                }


                db.PersonRepository.Delete(person);

                db.UserActionRepository.Insert(maker.GetAction("حذف بیمار "));

                return db.Save();

            }



        }


        private void toolStripButtonDeletePerson_Click(object sender, EventArgs e)
        {

            if (dataGridViewPersons.CurrentRow != null)
            {
                DialogResult result = RtlMessageBox.Show($"ایا از حذف {dataGridViewPersons.CurrentRow.Cells[1].Value} اطمینان دارید ؟ با حذف بمار تمام پرونده ها نوبت هاو تصاویر و اطلاعات مربوط به بیمار ازبین میرود ادامه میدهید ؟ ", "اطمینان از حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Delete())
                    {
                        refresh();
                    }

                }

            }

        }


        void Search()
        {

            refresh(p=>p.FullName.Contains(toolStripTextBoxSearch.Text) || p.PhoneNumber.Contains(toolStripTextBoxSearch.Text) || p.Address.Contains(toolStripTextBoxSearch.Text) || p.Age.ToString().Contains(toolStripTextBoxSearch.Text));


        }


        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {

            Search();


        }
    }
}
