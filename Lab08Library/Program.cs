using System;
using static Lab08Library.Book;

namespace Lab08Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            setup();
            Console.WriteLine(Library.books[0].Title);

        }

       static Library<Book> Library = new Library<Book>();
        static BookBag<Book> myBookBag = new BookBag<Book>();

        static void setup()
        {
            AddaBook("Lord of the Rings", "J.R.R.", "Tolkien", 1952, Book.Genres.Fantasy);
            AddaBook("Songs of Earth And Power", "Greg", "Bear", 934, Book.Genres.Fantasy);
            AddaBook("The Tempest", "William", "Shakespeare", 172, Book.Genres.Classic);

        }

        public static void AddaBook(string title, string firstName, string lastName, int pageNumber, Genres genre)
        {
            Author theAuthor = new Author(firstName, lastName);
            Book book = new Book(title, theAuthor, pageNumber, genre);
            Library.Add(book);

        }
        
       
    }
}
