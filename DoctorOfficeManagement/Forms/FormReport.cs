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
    public partial class FormReport : MetroForm
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void metroButtonReportPersons_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF File |*.PDF";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PDFgenerator generator = new PDFgenerator();
                generator.GeneratePDfPerons(save.FileName);
                RtlMessageBox.Show("فایل گزارش ساخته و در محل مورد نظر شما ذخیره شد ","انجام شد ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF File |*.PDF";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PDFgenerator generator = new PDFgenerator();
                generator.GeneratePDFtasks(save.FileName);
                RtlMessageBox.Show("فایل گزارش ساخته و در محل مورد نظر شما ذخیره شد ", "انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF File |*.PDF";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PDFgenerator generator = new PDFgenerator();
                generator.GeneratePDFVisits(save.FileName);
                RtlMessageBox.Show("فایل گزارش ساخته و در محل مورد نظر شما ذخیره شد ", "انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF File |*.PDF";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PDFgenerator generator = new PDFgenerator();
                generator.GeneratePDFuserActions(save.FileName);
                RtlMessageBox.Show("فایل گزارش ساخته و در محل مورد نظر شما ذخیره شد ", "انجام شد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
