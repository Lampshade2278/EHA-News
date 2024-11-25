namespace EHA_News.Models
{
    public class Account
    {
        private string Username { get; set; }
        private string Password { get; set; }

        // Constructor
        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }

        // Validate user credentials
        public bool Validate(string enteredUsername, string enteredPassword)
        {
            return Username == enteredUsername && Password == enteredPassword;
        }
    }
}
