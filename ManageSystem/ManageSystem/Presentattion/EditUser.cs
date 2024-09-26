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
    public partial class EditUser : UserControl
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a role first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Teaching Staff":
                    panel1.Controls.Clear();
                    EditTeachingStaff editTeachingStaff = new EditTeachingStaff();
                    editTeachingStaff.Dock = DockStyle.Fill;
                    panel1.Controls.Add(editTeachingStaff);
                    break;
                case "Administration":
                    panel1.Controls.Clear();
                    EditAdministration editadmin = new EditAdministration();
                    editadmin.Dock = DockStyle.Fill;
                    panel1.Controls.Add(editadmin);
                    break;
                case "Student":
                    panel1.Controls.Clear();
                    EditStudent editstudent = new EditStudent();
                    editstudent.Dock = DockStyle.Fill;
                    panel1.Controls.Add(editstudent);
                    break;
                default:
                    MessageBox.Show("Invalid Role Selected", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}

