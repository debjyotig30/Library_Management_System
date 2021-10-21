using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Controllers
{
    public class LibrarianController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
