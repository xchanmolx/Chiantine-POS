CREATE TABLE [dbo].[PasswordSettings] (
    [password_id]      INT           IDENTITY (1, 1) NOT NULL,
    [password_no]      INT           NULL,
    [password_changed] VARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([password_id] ASC)
);

