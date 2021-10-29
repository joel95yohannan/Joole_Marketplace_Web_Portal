CREATE TABLE [dbo].[tblType] (
    [TypeID]        INT           NOT NULL PRIMARY KEY,
    [TypeName]      NVARCHAR (50) NOT NULL,
    [TypeOption]    NVARCHAR (50) NULL,
    [ProductID]     INT           NOT NULL,
    [SubCategoryID] INT           NOT NULL,
    CONSTRAINT [FK_tblType_tblProducts] FOREIGN KEY ([ProductID]) REFERENCES [tblProducts] ([ProductID]),
    CONSTRAINT [FK_tblType_tblSubCategory] FOREIGN KEY ([SubCategoryID]) REFERENCES [tblSubCategory] ([SubCategoryID])

);

