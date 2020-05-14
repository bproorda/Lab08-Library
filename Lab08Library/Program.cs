using System;
using static Lab08Library.Book;

namespace Lab08Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

       static Library<Book> Library = new Library<Book>();

        public static void AddaBook(string title, string firstName, string lastName, int pageNumber, Genres genre)
        {
            Author theAuthor = new Author(firstName, lastName);
            Book book = new Book(title, theAuthor, pageNumber, genre);
            Library.Add(book);

        }
    }
}
