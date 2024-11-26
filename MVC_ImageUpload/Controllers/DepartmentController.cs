using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_ImageUpload.Models;

namespace MVC_ImageUpload.Controllers;

public class DepartmentController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public DepartmentController(AppDbContext context,ILogger<HomeController> logger)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var data = _context.Departments.ToList();
        return View(data);
    }
}