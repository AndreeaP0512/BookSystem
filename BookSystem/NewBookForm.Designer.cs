namespace BookSystem
{
  partial class NewBookForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      txtTitle = new TextBox();
      txtISBN = new TextBox();
      txtPublisher = new TextBox();
      txtAuthor = new TextBox();
      txtCategory = new TextBox();
      lblTitle = new Label();
      lblISBN = new Label();
      lblPublisher = new Label();
      lblAuthor = new Label();
      lblCategory = new Label();
      btnOK = new Button();
      btnCancel = new Button();
      SuspendLayout();
      // 
      // txtTitle
      // 
      txtTitle.Location = new Point(12, 41);
      txtTitle.Name = "txtTitle";
      txtTitle.Size = new Size(270, 23);
      txtTitle.TabIndex = 0;
      // 
      // txtISBN
      // 
      txtISBN.Location = new Point(12, 97);
      txtISBN.Name = "txtISBN";
      txtISBN.Size = new Size(270, 23);
      txtISBN.TabIndex = 1;
      // 
      // txtPublisher
      // 
      txtPublisher.Location = new Point(12, 157);
      txtPublisher.Name = "txtPublisher";
      txtPublisher.Size = new Size(270, 23);
      txtPublisher.TabIndex = 2;
      // 
      // txtAuthor
      // 
      txtAuthor.Location = new Point(12, 218);
      txtAuthor.Name = "txtAuthor";
      txtAuthor.Size = new Size(270, 23);
      txtAuthor.TabIndex = 3;
      // 
      // txtCategory
      // 
      txtCategory.Location = new Point(12, 282);
      txtCategory.Name = "txtCategory";
      txtCategory.Size = new Size(270, 23);
      txtCategory.TabIndex = 4;
      // 
      // lblTitle
      // 
      lblTitle.AutoSize = true;
      lblTitle.Location = new Point(12, 23);
      lblTitle.Name = "lblTitle";
      lblTitle.Size = new Size(32, 15);
      lblTitle.TabIndex = 5;
      lblTitle.Text = "Title:";
      // 
      // lblISBN
      // 
      lblISBN.AutoSize = true;
      lblISBN.Location = new Point(12, 79);
      lblISBN.Name = "lblISBN";
      lblISBN.Size = new Size(35, 15);
      lblISBN.TabIndex = 6;
      lblISBN.Text = "ISBN:";
      // 
      // lblPublisher
      // 
      lblPublisher.AutoSize = true;
      lblPublisher.Location = new Point(12, 139);
      lblPublisher.Name = "lblPublisher";
      lblPublisher.Size = new Size(59, 15);
      lblPublisher.TabIndex = 7;
      lblPublisher.Text = "Publisher:";
      // 
      // lblAuthor
      // 
      lblAuthor.AutoSize = true;
      lblAuthor.Location = new Point(12, 200);
      lblAuthor.Name = "lblAuthor";
      lblAuthor.Size = new Size(47, 15);
      lblAuthor.TabIndex = 8;
      lblAuthor.Text = "Author:";
      // 
      // lblCategory
      // 
      lblCategory.AutoSize = true;
      lblCategory.Location = new Point(12, 264);
      lblCategory.Name = "lblCategory";
      lblCategory.Size = new Size(58, 15);
      lblCategory.TabIndex = 9;
      lblCategory.Text = "Category:";
      // 
      // btnOK
      // 
      btnOK.Location = new Point(126, 334);
      btnOK.Name = "btnOK";
      btnOK.Size = new Size(75, 23);
      btnOK.TabIndex = 5;
      btnOK.Text = "OK";
      btnOK.UseVisualStyleBackColor = true;
      btnOK.Click += btnOK_Click;
      // 
      // btnCancel
      // 
      btnCancel.Location = new Point(207, 334);
      btnCancel.Name = "btnCancel";
      btnCancel.Size = new Size(75, 23);
      btnCancel.TabIndex = 6;
      btnCancel.Text = "Cancel";
      btnCancel.UseVisualStyleBackColor = true;
      // 
      // NewBookForm
      // 
      AcceptButton = btnOK;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = btnCancel;
      ClientSize = new Size(295, 369);
      Controls.Add(btnCancel);
      Controls.Add(btnOK);
      Controls.Add(lblCategory);
      Controls.Add(lblAuthor);
      Controls.Add(lblPublisher);
      Controls.Add(lblISBN);
      Controls.Add(lblTitle);
      Controls.Add(txtCategory);
      Controls.Add(txtAuthor);
      Controls.Add(txtPublisher);
      Controls.Add(txtISBN);
      Controls.Add(txtTitle);
      MaximizeBox = false;
      Name = "NewBookForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "New Book";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox txtTitle;
    private TextBox txtISBN;
    private TextBox txtPublisher;
    private TextBox txtAuthor;
    private TextBox txtCategory;
    private Label lblTitle;
    private Label lblISBN;
    private Label lblPublisher;
    private Label lblAuthor;
    private Label lblCategory;
    private Button btnOK;
    private Button btnCancel;
  }
}