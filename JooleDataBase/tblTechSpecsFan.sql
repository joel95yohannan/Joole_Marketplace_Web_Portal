CREATE TABLE [dbo].[tblTechSpecsFan]
(
	[ProductID]     INT NOT NULL PRIMARY KEY,
    [AirFlowCFM]    INT NULL,
    [PowerWattsMax] INT NULL,
    [PowerWattsMin] INT NULL,
    [OperatingVoltageMax] INT NULL,
    [OperatingVoltageMin] INT NULL,
    [FanSpeedMax] INT NULL,
    [FanSpeedMin] INT NULL,
    [NumbSpeed] INT NULL,
    [MaxSound] INT NULL,
    [SweepDiameter] INT NULL,
    [FanWeight] INT NULL,
    [MountingLocation] VARCHAR(20) NULL,
    CONSTRAINT [FK_tblTechSpecsFan_tblProducts] FOREIGN KEY ([ProductID]) REFERENCES [tblProducts] ([ProductID])
)
