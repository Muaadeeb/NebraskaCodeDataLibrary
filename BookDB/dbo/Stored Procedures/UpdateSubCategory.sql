CREATE PROCEDURE [dbo].[UpdateSubCategory]
	@SubCategoryId int,
	@SubCategoryName varchar(255),
	@CategoryId int,
	@CreatedUser VARCHAR(255),
	@UpdatedUser VARCHAR(255),
	@CreatedDate DateTime,
	@UpdatedDate DateTime

AS

Begin

	set nocount on;

	Update dbo.SubCategory
		Set
			SubCategoryName = @SubCategoryName,
			CategoryId = @CategoryId, 
			CreatedUser = @CreatedUser, 
			UpdatedUser = @UpdatedUser, 
			CreatedDate = @CreatedDate, 
			UpdatedDate = @UpdatedDate 
		Where SubCategoryId = @SubCategoryId

End


