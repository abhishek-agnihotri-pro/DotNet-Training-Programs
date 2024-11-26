using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient.Server;
using MVC_Code_First_Approach_EF.Models;

namespace MVC_Layout_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;
        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Employees;
            var departments = _context.Departments.ToDictionary(d => d.Id, d => d.Name);
            ViewBag.departments = departments;
            return View(data);
        }
        public IActionResult Create()
        {
            var department = _context.Departments.ToList().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name,
            });
            ViewBag.department = department;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee newStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(newStudent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            if (id == 0) return View();
            else
            {
                var data = _context.Employees.FirstOrDefault(y => y.ID == id);
                return View(data);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0) return View();
            else
            {
                var data = _context.Employees.FirstOrDefault(x => x.ID == id);
                if (data == null) return NotFound();
                return View(data);
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, Employee modified)
        {
            var data = _context.Employees.FirstOrDefault(y => y.ID == id);
            if (data == null)
            {
                return NotFound();
            }
            data.Name = modified.Name;
            data.Salary = modified.Salary;
            data.DepartmentID = modified.DepartmentID;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Employees.FirstOrDefault(y => y.ID == id);
            if (data == null) return NotFound();
            else
            {
                _context.Employees.Remove(data);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}