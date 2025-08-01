//namespace HostelManagement
//{
//    public partial class Login : Form
//    {
//        public Login()
//        {
//            InitializeComponent();
//        }

//        private void btnLogin_Click(object sender, EventArgs e)
//        {
//            string username = txtUsername.Text;
//            string password = txtPassword.Text;
//            string role = cmbRole.SelectedItem?.ToString();

//            if (string.IsNullOrWhiteSpace(username) ||
//                string.IsNullOrWhiteSpace(password) ||
//                string.IsNullOrWhiteSpace(role))
//            {
//                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            // Temporary authentication logic
//            if (username == "admin" && password == "1234")
//            {
//                MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                new MainForm().Show();
//                this.Hide();

//            }
//            else
//            {
//                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HostelManagement
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }

    public static class DATA2
    {
        public static List<User> Users = new List<User>
        {
            new User("admin", "1234", "Admin") // Default admin user
        };

        // Save users to file
        public static void SaveUsers()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("users.txt"))
                {
                    foreach (User user in Users)
                    {
                        writer.WriteLine($"{user.Username},{user.Password},{user.Role}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load users from file
        public static void LoadUsers()
        {
            try
            {
                if (File.Exists("users.txt"))
                {
                    Users.Clear();
                    using (StreamReader reader = new StreamReader("users.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length == 3)
                            {
                                Users.Add(new User(parts[0], parts[1], parts[2]));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetupRegisterButton();
            DATA2.LoadUsers(); // Load existing users when the form starts
        }

        private void SetupRegisterButton()
        {
            // Add Register button
            Button btnRegister = new Button();
            btnRegister.Text = "Register";
            btnRegister.Location = new Point(btnLogin.Location.X, btnLogin.Location.Y + btnLogin.Height + 10);
            btnRegister.Size = btnLogin.Size;
            btnRegister.Click += btnRegister_Click;
            this.Controls.Add(btnRegister);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the user exists and credentials match
            User user = DATA2.Users.Find(u => u.Username == username && u.Password == password && u.Role == role);

            if (user != null)
            {
                MessageBox.Show($"Login successful. Welcome, {username}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username, password, or role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Open the registration form
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();

            // After registration is complete, refresh the login form
            // (in case the user wants to log in with the new credentials)
        }
    }

    public class RegisterForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private ComboBox cmbRole;
        private Button btnSubmit;
        private Button btnCancel;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblRole;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Register New User";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new Point(30, 30);
            lblUsername.Size = new Size(100, 20);

            txtUsername = new TextBox();
            txtUsername.Location = new Point(150, 30);
            txtUsername.Size = new Size(200, 20);

            lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Location = new Point(30, 70);
            lblPassword.Size = new Size(100, 20);

            txtPassword = new TextBox();
            txtPassword.Location = new Point(150, 70);
            txtPassword.Size = new Size(200, 20);
            txtPassword.PasswordChar = '*';

            lblConfirmPassword = new Label();
            lblConfirmPassword.Text = "Confirm Password:";
            lblConfirmPassword.Location = new Point(30, 110);
            lblConfirmPassword.Size = new Size(120, 20);

            txtConfirmPassword = new TextBox();
            txtConfirmPassword.Location = new Point(150, 110);
            txtConfirmPassword.Size = new Size(200, 20);
            txtConfirmPassword.PasswordChar = '*';

            lblRole = new Label();
            lblRole.Text = "Role:";
            lblRole.Location = new Point(30, 150);
            lblRole.Size = new Size(100, 20);

            cmbRole = new ComboBox();
            cmbRole.Location = new Point(150, 150);
            cmbRole.Size = new Size(200, 20);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "Student","Block Manager", "Hostel Manager" });

            btnSubmit = new Button();
            btnSubmit.Text = "Submit";
            btnSubmit.Location = new Point(100, 200);
            btnSubmit.Size = new Size(80, 30);
            btnSubmit.Click += BtnSubmit_Click;

            btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(200, 200);
            btnCancel.Size = new Size(80, 30);
            btnCancel.Click += BtnCancel_Click;

            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(lblConfirmPassword);
            this.Controls.Add(txtConfirmPassword);
            this.Controls.Add(lblRole);
            this.Controls.Add(cmbRole);
            this.Controls.Add(btnSubmit);
            this.Controls.Add(btnCancel);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if username already exists
            if (DATA2.Users.Exists(u => u.Username == username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add new user
            DATA2.Users.Add(new User(username, password, role));

            // Save users to file
            DATA2.SaveUsers();

            MessageBox.Show($"User {username} registered successfully as {role}.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
