CREATE TABLE [dbo].[Equipment] (
    [Equipment_ID]  INT   NOT NULL,
    [E_Description] TEXT  NULL,
    [E_UnitPrice]   MONEY NULL,
    [Manufacturer]  TEXT  NULL,
    [Quantity]      INT   NULL,
    PRIMARY KEY CLUSTERED ([Equipment_ID] ASC)
);

