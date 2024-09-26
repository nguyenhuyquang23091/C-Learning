using ManageSystem.DAL; 
using System; 
using System.Collections.Generic; 
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace ManageSystem.Models
{
    public class Administration : User // Administration class inherits from User
    {
        public decimal Salary { get; private set; } // Salary property, only settable within the class
        public int Workhour { get; private set; } // Workhour property, only settable within the class
        public EmploymentType Employment { get; private set; } // Employment type property

        // Enum to define employment types
        public enum EmploymentType
        {
            FullTime, // Full-time employment
            PartTime // Part-time employment
        }

        // Constructor to initialize Administration object with relevant details
        public Administration(string name, string telephone, string email, decimal salary, int workhour, EmploymentType employmentType)
            : base(name, telephone, email, RoleType.Administration) // Call to base class constructor
        {
            Salary = salary; // Set the salary
            Workhour = workhour; // Set the work hours
            Employment = employmentType; // Set the employment type
        }

        // Method to add a new administration user
        public override void AddUser()
        {
            var addadministration = new LoginRepository(); // Create instance of LoginRepository
            addadministration.AddAdministration(this); // Call method to add administration data
        }

        // Method to edit an existing administration user
        public override void EditUser()
        {
            var editadmin = new LoginRepository(); // Create instance of LoginRepository
            editadmin.UpdateAdministration(this); // Call method to update administration data
        }

        // Method to delete an administration user
        public override void DeleteUser()
        {
            var deleteadmin = new LoginRepository(); // Create instance of LoginRepository
            deleteadmin.DeleteAdministration(this.ID); // Call method to delete administration data using ID
        }
    }
}