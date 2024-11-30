using System.ComponentModel.DataAnnotations;

namespace EHA_News.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter your Email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid Email address.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your Password.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
