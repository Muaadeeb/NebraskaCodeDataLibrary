CREATE PROCEDURE [dbo].[CreateCategory]
	@CategoryName varchar(255),
	@CreatedUser VARCHAR(255),
	@UpdatedUser VARCHAR(255),
	@CreatedDate DateTime,
	@UpdatedDate DateTime,
	@CategoryId int output

AS
	
Begin

	set nocount on;

	Insert Into dbo.Category(CategoryName, CreatedUser, UpdatedUser, CreatedDate, UpdatedDate)
	Values(@CategoryName, @CreatedUser, @UpdatedUser, @CreatedDate, @UpdatedDate)

	set @CategoryId = SCOPE_IDENTITY();

End

