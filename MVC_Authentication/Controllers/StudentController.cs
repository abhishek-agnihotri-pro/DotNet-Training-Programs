using Microsoft.AspNetCore.Mvc;

namespace MVC_Authentication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}