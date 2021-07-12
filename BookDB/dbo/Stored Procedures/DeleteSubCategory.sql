CREATE PROCEDURE [dbo].[DeleteSubCategory]
	@SubCategoryId int

AS

Begin

	set nocount on;

	Delete from dbo.[SubCategory]
	Where SubCategoryId = @SubCategoryId

End