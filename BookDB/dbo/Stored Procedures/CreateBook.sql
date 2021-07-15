CREATE PROCEDURE [dbo].[CreateBook]
	@Title VARCHAR(150),
	@AuthorFirstName VARCHAR(150),
	@AuthorLastName VARCHAR(150),
	@PrintLength INT,
	@Publisher VARCHAR(255),
	@PublicationDate DateTime,
	@ISBN INT NULL,
	@ReviewRating INT NULL,
	@Comments VARCHAR(MAX),
	--@AuthorMiddleName VARCHAR(150),
	--@CategoryId INT,
	--@SubCategoryId INT,
	--@CreatedUser VARCHAR(255),
	--@UpdatedUser VARCHAR(255),
	--@CreatedDate DateTime,
	--@UpdatedDate DateTime,
	@BookId int output

AS
Begin
	
	set nocount on;

	Insert Into dbo.Book(Title, AuthorFirstName, AuthorLastName, PrintLength,
		   Publisher, PublicationDate, ISBN, ReviewRating, Comments)
	Values(@Title, @AuthorFirstName, @AuthorLastName, @PrintLength,
		   @Publisher, @PublicationDate, @ISBN, @ReviewRating, @Comments)

	set @BookId = SCOPE_IDENTITY();

End