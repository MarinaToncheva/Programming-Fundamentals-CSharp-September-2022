namespace _03._Articles_2._0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        static void Main(string[] args)
        {
            int countOfArticle = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < countOfArticle; i++)
            {
                string[] currentArticle = Console.ReadLine().Split(", ");
                Article article = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);
                articles.Add(article);
            }

            string line = Console.ReadLine();

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}