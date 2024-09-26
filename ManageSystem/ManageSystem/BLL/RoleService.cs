using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageSystem.DAL;
using ManageSystem.Models;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Mysqlx.Crud;

namespace ManageSystem.BLL
{
    public class RoleService
    {
        private readonly LoginRepository roleRepository;
        public RoleService()
        {
            roleRepository = new LoginRepository();
        }
       
        public void RegisterUser(string username, string password)
        {
            roleRepository.RegisterUser(username, password);
        }
        public bool ValidateUser(string username, string password)
        {
            // Call the ValidateUser method in the roleRepository to authenticate the user
            // It returns true if the username and password match a record in the database
            return roleRepository.ValidateUser(username, password);
        }
        public void TestConnection()
        {
            roleRepository.TestConnection();
        }

        public void AddTeachingStaff(IUSer teachingStaff)
        {
            teachingStaff.AddUser();
        }
        public void AddAdministration(IUSer administration)
        { 
            administration.AddUser(); 

        }
        public void AddStudent(IUSer student)
        {
            student.AddUser(); // Calls the AddUser method on the IUser instance to add the student
        }

        // Convert the List<TeachingStaff> to a DataTable
        public DataTable ConvertToDataTable(List<TeachingStaff> list)
        {
            // Create a new DataTable to hold the teaching staff data
            var dataTable = new DataTable();

            // Define columns for the DataTable
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Telephone");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Salary");
            dataTable.Columns.Add("Subject1");
            dataTable.Columns.Add("Subject2");

            // Iterate over the list of TeachingStaff objects
            foreach (var teachStaff in list)
            {
                // Add a new row to the DataTable for each TeachingStaff object
                dataTable.Rows.Add(
                    teachStaff.ID,
                    teachStaff.Name,
                    teachStaff.Telephone,
                    teachStaff.Email,
                    teachStaff.Salary,
                    teachStaff.Subject1,
                    teachStaff.Subject2
                );
            }

            // Return the populated DataTable
            return dataTable;
        }

        // Fetch the data from DAL, then convert it to DataTable
        public DataTable GetTeachingStaffDataTable()
        {
            // Retrieve the list of teaching staff from the repository
            var teachingstafflist = roleRepository.GetTeachingStaffList();

            // Convert the list of teaching staff to a DataTable and return it
            return ConvertToDataTable(teachingstafflist);
        }
        public DataTable ConvertAdminDataTable(List<Administration> adminlist)
        {
            // Create a new DataTable to hold administration data
            var admindatatable = new DataTable();

            // Define the columns for the DataTable
            admindatatable.Columns.Add("ID");
            admindatatable.Columns.Add("Name");
            admindatatable.Columns.Add("Telephone");
            admindatatable.Columns.Add("Email");
            admindatatable.Columns.Add("Salary");
            admindatatable.Columns.Add("EmploymentType");
            admindatatable.Columns.Add("WorkingHours");

            // Populate the DataTable with data from the admin list
            foreach (var admin in adminlist)
            {
                admindatatable.Rows.Add(
                    admin.ID,
                    admin.Name,
                    admin.Telephone,
                    admin.Email,
                    admin.Salary,
                    admin.Employment.ToString(),
                    admin.Workhour
                );
            }

            // Return the populated DataTable
            return admindatatable;
        }

        public DataTable GetAdministrationDataTable()
        {
            // Retrieve the list of administrations from the repository
            var administrationlist = roleRepository.GetAdministrations();

            // Convert the list to a DataTable and return it
            return ConvertAdminDataTable(administrationlist);
        }
        public DataTable ConvertStudentDataTable(List<Student> studentlist)
        {
            var studenttable = new DataTable(); // Initialize a new DataTable
                                                // Define columns for the DataTable
            studenttable.Columns.Add("ID");
            studenttable.Columns.Add("Name");
            studenttable.Columns.Add("Telephone");
            studenttable.Columns.Add("Email");
            studenttable.Columns.Add("CurrentSubject1");
            studenttable.Columns.Add("CurrentSubject2");
            studenttable.Columns.Add("PreviousSubject1");
            studenttable.Columns.Add("PreviousSubject2");

            // Populate the DataTable with student data
            foreach (var student in studentlist)
            {
                studenttable.Rows.Add(student.ID, student.Name, student.Telephone, student.Email,
                    student.Subject1, student.Subject2, student.Presubject1, student.Presubject2);
            }

            return studenttable; // Return the populated DataTable
        }

