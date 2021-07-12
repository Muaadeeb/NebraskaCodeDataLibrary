CREATE PROCEDURE [dbo].[UpdateCategory]
	@CategoryId int,
	@CategoryName varchar(255),
	@CreatedUser VARCHAR(255),
	@UpdatedUser VARCHAR(255),
	@CreatedDate DateTime,
	@UpdatedDate DateTime

AS

Begin

	set nocount on;

	Update dbo.Category
		Set
			CategoryName = @CategoryName,
			CreatedUser = @CreatedUser, 
			UpdatedUser = @UpdatedUser, 
			CreatedDate = @CreatedDate, 
			UpdatedDate = @UpdatedDate 
		Where CategoryId = @CategoryId

End


