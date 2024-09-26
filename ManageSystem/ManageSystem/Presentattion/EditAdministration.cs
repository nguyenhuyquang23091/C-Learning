using ManageSystem.BLL;
using ManageSystem.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace ManageSystem.Presentattion
{
    public partial class EditAdministration : UserControl
    {
        private readonly RoleService roleservice;

        public EditAdministration()
        {
            InitializeComponent();
            roleservice = new RoleService();
            this.Load += EditAdminDataLoad;
        }

        private void EditAdminDataLoad(object sender, EventArgs e)
        {
            // Load administration data and populate the ComboBox
            LoadAdminData();
            txtAdminworktype.DataSource = Enum.GetValues(typeof(Administration.EmploymentType));
            txtAdminworktype.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadAdminData()
        {
            // Fetch and bind the administration data to the DataGridView
            var adminDataTable = roleservice.GetAdministrationDataTable();
            datagridadmin.DataSource = adminDataTable;
        }

        private void datagridadmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridadmin.Rows[e.RowIndex];

                // Populate text boxes with selected row data
                txtAdminName.Text = row.Cells["Name"].Value.ToString();
                txtAdmintelephone.Text = row.Cells["Telephone"].Value.ToString();
                txtAdminEmail.Text = row.Cells["Email"].Value.ToString();
                txtAdminsalary.Text = row.Cells["Salary"].Value.ToString();
                txtworkinghours.Text = row.Cells["WorkingHours"].Value.ToString();

                // Convert and set the EmploymentType value in the ComboBox
                var employmentTypeString = row.Cells["EmploymentType"].Value.ToString();
                if (Enum.TryParse(employmentTypeString, out Administration.EmploymentType employmentType))
                {
                    txtAdminworktype.SelectedItem = employmentType;
                }
                else
                {
                    MessageBox.Show($"Invalid Employment Type: {employmentTypeString}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateClick_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate and parse the EmploymentType from ComboBox
                if (txtAdminworktype.SelectedItem != null &&
                    Enum.TryParse(txtAdminworktype.SelectedItem.ToString(), out Administration.EmploymentType employmentType))
                {
                    // Get the selected row and other details
                    var selectedRow = datagridadmin.SelectedRows[0];
                    int idColumnIndex = datagridadmin.Columns["ID"].Index;
                    string name = txtAdminName.Text;
                    string telephone = txtAdmintelephone.Text;
                    string email = txtAdminEmail.Text;
                    decimal salary = Convert.ToDecimal(txtAdminsalary.Text);
                    int workhour = Convert.ToInt32(txtworkinghours.Text);

                    // Create Administration object and set its ID
                    var administration = new Administration(name, telephone, email, salary, workhour, employmentType)
                    {
                        ID = Convert.ToInt32(selectedRow.Cells[idColumnIndex].Value)
                    };

                    // Call the RoleService to update the Administration data
                    roleservice.UpdateAdministration(administration);
                    LoadAdminData();
                    MessageBox.Show("Administration updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a valid employment type.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the Administration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deleteadmin_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected in the DataGridView
                if (datagridadmin.SelectedRows.Count > 0)
                {
                    // Get the first selected row
                    var selectedRow = datagridadmin.SelectedRows[0];
                    // Retrieve the user ID from the selected row
                    int userId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                    // Call the DeleteAdministration method to delete the user
                    roleservice.DeleteAdministration(userId);

                    // Reload the DataGridView to reflect changes
                    LoadAdminData();

                    // Show a success message to the user
                    MessageBox.Show("Administration deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Prompt the user to select a record if none is selected
                    MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs during deletion
                MessageBox.Show($"An error occurred while deleting the Administration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
