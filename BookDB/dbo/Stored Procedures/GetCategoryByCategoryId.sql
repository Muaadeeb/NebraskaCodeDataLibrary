CREATE PROCEDURE [dbo].[GetCategoryByCategoryId]
	@CategoryId int

AS

Begin

	set nocount on;

	Select *
	From dbo.Category
	Where CategoryId = @CategoryId

End
