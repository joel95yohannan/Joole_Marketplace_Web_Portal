CREATE TABLE [dbo].[tblSubCategory] (
    [SubCategoryID]   INT           NOT NULL PRIMARY KEY, 
    [SubCategoryName] NVARCHAR (50) NULL,
    [CategoryID]      INT           NOT NULL,
    CONSTRAINT [FK_tblSubCategory_tblCategory] FOREIGN KEY ([CategoryID]) REFERENCES [tblCategory] ([CategoryID])
);
