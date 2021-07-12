CREATE PROCEDURE [dbo].[DeleteBook]
	@BookId int

AS

Begin

	set nocount on;

	Delete from dbo.Book
	Where BookId = @BookId

End