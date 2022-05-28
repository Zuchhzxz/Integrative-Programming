using System;

namespace ConsoleApp
{
    public struct Book
    {
        public string title;
        public string author;
        public int book_id;

        public void setValues(string newTtile, string newAuthor, int newBookID)
        {
            this.title = newTtile;
            this.author = newAuthor;
            this.book_id = newBookID;
        }

        public void displayValues()
        {
            Console.WriteLine("Book Title: " + this.title);
            Console.WriteLine("Book Author: " + this.author);
            Console.WriteLine("Book ID: " + this.book_id);
        }
    }
    class DemoStruct
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Object-Oriented Programming";
            book1.author = "John Doe";
            book1.book_id = 20190001;

            Console.WriteLine("Book Title: " + book1.title);
            Console.WriteLine("Book Author: " + book1.author);
            Console.WriteLine("Book ID: " + book1.book_id);

            Book book2 = new Book();
            book2.setValues("C# Programming", "Jane Doe", 20190001);
            book2.displayValues();
        }
    }
}