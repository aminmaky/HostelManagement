using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HostelManagement.Blocks;

namespace HostelManagement.Reports
{
    public partial class AssetsReportForm : Form
    {
        public AssetsReportForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void AssetsReportForm_Load(object sender, EventArgs e)
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.AddRange(new string[]
            {
                "All Assets",
                "Assets Per Room",
                "Assets Per Student",
                "Broken & Repairing Assets"
            });

            cmbReportType.SelectedIndex = 0;
        }

        private void BtnShowReport_Click(object sender, EventArgs e)
        {
            string selectedReport = cmbReportType.SelectedItem.ToString();
            dgvReport.Columns.Clear();
            dgvReport.Rows.Clear();

            switch (selectedReport)
            {
                case "All Assets":
                    dgvReport.Columns.Add("Type", "Type");
                    dgvReport.Columns.Add("PartNumber", "Part Number");
                    dgvReport.Columns.Add("AssetNumber", "Asset Number");

                    foreach (var tool in DATA.Tools)
                    {
                        dgvReport.Rows.Add(tool.Type, tool.PartNum, tool.PropertyNum);
                    }
                    break;

                case "Assets Per Room":
                    dgvReport.Columns.Add("Room", "Room");
                    dgvReport.Columns.Add("Item", "Item");

                    foreach (var tool in DATA.Tools)
                    {
                        if (tool.Room != null)
                            dgvReport.Rows.Add($"Room {tool.Room.RoomNum}", tool.Type);
                        else if (tool.RoomNum != 0)
                            dgvReport.Rows.Add($"Room {tool.RoomNum}", tool.Type);
                    }
                    break;

                case "Assets Per Student":
                    dgvReport.Columns.Add("Student", "Student");
                    dgvReport.Columns.Add("Item", "Item");

                    foreach (var tool in DATA.Tools)
                    {
                        if (tool.OwnerName != null)
                        {
                            string studentName = $"{tool.OwnerName.Firstname} {tool.OwnerName.Lastname}";
                            dgvReport.Rows.Add(studentName, tool.Type);
                        }
                    }
                    break;

                case "Broken & Repairing Assets":
                    dgvReport.Columns.Add("Item", "Item");
                    dgvReport.Columns.Add("PartNumber", "Part Number");
                    dgvReport.Columns.Add("Status", "Status");

                    foreach (var tool in DATA.Tools)
                    {
                        if (tool.Status == Status.Defective || tool.Status == Status.UnderRepair)
                        {
                            dgvReport.Rows.Add(tool.Type.ToString(), tool.PartNum, tool.Status.ToString());
                        }
                    }
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
