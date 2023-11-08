using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.Classes
{
  public class Book
  {
    public int BookId { get; set; }
    public string? Title { get; set; }
    public string? ISBN { get; set; }
    public string? PublisherName { get; set; }
    public string? AuthorName { get; set; }
    public string? CategoryName { get; set; }

    //string connectionString = "Data Source=DESKTOP-6MHQP1B\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True";
    readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

    public List<Book> GetBooks()
    {
      List<Book> bookList = new List<Book>();

      SqlConnection con = new SqlConnection(connectionString);
      string selectSQL = "SELECT BookId, Title, ISBN, PublisherName, AuthorName, CategoryName FROM GetBookData";
      con.Open();
      SqlCommand cmd = new SqlCommand(selectSQL, con);
      SqlDataReader dr = cmd.ExecuteReader();

      if (dr != null)
      {
        while (dr.Read())
        {
          Book book = new Book();
          book.BookId = Convert.ToInt32(dr["BookId"]);
          book.Title = dr["Title"].ToString();
          book.ISBN = dr["ISBN"].ToString();
          book.PublisherName = dr["PublisherName"].ToString();
          book.AuthorName = dr["AuthorName"].ToString();
          book.CategoryName = dr["CategoryName"].ToString();

          bookList.Add(book);
        }
      }
      return bookList;
    }

    public void CreateBook(Book book)
    {
      SqlConnection con = new SqlConnection(connectionString);
      SqlCommand cmd = new SqlCommand("CreateBook", con);
      cmd.CommandType = System.Data.CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@Title", book.Title));
      cmd.Parameters.Add(new SqlParameter("@ISBN", book.ISBN));
      cmd.Parameters.Add(new SqlParameter("@PublisherName", book.PublisherName));
      cmd.Parameters.Add(new SqlParameter("@AuthorName", book.AuthorName));
      cmd.Parameters.Add(new SqlParameter("@CategoryName", book.CategoryName));

      con.Open();
      cmd.ExecuteNonQuery();
      con.Close();
    }

    public Book GetBookData(int bookId)
    {
      Book book = new Book();
      SqlConnection con = new SqlConnection(connectionString);
      string selectSQL = "SELECT BookId, Title, ISBN, PublisherName, AuthorName, CategoryName FROM GetBookData WHERE BookId = " + bookId;
      con.Open();
      SqlCommand cmd = new SqlCommand(selectSQL, con);
      SqlDataReader dr = cmd.ExecuteReader();

      if (dr != null)
      {
        while (dr.Read())
        {
          book.BookId = Convert.ToInt32(dr["BookId"]);
          book.Title = dr["Title"].ToString();
          book.ISBN = dr["ISBN"].ToString();
          book.PublisherName = dr["PublisherName"].ToString();
          book.AuthorName = dr["AuthorName"].ToString();
          book.CategoryName = dr["CategoryName"].ToString();
        }
      }

      return book;
    }

    public void EditBookData(Book book)
    {
      using (SqlConnection con = new SqlConnection(connectionString))
      {
        SqlCommand cmd = new SqlCommand("UpdateBook", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@BookId", book.BookId));
        cmd.Parameters.Add(new SqlParameter("@Title", book.Title));
        cmd.Parameters.Add(new SqlParameter("@ISBN", book.ISBN));
        cmd.Parameters.Add(new SqlParameter("@PublisherName", book.PublisherName));
        cmd.Parameters.Add(new SqlParameter("@AuthorName", book.AuthorName));
        cmd.Parameters.Add(new SqlParameter("@CategoryName", book.CategoryName));

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
      }
    }

    public void DeleteBook(int bookId)
    {
      using (SqlConnection con = new SqlConnection(connectionString))
      {
        SqlCommand cmd = new SqlCommand("DeleteBook", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@BookId", bookId));

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
      }
    }

  }
}
