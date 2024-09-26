using ManageSystem.BLL;
using System;
using System.Windows.Forms;

namespace ManageSystem.Presentattion
{
    public partial class ViewByRole : UserControl
    {
        private readonly RoleService roleservice;
        public ViewByRole()
        {
            InitializeComponent();
            roleservice = new RoleService();
        }

        private void selectedrolebox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void check_Click(object sender, EventArgs e)
        {
            // Check if a role has been selected from the dropdown
            if (selectedrolebox.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if no role is selected
            }

            // Get the selected role as a string
            string selectedrole = selectedrolebox.SelectedItem.ToString();

            // Switch statement to handle different role types
            switch (selectedrole)
            {
                case "Teaching Staff":
                    label3.Text = "Teaching Staff Data:"; // Update label for teaching staff
                    label3.Visible = true; // Make the label visible
                    var teachstaffdatatable = roleservice.GetTeachingStaffDataTable(); // Retrieve data
                    roledata1.DataSource = teachstaffdatatable; // Bind data to grid
                    break;

                case "Administration":
                    label3.Text = "Administration Data:"; // Update label for administration
                    label3.Visible = true; // Make the label visible
                    var admindatatable = roleservice.GetAdministrationDataTable(); // Retrieve data
                    roledata1.DataSource = admindatatable; // Bind data to grid
                    break;

                case "Student":
                    label3.Text = "Student Data:"; // Update label for students
                    label3.Visible = true; // Make the label visible
                    var studentdatatable = roleservice.GetStudentDataTable(); // Retrieve data
                    roledata1.DataSource = studentdatatable; // Bind data to grid
                    break;
            }
        }

        private void roledata1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
