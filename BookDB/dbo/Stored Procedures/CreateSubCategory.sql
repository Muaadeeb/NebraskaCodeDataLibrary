CREATE PROCEDURE [dbo].[CreateSubCategory]
	@SubCategoryName varchar(255),
	@CategoryId int,
	@CreatedUser VARCHAR(255),
	@UpdatedUser VARCHAR(255),
	@CreatedDate DateTime,
	@UpdatedDate DateTime,
	@SubCategoryId int output

AS

Begin

	set nocount on;

	Insert Into dbo.SubCategory(SubCategoryName, CategoryId, CreatedUser, UpdatedUser, CreatedDate, UpdatedDate)
	Values(@SubCategoryName, @CategoryId, @CreatedUser, @UpdatedUser, @CreatedDate, @UpdatedDate)

	set @SubCategoryId = SCOPE_IDENTITY();

End

