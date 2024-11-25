using Microsoft.AspNetCore.Mvc;

namespace EHA_News.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
