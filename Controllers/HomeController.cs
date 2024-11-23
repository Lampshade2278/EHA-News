using Microsoft.AspNetCore.Mvc;
using EN_Assignment5.Models;
using System.Collections.Generic;

namespace Assignment_3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Ethan  De La Rosa";
            ViewBag.Education = "Associates";
            ViewBag.Birth = "Yokosuka, Japan";

            var holdModel = new Hold
            {
                Hobbies = new List<string> { "Video Games", "Poetry", "Reading" },
                Classes = new List<string> { "Software Engineering", "Computing Ethics", "Operating Systems", "Intro to Database Systems" }
            };

            return View(holdModel);
        }
    }
}
