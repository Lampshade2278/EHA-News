using System;
using Microsoft.EntityFrameworkCore;
using EHA_News.Models;

namespace EHA_News.Migration
{
    public class AccountContextInfo : DbContext
    {
        public AccountContextInfo(DbContextOptions<AccountContextInfo> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
