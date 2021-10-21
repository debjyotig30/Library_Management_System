using Library_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Controllers
{
    public class DashboardController : Controller
    {
        MockBookRepository mockBookRepository = new MockBookRepository();
        MockUserRepository mockUserRepository = new MockUserRepository();

        public IActionResult Index()
        {
            return View();
        }

        //dashboard/findbook?bookId=7
        public ActionResult FindBook(int bookId)
        {
            Book b = mockBookRepository._bookList.FirstOrDefault(_b => _b.BookId == bookId);
            ViewBag.Book = b;
            ViewData["Book"] = b;
            ViewBag.PageTitle = "Book details";
            return View(b);
        }

        //dashboard/addbook?bookName=Book5&bookId=5&author=someAuthor
        public ActionResult AddBook(string bookName, int bookId, string author)
        {
            Book newBook = new Book(bookName, bookId, author);
            mockBookRepository._bookList.Add(newBook);
            ViewBag.PageTitle = "New book added successfully.";
            ViewData["NewBook"] = newBook;
            return View(newBook);
        }

        //dashboard/finduser?userid=1
        public ActionResult FindUser(int userId)
        {
            User user = mockUserRepository._userList.FirstOrDefault(_u => _u.UserId == userId);
            ViewBag.User = user;
            ViewData["User"] = user;
            ViewBag.PageTitle = "User details";
            return View(user);
        }

        //dashboard/adduser?role=1&userId=13&username=qwert&department=erfg&emailId=qwer@qwdf
        public ActionResult AddUser(Role role, int userId, string userName, string department, string emailId)
        {
            User newUser = new User(role, userId, userName, department, emailId);
            mockUserRepository._userList.Add(newUser);
            ViewBag.PageTitle = "New user added successfully.";
            ViewData["NewUser"] = newUser;
            return View(newUser);
        }


    }
}
