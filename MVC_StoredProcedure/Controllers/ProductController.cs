using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_StoredProcedure.Models;

namespace MVC_StoredProcedure.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context){
            _context = context;
        }
        public IActionResult GetProductByCategory(int id){
            // var data = _context.ProductsByCategory;
            var data = _context.ProductsByCategory.FromSqlInterpolated($"dbo.SP_ProductsByCatId {id}");
            return View(data);
        }
    }
}