using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Authentication.Controllers
{
    public class StudentController : Controller
    {
        [Authorize]
        public IActionResult Index(){
            return View();
        }
    }
}