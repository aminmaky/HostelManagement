using System;
using HostelManagement.Persons.DormitoryManagers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Persons.DormitoryManagers.DormitoryManagersControl
{
    public partial class AddDormitoryManagerForm : Form
    {
        int Index;
        public AddDormitoryManagerForm(int index)
        {
            Index = index;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string position = txtPosition.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string IDnum = txtIDNum.Text.Trim();


            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(position))
            {
                MessageBox.Show("Please enter first name , last name and Position.");
                return;
            }
            MessageBox.Show("Dormitory manager added successfully.");
            DormitoryManager NewDormitoryManager = new DormitoryManager(firstName, lastName, IDnum, phone, address, position);
            DATA.DormitoryManagers.Insert(Index, NewDormitoryManager);
            new ManageDormitoryManagersForm().Show();
            this.Close();
            // TODO: Add to data store
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new ManageDormitoryManagersForm().Show();
            this.Close();
        }
    }
}
