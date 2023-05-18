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
namespace DoctorOfficeManagement.Forms
{
    public partial class FormSelectFile : MetroForm
    {
        UnitOfWorkDB db;
        Person person;
        List<DataLayer.Models.File> files;
        public FormSelectFile(int? personId = null , bool IsManage=false)
        {
            db = new UnitOfWorkDB();
            InitializeComponent();
            person = personId != null ? db.PersonRepository.GetByPrimaryKey(personId) : null;
            InizializeFormFilesList();
            if (IsManage)
            {
                Text = "میدیرت پرونده های بیمار";
                metroButtonCancel.Visible = false;
                metroButtonSubmit.Visible = false;
                Size = new Size(499, 520);
            }
        }

        void InizializeFormFilesList()
        {
            files = new List<File>();
            files.Clear();
            listBoxFiles.Items.Clear();
            files = person != null ? person.Files.ToList() : db.FileRepository.Get().ToList();

            foreach (DataLayer.Models.File file in files)
            {
                listBoxFiles.Items.Add(file.Title);
            }
        }


        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataLayer.Models.File currentFile = files[listBoxFiles.SelectedIndex];
                metroTextBoxFileTitle.Text = currentFile.Title;
                metroTextBoxFileDescription.Text = currentFile.Description;
                metroButtonShowPDFfiles.Enabled = currentFile.DigitalFiles.Count > 0 ? true : false;
                metroButtonShowFilesImages.Enabled = currentFile.ImagesOfFiles.Count > 0 ? true : false;
            }
            catch
            {

            }

        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void metroButtonShowPDFfiles_Click(object sender, EventArgs e)
        {
            DataLayer.Models.File currentFile = files[listBoxFiles.SelectedIndex];
            FormShowDigitalFiles form = new FormShowDigitalFiles(currentFile.DigitalFiles.ToArray());
            form.ShowDialog();
        }

        private void metroButtonShowFilesImages_Click(object sender, EventArgs e)
        {
            DataLayer.Models.File currentFile = files[listBoxFiles.SelectedIndex];
            FormViewImages form = new FormViewImages(currentFile.ImagesOfFiles.ToArray());
            form.ShowDialog();
        }

        private void metroButtonSubmit_Click(object sender, EventArgs e)
        {
            int Id = files[listBoxFiles.SelectedIndex].ID;
            FormsTerminal.ResetTerminalObject();
            FormsTerminal.TerminalObject = Id;
            DialogResult = DialogResult.OK;
        }



        bool DeleteFile()
        {

            DataLayer.Models.File file = files[listBoxFiles.SelectedIndex];

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

            return db.Save();

        }


        private void metroButtonDeleteFile_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem != null)
            {
                DialogResult result = RtlMessageBox.Show($"ایا از حذف پرونده {listBoxFiles.SelectedItem.ToString()}  اطمینان دارید ؟ با حذف این پرونده فایل ی دی اف و تمام تصاویر نیز حذف خواهند شد ادامه میدهید ؟", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    if (DeleteFile())
                    {
                        metroTextBoxFileTitle.Text = string.Empty;
                        metroTextBoxFileDescription.Text = string.Empty;
                        InizializeFormFilesList();

                    }

                }
            }

        }
    }
}
