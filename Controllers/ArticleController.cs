using Microsoft.AspNetCore.Mvc;
using EHA_News.Models;
using System.Collections.Generic;

namespace EHA_News.Controllers
{
    public class ArticleController : Controller
    {
        private static List<Article> Articles = new List<Article>();

        
        public IActionResult Index()
        {
            return View(Articles);
        }

        // POST: Handle article submission
        [HttpPost]
        public IActionResult Index(Article article)
        {
            if (ModelState.IsValid)
            {
                // Add article to the list
                Articles.Add(article);
                
                return RedirectToAction("Index");
            }

            
            ViewBag.Articles = Articles; // Pass articles to the view for display
            return View("Index", Articles);
        }
    }
}
