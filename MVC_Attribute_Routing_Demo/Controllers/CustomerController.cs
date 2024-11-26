using Microsoft.AspNetCore.Mvc;

namespace MVC_Attribute_Routing_Demo.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        
    }
}