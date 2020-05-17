CREATE TABLE [dbo].[Code] (
    [code_id]   INT           IDENTITY (1, 1) NOT NULL,
    [code_no]   INT           NULL,
    [code_name] VARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([code_id] ASC)
);

