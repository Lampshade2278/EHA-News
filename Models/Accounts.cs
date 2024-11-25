namespace EHA_News.Models
{
    public class Accounts
    {
        private string Username { get; set; }
        private string Password { get; set; }

        // Constructor
        public Accounts(string username, string password)
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
