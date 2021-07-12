CREATE PROCEDURE [dbo].[CreateBook]
	@Title VARCHAR(150),
	@AuthorFirstName VARCHAR(150),
	@AuthorLastName VARCHAR(150),
	@AuthorMiddleName VARCHAR(150),
	@CategoryId INT,
	@SubCategoryId INT,
	@PrintLength INT,
	@Publisher VARCHAR(255),
	@PublicationDate DateTime,
	@ISBN INT NULL,
	@ReviewRating Decimal(3,2),
	@CreatedUser VARCHAR(255),
	@UpdatedUser VARCHAR(255),
	@CreatedDate DateTime,
	@UpdatedDate DateTime,
	@BookId int output

AS
Begin
	
	set nocount on;

	Insert Into dbo.Book(Title, AuthorFirstName, AuthorLastName, AuthorMiddleName, CategoryId, SubCategoryId, PrintLength,
		   Publisher, PublicationDate, ISBN, ReviewRating, CreatedUser, UpdatedUser, CreatedDate,
		   UpdatedDate)
	Values(@Title, @AuthorFirstName, @AuthorLastName, @AuthorMiddleName, @CategoryId, @SubCategoryId, @PrintLength,
		   @Publisher, @PublicationDate, @ISBN, @ReviewRating, @CreatedUser, @UpdatedUser, @CreatedDate,
		   @UpdatedDate)

	set @BookId = SCOPE_IDENTITY();

End