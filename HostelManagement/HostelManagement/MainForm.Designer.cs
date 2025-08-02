namespace HostelManagement
{
    partial class MainForm
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
        private Button btnDormitories;
        private Button btnBlocks;
        private Button btnPeople;
        private Button btnAssets;
        private Button btnReports;

        private void InitializeComponent()
        {
            btnDormitories = new Button();
            btnBlocks = new Button();
            btnPeople = new Button();
            btnAssets = new Button();
            btnReports = new Button();
            LogoutBtn = new Button();
            DataReseting = new Button();
            DataSaving = new Button();
            SuspendLayout();
            // 
            // btnDormitories
            // 
            btnDormitories.Location = new Point(50, 30);
            btnDormitories.Name = "btnDormitories";
            btnDormitories.Size = new Size(200, 40);
            btnDormitories.TabIndex = 0;
            btnDormitories.Text = "Dormitories";
            btnDormitories.Click += btnDormitories_Click;
            // 
            // btnBlocks
            // 
            btnBlocks.Location = new Point(50, 80);
            btnBlocks.Name = "btnBlocks";
            btnBlocks.Size = new Size(200, 40);
            btnBlocks.TabIndex = 1;
            btnBlocks.Text = "Blocks";
            btnBlocks.Click += btnBlocks_Click;
            // 
            // btnPeople
            // 
            btnPeople.Location = new Point(50, 130);
            btnPeople.Name = "btnPeople";
            btnPeople.Size = new Size(200, 40);
            btnPeople.TabIndex = 2;
            btnPeople.Text = "People";
            btnPeople.Click += btnPeople_Click;
            // 
            // btnAssets
            // 
            btnAssets.Location = new Point(50, 180);
            btnAssets.Name = "btnAssets";
            btnAssets.Size = new Size(200, 40);
            btnAssets.TabIndex = 3;
            btnAssets.Text = "Assets";
            btnAssets.Click += btnAssets_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(50, 230);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 40);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.Click += btnReports_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(50, 302);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(200, 62);
            LogoutBtn.TabIndex = 5;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // DataReseting
            // 
            DataReseting.Location = new Point(176, 399);
            DataReseting.Name = "DataReseting";
            DataReseting.Size = new Size(112, 34);
            DataReseting.TabIndex = 6;
            DataReseting.Text = "Reset Data";
            DataReseting.UseVisualStyleBackColor = true;
            DataReseting.Click += DataReseting_Click;
            // 
            // DataSaving
            // 
            DataSaving.Location = new Point(12, 399);
            DataSaving.Name = "DataSaving";
            DataSaving.Size = new Size(112, 34);
            DataSaving.TabIndex = 7;
            DataSaving.Text = "Save Data";
            DataSaving.UseVisualStyleBackColor = true;
            DataSaving.Click += DataSaving_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(300, 445);
            Controls.Add(DataSaving);
            Controls.Add(DataReseting);
            Controls.Add(LogoutBtn);
            Controls.Add(btnDormitories);
            Controls.Add(btnBlocks);
            Controls.Add(btnPeople);
            Controls.Add(btnAssets);
            Controls.Add(btnReports);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            Load += MainForm_Load;
            ResumeLayout(false);
        }


        #endregion

        private Button LogoutBtn;
        private Button DataReseting;
        private Button DataSaving;
    }
}