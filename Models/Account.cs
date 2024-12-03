using System.ComponentModel.DataAnnotations;

namespace EHA_News.Models
{
    public class Account
    {
        [Required(ErrorMessage = "Please enter an Email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid Email Address")]
        public string AccountId { get; set; }

        [Required(ErrorMessage = "Please enter a Password.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Confirm your Password.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter your First Name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name.")]
        public string LastName { get; set; }

        // Parameterless constructor required for model binding
        public Account() { }

        // Constructor for creating an account with username and password
        public Account(string username, string password)
        {
            AccountId = username;
            Password = password;
        }

        // Validate credentials against stored values
        public bool Validate(string enteredUsername, string enteredPassword)
        {
            return AccountId == enteredUsername && Password == enteredPassword;
        }
    }
}
