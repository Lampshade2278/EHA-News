using EHA_News.Models;
using Microsoft.AspNetCore.Mvc;

namespace EHA_News.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            /* Create new account to put in database */
            var account = new Account("","");
            return View(account);
        }

        [HttpPost]
        public IActionResult Signup(Account account)
        {
            /*Add functions to Check Name and Password requirements, 
             put account in database, and then Redirect to home */

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            /* Create container to hold credentials during login */
            var login = new LoginModel();
            return View(login);
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            /*Add functions to Check Credentials and then Redirect to home */

            return View();
        }
    }
}
