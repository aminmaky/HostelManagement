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
    public partial class AddDormitoryManagerForm : Form
    {
        public AddDormitoryManagerForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string position = txtPosition.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter both first and last names.");
                return;
            }

            MessageBox.Show("Dormitory manager added successfully.");
            // TODO: Add to data store
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // new DormitoryManagersForm().Show();
            this.Close();
        }
    }
}
