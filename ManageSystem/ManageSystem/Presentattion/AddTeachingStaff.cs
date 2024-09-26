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
using ManageSystem.DAL;
using ManageSystem.Models;
using System.Xml.Linq;
using System.Data.SqlClient;


namespace ManageSystem
{
    public partial class AddTeachingStaff : UserControl
    {

        private readonly RoleService roleservice;
        public AddTeachingStaff()
        {
            InitializeComponent();
            roleservice = new RoleService();
            this.Load += AddTeachingDataLoad;
           
        }
        private void AddTeachingDataLoad(object sender, EventArgs e)
        {
            LoadTeachingStaffData();
        }
      
        private void LoadTeachingStaffData()
        {
            var teachstaffdatatable = roleservice.GetTeachingStaffDataTable();
            dataGridView1.DataSource = teachstaffdatatable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool SubjectDuplicate(string subject1, string subject2)
        {
            return (!string.IsNullOrWhiteSpace(subject1) && !string.IsNullOrWhiteSpace(subject2) && subject1.Equals(subject2, StringComparison.OrdinalIgnoreCase));
            
        }


        private void ClearInput(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)

                {
                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if ( control.HasChildren)
                {
                    ClearInput(control); 
                }

                }
            }


        private void Addclick_Click(object sender, EventArgs e)
        {
            // Retrieve input values from text fields
            string name = txtName.Text;
            string telephone = txtTelephone.Text;
            string email = txtEmail.Text;
            string salaryText = txtSalary.Text;
            string subject1 = txtSubject1.Text;
            string subject2 = txtSubject2.Text;

            // Validate required fields
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(telephone)
                || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(salaryText) || string.IsNullOrWhiteSpace(subject1)
                || string.IsNullOrWhiteSpace(subject2))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate email
            if (roleservice.CheckDuplicate(txtEmail.Text))
            {
                MessageBox.Show("An user with this email already exists.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate salary input
            if (!decimal.TryParse(salaryText, out decimal salary))
            {
                MessageBox.Show("Please enter a valid salary amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate telephone number
            if (telephone.Length > 11)
            {
                MessageBox.Show("Telephone number cannot exceed 11 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!telephone.All(char.IsDigit))
            {
                MessageBox.Show("Telephone number must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate subjects
            if (SubjectDuplicate(subject1, subject2))
            {
                MessageBox.Show("Subjects cannot be the same.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new TeachingStaff object
            var teachingstaff = new TeachingStaff(name, telephone, email, salary, subject1, subject2);
            try
            {
                // Add teaching staff to the database
                roleservice.AddTeachingStaff(teachingstaff);
                MessageBox.Show("Teaching staff added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the data display
                LoadTeachingStaffData();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the addition
                MessageBox.Show($"Error adding teaching staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clearclick_Click(object sender, EventArgs e)
        {
            ClearInput(this);
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Subject1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            // Temporarily unsubscribe from the event to avoid recursion issues
            txtSalary.TextChanged -= txtSalary_TextChanged;

            // Get the current text, removing dots to avoid parsing errors
            string text = txtSalary.Text.Replace(".", "");

            // Try to parse the text as a decimal number
            if (decimal.TryParse(text, out decimal salary))
            {
                // Reformat the number with thousand separators
                txtSalary.Text = salary.ToString("N0");

                // Move the cursor to the end of the text
                txtSalary.SelectionStart = txtSalary.Text.Length;
            }

            // Resubscribe to the event
            txtSalary.TextChanged += txtSalary_TextChanged;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtSubject2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
