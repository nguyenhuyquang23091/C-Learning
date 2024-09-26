using ManageSystem.BLL;
using ManageSystem.Models;
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
    public partial class EditStudent : UserControl
    {
        private readonly RoleService roleservice;
        public EditStudent()
        {
            InitializeComponent();
            roleservice = new RoleService();
            this.Load += EditStudent_Load;
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }
        private void LoadStudent()
        {
       
            var studentdatatable = roleservice.GetStudentDataTable();
            studatagrid.DataSource = studentdatatable;
        }
        private void studatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = studatagrid.Rows[e.RowIndex];
                txtStuname.Text = row.Cells["Name"].Value.ToString();
                txtStutelephone.Text = row.Cells["Telephone"].Value.ToString();
                txtStuemail.Text = row.Cells["Email"].Value.ToString();
                txtcurrentsubject1.Text = row.Cells["CurrentSubject1"].Value.ToString();
                txtcurrentsubject2.Text = row.Cells["CurrentSubject2"].Value.ToString();
                txtprevioussubject1.Text = row.Cells["PreviousSubject1"].Value.ToString();
                txtprevioussubject2.Text = row.Cells["PreviousSubject2"].Value.ToString();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row from the data grid
                var selectedrow = studatagrid.SelectedRows[0];
                int idcolumnindex = studatagrid.Columns["ID"].Index; // Get the index of the ID column

                // Retrieve input values from text fields
                string name = txtStuname.Text;
                string telephone = txtStutelephone.Text;
                string email = txtStuemail.Text;
                string currentsubject1 = txtcurrentsubject1.Text;
                string currentsubject2 = txtcurrentsubject2.Text;
                string previoussubject1 = txtprevioussubject1.Text;
                string previoussubject2 = txtprevioussubject2.Text;

                // Create a new Student object with the updated values
                var Student = new Student(name, telephone, email, currentsubject1, currentsubject2, previoussubject1, previoussubject2)
                {
                    ID = Convert.ToInt32(selectedrow.Cells[idcolumnindex].Value) // Set the ID from the selected row
                };

                // Update the student information in the database
                roleservice.UpdateStudent(Student);
                LoadStudent(); // Refresh the student list
                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Success message
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"An error occurred while updating the Student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any rows are selected in the data grid
                if (studatagrid.SelectedRows.Count > 0)
                {
                    var selectedRow = studatagrid.SelectedRows[0]; // Get the first selected row
                    int userId = Convert.ToInt32(selectedRow.Cells["ID"].Value); // Retrieve the user ID

                    // Call the service to delete the student
                    roleservice.DeleteStudent(userId);

                    LoadStudent(); // Refresh the student list

                    // Show success message
                    MessageBox.Show("Students deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Inform the user to select a record if none is selected
                    MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"An error occurred while deleting the Students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
