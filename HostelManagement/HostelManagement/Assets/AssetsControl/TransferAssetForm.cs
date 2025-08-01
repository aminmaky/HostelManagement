using HostelManagement.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HostelManagement.Assets
{
    public partial class TransferAssetForm : Form
    {
        public TransferAssetForm()
        {
            InitializeComponent();
            LoadAssets();
            CmbTransferType.SelectedIndexChanged += CmbTransferType_SelectedIndexChanged;
        }

        private void LoadAssets()
        {
            CmbAssets.Items.Clear();
            foreach (var tool in DATA.Tools)
            {
                CmbAssets.Items.Add(tool);
            }

            CmbAssets.SelectedIndex = -1;
        }

        private void CmbTransferType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTarget.Items.Clear();
            comboBoxTarget.Text = "";
            if (CmbTransferType.SelectedIndex == 0) // انتقال به اتاق
            {
                LblTarget.Text = "New Room:";
                foreach (var dorm in DATA.Dormitories)
                {
                    foreach (var block in dorm.Blocks)
                    {
                        foreach (var room in block.Rooms)
                        {
                            comboBoxTarget.Items.Add(room);
                        }
                    }
                }
            }
            else if (CmbTransferType.SelectedIndex == 1) // انتقال به دانشجو
            {
                LblTarget.Text = "New Student:";
                foreach (var student in DATA.Students)
                {
                    comboBoxTarget.Items.Add(student);
                }
            }

            comboBoxTarget.SelectedIndex = -1;
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            if (CmbAssets.SelectedItem == null || CmbTransferType.SelectedIndex == -1 || comboBoxTarget.SelectedItem == null)
            {
                MessageBox.Show("Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tool selectedTool = CmbAssets.SelectedItem as Tool;

            if (CmbTransferType.SelectedIndex == 0)
            {
                Room newRoom = comboBoxTarget.SelectedItem as Room;

                if (newRoom == null)
                {
                    MessageBox.Show("Invalid room selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selectedTool.Type == Asset.Fridge)
                {
                    if (newRoom.Tool.Any(t => t.Type == Asset.Fridge))
                    {
                        MessageBox.Show("This room already has a fridge.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                newRoom.Tool.Add(selectedTool);
                selectedTool.RoomNum = (int)newRoom.RoomNum;
                selectedTool.OwnerName.Tools.Remove(selectedTool);
                selectedTool.OwnerName = null;
                selectedTool.Room = newRoom;
                

                MessageBox.Show("Asset successfully transferred to the selected room.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                Student newStudent = comboBoxTarget.SelectedItem as Student;

                if (newStudent == null)
                {
                    MessageBox.Show("Invalid student selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsPersonal(selectedTool.Type.ToString()))
                {
                    MessageBox.Show("Only personal items can be assigned to students.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newStudent.Tools.Any(t => t.Type == selectedTool.Type))
                {
                    MessageBox.Show("Student already has this type of asset.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                selectedTool.OwnerName.Tools.Remove(selectedTool);
                newStudent.Tools.Add(selectedTool);
                selectedTool.OwnerName = newStudent;
                if (newStudent.Room != null)
                    selectedTool.RoomNum = (int)newStudent.Room.RoomNum;

                MessageBox.Show("Asset successfully transferred to the selected student.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Reset form
            CmbAssets.SelectedIndex = -1;
            CmbTransferType.SelectedIndex = -1;
            comboBoxTarget.Items.Clear();
            LblTarget.Text = "Target:";
        }

        private bool IsPersonal(string type)
        {
            return type == "bed" || type == "desk" || type == "chair" || type == "commode";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AssetManagementForm().Show();
            this.Close();
        }
    }
}
