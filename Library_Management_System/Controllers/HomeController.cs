using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Library_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Library_Management_System.Controllers 
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _studentRepository;
        public HomeController(IUserRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public string Index()
        {
            return _studentRepository.GetStudent(1).UserName;
        }

        public ViewResult Details()
        {
            User user = _studentRepository.GetStudent(1);

            //ViewData["Student"] = model;
            //ViewData["PageTitle"] = "Student Details";

            //ViewBag.Student = model;
            ViewBag.PageTitle = "Home Page";

            return View(user);
        }  
        
        public ViewResult Login()
        {
            return View();
        }
    }
}
