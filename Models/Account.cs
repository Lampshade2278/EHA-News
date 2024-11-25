namespace EHA_News.Models
{
    public class Account
    {
        private string AccountID { get; set; }
        private string Password { get; set; }

        // Constructor
        public Account(string username, string password)
        {
            AccountID = username;
            Password = password;
        }

        // Validate user credentials
        public bool Validate(string enteredUsername, string enteredPassword)
        {
            return AccountID == enteredUsername && Password == enteredPassword;
        }
    }
}
