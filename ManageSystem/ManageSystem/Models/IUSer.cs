using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.Models
{
    // Define an interface named 'IUser' that represents the contract for user-related operations.
    public interface IUSer
    {
        // Property for getting the user's name.
        string Name { get; }

        // Property for getting the user's email address.
        string Email { get; }

        // Property for getting the user's telephone number.
        string Telephone { get; }

        // Method for adding a new user. The implementation will define the details.
        void AddUser();

        // Method for editing an existing user. The implementation will define the details.
        void EditUser();

        // Method for deleting an existing user. The implementation will define the details.
        void DeleteUser();
    }
}
