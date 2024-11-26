using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_EDUHUB.Models;
using MVC_EDUHUB.Services;
using MVC_EDUHUB.ViewModel;

namespace MVC_EDUHUB.Controllers
{
    public class EducatorController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IEducatorService _educatorservice;
        private readonly ILogger<EducatorController> _logger;
        
        public EducatorController(AppDbContext context,IEducatorService educatorservice,ILogger<EducatorController> logger)
        {
            _context = context;
            _logger = logger;
            _educatorservice = educatorservice;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EducatorIndex()
        {
            int id = Convert.ToInt32(TempData["userId"]);
            TempData.Keep("userId");
            var user = _context.Users.FirstOrDefault(user => user.UserId == id);
            return View(user);
        }
        public IActionResult Login(){
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel login){
            _logger.LogWarning(login.Email);
            _logger.LogWarning(login.Password);
            var data = _educatorservice.GetEducator(login.Email,login.Password);
            if(data == null) return NotFound("Educator not found");
            _logger.LogWarning(data.Role);

            if(data.Role == "Educator"){
                TempData["Educator"] = data.UserName;
                TempData["UserId"] = data.UserId;
                TempData["Role"] = "Educator";
                TempData["ProfileImageEducator"] = data.ProfileImage;
                TempData.Keep("Role");
                TempData.Keep("UserId");
                TempData.Keep("Educator");
                TempData.Keep("ProfileImageEducator");
                return RedirectToAction("EducatorIndex");
            }
            return View();
        }
        public IActionResult Logout(){
            return RedirectToAction("Index","Home");
        }

    }
}