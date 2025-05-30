namespace HostelManagement.Dormitories
{
    partial class DormitoryManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private Button BtnAddDormitory;
        private Button BtnDeleteDormitory;
        private Button BtnEditDormitory;
        private Button BtnViewDormitories;

        private void InitializeComponent()
        {
            BtnAddDormitory = new Button();
            BtnDeleteDormitory = new Button();
            BtnEditDormitory = new Button();
            BtnViewDormitories = new Button();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // BtnAddDormitory
            // 
            BtnAddDormitory.Location = new Point(62, 38);
            BtnAddDormitory.Margin = new Padding(4);
            BtnAddDormitory.Name = "BtnAddDormitory";
            BtnAddDormitory.Size = new Size(312, 50);
            BtnAddDormitory.TabIndex = 0;
            BtnAddDormitory.Text = "Add Dormitory";
            BtnAddDormitory.UseVisualStyleBackColor = true;
            BtnAddDormitory.Click += BtnAddDormitory_Click;
            // 
            // BtnDeleteDormitory
            // 
            BtnDeleteDormitory.Location = new Point(62, 100);
            BtnDeleteDormitory.Margin = new Padding(4);
            BtnDeleteDormitory.Name = "BtnDeleteDormitory";
            BtnDeleteDormitory.Size = new Size(312, 50);
            BtnDeleteDormitory.TabIndex = 1;
            BtnDeleteDormitory.Text = "Delete Dormitory";
            BtnDeleteDormitory.UseVisualStyleBackColor = true;
            BtnDeleteDormitory.Click += BtnDeleteDormitory_Click;
            // 
            // BtnEditDormitory
            // 
            BtnEditDormitory.Location = new Point(62, 162);
            BtnEditDormitory.Margin = new Padding(4);
            BtnEditDormitory.Name = "BtnEditDormitory";
            BtnEditDormitory.Size = new Size(312, 50);
            BtnEditDormitory.TabIndex = 2;
            BtnEditDormitory.Text = "Edit Dormitory";
            BtnEditDormitory.UseVisualStyleBackColor = true;
            BtnEditDormitory.Click += BtnEditDormitory_Click;
            // 
            // BtnViewDormitories
            // 
            BtnViewDormitories.Location = new Point(62, 224);
            BtnViewDormitories.Margin = new Padding(4);
            BtnViewDormitories.Name = "BtnViewDormitories";
            BtnViewDormitories.Size = new Size(312, 50);
            BtnViewDormitories.TabIndex = 3;
            BtnViewDormitories.Text = "View Dormitories";
            BtnViewDormitories.UseVisualStyleBackColor = true;
            BtnViewDormitories.Click += BtnViewDormitories_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(62, 292);
            BtnBack.Margin = new Padding(4);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(312, 50);
            BtnBack.TabIndex = 4;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // DormitoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 375);
            Controls.Add(BtnBack);
            Controls.Add(BtnAddDormitory);
            Controls.Add(BtnDeleteDormitory);
            Controls.Add(BtnEditDormitory);
            Controls.Add(BtnViewDormitories);
            Margin = new Padding(4);
            Name = "DormitoryManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dormitory Management";
            Load += DormitoryManagementForm_Load;
            ResumeLayout(false);
        }


        #endregion

        private Button BtnBack;
    }
}