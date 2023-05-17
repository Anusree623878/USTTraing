using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
       /* public IActionResult Index()
        {
            return View();
        }*/

   /*      public string Index()
    {
        return "This is my default action...";
    }*/
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
        public IActionResult Index()
        {
            return View();
        }
    }
}
