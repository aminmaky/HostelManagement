namespace HostelManagement
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblRole;
        private ComboBox cmbRole;
        private Button btnLogin;
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnLogin = new Button();
            Closebtn = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(30, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(140, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 31);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(30, 70);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(140, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 31);
            txtPassword.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.Location = new Point(30, 110);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 20);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            cmbRole.Items.AddRange(new object[] { "Student", "Block Manager", "Hostel Manager" });
            cmbRole.Location = new Point(140, 110);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(200, 33);
            cmbRole.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(240, 174);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 34);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // Closebtn
            // 
            Closebtn.Location = new Point(30, 174);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(112, 34);
            Closebtn.TabIndex = 7;
            Closebtn.Text = "Close";
            Closebtn.UseVisualStyleBackColor = true;
            Closebtn.Click += Closebtn_Click;
            // 
            // Login
            // 
            ClientSize = new Size(400, 220);
            Controls.Add(Closebtn);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(btnLogin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dormitory Management Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Closebtn;
    }
}