CREATE TABLE [dbo].[tblUser] (
    [UserID]       INT           NOT NULL  PRIMARY KEY, 
    [UserName]     NVARCHAR (50) NOT NULL,
    [UserEmail]    NVARCHAR (50) NOT NULL,
    [UserPassword] NVARCHAR (50) NOT NULL,
    [UserImage]    IMAGE         NULL,
);

