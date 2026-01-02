using Microsoft.AspNetCore.Mvc;

namespace ConventionalMVC.Controllers
{
    public class HomeController : Controller
    {
        public string Welcome(string nm)
        {
            return nm;
        }
    }
}
