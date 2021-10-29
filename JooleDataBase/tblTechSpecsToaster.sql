CREATE TABLE [dbo].[tblTechSpecsToaster]
(
	[ProductID]     INT NOT NULL PRIMARY KEY,
    [NumOfPrograms]    INT NULL,
    [PowerWattsMax] INT NULL,
    [PowerWattsMin] INT NULL,
    [OperatingVoltageMax] INT NULL,
    [OperatingVoltageMin] INT NULL,
    [HeatMax] INT NULL,
    [HeatMin] INT NULL,
    [OutputPerHour] INT NULL,
    [SlotWidth] INT NULL,
    [ToasterHeight] INT NULL,
    [ToasterWeight] INT NULL,
    [Slot] VARCHAR(20) NULL,
    CONSTRAINT [FK_tblTechSpecsToaster_tblProducts] FOREIGN KEY ([ProductID]) REFERENCES [tblProducts] ([ProductID])
)
