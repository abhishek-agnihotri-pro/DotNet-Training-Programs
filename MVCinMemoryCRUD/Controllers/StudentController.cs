using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVCinMemoryCRUD.Models;
using MVCinMemoryCRUD.Service;

namespace MVC_ActionResult_Demo.Controllers
{
    public class StudentController : Controller
    {
        // [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = StudentService.GetAll();
            return View(students);
        }
        public IActionResult Details(int id)
        {
            var data = StudentService.GetStudentById(id);
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student newStudent)
        {
            StudentService.Add(newStudent);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int ID)
        {
            var data = StudentService.GetStudentById(ID);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Student modified)
        {
            StudentService.Update(modified);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            // StudentService.Delete(id);
            // return RedirectToAction("Index");
            var data = StudentService.GetStudentById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(int id, Student stud)
        {
            StudentService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}