using EHA_News.Models;
using Microsoft.AspNetCore.Mvc;

namespace EHA_News.Controllers
{
    public class HomeController : Controller
    {

        ArticleContext articleContext { set; get; }
        AccountContext accountContext { set; get; }
        
        public HomeController(ArticleContext arctx)
        {
            articleContext = arctx;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = articleContext.Categories.OrderBy(c => c.CategoryName).ToList();
            return RedirectToAction("Index", "Article");
        }
    }
}
