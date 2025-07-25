using HostelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HostelManagement.Persons.Students
{
    public partial class TransferStudentForm : Form
    {
        private List<Student> students;
        private List<Dormitory> dormitories;
        private Student FStudent;

        public TransferStudentForm(Student fStudent)
        {
            InitializeComponent();
            FStudent = fStudent;
            LoadData();
        }

        private void LoadData()
        {
            students = DATA.Students;
            dormitories = DATA.Dormitories;

            cmbStudent.Items.Clear();
            cmbDormitory.Items.Clear();
            cmbBlock.Items.Clear();

            foreach (var s in students)
                cmbStudent.Items.Add(s);

            if (FStudent != null)
            {
                int index = students.IndexOf(FStudent);
                if (index >= 0)
                    cmbStudent.SelectedIndex = index;
                else
                    cmbStudent.SelectedIndex = -1;
            }

            foreach (var d in dormitories)
                cmbDormitory.Items.Add(d);

            cmbDormitory.SelectedIndex = -1;
        }


        private void CmbDormitory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBlock.Items.Clear();
            if (cmbDormitory.SelectedItem is Dormitory selectedDorm)
            {
                cmbBlock.Items.AddRange(selectedDorm.Blocks.ToArray());
            }
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
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

            if (student.dormitory == dorm && student.Block == block && student.Room == roomNumber)
            {
                MessageBox.Show("Student is already assigned to the selected room.");
                return;
            }

            student.dormitory = dorm;
            student.Block = block;
            student.Room = roomNumber;

            MessageBox.Show("Student transferred successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new StudentManagementForm().Show();
            this.Close();
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
