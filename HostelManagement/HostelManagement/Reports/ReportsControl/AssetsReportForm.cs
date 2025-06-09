using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HostelManagement.Reports
{
    public partial class AssetsReportForm : Form
    {
        public AssetsReportForm()
        {
            InitializeComponent();
        }

        private void AssetsReportForm_Load(object sender, EventArgs e)
        {
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

                    dgvReport.Rows.Add("Bed", "001", "00012345");
                    dgvReport.Rows.Add("Desk", "002", "00023456");
                    dgvReport.Rows.Add("Chair", "003", "00034567");
                    break;

                case "Assets Per Room":
                    dgvReport.Columns.Add("Room", "Room");
                    dgvReport.Columns.Add("Item", "Item");

                    dgvReport.Rows.Add("101", "Bed");
                    dgvReport.Rows.Add("101", "Desk");
                    dgvReport.Rows.Add("102", "Chair");
                    break;

                case "Assets Per Student":
                    dgvReport.Columns.Add("Student", "Student");
                    dgvReport.Columns.Add("Item", "Item");

                    dgvReport.Rows.Add("Ali", "Bed");
                    dgvReport.Rows.Add("Ali", "Desk");
                    dgvReport.Rows.Add("Sara", "Wardrobe");
                    break;

                case "Broken & Repairing Assets":
                    dgvReport.Columns.Add("Item", "Item");
                    dgvReport.Columns.Add("PartNumber", "Part Number");
                    dgvReport.Columns.Add("Status", "Status");

                    dgvReport.Rows.Add("Desk", "00298765", "Broken");
                    dgvReport.Rows.Add("Chair", "00355555", "Repairing");
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
