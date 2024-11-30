using Microsoft.AspNetCore.Mvc;
using EHA_News.Models;
using System;
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


        [HttpPost]
        public IActionResult Index(Article article)
        {
            if (ModelState.IsValid)
            {
                
                Articles.Add(article);

                return RedirectToAction("Index");
            }

            return View(Articles);
        }
    }
}
