

using Microsoft.AspNetCore.Mvc;

namespace MVCactionResult
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentPrivacy()
        {
            return View();
        }
    }
}