CREATE PROCEDURE [dbo].[GetSubCategoryBySubCategoryId]
	@SubCategoryId int

AS

Begin

	set nocount on;

	Select *
	From dbo.[SubCategory]
	Where SubCategoryId = @SubCategoryId

End
