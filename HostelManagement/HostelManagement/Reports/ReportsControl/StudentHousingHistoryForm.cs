using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Reports
{
    public partial class StudentHousingHistoryForm : Form
    {
        public StudentHousingHistoryForm()
        {
            InitializeComponent();
        }

        private void StudentHousingHistoryForm_Load(object sender, EventArgs e)
        {
            cmbStudents.Items.Clear();
            foreach (var student in DATA.Students)
                cmbStudents.Items.Add($"{student.StudentId} - {student.Firstname} {student.Lastname}");

            if (cmbStudents.Items.Count > 0)
                cmbStudents.SelectedIndex = 0;
        }


        private void BtnLoadHistory_Click(object sender, EventArgs e)
        {
            dgvHistory.Columns.Clear();
            dgvHistory.Rows.Clear();

            dgvHistory.Columns.Add("Room", "Room");
            dgvHistory.Columns.Add("Dormitory", "Dormitory");
            dgvHistory.Columns.Add("Block", "Block");

            var selectedItem = cmbStudents.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedItem))
                return;

            var studentId = selectedItem.Split('-')[0].Trim();
            var student = DATA.Students.FirstOrDefault(s => s.StudentId == studentId);

            if (student?.HousingHistory != null)
            {
                foreach (var record in student.HousingHistory)
                {
                    dgvHistory.Rows.Add(record.Room, record.Dormitory, record.Block);
                }
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            new ReportsForm().Show();
            this.Close();
        }
    }
}
