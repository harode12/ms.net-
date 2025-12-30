using Microsoft.AspNetCore.Mvc;

namespace secondMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
