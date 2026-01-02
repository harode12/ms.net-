using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ViewTypes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            return View();
        }

        public ActionResult<int> GetNumber()
        {
            return 1111;
        }

        public StatusCodeResult GetStatus()
        {
            return StatusCode(404);
        }

        public JsonResult GetData()
        {
            var data = new
            {
                ID = 101,
                Name = "Hugh Jackman",
                Address = "NYC"
            };
            return Json(data);
        }
    }
}
