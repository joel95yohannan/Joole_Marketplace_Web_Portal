CREATE TABLE [dbo].[Specification]
(
	[TypeID]			INT           IDENTITY (1, 1) NOT NULL,
	[MinValue]			DECIMAL(18, 2)  NULL,
	[MaxValue]			DECIMAL(18, 2)  NULL,
	[ProductID]			INT     NOT NULL,
	[SubcategoryID]		INT		NOT NULL
	PRIMARY KEY CLUSTERED ([TypeID] ASC),
	CONSTRAINT [FK_dbo.Specification_dbo.Product_ProductID] FOREIGN KEY ([ProductID]) 
        REFERENCES [dbo].[Product] ([ProductID]),
	CONSTRAINT [FK_dbo.Specification_dbo.SubCategory_SubcategoryID] FOREIGN KEY ([SubcategoryID]) 
        REFERENCES [dbo].[SubCategory] ([SubcategoryID])
)
