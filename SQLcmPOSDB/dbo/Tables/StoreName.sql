CREATE TABLE [dbo].[StoreName] (
    [store_id]   INT           IDENTITY (1, 1) NOT NULL,
    [store_no]   INT           NULL,
    [store_name] VARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([store_id] ASC)
);

