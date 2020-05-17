CREATE TABLE [dbo].[SalesProduct] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [SKU]         VARCHAR (150)   NULL,
    [ProductName] VARCHAR (100)   NULL,
    [Price]       DECIMAL (18, 2) CONSTRAINT [DF_SalesProduct_Price] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_SalesProduct] PRIMARY KEY CLUSTERED ([Id] ASC)
);

