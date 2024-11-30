namespace EHA_News.Models
{
    public class Account
    {
        public string AccountId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
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
