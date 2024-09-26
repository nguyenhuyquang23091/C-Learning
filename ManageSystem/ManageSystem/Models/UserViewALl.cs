using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.Models
{
    public class UserViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string RoleType { get; set; }
        public decimal? Salary { get; set; }
        public int? WorkHours { get; set; }
        public bool? IsFullTime { get; set; }
        public string Subject1 { get; set; } // For TeachingStaff
        public string Subject2 { get; set; } // For TeachingStaff
        public string CurrentSubject1 { get; set; } // For Student
        public string CurrentSubject2 { get; set; } // For Student
        public string PreviousSubject1 { get; set; } // For Student
        public string PreviousSubject2 { get; set; } // For Student
        public string EmploymentType { get; set; } // For Administration
    }

}
