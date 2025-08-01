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
            var selectedDorm = cmbDormitory.SelectedItem as Dormitory;

            if (selectedDorm?.Blocks != null)
            {
                foreach (var block in selectedDorm.Blocks)
                    cmbBlock.Items.Add(block);
            }

            cmbBlock.SelectedIndex = -1;
        }
        private void cmbBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoom.Items.Clear();
            var selectedBlock = cmbBlock.SelectedItem as Block;

            if (selectedBlock != null)
            {
                foreach (var room in selectedBlock.Rooms)
                    cmbRoom.Items.Add(room);
            }

            cmbRoom.SelectedIndex = -1;
        }


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var student = FStudent;
            var dorm = cmbDormitory.SelectedItem as Dormitory;
            var block = cmbBlock.SelectedItem as Block;
            var room = cmbRoom.SelectedItem as Room;

            if (dorm == null || block == null || room == null)
            {
                MessageBox.Show("Please select all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (room.IsFull())
            {
                MessageBox.Show("Room is full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            student.Dormitory = dorm;
            student.Block = block;
            student.Room = room;

            MessageBox.Show("Student registered to dormitory successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new StudentManagementForm().Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new StudentManagementForm().Show();
            this.Close();
        }

    }
}
