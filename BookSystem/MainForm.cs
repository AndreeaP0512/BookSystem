using BookSystem.Classes;

namespace BookSystem
{
  public partial class MainForm : Form
  {
    private Book book;

    public MainForm()
    {
      InitializeComponent();
      book = new Book();

      FillGridView();
      AdjustGridView();
    }

    private void FillGridView()
    {
      List<Book> bookList = new List<Book>();
      bookList = book.GetBooks();
      dataGridViewBooks.DataSource = bookList;
    }

    private void btnNewForm_Click(object sender, EventArgs e)
    {
      NewBookForm newBookForm = new NewBookForm(null);
      newBookForm.ShowDialog();
    }

    private void MainForm_Activated(object sender, EventArgs e)
    {
      FillGridView();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      EditBook();
    }

    private void EditBook()
    {
      int bookId = (int)dataGridViewBooks.CurrentRow.Cells[0].Value;
      NewBookForm editBookForm = new NewBookForm(bookId);
      editBookForm.ShowDialog();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      DeleteBook();
      FillGridView();
    }

    private void DeleteBook()
    {
      int bookId = (int)dataGridViewBooks.CurrentRow.Cells[0].Value;
      string? bookTitle = dataGridViewBooks.CurrentRow.Cells[1].Value.ToString();
      
      string message = String.Format("Are you sure you want to delete the book {0}?", bookTitle);
      DialogResult dialogResult = MessageBox.Show(message, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (dialogResult == DialogResult.Yes)
      {
        book.DeleteBook(bookId);
      }
    }

    private void AdjustGridView()
    {
      dataGridViewBooks.Columns[0].Visible = false;
      dataGridViewBooks.Columns[1].HeaderText = "Title";
      dataGridViewBooks.Columns[2].HeaderText = "ISBN";
      dataGridViewBooks.Columns[3].HeaderText = "Publisher";
      dataGridViewBooks.Columns[4].HeaderText = "Author";
      dataGridViewBooks.Columns[5].HeaderText = "Category";

      dataGridViewBooks.Columns[1].Width = 245;
      dataGridViewBooks.Columns[2].Width = 100;
      dataGridViewBooks.Columns[3].Width = 130;
      dataGridViewBooks.Columns[4].Width = 130;
      dataGridViewBooks.Columns[5].Width = 130;

    }
  }
}