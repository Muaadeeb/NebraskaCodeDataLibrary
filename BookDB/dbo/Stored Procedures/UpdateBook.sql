CREATE PROCEDURE [dbo].[UpdateBook]
	@BookId int,
	@Title VARCHAR(150),
	@AuthorFirstName VARCHAR(150),
	@AuthorLastName VARCHAR(150),
	@PrintLength INT,
	@Publisher VARCHAR(255),
	@PublicationDate DateTime,
	@ISBN INT NULL,
	@ReviewRating INT NULL
	--@AuthorMiddleName VARCHAR(150),
	--@CategoryId INT,
	--@SubCategoryId INT,
	--@CreatedUser VARCHAR(255),
	--@UpdatedUser VARCHAR(255),
	--@CreatedDate DateTime,
	--@UpdatedDate DateTime

AS

Begin

	set nocount on;

	Update dbo.Book
		Set	
			Title = @Title,
			AuthorFirstName = @AuthorFirstName,
			AuthorLastName = @AuthorLastName,
			PrintLength = @PrintLength,
			Publisher = @Publisher,
			PublicationDate = @PublicationDate,
			ISBN = @ISBN,
			ReviewRating = @ReviewRating
			--AuthorMiddleName = @AuthorMiddleName,
			--CategoryId = @CategoryId,
			--SubCategoryId = @SubCategoryId,
			--CreatedUser = @CreatedUser,
			--UpdatedUser = @UpdatedUser,
			--CreatedDate = @CreatedDate,
			--UpdatedDate = @UpdatedDate
		Where BookId = @BookId
End
