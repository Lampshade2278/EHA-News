using Microsoft.EntityFrameworkCore;

namespace EHA_News.Models
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options) : base(options)
        { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category{CategoryId = "F", CategoryName = "Finance"},
                new Category { CategoryId = "C", CategoryName = "Computing" },
                new Category { CategoryId = "P", CategoryName = "Politics" },
                new Category { CategoryId = "E", CategoryName = "Entertainment" }


            );

            modelBuilder.Entity<Article>().HasData(
                new Article
                {
                    ArticleId = 1,
                    Author = "John Doe II",
                    Synopsis = "This is a test synopsis, and therefore is not at all a good read.",
                    Headline = "Man creates Database in asp.NET Server Core 2022. Earns $1 Million",
                    CategoryId = "C"
                }
            );
        }
    }
}
