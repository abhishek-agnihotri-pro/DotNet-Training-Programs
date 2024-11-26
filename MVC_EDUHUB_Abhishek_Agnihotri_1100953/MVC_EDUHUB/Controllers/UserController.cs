using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_EDUHUB.Models;
using MVC_EDUHUB.Services;
using MVC_EDUHUB.ViewModel;

namespace MVC_EDUHUB.Controllers
{
    public class UserController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly AppDbContext _context;
        private readonly ILogger<UserController> _logger;

        private readonly IUserService _userservice;

        public UserController(IWebHostEnvironment environment, IUserService userservice, ILogger<UserController> logger)
        {
            _environment = environment; 
            _logger = logger;
            _userservice = userservice;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            List<SelectListItem> userroles = new List<SelectListItem>(){new SelectListItem { Text = "Educator", Value = "Educator" },
            new SelectListItem{ Text="Student",Value="Student"},
            };
            ViewBag.role = userroles;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User user)
        {
            _logger.LogWarning(user.FullName);
            if (ModelState.IsValid)
            {
                if (user.Img != null)
                {
                    // _logger.LogWarning("--Reached--------------");
                    string uploadsFolder = Path.Combine(_environment.WebRootPath);
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + user.Img.FileName;
                    // _logger.LogWarning(uniqueFileName + "----------------");
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        user.Img.CopyTo(fileStream);
                    }

                    user.ProfileImage = uniqueFileName;
                }
            }

            if (user == null) return NotFound("User is empty");
            _userservice.CreateUser(user);
            if (user.Role?.ToLower() == "student")
                return RedirectToAction("Login", "Student");
            else if (user.Role?.ToLower() == "educator")
                return RedirectToAction("Login", "Educator");
            else
                return RedirectToAction("Index", "Home");
        }
        public IActionResult EducatorIndex()
        {
            return View();
        }
        public IActionResult EducatorLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EducatorLogin(LoginViewModel login)
        {
            _logger.LogWarning(login.Email);
            _logger.LogWarning(login.Password);
            var data = _userservice.GetEducator(login.Email, login.Password);
            if (data == null) return NotFound("Educator not found");
            _logger.LogWarning(data.Role);

            if (data.Role == "Educator")
            {
                TempData["Educator"] = data.UserName;
                TempData["UserId"] = data.UserId;
                return RedirectToAction("EducatorIndex");
            }
            return View();
        }
        public IActionResult StudentLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StudentLogin(LoginViewModel login)
        {
            // _logger.LogWarning(user.Email);
            // _logger.LogWarning(user.Password);
            // return RedirectToAction("Index","Home");
            return View();
        }
        public IActionResult StudentIndex()
        {
            return View();
        }

        // [HttpGet]
        //     public IActionResult AddUser()
        //     {
        //         List<SelectListItem> userroles = new List<SelectListItem>()
        //    {new SelectListItem { Text = "Educator", Value = "Educator" },
        //     new SelectListItem{ Text="Student",Value="student"},
        //       };
        //         ViewBag.role = userroles;
        //         return View();
        //     }
        [HttpPost]
        public IActionResult AddUser(User newuser)
        {
            _userservice.CreateUser(newuser);
            return RedirectToAction("Index");
        }
    }
}