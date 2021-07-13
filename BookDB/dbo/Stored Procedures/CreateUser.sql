CREATE PROCEDURE [dbo].[CreateUser]
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
	@UpdatedDate DateTime,
	@UserId int output

AS
	
Begin

	set nocount on;

	Insert Into dbo.[User](FirstName, LastName, Email, Phone, Address1, Address2, City, [State], ZipCode, IsActive, CreatedUser, 
					UpdatedUser, CreatedDate, UpdatedDate)
	Values(@FirstName,	@LastName, @Email, @Phone, @Address1, @Address2, @City, @State, @ZipCode, @IsActive, @CreatedUser, 
	@UpdatedUser, @CreatedDate, @UpdatedDate)

	set @UserId = SCOPE_IDENTITY();

End

