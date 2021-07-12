CREATE PROCEDURE [dbo].[UpdateUser]
	@UserId int,
	@FirstName varchar(150),
	@LastName varchar(150),
	@Email varchar(250),
	@Phone int,
	@Address1 varchar(255),
	@Address2 varchar(255),
	@City varchar(255),
	@State varchar(255),
	@ZipCode varchar(255),
	@IsActive bit,
	@CreatedUser VARCHAR(255),
	@UpdatedUser VARCHAR(255),
	@CreatedDate DateTime,
	@UpdatedDate DateTime

AS

Begin

	set nocount on;

	Update dbo.[User]
		Set 
			FirstName = @FirstName,
			LastName = @LastName,
			Email = @Email,
			Phone = @Phone,
			Address1 = @Address1,
			Address2 = @Address2,
			City = @City,
			[State] = @State,
			ZipCode = @ZipCode,
			IsActive = @IsActive,
			CreatedUser = @CreatedUser,
			UpdatedUser = @UpdatedUser,
			CreatedDate = @CreatedDate,
			UpdatedDate = @UpdatedDate
		Where UserId = @UserId

End