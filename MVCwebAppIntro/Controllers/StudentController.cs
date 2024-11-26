using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVCwebAppIntro.Models;

namespace MVCwebAppIntro.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetStudent()
        {
            // List<Student> students = new List<Student> { new Student { ID = 1, Name = "Abhishek A", Marks = 99 }, new Student { ID = 1, Name = "Ankit A", Marks = 99 } };


            // ViewData["student"] = new Student { ID = 1, Name = "Abhishek A", Marks = 99 };
            Student s = new Student { ID = 1, Name = "Abhishek A", Marks = 99 };
            // return View();
            return View(s);
        }
        public IActionResult GetAllStudent()
        {
            List<Student> students = new List<Student> { new Student { ID = 1, Name = "Abhishek A", Marks = 99 }, new Student { ID = 1, Name = "Ankit A", Marks = 99 }, new Student { ID = 1, Name = "Disjoint Set", Marks = 99 } };


            // ViewData["students"] = students;
            // ViewBag.students = students;
            // return View();
            return View(students);
        }
    }
}