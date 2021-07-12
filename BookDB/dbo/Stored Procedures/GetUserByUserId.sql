CREATE PROCEDURE [dbo].[GetUserByUserId]
	@UserId int

AS

Begin

	set nocount on;

	Select *
	From dbo.[User]
	Where UserId = @UserId

End
