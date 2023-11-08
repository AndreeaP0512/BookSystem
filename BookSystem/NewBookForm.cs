using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookSystem.Classes;

namespace BookSystem
{
  public partial class NewBookForm : Form
  {
    private int? selectedBookId = null;
    public NewBookForm(int? bookId)
    {
      InitializeComponent();

      if (bookId.HasValue)
      {
        this.Text = "Edit Book";
        selectedBookId = bookId.Value;
        GetBookData();
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      if (selectedBookId.HasValue)
      {
        EditBookData();
      }
      else
      {
        SaveBookData();
      }

      this.Close();
    }

    private void SaveBookData()
    {
      Book newBook = new Book();
      newBook.Title = txtTitle.Text;
      newBook.ISBN = txtISBN.Text;
      newBook.AuthorName = txtAuthor.Text;
      newBook.CategoryName = txtCategory.Text;
      newBook.PublisherName = txtPublisher.Text;

      newBook.CreateBook(newBook);
    }

    private void GetBookData()
    {
      if (selectedBookId.HasValue)
      {
        Book book = new Book();
        book = book.GetBookData(selectedBookId.Value);

        txtTitle.Text = book.Title;
        txtISBN.Text = book.ISBN;
        txtAuthor.Text = book.AuthorName;
        txtCategory.Text = book.CategoryName;
        txtPublisher.Text = book.PublisherName;
      }
    }

    private void EditBookData()
    {
      if (selectedBookId.HasValue)
      {
        Book book = new Book();
        book.BookId = selectedBookId.Value;
        book.Title = txtTitle.Text;
        book.ISBN = txtISBN.Text;
        book.AuthorName = txtAuthor.Text;
        book.CategoryName = txtCategory.Text;
        book.PublisherName = txtPublisher.Text;

        book.EditBookData(book);
      }
    }
  }
}
