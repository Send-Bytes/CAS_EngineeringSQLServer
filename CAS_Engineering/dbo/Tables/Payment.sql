CREATE TABLE [dbo].[Payment] (
    [Payment_ID]      INT   IDENTITY (1, 1) NOT NULL,
    [Project_ID]      INT   NULL,
    [Amount_Received] MONEY NULL,
    [Date_Received]   DATE  NULL,
    [Balance]         MONEY NULL,
    PRIMARY KEY CLUSTERED ([Payment_ID] ASC),
    CONSTRAINT [FK_Payment_Project] FOREIGN KEY ([Project_ID]) REFERENCES [dbo].[Project] ([Project_ID])
);

