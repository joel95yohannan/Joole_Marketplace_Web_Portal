CREATE TABLE [dbo].[Type]
(
	[TypeID]          INT           IDENTITY (1, 1) NOT NULL,
    [TypeName]        NVARCHAR (50) NOT NULL,
    [TypeOption]      NVARCHAR (50) NULL,
    [ProductID]       INT           NOT NULL,
    [SubcategoryID]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([TypeID] ASC),
    CONSTRAINT [FK_dbo.Type_dbo.Product_ProductID] FOREIGN KEY ([ProductID]) 
        REFERENCES [dbo].[Product] ([ProductID]),
    CONSTRAINT [FK_dbo.Type_dbo.SubCategory_SubcategoryID] FOREIGN KEY ([SubcategoryID]) 
        REFERENCES [dbo].[SubCategory] ([SubcategoryID]),
)
