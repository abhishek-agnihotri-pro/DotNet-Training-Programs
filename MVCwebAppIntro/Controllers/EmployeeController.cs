using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVCwebAppIntro.Models;

namespace MVCwebAppIntro.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult GetEmployee()
        {
            ViewBag.employee = new Employee { EmpId = 1100, Name = "Abhishek Agni", Salary = 1200 };
            return View();
        }
        public IActionResult GetAllEmployees()
        {
            List<Employee> employees = new() { new Employee { EmpId = 1100, Name = "Abhishek Agni", Salary = 1200 }, new Employee { EmpId = 1100, Name = "Waren Buffet", Salary = 1200 }, new Employee { EmpId = 1100, Name = "Sanjay Gupta", Salary = 1200 } };
            ViewBag.employees = employees;
            return View();
        }
    }
}