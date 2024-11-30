namespace EHA_News.Models
{
    public class Article
    {
        public string Headline { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }

        // Constructor with multiple fields
        public Article(string headline, string content, string author, string category)
        {
            Headline = headline;
            Content = content;
            Author = author;
            Category = category;
        }
    }
}

