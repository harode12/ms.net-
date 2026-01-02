using Microsoft.AspNetCore.Mvc;

namespace ConventionalMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
