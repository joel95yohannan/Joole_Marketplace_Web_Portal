CREATE TABLE [dbo].[tblUser]
(
	[UserID]       INT           IDENTITY (1, 1) NOT NULL,
    [UserName]     NVARCHAR (50)  NOT NULL,
    [UserEmail]    NVARCHAR (50)  NOT NULL,
    [UserPassword] NVARCHAR (50)  NOT NULL,
    [UserImage]    IMAGE          NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
)