        public DataTable GetStudentDataTable()
        {
            var studentlist = roleRepository.GetStudents(); // Retrieve the list of students
            return ConvertStudentDataTable(studentlist); // Convert the list to a DataTable
        }
        public void UpdateTeachingStaff(TeachingStaff teachingStaff)
        {
            // Call the repository method to update the teaching staff information in the database
            roleRepository.UpdateTeachingStaff(teachingStaff);
        }
        public void UpdateAdministration(Administration administration)
        {

            // Call the repository method to update the administration information in the database
            roleRepository.UpdateAdministration(administration);
        }
        public void UpdateStudent(Student student)
        {
            // Call the repository method to update the student information in the database
            roleRepository.UpdateStudent(student);
        }
        public void DeleteTeachingStaff(int userId)
        {
            // Calls the repository method to delete the teaching staff record based on userId
            roleRepository.DeleteTeachingStaff(userId);
        }
        public void DeleteAdministration(int userId)
        {
            // Calls the repository method to delete the administration record based on userId
            roleRepository.DeleteAdministration(userId);
        }
        public void DeleteStudent(int userId)
        {
            // Calls the repository method to delete the student record based on userId
            roleRepository.DeleteStudent(userId);
        }
        public bool CheckDuplicate(string email)
        {
            // Calls the repository method to check the user record based on email
            return roleRepository.CheckDuplicateUser(email);
        }
        public DataTable ConvertUserDataToDataTable(List<UserViewModel> userViewModels)
        {
            // Create a new DataTable to hold user data
            var dataTable = new DataTable();

            // Define columns for the DataTable with appropriate data types
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Telephone", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("RoleType", typeof(string));
            dataTable.Columns.Add("Salary", typeof(decimal));
            dataTable.Columns.Add("WorkHours", typeof(int));
            dataTable.Columns.Add("Subject1", typeof(string));
            dataTable.Columns.Add("Subject2", typeof(string));
            dataTable.Columns.Add("CurrentSubject1", typeof(string));
            dataTable.Columns.Add("CurrentSubject2", typeof(string));
            dataTable.Columns.Add("PreviousSubject1", typeof(string));
            dataTable.Columns.Add("PreviousSubject2", typeof(string));
            dataTable.Columns.Add("EmploymentType", typeof(string));

            // Populate the DataTable rows with user data
            foreach (var user in userViewModels)
            {
                dataTable.Rows.Add(
                    user.ID,
                    user.Name,
                    user.Telephone,
                    user.Email,
                    user.RoleType,
                    // Use DBNull.Value for nullable Salary
                    user.Salary.HasValue ? (object)user.Salary.Value : DBNull.Value,
                    // Use DBNull.Value for nullable WorkHours
                    user.WorkHours.HasValue ? (object)user.WorkHours.Value : DBNull.Value,
                    // Use DBNull.Value for nullable subjects
                    user.Subject1 ?? (object)DBNull.Value,
                    user.Subject2 ?? (object)DBNull.Value,
                    user.CurrentSubject1 ?? (object)DBNull.Value,
                    user.CurrentSubject2 ?? (object)DBNull.Value,
                    user.PreviousSubject1 ?? (object)DBNull.Value,
                    user.PreviousSubject2 ?? (object)DBNull.Value,
                    user.EmploymentType ?? (object)DBNull.Value
                );
            }

            // Return the populated DataTable
            return dataTable;
        }

        public DataTable GetAllUserData()
        {
            // Retrieve all user data from the repository
            var userdatalist = roleRepository.GetAllData();
            // Convert the user data list to a DataTable and return it
            return ConvertUserDataToDataTable(userdatalist);
        }



    }
}
