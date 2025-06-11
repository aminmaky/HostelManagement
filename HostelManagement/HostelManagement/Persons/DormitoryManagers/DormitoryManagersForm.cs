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
    public partial class DormitoryManagersForm : Form
    {
        public DormitoryManagersForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Dormitory Manager clicked.");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Dormitory Manager clicked.");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Dormitory Manager clicked.");
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Dormitory Managers clicked.");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new PersonManagementForm().Show();
            this.Hide();
        }
    }
}
