/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
MERGE INTO tblUser AS Target
USING (VALUES 
        (1, 'John', 'john@gmail.com', 1001, NULL), 
        (2, 'Amy', 'amy@gmail.com', 1002, NULL), 
        (3, 'Evie','evie@gmail.com', 1003, NULL),
        (4, 'Peter', 'peter@gmail.com', 1004, NULL),
        (5, 'Nick', 'nick@gmail.com', 1005, NULL)
) 
AS Source (UserID, UserName, UserEmail, UserPassword, UserImage) 
ON Target.UserID = Source.UserID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (UserID, UserName, UserEmail, UserPassword, UserImage) 
VALUES (UserID, UserName, UserEmail, UserPassword, UserImage);

MERGE INTO tblManufacturer AS Target
USING (VALUES 
        (1, 'Emerson'), 
        (2, 'Minka'), 
        (3, 'YYY'),
        (4, 'Lavenci'), 
        (5, 'Joking'), 
        (6, 'EHP Q'),
        (7, 'Big Bob')
)
AS Source (ManufacturerID, ManufacturerName)
ON Target.ManufacturerID = Source.ManufacturerID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ManufacturerID, ManufacturerName)
VALUES (ManufacturerID, ManufacturerName);


MERGE INTO tblCategory AS Target 
USING (VALUES 
        (1, 'Mechanical'), 
        (2, 'Electrical'), 
        (3, 'Stationary'),
        (4, 'Furniture')
) 
AS Source (CategoryID, CategoryName) 
ON Target.CategoryID = Source.CategoryID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (CategoryID, CategoryName) 
VALUES (CategoryID, CategoryName);


MERGE INTO tblSubCategory AS Target 
USING (VALUES 
        (1, 'Fans', 1), 
        (2, 'Vacuums', 1), 
        (3, 'Toasters', 1)
) 
AS Source (SubCategoryID, SubCategoryName, CategoryID) 
ON Target.SubCategoryID = Source.SubCategoryID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (SubCategoryID, SubCategoryName, CategoryID) 
VALUES (SubCategoryID, SubCategoryName, CategoryID);


MERGE INTO tblType AS Target 
USING (VALUES 
        (1, 'Power', NULL, 1, 1), 
        (2, 'Operation Voltage', NULL, 1, 1), 
        (3, 'Max Speed Sound', NULL, 1, 1),
        (4, 'Height', NULL, 1, 1),
        (5, 'Weight', NULL, 1, 1)
) 
AS Source (TypeID, TypeName, TypeOption, ProductID, SubCategoryID) 
ON Target.TypeID = Source.TypeID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (TypeID, TypeName, TypeOption, ProductID, SubCategoryID) 
VALUES (TypeID, TypeName, TypeOption, ProductID, SubCategoryID);


MERGE INTO tblProducts AS Target
USING (VALUES 
        (1, 'X FAN', NULL, 'Haiku H', NULL, 'S3-1508', 2015, 3, 1, 3),
        (2, 'Pro Fan', NULL, 'Tim C', NULL, 'EE-0130', 2017, 1, 1, 5),
        (3, '1967 Fan', NULL, 'Della J', NULL, 'JL0815', 2021, 2, 1, 1),
        (4, 'Sanko V6 Vacuum', NULL, 'Sanko V6', NULL, 'SK-6731', 2016, 5, 2, 3),
        (5, 'Shark UL Vacuum', NULL, 'Shark I8', NULL, 'SH789', 2017, 4, 2, 4),
        (6, 'Wing F9 Vacuum', NULL, 'Wing F9', NULL, 'W99', 2019, 6, 2, 2),
        (7, 'Snko 41 Toasters', NULL, 'Sanko 41', NULL, 'SK-11-97', 2018, 5, 3, 5),
        (8, 'Snko 42 Toasters', NULL, 'Sanko 42', NULL, 'SK-12-98', 2019, 5, 3, 2),
        (9, 'Snko 43 Toasters', NULL, 'Sanko 43', NULL, 'SK-13-99', 2020, 5, 3, 1)
)
AS Source (ProductID, ProductName, ProductImage, Series, SeriesInfo, Model, ModelYear, ManufacturerID, SubCategoryID, UserID)
ON Target.ProductID = Source.ProductID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ProductID, ProductName, ProductImage, Series, SeriesInfo, Model, ModelYear, ManufacturerID, SubCategoryID, UserID)
VALUES (ProductID, ProductName, ProductImage, Series, SeriesInfo, Model, ModelYear, ManufacturerID, SubCategoryID, UserID);


