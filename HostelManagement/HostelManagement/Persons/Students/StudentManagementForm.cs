using HostelManagement.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Persons.Students
{
    public partial class StudentManagementForm : Form
    {
        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private List<Student> students = new List<Student>();

        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            // Load students from database or storage
            LoadStudents();
        }

        private void LoadStudents()
        {
            lstStudents.Items.Clear();
            foreach (var student in students)
            {
                // lstStudents.Items.Add($"{student.FullName} - {student.StudentNumber}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddStudent().Show();
            this.Hide();
            //var form = new AddStudentForm();
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    students.Add(form.NewStudent);
            //    LoadStudents();
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }

            var student = students[lstStudents.SelectedIndex];
            //var form = new EditStudentForm(student);
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    students[lstStudents.SelectedIndex] = form.UpdatedStudent;
            //    LoadStudents();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                students.RemoveAt(lstStudents.SelectedIndex);
                LoadStudents();
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student to view.");
                return;
            }

            var student = students[lstStudents.SelectedIndex];
            // MessageBox.Show(student.GetFullDetails(), "Student Details");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();
            //var results = students.Where(s =>
            //    s.FullName.ToLower().Contains(query) ||
            //    s.StudentNumber.ToLower().Contains(query)).ToList();

            //lstStudents.Items.Clear();
            //foreach (var student in results)
            //{
            //    lstStudents.Items.Add($"{student.FullName} - {student.StudentNumber}");
            //}
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student to register.");
                return;
            }

            var student = students[lstStudents.SelectedIndex];
            //var form = new RegisterStudentForm(student);
            //form.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student to transfer.");
                return;
            }

            var student = students[lstStudents.SelectedIndex];
            //var form = new TransferStudentForm(student);
            //form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new PersonManagementForm().Show();
            this.Close();
        }











        /*
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            new AddStudent().Show();
            this.Hide();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnViewStudentInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignDorm_Click(object sender, EventArgs e)
        {

        }

        private void btnTransferStudent_Click(object sender, EventArgs e)
        {

        }
        */
    }
}
