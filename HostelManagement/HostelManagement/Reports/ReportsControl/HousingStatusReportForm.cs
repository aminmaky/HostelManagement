using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace HostelManagement.Reports
{
    public partial class HousingStatusReportForm : Form
    {
        public HousingStatusReportForm()
        {
            InitializeComponent();
        }

        private void HousingStatusReportForm_Load(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = 0;
        }

        private void BtnShowReport_Click(object sender, EventArgs e)
        {
            string selected = cmbReportType.SelectedItem.ToString();
            dgvHousingReport.Columns.Clear();
            dgvHousingReport.Rows.Clear();

            switch (selected)
            {
                case "Overall Student Housing":
                    dgvHousingReport.Columns.Add("TotalStudents", "Total Students");
                    dgvHousingReport.Columns.Add("Housed", "Housed");
                    dgvHousingReport.Columns.Add("NotHoused", "Not Housed");

                    dgvHousingReport.Rows.Add("300", "250", "50");
                    break;

                case "Empty and Occupied Rooms":
                    dgvHousingReport.Columns.Add("Room", "Room");
                    dgvHousingReport.Columns.Add("Status", "Status");

                    dgvHousingReport.Rows.Add("101", "Occupied");
                    dgvHousingReport.Rows.Add("102", "Empty");
                    dgvHousingReport.Rows.Add("103", "Occupied");
                    break;

                case "Dormitory and Block Capacities":
                    dgvHousingReport.Columns.Add("Dormitory", "Dormitory");
                    dgvHousingReport.Columns.Add("Block", "Block");
                    dgvHousingReport.Columns.Add("TotalCapacity", "Total Capacity");
                    dgvHousingReport.Columns.Add("Remaining", "Remaining");

                    dgvHousingReport.Rows.Add("Dorm A", "Block 1", "100", "20");
                    dgvHousingReport.Rows.Add("Dorm A", "Block 2", "80", "5");
                    dgvHousingReport.Rows.Add("Dorm B", "Block 1", "120", "30");
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new ReportsForm().Show();
            this.Close();
        }
    }
}
