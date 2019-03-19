using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Concrete Component class
/// </summary>
namespace DecoratorPattern
{
    class Book : LibraryItem
    {
        //properties for book
        private string _author;
        private string _title;

        //constructor to set properties
        public Book(string author, string title, int numCopies)
        {
            _author = author;
            _title = title;
            this.NumCopies = numCopies;
        }

        //overriding base class method to share between child classes
        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}
