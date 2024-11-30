using Microsoft.AspNetCore.Mvc;

namespace EHA_News.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult View_Article()
        {
            return View();
        }
    }
}
