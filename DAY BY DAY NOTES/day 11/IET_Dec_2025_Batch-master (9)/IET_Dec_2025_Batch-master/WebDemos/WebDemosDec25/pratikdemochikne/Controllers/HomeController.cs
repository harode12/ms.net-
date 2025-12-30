using Microsoft.AspNetCore.Mvc;

namespace pratikdemochikne.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
