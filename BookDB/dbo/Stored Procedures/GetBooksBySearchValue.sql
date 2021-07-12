CREATE PROCEDURE [dbo].[GetBooksBySearchValue]
	@SearchValue varchar(255)
AS

Begin
	
	set nocount on;

	Select *
	From dbo.Book
	Where	(Title like '''%''' + @SearchValue + '''%''') OR
			(AuthorFirstName like '''%''' + @SearchValue + '''%''') OR
			(AuthorLastName like '''%''' + @SearchValue + '''%''')

End

