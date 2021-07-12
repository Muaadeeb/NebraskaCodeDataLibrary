CREATE PROCEDURE [dbo].[DeleteUser]
	@UserId int

AS

Begin

	set nocount on;

	Delete from dbo.[User]
	Where UserId = @UserId

End
