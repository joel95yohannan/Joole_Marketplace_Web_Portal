CREATE TABLE [dbo].[Manufacturer]
(
	[ManufacturerID]      INT            IDENTITY (1, 1) NOT NULL,
    [ManufacturerName]    NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ManufacturerID] ASC)
)
