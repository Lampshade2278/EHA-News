using System;
using Microsoft.EntityFrameworkCore;
using EHA_News.Models;

namespace EHA_News.Migration
{
    public class ArticleContextInfo : DbContext
    {
        public ArticleContextInfo(DbContextOptions<ArticleContextInfo> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
