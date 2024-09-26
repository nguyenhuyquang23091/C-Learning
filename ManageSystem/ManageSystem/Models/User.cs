using ManageSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.Models
{
    public abstract class User : IUSer
    {
        public int ID { get; set; }
        private string _Name = "";
        private string _Telephone = "";
        private string _Email = "";
        private RoleType _RoleType;

        public User(string name, string telephone, string email, RoleType role)
        {
            _Name = name;
            _Telephone = telephone; // Use the property setter for validation
            _Email = email;
            _RoleType = role;
        }

        // Public properties with get and set methods
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public virtual string Telephone
        {
            get { return _Telephone; }
            set
            {
                _Telephone = value;
            }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public RoleType Role
        {
            get { return _RoleType; }
            set { _RoleType = value; }
        }

        public virtual void AddUser()
        {
           
        }

        public virtual void EditUser()
        {
          
        }

        public virtual void DeleteUser()
        {
            
        }
    }
}