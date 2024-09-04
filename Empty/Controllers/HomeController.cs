using Microsoft.AspNetCore.Mvc;

namespace Empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
