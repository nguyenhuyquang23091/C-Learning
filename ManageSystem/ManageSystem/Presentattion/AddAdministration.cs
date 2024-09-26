using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSystem.BLL;
using ManageSystem.Models;
using static ManageSystem.Models.Administration;

namespace ManageSystem
{
    public partial class AddAdministration : UserControl
    {
        private readonly RoleService roleservice;
        public AddAdministration()
        {
            // Initialize the form components
            InitializeComponent();

            // Create an instance of the RoleService to manage role-related operations
            roleservice = new RoleService();

            // Subscribe to the Load event of the form
            this.Load += AddAdminDataLoad;
        }

        private void AddAdminDataLoad(object sender, EventArgs e)
        {
            // Call the method to load administration data when the form loads
            LoadAdminData();
        }

        private void LoadAdminData()
        {
            // Retrieve the administration data as a DataTable from the RoleService
            var admindatatable = roleservice.GetAdministrationDataTable();

            // Bind the DataTable to the DataGridView for display
            datagridadmin.DataSource = admindatatable;

            // Populate the work type combo box with values from the EmploymentType enum
            txtAdminworktype.DataSource = Enum.GetValues(typeof(Administration.EmploymentType));

            // Set the ComboBox style to DropDownList to restrict user input to the list
            txtAdminworktype.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addclick_Click(object sender, EventArgs e)
        {
            // Retrieve input values from text boxes
            string name = txtAdminName.Text;
            string telephone = txtAdmintelephone.Text;
            string email = txtAdminEmail.Text;
            string workhours = txtworkinghours.Text;

            // Check for duplicate email addresses
            if (roleservice.CheckDuplicate(txtAdminEmail.Text))
            {
                MessageBox.Show("An user with this email already exists.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if duplicate found
            }

            // Validate salary input
            if (!decimal.TryParse(txtAdminsalary.Text, out decimal salary))
            {
                MessageBox.Show("Please enter a valid salary amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if salary is invalid
            }

            // Validate working hours input
            if (!int.TryParse(txtworkinghours.Text, out int workHours))
            {
                MessageBox.Show("Please enter a valid number of working hours.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if working hours are invalid
            }

            // Validate telephone number length
            if (telephone.Length > 11)
            {
                MessageBox.Show("Telephone number cannot exceed 11 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if length exceeds limit
            }

            // Validate telephone number format
            if (!telephone.All(char.IsDigit))
            {
                MessageBox.Show("Telephone number must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if format is invalid
            }

            // Parse the selected employment type
            Administration.EmploymentType employmentType;
            if (Enum.TryParse(txtAdminworktype.SelectedItem?.ToString(), out employmentType))
            {
                // Create a new Administration object with validated data
                var administration = new Administration(name, telephone, email, salary, workHours, employmentType);
                try
                {
                    // Attempt to add the new administration record
                    roleservice.AddAdministration(administration);
                    MessageBox.Show("Administration added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdminData(); // Refresh the data display
                }
                catch (Exception ex)
                {
                    // Handle any errors during the addition process
                    MessageBox.Show($"Error adding Administration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle invalid employment type selection
                MessageBox.Show("Please select a valid employment type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtAdminworktype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminsalary_TextChanged(object sender, EventArgs e)
        {
            
            txtAdminsalary.TextChanged -= txtAdminsalary_TextChanged;

            string text = txtAdminsalary.Text.Replace(".", "").Replace(",", "");

           
            if (decimal.TryParse(text, out decimal salary))
            {
            
                txtAdminsalary.Text = salary.ToString("N0");

               
                txtAdminsalary.SelectionStart = txtAdminsalary.Text.Length;
            }

         
            txtAdminsalary.TextChanged += txtAdminsalary_TextChanged;
        }

        private void datagridadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }
    }
}
