using Microsoft.AspNetCore.Mvc;

namespace ConventionalMVC.Controllers
{
    public class UserController : Controller
    {
        public ActionResult<string> CheckUser(string un,string pw)
        {
            return $"username={un} password={pw}";
        }
    }
}
