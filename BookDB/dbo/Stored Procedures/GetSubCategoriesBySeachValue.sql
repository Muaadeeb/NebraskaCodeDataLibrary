CREATE PROCEDURE [dbo].[GetSubCategorysBySeachValue]
	@SearchValue varchar(255)
	
AS
	
Begin

	set nocount on;

	Select *
	From dbo.[SubCategory]
	Where	(SubCategoryName like '''%''' + @SearchValue + '''%''') 

End