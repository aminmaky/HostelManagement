﻿namespace HostelManagement.Assets
{
    partial class AssignAssetToStudentForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label LblAsset;
        private ComboBox CmbAssets;
        private Label LblStudent;
        private TextBox TxtStudent;
        private Button BtnAssign;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LblAsset = new Label();
            CmbAssets = new ComboBox();
            LblStudent = new Label();
            TxtStudent = new TextBox();
            BtnAssign = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // LblAsset
            // 
            LblAsset.AutoSize = true;
            LblAsset.Location = new Point(30, 30);
            LblAsset.Name = "LblAsset";
            LblAsset.Size = new Size(110, 25);
            LblAsset.TabIndex = 0;
            LblAsset.Text = "Select Asset:";
            // 
            // CmbAssets
            // 
            CmbAssets.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbAssets.Location = new Point(180, 27);
            CmbAssets.Name = "CmbAssets";
            CmbAssets.Size = new Size(250, 33);
            CmbAssets.TabIndex = 1;
            // 
            // LblStudent
            // 
            LblStudent.AutoSize = true;
            LblStudent.Location = new Point(30, 80);
            LblStudent.Name = "LblStudent";
            LblStudent.Size = new Size(199, 25);
            LblStudent.TabIndex = 2;
            LblStudent.Text = "Enter Student ID/Name:";
            // 
            // TxtStudent
            // 
            TxtStudent.Location = new Point(230, 74);
            TxtStudent.Name = "TxtStudent";
            TxtStudent.Size = new Size(200, 31);
            TxtStudent.TabIndex = 3;
            // 
            // BtnAssign
            // 
            BtnAssign.Location = new Point(285, 130);
            BtnAssign.Name = "BtnAssign";
            BtnAssign.Size = new Size(100, 40);
            BtnAssign.TabIndex = 4;
            BtnAssign.Text = "Assign";
            BtnAssign.Click += BtnAssign_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(80, 130);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AssignAssetToStudentForm
            // 
            ClientSize = new Size(450, 200);
            Controls.Add(btnCancel);
            Controls.Add(LblAsset);
            Controls.Add(CmbAssets);
            Controls.Add(LblStudent);
            Controls.Add(TxtStudent);
            Controls.Add(BtnAssign);
            Name = "AssignAssetToStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign Asset to Student";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCancel;
    }
}
