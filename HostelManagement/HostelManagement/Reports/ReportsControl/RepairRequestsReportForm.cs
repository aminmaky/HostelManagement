using System;
using System.Linq;
using System.Windows.Forms;
using HostelManagement;

namespace HostelManagement.Reports
{
    public partial class RepairRequestsReportForm : Form
    {
        public RepairRequestsReportForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void RepairRequestsReportForm_Load(object sender, EventArgs e)
        {
            BtnLoadRequests_Click(sender, e);
        }

        private void BtnLoadRequests_Click(object sender, EventArgs e)
        {
            dgvRepairRequests.Columns.Clear();
            dgvRepairRequests.Rows.Clear();

            dgvRepairRequests.Columns.Add("AssetType", "Asset Type");
            dgvRepairRequests.Columns.Add("PartNumber", "Part Number");
            dgvRepairRequests.Columns.Add("AssetCode", "Asset Code");
            dgvRepairRequests.Columns.Add("Status", "Status");
            dgvRepairRequests.Columns.Add("ReportedBy", "Reported By");

            var filteredTools = DATA.Tools
                .Where(t => t.Status == Status.Defective || t.Status == Status.UnderRepair)
                .ToList();

            foreach (var tool in filteredTools)
            {
                string reporter = "Unknown";

                if (tool.OwnerName != null)
                    reporter = $"Student: {tool.OwnerName.Firstname} {tool.OwnerName.Lastname}";
                else if (tool.Room != null)
                    reporter = $"Room {(int)tool.Room.RoomNum}";

                dgvRepairRequests.Rows.Add(
                    tool.Type.ToString(),
                    tool.PartNum,
                    tool.PropertyNum,
                    tool.Status.ToString(),
                    reporter
                );
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new ReportsForm().Show();
            this.Close();
        }
    }
}
