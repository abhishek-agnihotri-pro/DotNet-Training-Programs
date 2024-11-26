using Microsoft.AspNetCore.Mvc;

namespace MVC_Attribute_Routing_Demo.Controllers
{
    [Route("emp")]
    public class EmployeeController : Controller
    {
        [Route("home")]
        [Route("index")]
        public IActionResult Index(){
            return View();
        }
        [Route("hello")]
        [Route("welcome")]
        public IActionResult Welcome(){
            return View();
        }
        
    }
}