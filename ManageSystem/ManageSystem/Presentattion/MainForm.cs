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
using ManageSystem.Presentattion;

namespace ManageSystem
{
    public partial class MainForm : Form
    {
        bool sidebarexpand;
        private RoleService roleservice;
        public MainForm()
        {
            InitializeComponent();
            roleservice = new RoleService();
            sidebarcontainer.Width = sidebarcontainer.MinimumSize.Width;
            sidebarexpand = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SelectRole selectRoleForm = new SelectRole();
            if (selectRoleForm.ShowDialog() == DialogResult.OK)
            {
                string selectedRole = selectRoleForm.SelectedRole;
                MessageBox.Show($"Navigating to: {selectedRole}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (selectedRole == "Teaching Staff")
                {
                    // Clear the panel and add the user control
                    PanelContainer.Controls.Clear();
                    AddTeachingStaff teachingStaffControl = new AddTeachingStaff();
                    teachingStaffControl.Dock = DockStyle.Fill;
                    PanelContainer.Controls.Add(teachingStaffControl);
                    
                }
                else if (selectedRole == "Administration")
                {
                    PanelContainer.Controls.Clear();
                    AddAdministration administrationcontrol = new AddAdministration();
                    administrationcontrol.Dock = DockStyle.Fill;
                    PanelContainer.Controls.Add(administrationcontrol);
                }
                else
                {

                    PanelContainer.Controls.Clear();
                    AddStudent studentcontroll = new AddStudent();
                    studentcontroll.Dock = DockStyle.Fill;
                    PanelContainer.Controls.Add(studentcontroll);
                }

            }


        }


        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Loginform lfr = new Loginform();
                lfr.Show();
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void viewall_Click(object sender, EventArgs e)
        {
            // Clear existing controls in the PanelContainer
            PanelContainer.Controls.Clear();

            // Create a new instance of the ViewAll control
            ViewAll viewallcontroll = new ViewAll();

            // Set the control to fill the entire panel
            viewallcontroll.Dock = DockStyle.Fill;

            // Add the new control to the PanelContainer
            PanelContainer.Controls.Add(viewallcontroll);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            EditUser editUsercontroll = new EditUser();
            editUsercontroll.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(editUsercontroll);
        }

        private void addTeachingStaff1_Load_1(object sender, EventArgs e)
        {

        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void viewgroup_Click(object sender, EventArgs e)
        {
           
            PanelContainer.Controls.Clear();
            ViewByRole viewByRoleControl = new ViewByRole();
            viewByRoleControl.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(viewByRoleControl);
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                // Collapse the sidebar by reducing its width
                sidebarcontainer.Width -= 10;
                if (sidebarcontainer.Width <= sidebarcontainer.MinimumSize.Width)
                {
                    // Stop the timer and set the final width to the minimum size
                    sidebarcontainer.Width = sidebarcontainer.MinimumSize.Width;
                    sidebarexpand = false;
                    timer2.Stop();
                }
            }
            else
            {
                // Expand the sidebar by increasing its width
                sidebarcontainer.Width += 10;
                if (sidebarcontainer.Width >= sidebarcontainer.MaximumSize.Width)
                {
                    // Stop the timer and set the final width to the maximum size
                    sidebarcontainer.Width = sidebarcontainer.MaximumSize.Width;
                    sidebarexpand = true;
                    timer2.Stop();
                }
            }
        }

        private void sidebaricon_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
