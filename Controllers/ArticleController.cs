using Microsoft.AspNetCore.Mvc;
using EHA_News.Models;
using System.Collections.Generic;

namespace EHA_News.Controllers
{
    public class ArticleController : Controller
    {

        ArticleContext context { get; set; }
        public ArticleController(ArticleContext ctx)
        {
            context = ctx;
        }


        public IActionResult Index()
        {
            ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
            return View(context.Articles);
        }


        public IActionResult create()
        {
            ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
            Article NewArticle = new();
            return View(NewArticle);
        }

        [HttpPost]
        public IActionResult create(Article article)
        {
            ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
            if (ModelState.IsValid)
            {

                article.DatePublished = DateTime.Now;
                context.Articles.Add(article);
                context.SaveChanges();

                return View("Index", context.Articles);
            }

            
            ViewBag.Articles = context.Articles; 
            return View(article);
        }

        
        public IActionResult Category(String categoryID)
        {

            var SelectedCategory = context.Categories.Find(categoryID).CategoryName;

            ViewBag.DisplayCategory = SelectedCategory;

            var CategoryList = context.Articles.Select(c => c).Where(c => c.CategoryId == categoryID).ToList();

            return View(CategoryList);
        }

        public IActionResult View_Article(int articleID)
        {
            ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
            return View(context.Articles.Find(articleID));
        }


    }
}
