using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Animation;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using MetroFramework.Native;
using MetroFramework.Properties;
using System.Linq.Expressions;
using DataLayer.Models;
using DataLayer.Repository;
using UnitOfWork;
using DoctorOfficeManagement.Classes;
using DoctorOfficeManagement.Classes.ViewModels;

namespace DoctorOfficeManagement.Forms
{

    public partial class FormSelectPerson : MetroForm
    {

        void Refresh(Expression<Func<Person,bool>> where = null)
        {
            List<PersonViewModel> model = new List<PersonViewModel>();

            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {
                foreach (Person person in db.PersonRepository.Get(where))
                {
                    model.Add(new PersonViewModel(person));
                }
            }

            dataGridViewPersons.DataSource = model;

        }



        public FormSelectPerson()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(dataGridViewPersons.CurrentRow.Cells[0].Value.ToString());

            FormsTerminal.ResetTerminalObject();
            FormsTerminal.TerminalObject = Id;
            DialogResult = DialogResult.OK;
        }

        private void FormSelectPerson_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Refresh(p => p.FullName.Contains(toolStripTextBoxSearch.Text) | p.PhoneNumber.Contains(toolStripTextBoxSearch.Text) || p.Email.Contains(toolStripTextBoxSearch.Text) || p.Address.Contains(toolStripTextBoxSearch.Text) || p.Age.ToString().Contains(toolStripTextBoxSearch.Text));

        }
    }
}
