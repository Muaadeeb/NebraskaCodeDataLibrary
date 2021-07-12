CREATE PROCEDURE [dbo].[GetBookByBookId]
	@BookId int

AS

Begin

	set nocount on;

	Select *
	From dbo.Book
	Where BookId = @BookId

End
