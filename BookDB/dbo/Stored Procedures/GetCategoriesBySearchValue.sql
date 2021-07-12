CREATE PROCEDURE [dbo].[GetCategorysBySearchValue]
	@SearchValue varchar(255)
	
AS
	
Begin

	set nocount on;

	Select *
	From dbo.Category
	Where	(CategoryName like '''%''' + @SearchValue + '''%''')

End