CREATE TABLE [dbo].[Product]
(
	[ProductID]       INT           IDENTITY (1, 1) NOT NULL,
    [ProductName]     NVARCHAR (50) NULL,
    [ProductImage]    IMAGE         NULL,
    [Series]          NVARCHAR (50) NULL,
    [SeriesInfo]      NVARCHAR (50) NULL,
    [Model]           NVARCHAR (50) NULL,
    [ModelYear]       INT           NULL,
    [ManufacturerID]  INT           NOT NULL, 
    [SubcategoryID]   INT           NOT NULL,
    [UserID]          INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductID] ASC),
    CONSTRAINT [FK_dbo.Product_dbo.Manufacturer_ManufacturerID] FOREIGN KEY ([ManufacturerID]) 
        REFERENCES [dbo].[Manufacturer] ([ManufacturerID]),  
    CONSTRAINT [FK_dbo.Product_dbo.SubCategory_SubcategoryID] FOREIGN KEY ([SubcategoryID]) 
        REFERENCES [dbo].[SubCategory] ([SubcategoryID]),    
    CONSTRAINT [FK_dbo.Product_dbo.User_UserID] FOREIGN KEY ([UserID]) 
        REFERENCES [dbo].[tblUser] ([UserID]) ON DELETE CASCADE
)
