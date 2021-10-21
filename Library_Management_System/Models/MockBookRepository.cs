using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class MockBookRepository : IBookRepository
    {
        public List<Book> _bookList;

        public MockBookRepository()
        {
            _bookList = new List<Book>
                    {
                        new Book{ BookId = 1, BookName = "Harry Potter and the Sorcerer’s Stone", Author = "J.K.Rowling"},
                        new Book{ BookId = 2, BookName = "Harry Potter and the Chamber of Secrets", Author = "J.K.Rowling"},
                        new Book{ BookId = 3, BookName = "Harry Potter and the Prisoner of Azkaban", Author = "J.K.Rowling"},
                        new Book{ BookId = 4, BookName = "Harry Potter and the Goblet of Fire", Author = "J.K.Rowling"},
                        new Book{ BookId = 5, BookName = "Harry Potter and the Order of the Phoenix", Author = "J.K.Rowling"},
                        new Book{ BookId = 6, BookName = "Harry Potter and the Half-blood Prince", Author = "J.K.Rowling"},
                        new Book{ BookId = 7, BookName = "Harry Potter and the Deathly Hallows", Author = "J.K.Rowling"}
                    };
        }
        public Book AddBook()
        {
            throw new NotImplementedException();
        }

        public Book FindBook(int bookId)
        {
            return _bookList.FirstOrDefault(b => b.BookId == bookId);
        }
    }
}
