using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library: IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            Books = new SortedSet<Book>(books, new BookComparator());
        }
        private readonly SortedSet<Book> Books;

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books);//////
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        //
        private class LibraryIterator : IEnumerator<Book>
        {
            public LibraryIterator(IEnumerable<Book> book)
            {
                Reset();
                this.books = new List<Book>(book);
            }
            public Book Current => books[currentIndex];
            private readonly List<Book> books;
            private int currentIndex;


            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext() => ++currentIndex < books.Count;


            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
    
}
