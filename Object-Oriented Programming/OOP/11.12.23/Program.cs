using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._12._23
{
    internal class Program
    {
        class Book
        {
            public Book(string title, int year, params string[] authors)
            {
                Title = title;
                Year = year;
                Authors = authors.ToList();
            }

            public string Title { get; set; }
            public int Year { get; set; }
            List<string> Authors { get; set; }
            public override string ToString()
            {
                return $"{Title} {Year} {string.Join(",", Authors)}";
            }
        }
        class Library : IEnumerable<Book>
        {
            List<Book> books;
            public Library(params Book[] books)
            {
                this.books = new List<Book>(books.ToList());
            }
            public IEnumerator<Book> GetEnumerator()
            {
                return new BookCollection(books);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return new BookCollection(books);

            }
        }
        class BookCollection : IEnumerator<Book>
        {
            public Book Current => books[index];

            object IEnumerator.Current => books[index];
            private List<Book> books;

            public BookCollection(List<Book> books)
            {
                this.books = books;
            }

            private int index = -1;
            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                index++;
                return index < books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }

        static void Main(string[] args)
        {



            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var sdf in libraryTwo)
            {
                Console.WriteLine(sdf.ToString());
            }
        }
    }
}