namespace EHA_News.Models
{
    public class Account
    {
        
        public string AccountId { get; set; }
        
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Constructor
        public Account(string username, string password)
        {
            AccountId = username;
            Password = password;
        }

        // Validate user credentials
        public bool Validate(string enteredUsername, string enteredPassword)
        {
            return AccountId == enteredUsername && Password == enteredPassword;
        }
    }
}
