using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC_Code_First_Approach_EF.Models;

namespace MVC_Code_First_Approach_EF.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;
        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Departments;
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department category)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(category);
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
                var data = _context.Departments.FirstOrDefault(y => y.Id == id);
                return View(data);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0) return View();
            else
            {
                var data = _context.Departments.FirstOrDefault(x => x.Id == id);
                if (data == null) return NotFound();
                return View(data);
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, Department modified)
        {
            var data = _context.Departments.FirstOrDefault(y => y.Id == id);
            if (data == null)
            {
                return NotFound();
            }
            data.Name = modified.Name;

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Departments.FirstOrDefault(y => y.Id == id);
            if (data == null) return NotFound();
            else
            {
                _context.Departments.Remove(data);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}