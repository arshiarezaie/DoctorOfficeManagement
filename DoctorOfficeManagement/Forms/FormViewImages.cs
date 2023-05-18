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
    public partial class FormViewImages : MetroForm
    {
        ImagesOfFile[] Images;
        int Index = default(int);
        void InizializeImages()
        {

            pictureBoxImages.ImageLocation =  Images[Index].ImageAddress;

        }

        void Next()
        {
            if (Index < (Images.Length-1))
            {
                Index++;
                InizializeImages();
            }

        }
        void Previews()
        {
            if (Index > 0)
            {
                Index--;
                InizializeImages();
            }

        }

        public FormViewImages(ImagesOfFile[] images)
        {
            InitializeComponent();
            Images = images;
        }

        private void FormViewImages_Load(object sender, EventArgs e)
        {
            InizializeImages();
        }

        private void metroButtonPreviews_Click(object sender, EventArgs e)
        {
            Previews();
        }

        private void metroButtonNext_Click(object sender, EventArgs e)
        {
            Next();
        }
    }
}
