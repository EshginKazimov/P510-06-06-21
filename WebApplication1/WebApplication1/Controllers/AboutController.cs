using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
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

            var groups = new List<Group>
            {
                new Group {Name = "P510"},
                new Group {Name = "P316"},
                new Group {Name = "P317"}
            };

            var aboutViewModel = new AboutViewModel
            {
                Students = students,
                Groups = groups
            };

            return View(aboutViewModel);
        }

        public IActionResult Info()
        {
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

            return View(students);
        }
    }
}
