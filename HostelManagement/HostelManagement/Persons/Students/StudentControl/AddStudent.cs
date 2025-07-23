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
            // Basic validation (optional)
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and save student
            /*
            Student student = new Student(txtFirstName.Text, txtLastName.Text, txtStudentID.Text, txtNationalID.Text,
            string address, string StudentId, int Room, int Block, int dormitory, List < Tools > tool);
            {
                FirstName = ,
                LastName = ,
                StudentID = ,
                NationalID = ,
                Phone = ,
                Address = txtAddress.Text
            };

            DATA.Students.Add(student);
            */
            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            new StudentManagementForm().Show();
            this.Hide();
        }
    }
}
