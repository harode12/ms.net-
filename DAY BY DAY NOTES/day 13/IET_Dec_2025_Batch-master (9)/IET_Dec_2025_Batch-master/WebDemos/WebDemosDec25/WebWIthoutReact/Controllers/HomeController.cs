using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebWIthoutReact.Models;

namespace WebWIthoutReact.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IETDbContext _Pcontext;

        //public HomeController(IETDbContext context)
        //{
        //   _Pcontext= context;
        //}

        //public IActionResult Index()
        //{
        //    ViewBag.ctr= "Home";
        //    var allemp = _Pcontext.emps.ToList();
        //    return View(allemp);
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
