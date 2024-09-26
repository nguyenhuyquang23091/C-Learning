using ManageSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.Presentattion
{
    public partial class Registerform : Form
    {
        private RoleService roleService;
        public Registerform()
        {
            roleService = new RoleService();
            InitializeComponent();
        }
        private void Loginform_Load(object sender, EventArgs e)
        {
            roleService.TestConnection();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void registerbutton_Click_1(object sender, EventArgs e)
        {
            // Capture user inputs from the form
            string username = txtusername.Text; // Get the username
            string password = txtpassword.Text; // Get the password
            string retypePassword = txtretypebox.Text; // Get the re-entered password

            // Validate that none of the fields are empty
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(retypePassword))
            {
                // Show an error message if any field is empty
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            // Validate that the passwords match
            if (password != retypePassword)
            {
                // Show an error message if passwords do not match
                MessageBox.Show("Passwords do not match. Please retype your password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            // Attempt to register the user
            try
            {
                roleService.RegisterUser(username, password); // Call the BLL method to register the user
                                                              // Show success message if registration is successful
                MessageBox.Show("Registration successful! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, open the login form
                Loginform lform = new Loginform();
                lform.Show(); // Show the login form
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during registration
                MessageBox.Show($"Registration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void txtretypebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
