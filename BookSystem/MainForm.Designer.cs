namespace BookSystem
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      dataGridViewBooks = new DataGridView();
      btnNewForm = new Button();
      btnEdit = new Button();
      btnDelete = new Button();
      lblBooks = new Label();
      ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
      SuspendLayout();
      // 
      // dataGridViewBooks
      // 
      dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewBooks.Location = new Point(12, 32);
      dataGridViewBooks.Name = "dataGridViewBooks";
      dataGridViewBooks.RowTemplate.Height = 25;
      dataGridViewBooks.Size = new Size(776, 366);
      dataGridViewBooks.TabIndex = 0;
      // 
      // btnNewForm
      // 
      btnNewForm.Location = new Point(551, 404);
      btnNewForm.Name = "btnNewForm";
      btnNewForm.Size = new Size(75, 23);
      btnNewForm.TabIndex = 1;
      btnNewForm.Text = "New";
      btnNewForm.UseVisualStyleBackColor = true;
      btnNewForm.Click += btnNewForm_Click;
      // 
      // btnEdit
      // 
      btnEdit.Location = new Point(632, 404);
      btnEdit.Name = "btnEdit";
      btnEdit.Size = new Size(75, 23);
      btnEdit.TabIndex = 2;
      btnEdit.Text = "Edit";
      btnEdit.UseVisualStyleBackColor = true;
      btnEdit.Click += btnEdit_Click;
      // 
      // btnDelete
      // 
      btnDelete.Location = new Point(713, 404);
      btnDelete.Name = "btnDelete";
      btnDelete.Size = new Size(75, 23);
      btnDelete.TabIndex = 3;
      btnDelete.Text = "Delete";
      btnDelete.UseVisualStyleBackColor = true;
      btnDelete.Click += btnDelete_Click;
      // 
      // lblBooks
      // 
      lblBooks.AutoSize = true;
      lblBooks.Location = new Point(12, 9);
      lblBooks.Name = "lblBooks";
      lblBooks.Size = new Size(42, 15);
      lblBooks.TabIndex = 4;
      lblBooks.Text = "Books:";
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 437);
      Controls.Add(lblBooks);
      Controls.Add(btnDelete);
      Controls.Add(btnEdit);
      Controls.Add(btnNewForm);
      Controls.Add(dataGridViewBooks);
      MaximizeBox = false;
      Name = "MainForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Library System";
      Activated += MainForm_Activated;
      ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private DataGridView dataGridViewBooks;
    private Button btnNewForm;
    private Button btnEdit;
    private Button btnDelete;
    private Label lblBooks;
  }
}