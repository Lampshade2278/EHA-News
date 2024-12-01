using Microsoft.EntityFrameworkCore;

namespace EHA_News.Models
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
            { }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    AccountId = "DoeJohn@fake.com",
                    Password = "Te5tP@sswd",
                    ConfirmPassword = "Te5tP@sswd",
                    FirstName = "John",
                    LastName = "Doe"
                }
            );
        }
    }
}
