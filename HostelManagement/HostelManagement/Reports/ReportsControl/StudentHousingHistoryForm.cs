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
            // Sample data - later will be loaded from actual student list
            cmbStudents.Items.Add("98123456 - Ali Rezaei");
            cmbStudents.Items.Add("99111222 - Sara Ahmadi");
            cmbStudents.SelectedIndex = 0;
        }

        private void BtnLoadHistory_Click(object sender, EventArgs e)
        {
            dgvHistory.Columns.Clear();
            dgvHistory.Rows.Clear();

            dgvHistory.Columns.Add("Room", "Room");
            dgvHistory.Columns.Add("Dormitory", "Dormitory");
            dgvHistory.Columns.Add("Block", "Block");
            dgvHistory.Columns.Add("CheckIn", "Check-in Date");
            dgvHistory.Columns.Add("CheckOut", "Check-out Date");

            // Sample history for selected student
            dgvHistory.Rows.Add("101", "Dorm A", "Block 1", "2023-09-01", "2024-02-01");
            dgvHistory.Rows.Add("204", "Dorm B", "Block 2", "2024-02-02", "2025-01-01");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new ReportsForm().Show();
            this.Close();
        }
    }
}
