using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var viewResult = new ViewResult();
            //viewResult.ViewName = "Index";

            //return viewResult;

            ViewBag.Hello = "Hello P510!";
            ViewData["Bye"] = "Bye P510";
            TempData["Group"] = "P510";

            var student = new Student
            {
                Name = "Talish",
                Surname = "Suleymanli"
            };
            ViewBag.Student = student;

            var students = new List<Student>
            {
                new Student
                {
                    Name = "Talish",
                    Surname = "Suleymanli"
                },
                new Student
                {
                    Name = "Tural",
                    Surname = "Suleymanli"
                }
            };
            ViewBag.Students = students;

            return View();
            //return RedirectToAction("Create");

            //return Json(new {name = "P510"});
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
