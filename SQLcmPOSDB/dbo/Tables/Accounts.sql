CREATE TABLE [dbo].[Accounts] (
    [AccountID] INT           IDENTITY (1, 1) NOT NULL,
    [Username]  VARCHAR (100) NOT NULL,
    [Password]  VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([AccountID] ASC)
);

