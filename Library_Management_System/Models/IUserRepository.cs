using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public interface IUserRepository
    {
        User GetStudent(int id);
    }
}
