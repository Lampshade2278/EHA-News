using Microsoft.AspNetCore.Mvc;

namespace EHA_News.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Article");
        }
    }
}
