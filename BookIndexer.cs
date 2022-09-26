using System;

namespace sess09_Properties__and_Indexers
{
    /// <summary>
    /// Program demonstrating the use of indexers to access objects instances
    /// </summary>
    public class BookIndexer
    {
        //Create an array of Programming Books
        private Book[] programmingBooks = new Book[]
        {
            new Book(578,"C# How to Program", "Deitel & Deitel.", 54.55f),
            new Book(579,"C# Notes for Professionals", "Et al.", 0.0f),
            new Book(580,"Java the Complete Reference", "Oracle Inc.", 89.99f),
            new Book(581,"Python Programming", "Python Author", 25.59f),
        };

        //Set up the Book read-only Indexer
        public Book this[uint bookID]
        {
            get { return programmingBooks[bookID]; }
        }

        static void Main(string[] args)
        {
            //Display the books in the programming array
            //1. Using a for...each loop
            //foreach(Book book in new BookIndexer().programmingBooks)
            //{
            //    Console.WriteLine(book.ToString());
            //}

            //2. Using a for loop
            BookIndexer indexer = new BookIndexer();
            for( uint n = 0; n <= indexer.programmingBooks.GetUpperBound(0); n++)
            {
                Console.WriteLine(indexer[n].ToString()); 
            }
        }
    }
}
