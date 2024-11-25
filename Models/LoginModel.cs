using System.ComponentModel.DataAnnotations;

namespace EHA_News.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter your Email.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your Password.")]
        public string Password { get; set; }
    }
}
