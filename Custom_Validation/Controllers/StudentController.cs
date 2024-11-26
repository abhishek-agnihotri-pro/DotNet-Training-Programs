using Custom_Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Custom_Validation.Controllers
{
    public class StudentController : Controller
    {
        
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Students;
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student newStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(newStudent);
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
                var data = _context.Students.FirstOrDefault(y => y.Id == id);
                return View(data);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0) return View();
            else
            {
                var data = _context.Students.FirstOrDefault(x => x.Id == id);
                if (data == null) return NotFound();
                return View(data);
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, Student modified)
        {
            var data = _context.Students.FirstOrDefault(y => y.Id == id);
            if (data == null)
            {
                return NotFound();
            }
            data.FirstName = modified.FirstName;
            data.LastName = modified.LastName;
            data.DOA = modified.DOA;

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Students.FirstOrDefault(y => y.Id == id);
            if (data == null) return NotFound();
            else
            {
                _context.Students.Remove(data);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}