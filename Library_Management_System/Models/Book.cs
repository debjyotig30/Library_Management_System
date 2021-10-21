using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Book
    {
        public string BookName { get; set; }
        public int BookId { get; set; }
        public string Author { get; set; }

        public Book()
        {

        }

        public Book(string bookName, int bookId, string author)
        {
            BookName = bookName;
            BookId = bookId;
            Author = author;
        }
    }
}
