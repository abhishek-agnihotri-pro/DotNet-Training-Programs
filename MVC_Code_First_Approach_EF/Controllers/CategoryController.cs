using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC_Code_First_Approach_EF.Models;

namespace MVC_Code_First_Approach_EF.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Categories;
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
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
                var data = _context.Categories.FirstOrDefault(y => y.ID == id);
                return View(data);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0) return View();
            else
            {
                var data = _context.Categories.FirstOrDefault(x => x.ID == id);
                if (data == null) return NotFound();
                return View(data);
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, Category modified)
        {
            var data = _context.Categories.FirstOrDefault(y => y.ID == id);
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
            var data = _context.Categories.FirstOrDefault(y => y.ID == id);
            if (data == null) return NotFound();
            else
            {
                _context.Categories.Remove(data);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}