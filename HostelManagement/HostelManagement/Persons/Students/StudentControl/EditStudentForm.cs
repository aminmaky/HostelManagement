using HostelManagement.Persons.BlockManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Persons.Students.StudentControl
{
    public partial class EditStudentForm : Form
    {
        private List<Student> allStudents;
        private Student selectedStudent;
        private Student FStudent;

        public EditStudentForm(Student student)
        {
            FStudent = student;
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            allStudents = DATA.Students;

            cmbStudents.Items.Clear();
            foreach (var student in allStudents)
                cmbStudents.Items.Add($"{student.Firstname} {student.Lastname} ({student.StudentId})");
            
            int index = allStudents.IndexOf(FStudent);
            if (index >= 0)
                cmbStudents.SelectedIndex = index;
        }


        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudent = allStudents[cmbStudents.SelectedIndex];

            txtFirstname.Text = selectedStudent.Firstname;
            txtLastname.Text = selectedStudent.Lastname;
            txtIdNum.Text = selectedStudent.IdNum;
            txtTel.Text = selectedStudent.TelNum;
            txtAddress.Text = selectedStudent.Address;
            txtStudentId.Text = selectedStudent.StudentId;
            // txtRoom.Text = selectedStudent.Room.ToString();

            //cmbDormitory.DataSource = null;
            //cmbDormitory.DataSource = DATA.Dormitories;
            //cmbDormitory.DisplayMember = "Name";

            //if (selectedStudent.dormitory != null)
            //    cmbDormitory.SelectedItem = selectedStudent.dormitory;

            // LoadBlocksForDormitory(selectedStudent.dormitory);

            //if (selectedStudent.Block != null)
            //    cmbBlock.SelectedItem = selectedStudent.Block;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                MessageBox.Show("No student selected.");
                return;
            }

            //if (!int.TryParse(txtRoom.Text, out int roomNumber))
            //{
            //    MessageBox.Show("Invalid room number.");
            //    return;
            //}

            selectedStudent.Firstname = txtFirstname.Text;
            selectedStudent.Lastname = txtLastname.Text;
            selectedStudent.IdNum = txtIdNum.Text;
            selectedStudent.TelNum = txtTel.Text;
            selectedStudent.Address = txtAddress.Text;
            selectedStudent.StudentId = txtStudentId.Text;
            // selectedStudent.Room = roomNumber;

            // selectedStudent.dormitory = cmbDormitory.SelectedItem as Dormitory;
            // selectedStudent.Block = cmbBlock.SelectedItem as Block;

            MessageBox.Show("Student information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new StudentManagementForm().Show();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new StudentManagementForm().Show();
            this.Close();
        }
    }
}
