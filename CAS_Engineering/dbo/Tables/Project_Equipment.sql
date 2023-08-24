CREATE TABLE [dbo].[Project_Equipment] (
    [Project_ID]        INT NOT NULL,
    [Equipment_ID]      INT NULL,
    [Quantity_Required] INT NULL,
    CONSTRAINT [FK_Project_Equipment_Equipment] FOREIGN KEY ([Equipment_ID]) REFERENCES [dbo].[Equipment] ([Equipment_ID]),
    CONSTRAINT [FK_Project_Equipment_Project] FOREIGN KEY ([Project_ID]) REFERENCES [dbo].[Project] ([Project_ID])
);

