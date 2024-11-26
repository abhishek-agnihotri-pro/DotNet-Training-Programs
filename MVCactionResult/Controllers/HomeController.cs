using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCactionResult.Models;

namespace MVCactionResult.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int x = 10, y = 0;
            var z = x / y;

            return View("SecondView");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult SecondView()
        {
            return View();
        }
        public ContentResult Index1()
        {
            return Content("content view");
        }
        public FileResult Index2()
        {
            return File("~/Files/TextFile.txt", "text/plain");
        }
        public JsonResult index3()
        {
            return Json(new { Name = "Abhishek", ID = 1 });
        }

        public RedirectToRouteResult Index4()
        {
            return RedirectToRoute(new { Controller = "Student", Action = "StudentPrivacy" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
