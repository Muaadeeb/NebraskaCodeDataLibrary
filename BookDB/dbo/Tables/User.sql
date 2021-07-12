CREATE TABLE [dbo].[User]
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(150) NULL,
	[LastName] VARCHAR(150) NULL,
	[Email] VARCHAR(250) NULL,
	[Phone] INT NULL,
	[Address1] VARCHAR(255) NULL,
	[Address2] VARCHAR(255) NULL,
	[City] VARCHAR(255) NULL,
	[State] VARCHAR(255) NULL,
	[ZipCode] VARCHAR(255) NULL,
	[IsActive] bit NULL,
	[CreatedUser] VARCHAR(255) NULL DEFAULT (SUser_Name()),
	[UpdatedUser] VARCHAR(255) NULL DEFAULT (SUser_Name()),
	[CreatedDate] DateTime NULL DEFAULT (GetDate()),
	[UpdatedDate] DateTime NULL DEFAULT (GetDate())
)
