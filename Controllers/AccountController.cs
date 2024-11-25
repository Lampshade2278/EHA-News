using Microsoft.AspNetCore.Mvc;

namespace EHA_News.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
