using ManageSystem.BLL;
using ManageSystem.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace ManageSystem.Presentattion
{
    public partial class EditTeachingStaff : UserControl
    {
        private readonly RoleService roleservice; 

        public EditTeachingStaff()
        {
            roleservice = new RoleService(); // Initialize the RoleService instance
            InitializeComponent(); // Set up the UI components
            this.Load += EditTeachingDataLoad; // Subscribe to the Load event to load data
        }

        private void EditTeachingDataLoad(object sender, EventArgs e)
        {
            // Load teaching staff data when the user control is loaded
            LoadTeachingStaffData();
        }

        private void LoadTeachingStaffData()
        {
            // Retrieve teaching staff data and bind it to the DataGridView
            var teachstaffdatatable = roleservice.GetTeachingStaffDataTable();
            editteachgrid.DataSource = teachstaffdatatable; // Set the data source for the grid
        }

        private void editteachgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = editteachgrid.Rows[e.RowIndex]; // Get the clicked row

                // Populate text boxes with the selected row's data
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtTelephone.Text = row.Cells["Telephone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
                txtSubject1.Text = row.Cells["Subject1"].Value.ToString();
                txtSubject2.Text = row.Cells["Subject2"].Value.ToString();
            }
        }

        private void EditTeachingStaff_Load(object sender, EventArgs e)
        {
            // Placeholder for any additional setup when the control loads, currently empty
        }

        private void Updateclick_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row from the DataGridView
                var selectedRow = editteachgrid.SelectedRows[0];
                int idColumnIndex = editteachgrid.Columns["ID"].Index; // Get the index of the ID column

                // Retrieve values from the text boxes
                string name = txtName.Text;
                string telephone = txtTelephone.Text;
                string email = txtEmail.Text;
                decimal salary = Convert.ToDecimal(txtSalary.Text); // Convert salary to decimal
                string subject1 = txtSubject1.Text;
                string subject2 = txtSubject2.Text;

                // Create a new TeachingStaff object with the updated data
                var teachingStaff = new TeachingStaff(name, telephone, email, salary, subject1, subject2)
                {
                    ID = Convert.ToInt32(selectedRow.Cells[idColumnIndex].Value) // Set the ID from the selected row
                };

                // Update the teaching staff data using the RoleService
                roleservice.UpdateTeachingStaff(teachingStaff);

                // Reload the teaching staff data to refresh the grid
                LoadTeachingStaffData();

                // Show a success message to the user
                MessageBox.Show("Teaching Staff updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs during the update
                MessageBox.Show($"An error occurred while updating the Teaching Staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

    private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void editteachgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (editteachgrid.SelectedRows.Count > 0)
                {
                    var selectedRow = editteachgrid.SelectedRows[0];
                    int userId = Convert.ToInt32(selectedRow.Cells["ID"].Value);


                    roleservice.DeleteTeachingStaff(userId);

                    
                    LoadTeachingStaffData();

                    MessageBox.Show("Teaching Staff deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the Teaching Staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
