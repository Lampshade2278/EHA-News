namespace EHA_News.Models
{
    public class Article
    {
        
        public int ArticleId { get; set; }
        public string Headline { get; set; }
        public string Synopsis { get; set; }
        public string Author { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime DatePublished { get; set;}

        // Constructor with multiple fields
        public Article(string headline, string synopsis, string author, string category)
        {
            Headline = headline;
            Synopsis = synopsis;
            Author = author;
            CategoryId = category;
        }
    }
}

