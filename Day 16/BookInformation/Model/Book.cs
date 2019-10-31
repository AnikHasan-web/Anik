using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookInformation.Model
{
    public class Book
    {
        public string Name { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }
        public int BookId { get; internal set; }

        public Book(string name, string isbn, string author)
        {
            Name = name;
            Isbn = isbn;
            Author = author;
        }

        public Book()
        {

        }
    }
}