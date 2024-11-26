using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Session_Demo.Models;

namespace MVC_Session_Demo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private const string SessionName = "_Name";
    private const string SessionAge = "_Age";

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HttpContext.Session.SetString(SessionName,"Abhishek");
        HttpContext.Session.SetInt32(SessionAge,20);
        return View();
    }

    public IActionResult About()
    {
        ViewBag.Name = HttpContext.Session.GetString(SessionName);
        ViewBag.Age = HttpContext.Session.GetInt32(SessionAge);
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
