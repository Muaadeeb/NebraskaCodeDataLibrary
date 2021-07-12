CREATE PROCEDURE [dbo].[DeleteCategory]
	@CategoryId int

AS

Begin

	set nocount on;

	Delete from dbo.Category
	Where CategoryId = @CategoryId

End