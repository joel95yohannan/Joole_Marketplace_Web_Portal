CREATE TABLE [dbo].[SubCategory]
(
	[SubcategoryID]    INT            IDENTITY (1, 1) NOT NULL,
	[SubcategoryName]  NVARCHAR (50)  NOT NULL,
    [CategoryID]       INT            NOT NULL,
	PRIMARY KEY CLUSTERED ([SubcategoryID] ASC),
	CONSTRAINT [FK_dbo.Subcategory_dbo.Category_CategoryID] FOREIGN KEY ([CategoryID]) 
        REFERENCES [dbo].[Category] ([CategoryID]) 
)
