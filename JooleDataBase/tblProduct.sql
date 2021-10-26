CREATE TABLE [dbo].[tblProduct] (
    [ProductID]      INT           NOT NULL PRIMARY KEY,
    [ProductName]    NVARCHAR (50) NOT NULL,
    [ProductImage]   IMAGE         NULL,
    [Series]         NVARCHAR (50) NOT NULL,
    [SeriesInfo]     NVARCHAR (50) NULL,
    [Model]          NVARCHAR (50) NOT NULL,
    [ModelYear]      INT           NOT NULL,
    [ManufacturerID] INT           NOT NULL,
    [SubCategoryID]  INT           NOT NULL,
    [UserID]         INT           NOT NULL,
    CONSTRAINT [FK_tblProduct_tblManufacturer] FOREIGN KEY ([ManufacturerID]) REFERENCES [tblManufacturer] ([ManufacturerID]),
    CONSTRAINT [FK_tblProduct_tblSubCategory] FOREIGN KEY ([SubCategoryID]) REFERENCES [tblSubCategory] ([SubCategoryID]),
    CONSTRAINT [FK_tblProduct_tblUser] FOREIGN KEY ([UserID]) REFERENCES [tblUser] ([UserID])
)
