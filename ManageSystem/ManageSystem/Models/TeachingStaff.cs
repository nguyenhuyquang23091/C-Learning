using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSystem.DAL;

namespace ManageSystem.Models
{
    // 'TeachingStaff' class inheriting from the abstract 'User' class.
    // This class represents a specific type of user in the system.
    public class TeachingStaff : User
    {
        // Property to store the salary of the teaching staff member.
        public decimal Salary { get; private set; }

        // Property to store the first subject taught by the teaching staff member.
        public string Subject1 { get; private set; }

        // Property to store the second subject taught by the teaching staff member.
        public string Subject2 { get; private set; }

        // Constructor to initialize the 'TeachingStaff' object with specific details.
        public TeachingStaff(string name, string telephone, string email, decimal salary, string subject1, string subject2)
            : base(name, telephone, email, RoleType.TeachingStaff) // Call to the base class constructor.
        {
            Salary = salary;
            Subject1 = subject1;
            Subject2 = subject2;
        }

        // Override of the 'AddUser' method from the base 'User' class.
        // This method adds a new teaching staff member to the database.
        public override void AddUser()
        {
            var addteachstaff = new LoginRepository();
            addteachstaff.AddTeachingStaff(this); // Calls the repository to add this teaching staff member.
        }

        // Override of the 'EditUser' method from the base 'User' class.
        // This method updates the existing teaching staff member's details in the database.
        public override void EditUser()
        {
            var editteachstaff = new LoginRepository();
            editteachstaff.UpdateTeachingStaff(this); // Calls the repository to update this teaching staff member.
        }

        // Override of the 'DeleteUser' method from the base 'User' class.
        // This method deletes the teaching staff member from the database.
        public override void DeleteUser()
        {
            var deleteteachstaff = new LoginRepository();
            deleteteachstaff.DeleteTeachingStaff(this.ID); // Calls the repository to delete this teaching staff member by ID.
        }
    }
}
