CREATE TABLE [dbo].[tblSpecification] (
    [TypeID]        INT             NOT NULL PRIMARY KEY,
    [MinValue]      DECIMAL (18, 2) NULL,
    [MaxValue]      DECIMAL (18, 2) NULL,
    [ProductID]     INT             NOT NULL,
    [SubCategoryID] INT             NOT NULL,
    CONSTRAINT [FK_tblSpecification_tblProduct] FOREIGN KEY ([ProductID]) REFERENCES [tblProduct] ([ProductID]),
    CONSTRAINT [FK_tblSpecification_tblSubCategory] FOREIGN KEY ([SubCategoryID]) REFERENCES [tblSubCategory] ([SubCategoryID])
);

