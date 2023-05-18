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
    public partial class FormShowDigitalFiles : MetroForm
    {
        DigitalFile[] digitalfiles;
        void inizializeDigitalFiles()
        {
            for (int i = 0; i < digitalfiles.Length; i++)
            {
                ListViewItem item = new ListViewItem("فایل شماره " + i + 1, 0);
                metroListViewDigitalFiles.Items.Add(item);
            }
        }

        public FormShowDigitalFiles(DigitalFile[] digitalFiles)
        {
            InitializeComponent();
            digitalfiles = digitalFiles;
            inizializeDigitalFiles();
        }

        private void metroListViewDigitalFiles_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (metroListViewDigitalFiles.SelectedItems.Count > 0)
                {
                    string address = Application.StartupPath + digitalfiles[metroListViewDigitalFiles.Items.IndexOf(metroListViewDigitalFiles.SelectedItems[0])].DigitalAddress;
                    System.Diagnostics.Process.Start(address);
                }
            }
            catch
            {

            }


        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
