using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_PartialViewDemo.Models;

namespace MVC_PartialViewDemo.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(AppDbContext context, ILogger<DepartmentController> logger)
        {
            _logger = logger;
            _context = context;

        }
        public IActionResult Index()
        {
            var data = _context.Courses.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult GetEmployeeByDepartment(int? id)
        {
            if (id == null) NotFound();
            var model = _context.Departments.Include(e => e.Employees).FirstOrDefault(m => m.ID == id);
            return View(model);
        }
    }
}