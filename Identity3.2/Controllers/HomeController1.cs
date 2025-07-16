using Microsoft.AspNetCore.Mvc;

namespace Identity3._2.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
