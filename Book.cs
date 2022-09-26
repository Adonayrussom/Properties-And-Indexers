using System;

namespace sess09_Properties__and_Indexers
{
    /// <summary>
    /// Class that will be used to create Book objects.
    /// </summary>
    public class Book
    {
        public uint BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }

        public Book()
        {
            this.BookID = 0;
            this.Title = "";
            this.Author = "";
            this.Price = 0.0f;        
        }
        public Book(uint bookID, string title, string author, float price)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            Price = price;
        }

        public override String ToString()
        {
            return ($"SimplePerson Details"
                    + $"\n------------------------------"
                    + $"\nBook Id: {this.BookID}"
                    + $"\nBook Title: {this.Title}"
                    + $"\nBook Author: {this.Author}"
                    + $"\nBook Price: {this.Price:c}"
                    + $"\n------------------------------\n");
        }


    }
}
