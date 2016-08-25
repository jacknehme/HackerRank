using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay13.AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }

    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();

    }

    // classes Book and Program provided by HackerRank
    class MyBook : Book
    {
        protected int price;

        // : base(), calls the base constructor
        public MyBook(string t, string a , int p) : base(t, a)
        {
            price = p;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }
}
