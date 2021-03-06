﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab08Library
{
    public class BookBag<T> : IEnumerable<T>
    {
        //Fields
        T[] books;
        int count;

        //Constructors
        public BookBag(int capacity)
        {
            if (capacity <= 0) throw new ArgumentException();

            books = new T[capacity];
        }

        //constructor if no argument is given
        public BookBag() : this(6)
        {
        }

        //Properties
        public int Count => count;

        public T this[int index] => books[index];

        public void Add(T value)
        {
            if (books.Length == count)
            {
                Array.Resize(ref books, count * 2);
            }
            books[count] = value;
            count++;
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
    }
}
