using ManageSystem.DAL;
using System;

namespace ManageSystem.Models
{
    public class Student : User
    {
        // Properties to store the subjects associated with the student.
        public string Subject1 { get; private set; }
        public string Subject2 { get; private set; }
        public string Presubject1 { get; private set; }
        public string Presubject2 { get; private set; }

        // Constructor to initialize the 'Student' object with specific details.
        public Student(string name, string telephone, string email, string subject1, string subject2, string presubject1, string presubject2)
            : base(name, telephone, email, RoleType.Student) // Call to the base class constructor.
        {
            Subject1 = subject1; // Assign first subject to the property.
            Subject2 = subject2; // Assign second subject to the property.
            Presubject1 = presubject1; // Assign pre-subject one to the property.
            Presubject2 = presubject2; // Assign pre-subject two to the property.
        }

        // Override of the 'AddUser' method from the base 'User' class.
        public override void AddUser()
        {
            var addstudent = new LoginRepository(); // Create repository instance.
            addstudent.AddStudent(this); // Calls the repository to add this student.
        }

        // Override of the 'EditUser' method from the base 'User' class.
        public override void EditUser()
        {
            var editstudent = new LoginRepository(); // Create repository instance.
            editstudent.UpdateStudent(this); // Calls the repository to update this student.
        }

        // Override of the 'DeleteUser' method from the base 'User' class.
        public override void DeleteUser()
        {
            var deletestudent = new LoginRepository(); // Create repository instance.
            deletestudent.DeleteStudent(this.ID); // Calls the repository to delete this student by ID.
        }
    }
}