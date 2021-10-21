using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public interface IBookRepository
    {
        Book AddBook();
        Book FindBook(int bookId);
    }
}
