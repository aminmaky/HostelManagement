using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Assets
{
    public partial class AssetManagementForm : Form
    {
        public AssetManagementForm()
        {
            InitializeComponent();
        }

        private void AssetManagementForm_Load(object sender, EventArgs e)
        {
            // Optional: Load data or initialize state
        }

        private void BtnAddAsset_Click(object sender, EventArgs e)
        {
            new AddAssetForm().Show();
            this.Hide();
        }

        private void BtnAssignToRoom_Click(object sender, EventArgs e)
        {
            new AssignAssetToRoomForm().Show();
            this.Hide();
        }

        private void BtnAssignToStudent_Click(object sender, EventArgs e)
        {
            new AssignAssetToStudentForm().Show();
            this.Hide();
        }

        private void BtnManageTransfers_Click(object sender, EventArgs e)
        {
            new TransferAssetForm().Show();
            this.Hide();
        }

        private void BtnManageRepairs_Click(object sender, EventArgs e)
        {
            new RepairAssetForm().Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }
    }
}
