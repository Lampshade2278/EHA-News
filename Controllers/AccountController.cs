using EHA_News.Models;
using Microsoft.AspNetCore.Mvc;

namespace EHA_News.Controllers
{
    public class AccountController : Controller
    {
        AccountContext context { get; set; }
        public AccountController(AccountContext ctx)
        {
            context = ctx;
        }

        // Replace with a real database or data store
        private static readonly List<Account> AccountsDatabase = new();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            // Initialize an empty account model for the view
            var account = new Account();
            return View(account);
        }

        [HttpPost]
        public IActionResult Signup(Account account)
        {
            if (!ModelState.IsValid)
            {
                // If validation fails, reload the view with validation messages
                return View(account);
            }

            // Validate name and password requirements
            if (!IsValidAccount(account))
            {
                ModelState.AddModelError("", "Invalid username or password requirements.");
                return View(account);
            }

            // Add the account to a database
            context.Accounts.Add(account);
            context.SaveChanges();

            // Redirect to a success page
            TempData["UserName"] = account.FirstName + " " + account.LastName;
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            // Initialize a login model for the view
            var login = new LoginModel();
            return View(login);
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            if (!ModelState.IsValid)
            {
                // If validation fails, reload the view with validation messages
                return View(login);
            }

            // Validate credentials
            var account = context.Accounts.Find(login.Username);
            if (account != null && account.Validate(login.Username, login.Password))
            {
                // Redirect to home or a dashboard upon successful login
                TempData["UserName"] = account.FirstName + " " + account.LastName;
                return RedirectToAction("Index", "Home");
            }

            // Show an error message for invalid credentials
            ModelState.AddModelError("", "Invalid username or password.");
            return View(login);
        }

        public IActionResult LogOut()
        {
            // Initialize a login model for the view
            TempData["UserName"] = "";
            return RedirectToAction("Index", "Home");
        }

        private bool IsValidAccount(Account account)
        {
            // Example validation rules: username and password length, confirm password match
            var ModelAccount = context.Accounts.Find(account.AccountId);
            if (ModelAccount != null) {
                ModelState.AddModelError("account.AccountId", "Email Address Taken.");
                return false;
            }

            if (account.AccountId.Length < 5)
            {
                ModelState.AddModelError("account.AccountId", "Email Address must be at least 5 characters long.");
                return false;
            }

            if (account.Password.Length < 8 || !account.Password.Any(char.IsDigit))
            {
                ModelState.AddModelError("account.Password", "Password must be at least 8 characters long.");
                return false;
            }


            if (account.Password != account.ConfirmPassword)
            {
                ModelState.AddModelError("account.ConfirmPassword", "Passwords must match");
                return false;
            }
            return true;
        }
    }
}
