IF NOT EXISTS
(
	SELECT 1 FROM sys.tables WHERE name = 'Author'
)
BEGIN

CREATE TABLE [Author]
( 
	[AuthorId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[AuthorName] NVARCHAR(50) NOT NULL UNIQUE
)
END
GO

IF NOT EXISTS
(
	SELECT 1 FROM sys.tables WHERE name = 'Publisher'
)
BEGIN

CREATE TABLE [Publisher]
( 
	[PublisherId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[PublisherName] NVARCHAR(50) NOT NULL UNIQUE
)
END
GO

IF NOT EXISTS
(
	SELECT 1 FROM sys.tables WHERE name = 'Category'
)
BEGIN

CREATE TABLE [Category]
( 
	[CategoryId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[CategoryName] NVARCHAR(50) NOT NULL UNIQUE
)
END
GO


IF NOT EXISTS
(
	SELECT 1 FROM sys.tables WHERE name = 'Book'
)
BEGIN

CREATE TABLE [Book]
(
	[BookId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Title] NVARCHAR(50) NOT NULL UNIQUE,
	[ISBN] NVARCHAR(20) NOT NULL,
	[PublisherId] INT NOT NULL FOREIGN KEY REFERENCES [Publisher] ([PublisherId]),
	[AuthorId] INT NOT NULL FOREIGN KEY REFERENCES [Author] ([AuthorId]),
	[CategoryId] INT NOT NULL FOREIGN KEY REFERENCES [Category] ([CategoryId])
)
END
GO

-- author
INSERT INTO [Author] (AuthorName) VALUES ('Knut Hamsun')
GO
INSERT INTO [Author] (AuthorName) VALUES ('Gilbert Strang')
GO
INSERT INTO [Author] (AuthorName) VALUES ('J.R.R Tolkien')
GO
INSERT INTO [Author] (AuthorName) VALUES ('Dorf Bishop')
GO

-- publisher
INSERT INTO [Publisher] (PublisherName) VALUES ('Prentice Hall')
GO
INSERT INTO [Publisher] (PublisherName) VALUES ('Wiley')
GO
INSERT INTO [Publisher] (PublisherName) VALUES ('McGraw-Hill')
GO

-- category
INSERT INTO [Category] (CategoryName) VALUES ('Science')
GO

-- book
INSERT INTO Book (Title, ISBN, PublisherId, AuthorId, CategoryId)
VALUES
(
	'Introduction to Linear Algebra',
	'0-07-066781-0',
	(SELECT PublisherId FROM  Publisher WHERE PublisherName = 'Prentice Hall'),
	(SELECT AuthorId FROM Author WHERE AuthorName = 'Gilbert Strang'),
	(SELECT CategoryId FROM Category WHERE CategoryName = 'Science')
)
GO

IF EXISTS
(
	SELECT name FROM sysobjects WHERE name = 'GetBookData' AND type = 'V'
)
DROP VIEW GetBookData
GO

CREATE VIEW GetBookData
AS
	SELECT Book.BookId, Book.Title, Book.ISBN, Publisher.PublisherName, Author.AuthorName, Category.CategoryName
	FROM Book 
	INNER JOIN Publisher ON Publisher.PublisherId = Book.PublisherId
	INNER JOIN Author ON Author.AuthorId = Book.AuthorId
	INNER JOIN Category ON Category.CategoryId = Book.CategoryId
GO
