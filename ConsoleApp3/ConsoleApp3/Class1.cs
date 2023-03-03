using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniga
{
    internal class Book
    {
        private string author; // автор
        private string title; // название
        private string publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания
        private static double price = 9;
        public void SetBook(String author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public Book(string author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        static Book() //статический конструктор
        {
            price = 10;
        }
        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
        }
        public Book(string author, int pages)
        {
            this.author = author;
            this.pages = pages;
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public Book()
        {
        }
        public static void SetPrice(double price)
        {
            Book.price = price;
        }
        public void Show()
        {
            Console.WriteLine("\nКнига:\nАвтор:{0}\n Название:{1}\nГод издания:{2}\nИздательство:{3}\nКол-во страниц:{4}\nСтоимость аренды:{5}", author, title, year, publisher, pages, Book.price);
        }
        public double priceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
    }
}
