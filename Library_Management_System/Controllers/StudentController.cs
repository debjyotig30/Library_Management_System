using Library_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUserRepository _studentRepository;
        public StudentController(IUserRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public string Index()
        {
            return _studentRepository.GetStudent(1).UserName;
        }

        public ViewResult Details()
        {
            User model = _studentRepository.GetStudent(1);
            ViewData["Student"] = model;
            ViewData["PageTitle"] = "Student Details";
            return View();
            
            //return View("../Home/Details");
            //return View("Views/Home/Details.cshtml");
            //return View("~/Views/Home/Details.cshtml");
        }
    }
}
