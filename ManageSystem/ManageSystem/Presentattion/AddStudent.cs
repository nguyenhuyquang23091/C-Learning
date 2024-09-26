using ManageSystem.BLL;
using ManageSystem.Models;
using Mysqlx.Datatypes;
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
    public partial class AddStudent : UserControl
    {
        private readonly RoleService roleservice;
        public AddStudent()
        {
            InitializeComponent();
            roleservice = new RoleService();
            LoadStudent();
        }
        private void AddStudentData (object sender, EventArgs e)
        {
            LoadStudent();
        }
        private void LoadStudent()
        {
          
            var studentdatatable = roleservice.GetStudentDataTable();
            studatagrid.DataSource = studentdatatable;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool SubjectDuplicate(string currentsubject1, string currentsubject2, string previoussubject1, string previoussubject2)
        {
            bool currentDuplicate = !string.IsNullOrWhiteSpace(currentsubject1) &&
                                    !string.IsNullOrWhiteSpace(currentsubject2) &&
                                    currentsubject1.Equals(currentsubject2, StringComparison.OrdinalIgnoreCase);
            bool previousDuplicate = !string.IsNullOrWhiteSpace(previoussubject1) &&
                                    !string.IsNullOrWhiteSpace(previoussubject2) &&
                                    previoussubject1.Equals(previoussubject2, StringComparison.OrdinalIgnoreCase);
            return currentDuplicate || previousDuplicate;
        }
        private void Addclick_Click(object sender, EventArgs e)
        {
            string name = txtStuname.Text;
            string email = txtStuemail.Text;
            string telephone = txtStutelephone.Text;
            string currentsubject1 = txtcurrentsubject1.Text;
            string currentsubject2 = txtcurrentsubject2.Text;
            string previoussubject1 = txtprevioussubject1.Text;
            string previoussubject2 = txtprevioussubject2.Text;
            if (roleservice.CheckDuplicate(txtStuemail.Text))
            {
                MessageBox.Show("An user with this email already exists.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (telephone.Length > 11)
            {
                MessageBox.Show("Telephone number cannot exceed 11 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!telephone.All(char.IsDigit))
            {
                MessageBox.Show("Telephone number must be number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SubjectDuplicate(currentsubject1,currentsubject2,previoussubject1,previoussubject2))
            {
                MessageBox.Show("Subjects can't be the same", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var student = new Student(name, telephone, email, currentsubject1, currentsubject2, previoussubject1, previoussubject2);
            {
                try
                {
                    roleservice.AddStudent(student);
                    MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                }
           

        }

        private void studatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
