CREATE TABLE [dbo].[tblType] (
    [TypeID]        INT           NOT NULL PRIMARY KEY,
    [TypeName]      NVARCHAR (50) NOT NULL,
    [TypeOption]    NVARCHAR (50) NULL,
    [ProductID]     INT           NOT NULL,
    [SubCategoryID] INT           NOT NULL,
    CONSTRAINT [FK_tblType_tblProduct] FOREIGN KEY ([ProductID]) REFERENCES [tblProduct] ([ProductID]),
    CONSTRAINT [FK_tblType_tblSubCategory] FOREIGN KEY ([SubCategoryID]) REFERENCES [tblSubCategory] ([SubCategoryID])

);

