using System;
using System.Collections.Generic;

namespace PolymorphismDemo
{
    class Book
    {
        protected string Title;
        protected string Author;


        public Book(string Title, string Author)
        {
            this.Title = Title;
            this.Author = Author;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetAuthor()
        {
            return Author;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Book: {Title} by {Author}");
        }
    }
    class EBook : Book
    {
        private string Format;  // Kindle or Nook

        public EBook(string Title, string Author, string Format) : base(Title, Author)
        {
            this.Format = Format;
        }

        public string GetFormat()
        {
            return Format;
        }

        public override void PrintInfo()
        {
            //base.PrintInfo();
            Console.WriteLine($"EBook: {Title} by {Author} available for {Format}");
        }
    }

    class Program
    {
        private static void PrintLibrary(string LibraryName, List<Book> library)
        {
            Console.WriteLine(LibraryName);
            foreach (Book next in library)
            {
                next.PrintInfo();
            }
        }

        static void Main(string[] args)
        {
            List<Book> library = new List<Book>();

            Book mybook;
            mybook = new Book("Xmas Carol", "Charles Dickens");
            Console.WriteLine($"Adding a book by {mybook.GetAuthor()}");
            library.Add(mybook);    
            
            mybook = new EBook("Great Expectations", "Charles Dickens", "Kindle");
            Console.WriteLine($"Adding a book by {mybook.GetAuthor()}");
            library.Add(mybook);

            mybook = new EBook("The Martian Chronicles", "Ray Bradbury", "Nook");
            Console.WriteLine($"Adding a book by {mybook.GetAuthor()}");
            library.Add(mybook);

            PrintLibrary("Cool Library", library);
           
            //((EBook)mybook).Format = "Kindle";  // casting from class EBook; NOT preferred, instead create constructor
        }

    }
}
