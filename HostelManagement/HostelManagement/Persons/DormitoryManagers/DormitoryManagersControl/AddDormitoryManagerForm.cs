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

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1);
                txtPhone.SelectionStart = txtPhone.Text.Length;
            }
        }

        private void txtIDNum_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIDNum.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtIDNum.Text = txtIDNum.Text.Remove(txtIDNum.Text.Length - 1);
                txtIDNum.SelectionStart = txtIDNum.Text.Length;
            }
        }
    }
}
