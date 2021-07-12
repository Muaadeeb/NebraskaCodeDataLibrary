CREATE TABLE [dbo].[Book]
(
	[BookId] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Title] VARCHAR(150) NULL,
    [AuthorFirstName] VARCHAR(150) NULL,
	[AuthorLastName] VARCHAR(150) NULL,
	[AuthorMiddleName] VARCHAR(150) NULL,
	[CategoryId] Int Not NULL,
	[SubCategoryId] INT Not NULL,
	[PrintLength] int NULL,
	[Publisher] VARCHAR(255) NULL,
	[PublicationDate] DateTime NULL,
	[ISBN] INT NULL,
	[ReviewRating] Decimal(3,2) NULL,
	[CreatedUser] VARCHAR(255) NULL DEFAULT (SUser_Name()),
	[UpdatedUser] VARCHAR(255) NULL DEFAULT (SUser_Name()),
	[CreatedDate] DateTime NULL DEFAULT (GetDate()),
	[UpdatedDate] DateTime NULL DEFAULT (GetDate()), 
    CONSTRAINT [FK_Book_SubCategory] FOREIGN KEY ([SubCategoryId]) REFERENCES [SubCategory]([SubCategoryId]), 
    CONSTRAINT [FK_Book_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([CategoryId])
)
