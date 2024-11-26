using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVCTagHelper.Models;

namespace MVC_TagHelper_Demo.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> studlist = new List<Student>();
        static StudentController()
        {
            studlist = new List<Student>()
            {
                new Student(){StudentID=101,Name="John",Branch=Branch.CSE,Gender=Gender.Male},
                new Student(){StudentID=102,Name="Olivi",Branch=Branch.ETC,Gender=Gender.Female},
                new Student(){StudentID=103,Name="David",Branch=Branch.Mech,Gender=Gender.Male}
            };
        }
        [HttpGet]
        public ViewResult Index()
        {
            return View(studlist);
        }
        public ViewResult Details(int Id)
        {
            var studenDetails = studlist.FirstOrDefault(std => std.StudentID == Id);
            return View(studenDetails);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Student student = new Student
            {
                AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList()
            };
            return View(student);
        }
        [HttpPost]
        public ActionResult Create(Student newstudent)
        {
            studlist.Add(newstudent);
            return RedirectToAction("Index");
        }
    }
}