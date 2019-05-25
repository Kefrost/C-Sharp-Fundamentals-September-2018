using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string newEdit)
        {
            Content = newEdit;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;

        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public void OverrideToString()
        {
            Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string title = input[0];
            string content = input[1];
            string author = input[2];

            var article = new Article(title, content, author);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var currInput = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = currInput[0];
                if (command == "Edit")
                {
                    string newContent = currInput[1].Trim();
                    article.Edit(newContent);
                }
                if (command == "ChangeAuthor")
                {
                    string newAuthor = currInput[1].Trim();
                    article.ChangeAuthor(newAuthor);
                }
                if (command == "Rename")
                {
                    string newTitle = currInput[1].Trim();
                    article.Rename(newTitle);
                }
            }
            article.OverrideToString();
        }
    }
}
