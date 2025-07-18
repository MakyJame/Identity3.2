using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity3._2.Controllers
{
    public class StaffController : Controller
    {
        [Authorize(Roles ="Staff")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
