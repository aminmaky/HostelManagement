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
using HostelManagement.Blocks;

namespace HostelManagement.Assets
{
    public partial class AssignAssetToRoomForm : Form
    {
        public AssignAssetToRoomForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // LoadAssetList();
        }

        private void AssignAssetToRoomForm_Load(object sender, EventArgs e)
        {
            cmbDormitory.Items.AddRange(DATA.Dormitories.ToArray());
            CmbAssets.Items.AddRange(DATA.Tools.Where(t => t.Type == Asset.Fridge || t.Type != Asset.Fridge).ToArray());
        }


        private void BtnAssign_Click(object sender, EventArgs e)
        {
            if (CmbAssets.SelectedItem == null || cmbRoom.SelectedItem == null)
            {
                MessageBox.Show("Please select an asset and a room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedAssetStr = CmbAssets.SelectedItem.ToString();
            string assetNumber = selectedAssetStr.Split('-')[0].Trim();

            // Tool selectedTool = DATA.Tools.FirstOrDefault(t => t.PropertyNum == assetNumber);
            Tool selectedTool = CmbAssets.SelectedItem as Tool;

            Room selectedRoom = cmbRoom.SelectedItem as Room;

            if (selectedTool == null || selectedRoom == null)
            {
                MessageBox.Show("Invalid asset or room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedTool.Type == Asset.Fridge && selectedRoom.Tool.Any(t => t.Type == Asset.Fridge))
            {
                MessageBox.Show("This room already has a fridge. Cannot assign another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            selectedRoom.Tool.Add(selectedTool);
            selectedTool.Room = selectedRoom;

            MessageBox.Show($"Asset {assetNumber} assigned to Room {selectedRoom.RoomNum}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AssetManagementForm().Show();
            this.Close();
        }

        private void CmbDormitory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBlock.Items.Clear();
            var selectedDorm = cmbDormitory.SelectedItem as Dormitory;

            if (selectedDorm?.Blocks != null)
            {
                foreach (var block in selectedDorm.Blocks)
                    cmbBlock.Items.Add(block);
            }

            cmbBlock.SelectedIndex = -1;
        }
        private void cmbBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoom.Items.Clear();
            var selectedBlock = cmbBlock.SelectedItem as Block;

            if (selectedBlock != null)
            {
                foreach (var room in selectedBlock.Rooms)
                    cmbRoom.Items.Add(room);
            }

            cmbRoom.SelectedIndex = -1;
        }
    }
}
