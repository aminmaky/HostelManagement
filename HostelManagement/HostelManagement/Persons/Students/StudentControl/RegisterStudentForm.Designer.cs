using System;
using System.Drawing;
using System.Windows.Forms;

namespace HostelManagement.Persons.Students
{
    partial class RegisterStudentForm
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cmbStudent;
        private ComboBox cmbDormitory;
        private ComboBox cmbBlock;
        private Label lblStudent;
        private Label lblDormitory;
        private Label lblBlock;
        private Label lblRoom;
        private NumericUpDown numRoom;
        private Button btnRegister;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblStudent = new Label();
            lblDormitory = new Label();
            lblBlock = new Label();
            lblRoom = new Label();
            cmbStudent = new ComboBox();
            cmbDormitory = new ComboBox();
            cmbBlock = new ComboBox();
            numRoom = new NumericUpDown();
            btnRegister = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numRoom).BeginInit();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(38, 38);
            lblStudent.Margin = new Padding(4, 0, 4, 0);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(73, 25);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Student";
            // 
            // lblDormitory
            // 
            lblDormitory.AutoSize = true;
            lblDormitory.Location = new Point(38, 88);
            lblDormitory.Margin = new Padding(4, 0, 4, 0);
            lblDormitory.Name = "lblDormitory";
            lblDormitory.Size = new Size(94, 25);
            lblDormitory.TabIndex = 2;
            lblDormitory.Text = "Dormitory";
            // 
            // lblBlock
            // 
            lblBlock.AutoSize = true;
            lblBlock.Location = new Point(38, 138);
            lblBlock.Margin = new Padding(4, 0, 4, 0);
            lblBlock.Name = "lblBlock";
            lblBlock.Size = new Size(54, 25);
            lblBlock.TabIndex = 4;
            lblBlock.Text = "Block";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(38, 188);
            lblRoom.Margin = new Padding(4, 0, 4, 0);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(60, 25);
            lblRoom.TabIndex = 6;
            lblRoom.Text = "Room";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.Location = new Point(188, 38);
            cmbStudent.Margin = new Padding(4, 4, 4, 4);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(249, 33);
            cmbStudent.TabIndex = 1;
            // cmbStudent.SelectedIndexChanged += cmbStudent_SelectedIndexChanged;
            // 
            // cmbDormitory
            // 
            cmbDormitory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDormitory.Location = new Point(188, 88);
            cmbDormitory.Margin = new Padding(4, 4, 4, 4);
            cmbDormitory.Name = "cmbDormitory";
            cmbDormitory.Size = new Size(249, 33);
            cmbDormitory.TabIndex = 3;
            cmbDormitory.SelectedIndexChanged += CmbDormitory_SelectedIndexChanged;
            // 
            // cmbBlock
            // 
            cmbBlock.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBlock.Location = new Point(188, 138);
            cmbBlock.Margin = new Padding(4, 4, 4, 4);
            cmbBlock.Name = "cmbBlock";
            cmbBlock.Size = new Size(249, 33);
            cmbBlock.TabIndex = 5;
            // cmbBlock.SelectedIndexChanged += cmbBlock_SelectedIndexChanged;
            // 
            // numRoom
            // 
            numRoom.Location = new Point(188, 188);
            numRoom.Margin = new Padding(4, 4, 4, 4);
            numRoom.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numRoom.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRoom.Name = "numRoom";
            numRoom.Size = new Size(250, 31);
            numRoom.TabIndex = 7;
            numRoom.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(88, 275);
            btnRegister.Margin = new Padding(4, 4, 4, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 50);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += BtnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(250, 275);
            btnBack.Margin = new Padding(4, 4, 4, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 50);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // RegisterStudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 375);
            Controls.Add(lblStudent);
            Controls.Add(cmbStudent);
            Controls.Add(lblDormitory);
            Controls.Add(cmbDormitory);
            Controls.Add(lblBlock);
            Controls.Add(cmbBlock);
            Controls.Add(lblRoom);
            Controls.Add(numRoom);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            Margin = new Padding(4, 4, 4, 4);
            Name = "RegisterStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Student";
            ((System.ComponentModel.ISupportInitialize)numRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
