CREATE PROCEDURE [dbo].[GetUsersBySearchValue]
	@SearchValue varchar(255)

AS

Begin

	set nocount on;

	Select *
	From dbo.[User]
	Where	(FirstName like '''%''' + @SearchValue + '''%''') OR
			(LastName like '''%''' + @SearchValue + '''%''') OR
			(Email like '''%''' + @SearchValue + '''%''') 

End