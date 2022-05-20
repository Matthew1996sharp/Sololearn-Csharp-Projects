using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    // Вы создаете приложение социальной сети и хотите добавить функцию создания публикаций
    // При создании использователем публикации, автоматически должен выводиться текст "New post",
    // чтобы пользователь мог добавить текст, которым он хочет поделиться
    // Вам дана программа, которая объявляет класс post с приватным элементом text
    // и методом ShowPost(), который выводит содержание. Добавьте класс:
    // 1. конструктор, который выводит "New Post" при вызове
    // 2. свойство Text, которое позволит получить и задать значение поля text
    // После того как вы внесете изменения в программу, чтобы она работала правильно,
    // в main программа будет принимать текст публикации от пользователя,
    // создавать объект публикации. присваивать полученное значение полю text и выводить его

    internal class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

            Console.ReadKey();
        }
    }

    class Post
    {
        private string text;

        public Post()
        {
            Console.WriteLine("New Post");
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }

        public string Text
        { 
            get { return text; }
            set { text = value; }
        }
    }
}
