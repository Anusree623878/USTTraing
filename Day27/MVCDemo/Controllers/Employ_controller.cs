using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class Employ_controller : Controller
    {
        public string Display()
        {
            return "hello mvc Controller";
        }
        public IActionResult Index()
        {
             return View();
        }
       
    }
}
