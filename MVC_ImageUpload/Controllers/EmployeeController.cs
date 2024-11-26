using System.Diagnostics;
using MVC_ImageUpload.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_ImageUpload.ViewModel;


namespace MVC_ImageUpload.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;
    private readonly IWebHostEnvironment _hostingEnvironment;
    public EmployeeController(AppDbContext context, ILogger<HomeController> logger, IWebHostEnvironment hostingEnvironment)
    {
        _logger = logger;
        _context = context;
        _hostingEnvironment = hostingEnvironment;
    }

    public IActionResult Index()
    {
        var data = _context.Employees.ToList();
        return View(data);
    }
    [HttpGet]
    public IActionResult Create(){
        var deptlist = from dep in _context.Departments 
        select new SelectListItem()
        {
            Text = dep.Name,
            Value = dep.Id.ToString(),
        };
        ViewBag.departments = deptlist;
        return View();
    }
    [HttpPost]
    public IActionResult Create(EmployeeCreateViewModel model){
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
 
                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.Photopath != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photopath.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.Photopath.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Employee newEmployee = new Employee{
                    Name = model.Name,
                    Salary = model.Salary,
                    deptId = model.deptId,
                    DOJ = model.DOJ,
                    Gender = model.Gender,
                    Photopath = uniqueFileName,
                };







                
                _context.Employees.Add(newEmployee);
                _context.SaveChanges();
                return RedirectToAction("details", new { id = newEmployee.Id});
        }
        return View();
    }
}