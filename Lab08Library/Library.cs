using System;
using System.Collections;
using System.Collections.Generic;
using static Lab08Library.Book;

namespace Lab08Library
{
    public class Library<T> : IEnumerable<T>
    {
        //Fields
        T[] books;
        int count;

        //Constructors
        public Library(int capacity)
        {
            if (capacity <= 0) throw new ArgumentException();

            books = new T[capacity];
        }

        //constructor if no argument is given
        public Library() : this(6)
        {
        }

        //Properties
        public int Count => count;

        public T this[int index] => books[index];

        public void Add(T value)
        {
            if(books.Length == count)
            {
                Array.Resize(ref books, count * 2);
            }
            books[count] = value;
            count++;
        }

        public void Remove(int bookToRemove)
        {
            for (int i = 1; i <= count; i++)
            {
                books[bookToRemove + (i-1)] = books[bookToRemove + i];
            }
            count--;
        }

        public T[] ViewAllBooks()
        {
            T[] output = new T[count];

            for (int i = 0; i < count; i++)
            {
                output[i] = books[i];
            }
            

            return output;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static void AddaBook(string title, string firstName, string lastName, int pageNumber, Genres genre)
        {
           Author theAuthor = new Author(firstName, lastName);
           Book book = new Book(title, theAuthor, pageNumber, genre);
           Library.Add(book);
          
        }
    }
}
