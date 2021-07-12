CREATE PROCEDURE [dbo].[GetAllBooks]

AS

Begin

	Set nocount on;

	SELECT *
	From dbo.Book

End