MERGE INTO tblTechSpecsFan AS Target
USING (VALUES 
        (1, 5100, 100, 55, 240, 100, 390, 300, 5, 35, 50, 20, 'Roof'),
        (2, 5200, 100, 55, 240, 110, 380, 300, 6, 30, 47, 30, 'Roof'),
        (3, 5500, 100, 55, 240, 120, 370, 310, 4, 35, 60, 25, 'Roof')        
)
AS Source (ProductID, AirFlowCFM, PowerWattsMax, PowerWattsMin, OperatingVoltageMax, OperatingVoltageMin, FanSpeedMax, FanSpeedMin, NumbSpeed, MaxSound, SweepDiameter, FanWeight, MountingLocation)
ON Target.ProductID = Source.ProductID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ProductID, AirFlowCFM, PowerWattsMax, PowerWattsMin, OperatingVoltageMax, OperatingVoltageMin, FanSpeedMax, FanSpeedMin, NumbSpeed, MaxSound, SweepDiameter, FanWeight, MountingLocation)
VALUES (ProductID, AirFlowCFM, PowerWattsMax, PowerWattsMin, OperatingVoltageMax, OperatingVoltageMin, FanSpeedMax, FanSpeedMin, NumbSpeed, MaxSound, SweepDiameter, FanWeight, MountingLocation);


MERGE INTO tblTechSpecsVacuum AS Target
USING (VALUES 
        (4, 125, 3000, 500, 120, 110, 25000, 15000, 75, 12, 15, 15, 'Stick'),
        (5, 150, 3000, 500, 120, 110, 20000, 15000, 70, 10, 12, 25, 'Upright'),
        (6, 130, 3000, 500, 120, 110, 25000, 20000, 70, 16, 10, 20, 'Stick')        
)
AS Source (ProductID, AirFlowCFM, PowerWattsMax, PowerWattsMin, OperatingVoltageMax, OperatingVoltageMin, FanSpeedMax, FanSpeedMin, MaxSound, CleaningWidth, AttachmentReach, VacuumWeight, FormFactor)
ON Target.ProductID = Source.ProductID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ProductID, AirFlowCFM, PowerWattsMax, PowerWattsMin, OperatingVoltageMax, OperatingVoltageMin, FanSpeedMax, FanSpeedMin, MaxSound, CleaningWidth, AttachmentReach, VacuumWeight, FormFactor)
VALUES (ProductID, AirFlowCFM, PowerWattsMax, PowerWattsMin, OperatingVoltageMax, OperatingVoltageMin, FanSpeedMax, FanSpeedMin, MaxSound, CleaningWidth, AttachmentReach, VacuumWeight, FormFactor);


MERGE INTO tblTechSpecsToaster AS Target
USING (VALUES 
        (7, 2, 1500, 800, 120, 110, 450, 150, 65, 2, 14, 2, 'Single'),
        (8, 3, 1500, 800, 120, 110, 400, 150, 100, 2, 15, 3, 'Multi'),
        (9, 3, 1500, 800, 120, 110, 450, 200, 165, 2, 14, 4, 'Multi')        
)
AS Source (ProductID, NumOfPrograms, PowerWattsMax, PowerWattsMin, OperatingVoltageMax, OperatingVoltageMin, HeatMax, HeatMin, 
OutputPerHour, SlotWidth, ToasterHeight, ToasterWeight, Slot)
ON Target.ProductID = Source.ProductID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ProductID, NumOfPrograms, PowerWattsMax, PowerWattsMin, OperatingVoltageMax, OperatingVoltageMin, HeatMax, HeatMin, OutputPerHour, SlotWidth, ToasterHeight, ToasterWeight, Slot)
VALUES (ProductID, NumOfPrograms, PowerWattsMax, PowerWattsMin, OperatingVoltageMax, OperatingVoltageMin, HeatMax, HeatMin, OutputPerHour, SlotWidth, ToasterHeight, ToasterWeight, Slot);



MERGE INTO tblSpecification AS Target
USING (VALUES 
        (1, 1.00, 50.00, 1, 1), 
        (2, 20.00, 500.00, 1, 1), 
        (3, NULL, 200.00, 1, 1),
        (4, 1.00, 100.00, 1, 1), 
        (5, NULL, 30.00, 1, 1)
)
AS Source (TypeID, MinValue, MaxValue, ProductID, SubCategoryID)
ON Target.TypeID = Source.TypeID
WHEN NOT MATCHED BY TARGET THEN
INSERT (TypeID, MinValue, MaxValue, ProductID, SubCategoryID)
VALUES (TypeID, MinValue, MaxValue, ProductID, SubCategoryID);


