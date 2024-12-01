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


        public IActionResult create()
        {
            Article NewArticle = new("","","","");
            return View(NewArticle);
        }

        [HttpPost]
        public IActionResult create(Article article)
        {
            if (ModelState.IsValid)
            {

                Articles.Add(article);
                
                return RedirectToAction("Index");
            }

            
            ViewBag.Articles = Articles; 
            return View("Index", Articles);
        }

        public IActionResult View_Article()
        {
            return View();
        }


    }
}
