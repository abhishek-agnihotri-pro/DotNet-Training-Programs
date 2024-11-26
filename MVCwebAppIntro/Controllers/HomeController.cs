using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCwebAppIntro.Models;
 
 
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    const string CookieUserId = "UserId";
    const string CookieUserName = "UserName";
 
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
 
    public IActionResult Index()
    {
        CookieOptions options = new CookieOptions()
        {
            Domain = "localhost",
            Path = "/",
            Expires = DateTime.Now.AddDays(7),
            Secure = false,
            HttpOnly = true,
            IsEssential = true
        };
        Response.Cookies.Append(CookieUserId,"1234567",options);
        Response.Cookies.Append(CookieUserName,"a.a@gmail.com",options);
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
 