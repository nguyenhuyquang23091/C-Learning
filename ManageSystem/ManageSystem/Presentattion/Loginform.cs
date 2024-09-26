using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Windows.Forms;
using ManageSystem.BLL;

namespace ManageSystem
{
    public partial class Loginform : Form
    {

        private RoleService roleService;
        public Loginform()
        {
            InitializeComponent();
            roleService = new RoleService();
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            // Check if username or password fields are empty
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                // Show an error message prompting the user to fill in the fields
                MessageBox.Show("Please fill in all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Validate the user's credentials using the roleService
                bool isValidUser = roleService.ValidateUser(username.Text, password.Text);

                // Check if the user is valid
                if (isValidUser)
                {
                    // Show a success message if login is successful
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the main application form
                    MainForm mform = new MainForm();
                    mform.Show();
                    this.Hide(); // Hide the login form
                }
                else
                {
                    // Show an error message if login fails
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Your code here for panel2 paint, if needed
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            // Your code here for password text changed, if needed
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showPass_CheckedChanged_1(object sender, EventArgs e)
        {
            // Toggle password visibility
            password.UseSystemPasswordChar = !showPass.Checked;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}