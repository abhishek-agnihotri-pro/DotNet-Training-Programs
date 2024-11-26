using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Mvc;

namespace MVCwebAppIntro.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            ViewData["name"] = "Abhishekekkk";
            ViewData["contact"] = "9098080785";
            List<string> fruits = new List<string> { "Apple", "Banana", "Guava", "Grapes" };
            ViewData["fruits"] = fruits;
            return View();
        }

        public IActionResult ViewBagMethod()
        {
            ViewBag.company = "Yash Tech";
            ViewBag.today = DateTime.Now;
            List<string> fruits = new List<string> { "PineApple", "Tomato", "Dragon ki Sabji" };
            ViewBag.fruits = fruits;
            return View();
        }

    }

}