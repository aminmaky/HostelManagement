using System;
using System.Linq;
using System.Windows.Forms;
using HostelManagement.Blocks;

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
            cmbReportType.Items.Clear();
            cmbReportType.Items.AddRange(new string[]
            {
                "Overall Student Housing",
                "Empty and Occupied Rooms",
                "Dormitory and Block Capacities"
            });

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

                    int totalStudents = DATA.Students.Count;
                    int housed = DATA.Students.Count(s => s.Room != null);
                    int notHoused = totalStudents - housed;

                    dgvHousingReport.Rows.Add(totalStudents, housed, notHoused);
                    break;

                case "Empty and Occupied Rooms":
                    dgvHousingReport.Columns.Add("Room", "Room");
                    dgvHousingReport.Columns.Add("Status", "Status");

                    foreach (var dorm in DATA.Dormitories)
                    {
                        foreach (var block in dorm.Blocks)
                        {
                            foreach (var room in block.Rooms)
                            {
                                string roomLabel = $"Dorm: {dorm.Name}, Block: {block.Name}, Room: {(int)room.RoomNum}";
                                string status = room.IsFull() || room.Daneshgo.Count > 0 ? "Occupied" : "Empty";
                                dgvHousingReport.Rows.Add(roomLabel, status);
                            }
                        }
                    }
                    break;

                case "Dormitory and Block Capacities":
                    dgvHousingReport.Columns.Add("Dormitory", "Dormitory");
                    dgvHousingReport.Columns.Add("Block", "Block");
                    dgvHousingReport.Columns.Add("TotalCapacity", "Total Capacity");
                    dgvHousingReport.Columns.Add("Remaining", "Remaining");

                    foreach (var dorm in DATA.Dormitories)
                    {
                        foreach (var block in dorm.Blocks)
                        {
                            int totalCapacity = block.Rooms.Sum(r => r.Capacity);
                            int used = block.Rooms.Sum(r => r.Daneshgo.Count);
                            int remaining = totalCapacity - used;

                            dgvHousingReport.Rows.Add(dorm.Name, block.Name, totalCapacity, remaining);
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
