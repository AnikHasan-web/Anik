using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookInformation.Model;

namespace BookInformation.DAL
{
    public class BookGateway
    {
        public int SaveBook(Book book)
        {
            string connectionString =
                @"Server = PC-301-17\SQLEXPRESS; Database = BookInformationKeeperDB; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Book_tbl Values('" + book.Name + "','" + book.Isbn + "','" + book.Author + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();
            return rowEffect;
        }

        public List<Book> GetAllBook()
        {
            string connectionString =
                @"Server = PC-301-17\SQLEXPRESS; Database = BookInformationKeeperDB; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Book_tbl";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book book =new Book();
                book.BookId = (int) reader["BookId"];
                book.Name = reader["BookName"].ToString();
                book.Isbn = reader["Isbn"].ToString();
                book.Author = reader["Author"].ToString();
                books.Add(book);
               
            }
            reader.Close();
            connection.Close();

            return books;
        }
    }
}