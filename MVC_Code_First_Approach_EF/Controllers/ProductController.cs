using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient.Server;
using MVC_Code_First_Approach_EF.Models;

namespace MVC_Layout_Demo.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.ToDictionary(c => c.ID, c => c.Name);
            ViewBag.categories = categories;
            var data = _context.Products;
            return View(data);
        }
        public IActionResult Create()
        {
            var categories = _context.Categories.ToList().Select(x => new SelectListItem{
                Value = x.ID.ToString(),
                Text = x.Name,
            });
            ViewBag.category = categories;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product newStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(newStudent);
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
                var data = _context.Products.FirstOrDefault(y => y.ID == id);
                return View(data);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0) return View();
            else
            {
                var data = _context.Products.FirstOrDefault(x => x.ID == id);
                var categories = _context.Categories.ToList().Select(x => new SelectListItem{
                    Value = x.ID.ToString(),
                    Text = x.Name,
                });
                ViewBag.category = categories;
                if (data == null) return NotFound();
                return View(data);
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, Product modified)
        {
            var data = _context.Products.FirstOrDefault(y => y.ID == id);
            if (data == null)
            {
                return NotFound();
            }
            data.Name = modified.Name;
            data.Description = modified.Description;
            data.CategoryID = modified.CategoryID;
            data.Price = modified.Price;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Products.FirstOrDefault(y => y.ID == id);
            if (data == null) return NotFound();
            else
            {
                _context.Products.Remove(data);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}