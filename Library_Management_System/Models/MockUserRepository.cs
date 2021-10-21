using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class MockUserRepository : IUserRepository
    {
        public List<User> _userList;
        public MockUserRepository()
        {
            _userList = new List<User>()
                        {
                            new User() { Role = Role.Librarian, UserId = 1, UserName = "Mary", Department = "CSE", EmailId = "mary@lms.com" },
                            new User() { Role = Role.Student, UserId = 2, UserName = "John", Department = "ECE", EmailId = "john@lms.com" },
                            new User() { Role = Role.Student, UserId = 3, UserName = "Sam", Department = "EIE", EmailId = "sam@lms.com" },
                        }; 
        }

        public User GetStudent(int id)
        {
            return _userList.FirstOrDefault(s => s.UserId == id);
        }
    }
}
