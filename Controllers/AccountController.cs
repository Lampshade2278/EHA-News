using EHA_News.Models;
using Microsoft.AspNetCore.Mvc;

namespace EHA_News.Controllers
{
    public class AccountController : Controller
    {
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
            var account = new Account("", "");
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

            // Simulate adding the account to a database
            AccountsDatabase.Add(account);

            // Redirect to a success page
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
            var account = AccountsDatabase.FirstOrDefault(a => a.Validate(login.Username, login.Password));
            if (account != null)
            {
                // Redirect to home or a dashboard upon successful login
                return RedirectToAction("Index", "Home");
            }

            // Show an error message for invalid credentials
            ModelState.AddModelError("", "Invalid username or password.");
            return View(login);
        }

        private bool IsValidAccount(Account account)
        {
            // Example validation rules: username and password length, confirm password match
            if (string.IsNullOrEmpty(account.AccountId) || account.AccountId.Length < 5)
                return false;

            if (string.IsNullOrEmpty(account.Password) || account.Password.Length < 8 || !account.Password.Any(char.IsDigit))
                return false;

            if (account.Password != account.ConfirmPassword)
                return false;

            return true;
        }
    }
}
