namespace HostelManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
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

            // Temporary authentication logic
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new MainForm().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username (admin) or password (1234).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Close();
            DataStorage.SaveData(); // Save...
            Application.Exit();
        }
    }
}