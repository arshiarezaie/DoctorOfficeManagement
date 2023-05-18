using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitOfWork;
using DataLayer.Models;
using DataLayer.Repository;
using System.Threading;
namespace DoctorOfficeManagement.Forms
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }


        void Open()
        {
            Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {

                if (db.UserRepository.Get().Count() > 0)
                {

                    FormLogin frm = new FormLogin();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Open();
                    }
                }
                else
                {
                    FormRegister frm = new FormRegister(true);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Open();
                    }

                }
            }
            
        }
    }
}
