CREATE TABLE [dbo].[SubCategory]
(
	[SubCategoryId] INT NOT NULL PRIMARY KEY IDENTITY,
	[SubCategoryName] VARCHAR(255) NOT NULL,
	[CategoryId] int not null,
	[CreatedUser] VARCHAR(255) NULL DEFAULT (SUser_Name()),
	[UpdatedUser] VARCHAR(255) NULL DEFAULT (SUser_Name()),
	[CreatedDate] DateTime NULL DEFAULT (GetDate()),
	[UpdatedDate] DateTime NULL DEFAULT (GetDate()), 
    CONSTRAINT [FK_SubCategory_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([CategoryId]), 
    
)
