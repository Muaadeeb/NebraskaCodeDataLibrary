CREATE TABLE [dbo].[Category]
(
	[CategoryId] INT NOT NULL PRIMARY KEY IDENTITY,
	[CategoryName] VARCHAR(255) NULL,
	[CreatedUser] VARCHAR(255) NULL DEFAULT (SUser_Name()),
	[UpdatedUser] VARCHAR(255) NULL DEFAULT (SUser_Name()),
	[CreatedDate] DateTime NULL DEFAULT (GetDate()),
	[UpdatedDate] DateTime NULL DEFAULT (GetDate())
)
