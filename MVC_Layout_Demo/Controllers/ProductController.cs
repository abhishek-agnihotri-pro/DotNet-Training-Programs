using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC_Layout_Demo.Models;

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
            var data = _context.Products;
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(newProduct);
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
                var data = _context.Products.FirstOrDefault(y => y.Id == id);
                return View(data);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0) return View();
            else
            {
                var data = _context.Products.FirstOrDefault(x => x.Id == id);
                if (data == null) return NotFound();
                return View(data);
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, Product modified)
        {
            var data = _context.Products.FirstOrDefault(y => y.Id == id);
            if (data == null)
            {
                return NotFound();
            }
            data.Name = modified.Name;
            data.Quantity = modified.Quantity;
            data.Price = modified.Price;
            data.Expire = modified.Expire;
            data.Description = modified.Description;
            data.Active = modified.Active;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Products.FirstOrDefault(y => y.Id == id);
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