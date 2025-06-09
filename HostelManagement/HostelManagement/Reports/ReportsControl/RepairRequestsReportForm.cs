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
    public partial class RepairRequestsReportForm : Form
    {
        public RepairRequestsReportForm()
        {
            InitializeComponent();
        }

        private void RepairRequestsReportForm_Load(object sender, EventArgs e)
        {
            // Optional: auto-load data
        }

        private void BtnLoadRequests_Click(object sender, EventArgs e)
        {
            dgvRepairRequests.Columns.Clear();
            dgvRepairRequests.Rows.Clear();

            dgvRepairRequests.Columns.Add("AssetType", "Asset Type");
            dgvRepairRequests.Columns.Add("PartNumber", "Part Number");
            dgvRepairRequests.Columns.Add("AssetCode", "Asset Code");
            dgvRepairRequests.Columns.Add("RequestDate", "Request Date");
            dgvRepairRequests.Columns.Add("Status", "Status");
            dgvRepairRequests.Columns.Add("ReportedBy", "Reported By");

            // Sample rows
            dgvRepairRequests.Rows.Add("Fridge", "003", "00001234", "2025-05-01", "Repairing", "Room 101");
            dgvRepairRequests.Rows.Add("Desk", "002", "00005678", "2025-04-29", "Broken", "Student: Ali R.");
            dgvRepairRequests.Rows.Add("Chair", "004", "00007890", "2025-04-28", "Repaired", "Room 204");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new ReportsForm().Show();
            this.Close();
        }
    }
}
