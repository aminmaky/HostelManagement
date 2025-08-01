using HostelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static HostelManagement.Student;

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

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            var student = cmbStudent.SelectedItem as Student;
            var dorm = cmbDormitory.SelectedItem as Dormitory;
            var block = cmbBlock.SelectedItem as Block;
            var room = cmbRoom.SelectedItem as Room;

            
            if (student == null || dorm == null || block == null || room == null)
            {
                MessageBox.Show("Please select all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (student.Dormitory == dorm && student.Block == block && student.Room == room)
            {
                MessageBox.Show("Student is already assigned to the selected room.");
                return;
            }
            
            if (room.IsFull())
            {
                MessageBox.Show("Room is full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Save current location before transfer
            if (student.Room != null && student.Block != null && student.Dormitory != null)
            {
                student.HousingHistory.Add(new HousingRecord(
                    room: ((int)student.Room.RoomNum).ToString(),
                    dormitory: student.Dormitory.Name,
                    block: student.Block.Name
                ));
            }

            student.Dormitory = dorm;
            student.Block = block;
            student.Room = room;

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
