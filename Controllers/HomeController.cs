using Microsoft.AspNetCore.Mvc;
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


            return View();
        }
    }
}
