using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HostelManagement.Persons.Students
{
    public partial class RegisterStudentForm : Form
    {
        private List<Student> students;
        private List<Dormitory> dormitories;
        private Student FStudent;

        public RegisterStudentForm(Student fStudent)
        {
            InitializeComponent();
            LoadData();
            FStudent = fStudent;
        }

        private void LoadData()
        {
            students = DATA.Students;
            dormitories = DATA.Dormitories;

            // cmbStudent.Items.Clear();
            cmbDormitory.Items.Clear();

            foreach (var s in students)
                cmbStudent.Items.Add(s); // override ToString() in Student if needed

            foreach (var d in dormitories)
                cmbDormitory.Items.Add(d); // override ToString() in Dormitory if needed

            int index = students.IndexOf(FStudent);
            if (index >= 0)
                cmbStudent.SelectedIndex = index;
            else
                cmbStudent.SelectedIndex = -1;
            cmbDormitory.SelectedIndex = -1;
            cmbBlock.Items.Clear();
        }

        private void CmbDormitory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBlock.Items.Clear();
            var selectedDorm = cmbDormitory.SelectedItem as Dormitory;

            if (selectedDorm != null && selectedDorm.Blocks != null)
            {
                foreach (var block in selectedDorm.Blocks)
                    cmbBlock.Items.Add(block);
            }

            cmbBlock.SelectedIndex = -1;
        }


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var student = cmbStudent.SelectedItem as Student;
            var dorm = cmbDormitory.SelectedItem as Dormitory;
            var block = cmbBlock.SelectedItem as Block;
            int roomNumber = (int)numRoom.Value;

            if (student == null || dorm == null || block == null || roomNumber <= 0)
            {
                MessageBox.Show("Please select all fields and enter a valid room number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            student.dormitory = dorm;
            student.Block = block;
            student.Room = roomNumber;

            MessageBox.Show("Student registered to dormitory successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            new StudentManagementForm().Show();
            this.Close();
        }

    }
}
