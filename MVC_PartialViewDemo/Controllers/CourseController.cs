using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_PartialViewDemo.Models;

namespace MVC_PartialViewDemo.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<CourseController> _logger;
        
        public CourseController(AppDbContext context,ILogger<CourseController> logger)
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
        public IActionResult GetStudentByCourse(int? id)
        {
            if(id == null) NotFound();
            var model = _context.Courses.Include(s => s.Students).FirstOrDefault(m => m.ID == id);
            return View(model);
        }
    }
}