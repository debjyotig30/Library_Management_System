using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class User
    {
        public Role Role { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Department { get; set; }
        public string EmailId { get; set; }

        public User()
        {

        }

        public User(Role role, int userId, string userName, string department, string emailId)
        {
            Role = role;
            UserId = userId;
            UserName = userName;
            Department = department;
            EmailId = emailId;
        }
    }
}
