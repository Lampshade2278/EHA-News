namespace EHA_News.Models
{
    public class Article
    {
        public string Headline { get; set; }

        public Article(string headline)
        {
            Headline = headline;
        }
    }

}
