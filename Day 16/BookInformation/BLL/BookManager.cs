using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookInformation.DAL;
using BookInformation.Model;

namespace BookInformation.BLL
{
    public class BookManager
    {
        BookGateway bookGateway = new BookGateway();

        public string SaveBook(Book book)
        {
           if(book.Isbn.Length == 13) { 
               int rowEffect = bookGateway.SaveBook(book);
               if (rowEffect>0)
               {
                 return "Saved Successfully";
               }
               else
               {
                   return "Failed to Save";
               }
               }
           else
           {
               return "Isbn must be 13 Characters long";
           }
        }

        public List<Book> GetAllBooks()
        {
            return bookGateway.GetAllBook();
        }
    }
}