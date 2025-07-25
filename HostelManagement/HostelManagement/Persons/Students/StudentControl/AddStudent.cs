using HostelManagement.Persons.Students;
using HostelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtStudentID.Text) // ||
                // cmbDormitory.SelectedItem == null ||
                // cmbBlock.SelectedItem == null ||
                // !int.TryParse(txtRoom.Text, out int roomNumber)
                )
            {
                MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();
            string idNum = txtNationalID.Text.Trim();
            string telNum = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string studentId = txtStudentID.Text.Trim();
            // Dormitory dorm = cmbDormitory.SelectedItem as Dormitory;
            // Block block = cmbBlock.SelectedItem as Block;

            var student = new Student(firstname, lastname, idNum, telNum, address,
                                      studentId/*, roomNumber, block, dorm, new List<Tools>()*/);

            DATA.Students.Add(student);

            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // new StudentManagementForm().Show();
            this.Hide();
        }
    }
}
