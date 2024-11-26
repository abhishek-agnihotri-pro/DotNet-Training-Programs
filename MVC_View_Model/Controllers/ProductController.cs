using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using MVC_View_Model.Models;

namespace MVC_View_Model.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Details(){
            Category C = new Category()
            {
                Id = 1,
                Catname = "Soap",
                products = new List<Product>()
                {
                    new Product() {Id = 1, ProductName = "Dove",Price = 25},
                    new Product() {Id = 2, ProductName = "Lux",Price = 40},
                    new Product() {Id = 3, ProductName = "Lyril",Price = 30},
                    new Product() {Id = 4, ProductName = "Santoor",Price = 30},
                }
            };
            return View(C);   
        }
    }
}