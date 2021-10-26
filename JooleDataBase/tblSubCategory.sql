CREATE TABLE [dbo].[tblSubcategory] (
    [SubCategoryID]   INT           NOT NULL PRIMARY KEY, 
    [SubCategoryName] NVARCHAR (50) NULL,
    [CategoryID]      INT           NOT NULL,

);
