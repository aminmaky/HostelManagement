using HostelManagement.Blocks;
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
    public partial class AssignAssetToStudentForm : Form
    {
        public AssignAssetToStudentForm()
        {
            InitializeComponent();
            LoadPersonalAssets();
        }

        private void LoadPersonalAssets()
        {
            CmbAssets.Items.Clear();

            //foreach (var eq in AssetStorage.AllEquipments)
            //{
            //    // فقط تجهیزاتی که هنوز به دانشجو تخصیص نیافته‌اند و شخصی هستند
            //    if (IsPersonal(eq.Type) && string.IsNullOrWhiteSpace(eq.Student))
            //    {
            //        CmbAssets.Items.Add($"{eq.AssetNumber} - {eq.Type}");
            //    }
            //}
        }

        private bool IsPersonal(string type)
        {
            return type == "تخت" || type == "میز" || type == "صندلی" || type == "کمد";
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            if (CmbAssets.SelectedItem == null || string.IsNullOrWhiteSpace(TxtStudent.Text))
            {
                MessageBox.Show("Please select an asset and enter student info.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedAssetStr = CmbAssets.SelectedItem.ToString();
            string assetNumber = selectedAssetStr.Split('-')[0].Trim();
            string student = TxtStudent.Text.Trim();

            //Equipment eq = AssetStorage.AllEquipments.Find(e => e.AssetNumber == assetNumber);

            //if (eq != null)
            //{
            //    eq.Student = student;
            //    MessageBox.Show($"Asset {eq.AssetNumber} assigned to student {student}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Asset not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            TxtStudent.Text = "";
            CmbAssets.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AssetManagementForm().Show();
            this.Close();
        }
    }
}
