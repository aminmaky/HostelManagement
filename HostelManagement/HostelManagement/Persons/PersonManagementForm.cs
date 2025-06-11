using HostelManagement.Persons.DormitoryManagers.DormitoryManagersControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.People
{
    public partial class PersonManagementForm : Form
    {
        public PersonManagementForm()
        {
            InitializeComponent();
        }

        private void BtnDormitoryManagers_Click(object sender, EventArgs e)
        {
            new ManageDormitoryManagersForm().Show();
            this.Hide();
        }

        private void BtnBlockManagers_Click(object sender, EventArgs e)
        {
            // new BlockManagersForm().Show();
            this.Hide();
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            new StudentManagementForm().Show();
            this.Hide();
        }

        private void BtnBackToMain_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }
    }
}
