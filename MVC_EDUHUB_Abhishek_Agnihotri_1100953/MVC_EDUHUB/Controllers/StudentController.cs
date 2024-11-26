using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_EDUHUB.Models;
using MVC_EDUHUB.Services;
using MVC_EDUHUB.ViewModel;

namespace MVC_EDUHUB.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IStudentService _studentservice;
        private readonly ILogger<StudentController> _logger;

        public StudentController(IStudentService studentservice, ILogger<StudentController> logger, AppDbContext context)
        {
            _logger = logger;
            _studentservice = studentservice;
            _context = context;
        }
        public IActionResult StudentIndex()
        {
            int id = Convert.ToInt32(TempData["userId"]);
            TempData.Keep("userId");
            var user = _context.Users.FirstOrDefault(user => user.UserId == id);
            return View(user);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            _logger.LogWarning(login.Email);
            _logger.LogWarning(login.Password);

            User student = _studentservice.GetStudent(login.Email, login.Password);
            if (student == null) return NotFound("Invalid Crediantials");
            _logger.LogWarning(student.Email + " " + student.Password + " " + student.Role);
            if (student.Role == "Student")
            {
                TempData["Student"] = student.UserName;
                TempData["UserId"] = student.UserId;
                TempData["Role"] = "Student";
                TempData["ProfileImageStudent"] = student.ProfileImage;
                // _logger.LogWarning(student.ProfileImage);
                TempData.Keep("Role");
                TempData.Keep("UserId");
                TempData.Keep("Student");
                TempData.Keep("ProfileImageStudent");
                return RedirectToAction("StudentIndex");
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}