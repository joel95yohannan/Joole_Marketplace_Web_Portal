CREATE TABLE [dbo].[tblTechSpecsVacuum]
(
	[ProductID]     INT NOT NULL PRIMARY KEY,
    [AirFlowCFM]    INT NULL,
    [PowerWattsMax] INT NULL,
    [PowerWattsMin] INT NULL,
    [OperatingVoltageMax] INT NULL,
    [OperatingVoltageMin] INT NULL,
    [FanSpeedMax] INT NULL,
    [FanSpeedMin] INT NULL,
    [MaxSound] INT NULL,
    [CleaningWidth] INT NULL,
    [AttachmentReach] INT NULL,
    [VacuumWeight] INT NULL,
    [FormFactor] VARCHAR(20) NULL,
    CONSTRAINT [FK_tblTechSpecsVacuum_tblProducts] FOREIGN KEY ([ProductID]) REFERENCES [tblProducts] ([ProductID])
)
