CREATE OR ALTER PROCEDURE CreateBook
	@Title NVARCHAR(50),
	@ISBN NVARCHAR(20),
	@PublisherName NVARCHAR(50),
	@AuthorName NVARCHAR(50),
	@CategoryName NVARCHAR(50)
AS
	IF NOT EXISTS
	(
		SELECT * FROM Publisher WHERE PublisherName = @PublisherName
	)
	INSERT INTO Publisher (PublisherName) VALUES (@PublisherName)

	IF NOT EXISTS
	(
		SELECT * FROM Author WHERE AuthorName = @AuthorName
	)
	INSERT INTO Author (AuthorName) VALUES (@AuthorName)

	IF NOT EXISTS
	(
		SELECT * FROM Category WHERE CategoryName = @CategoryName
	)
	INSERT INTO Category (CategoryName) VALUES (@CategoryName)

	IF NOT EXISTS
	(
		SELECT * FROM Book WHERE Title = @Title
	)
	INSERT INTO Book (Title, ISBN, PublisherId, AuthorId, CategoryId)
	VALUES 
	(
		@Title, 
		@ISBN,
		(SELECT PublisherId FROM Publisher WHERE PublisherName = @PublisherName),
		(SELECT AuthorId FROM Author WHERE AuthorName = @AuthorName),
		(SELECT CategoryId FROM Category WHERE CategoryName = @CategoryName)
	)
	
GO