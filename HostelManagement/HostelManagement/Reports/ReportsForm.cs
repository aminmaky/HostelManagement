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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            // Optional: initialize logic
        }

        private void BtnHousingStatusReport_Click(object sender, EventArgs e)
        {
            new HousingStatusReportForm().Show();
            this.Hide();
        }
        private void BtnStudentHousingHistory_Click(object sender, EventArgs e)
        {
            new StudentHousingHistoryForm().Show();
            this.Hide();
        }
        private void BtnAssetsReport_Click(object sender, EventArgs e)
        {
            new AssetsReportForm().Show();
            this.Hide();
        }

        private void BtnSpecialReports_Click(object sender, EventArgs e)
        {
            new RepairRequestsReportForm().Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Close();
        }
    }
}
