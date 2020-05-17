CREATE TABLE [dbo].[Orders] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [SKU]           VARCHAR (150)   NULL,
    [ProductName]   VARCHAR (100)   NULL,
    [Price]         DECIMAL (18, 2) NULL,
    [Quantity]      INT             CONSTRAINT [DF_Orders_Quantity] DEFAULT ((1)) NOT NULL,
    [Total]         DECIMAL (18, 2) CONSTRAINT [DF_Orders_Total] DEFAULT ((0)) NULL,
    [DatePurchased] NVARCHAR (250)  CONSTRAINT [DF_Orders_Date] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([Id] ASC)
);

