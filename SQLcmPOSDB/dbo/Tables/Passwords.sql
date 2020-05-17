CREATE TABLE [dbo].[Passwords] (
    [PasswordID] INT           IDENTITY (1, 1) NOT NULL,
    [Password]   VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Passwords] PRIMARY KEY CLUSTERED ([PasswordID] ASC)
);

