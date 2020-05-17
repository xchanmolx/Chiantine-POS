CREATE TABLE [dbo].[TotalSales] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [TotalSales]    VARCHAR (250)  NULL,
    [DatePurchased] NVARCHAR (250) NULL,
    CONSTRAINT [PK_TotalSales] PRIMARY KEY CLUSTERED ([Id] ASC)
);

