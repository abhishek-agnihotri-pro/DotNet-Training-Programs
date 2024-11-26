using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_EDUHUB.Models;
using MVC_EDUHUB.Services;
using MVC_EDUHUB.ViewModel;

namespace MVC_EDUHUB.Controllers
{
    public class EducatorController : Controller
    {
        // Fields for database context, service, and logger
        private readonly AppDbContext _context;
        private readonly IEducatorService _educatorservice;
        private readonly ILogger<EducatorController> _logger;
        
        // Constructor to initialize dependencies
        public EducatorController(AppDbContext context, IEducatorService educatorservice, ILogger<EducatorController> logger)
        {
            _context = context; // Assign context
            _logger = logger;   // Assign logger
            _educatorservice = educatorservice; // Assign educator service
        }

        // Action method to display the main index view
        public IActionResult Index()
        {
            return View(); // Return the index view
        }

        // Action method to display educator-specific index view
        public IActionResult EducatorIndex()
        {
            int id = Convert.ToInt32(TempData["userId"]); // Retrieve user ID from TempData
            TempData.Keep("userId"); // Keep user ID in TempData for later use
            var user = _context.Users.FirstOrDefault(user => user.UserId == id); // Find user by ID
            return View(user); // Return the educator view with user data
        }

        // Action method to display the login view
        public IActionResult Login()
        {
            return View(); // Return the login view
        }

        // POST action method for handling login
        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            // Log the email and password (for debugging purposes)
            _logger.LogWarning(login.Email);
            _logger.LogWarning(login.Password);

            // Authenticate educator using the provided credentials
            var data = _educatorservice.GetEducator(login.Email, login.Password);
            if (data == null) return NotFound("Educator not found"); // Return not found if no educator is found

            _logger.LogWarning(data.Role); // Log the role of the authenticated user

            // Check if the user is an educator
            if (data.Role == "Educator")
            {
                // Store educator information in TempData
                TempData["Educator"] = data.UserName;
                TempData["UserId"] = data.UserId;
                TempData["Role"] = "Educator";
                TempData["ProfileImageEducator"] = data.ProfileImage;
                TempData.Keep("Role");
                TempData.Keep("UserId");
                TempData.Keep("Educator");
                TempData.Keep("ProfileImageEducator");
                return RedirectToAction("EducatorIndex"); // Redirect to the educator index view
            }
            return View(); // Return to login view if not an educator
        }

        // Action method to handle logout
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home"); // Redirect to home index after logout
        }
    }
}