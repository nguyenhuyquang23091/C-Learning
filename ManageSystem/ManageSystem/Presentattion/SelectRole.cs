using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem
{
    public partial class SelectRole : Form
    {
        public string SelectedRole{get; private set;}
        public SelectRole()
        {
            InitializeComponent();
        }

        private void SelectRole_Load(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Teachingstaff.Checked)
            {
                SelectedRole = "Teaching Staff";
                AddAdministration addteachingstaff = new AddAdministration();
                addteachingstaff.Show();
            }
            else if(Administration.Checked)
            {
                SelectedRole = "Administration";
            }
            else if (Student.Checked)
            {
                SelectedRole = "Student";
            }
            else
            {
                MessageBox.Show("Please select a role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Teachingstaff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Administration_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Student_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            // Close the form
            this.Close();
        }
    }

}
