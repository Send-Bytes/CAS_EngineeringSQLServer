CREATE TABLE [dbo].[Project] (
    [Project_ID]      INT   IDENTITY (1, 1) NOT NULL,
    [Client_ID]       INT   NOT NULL,
    [P_Description]   TEXT  NULL,
    [P_StartDate]     DATE  NULL,
    [P_EndDate]       DATE  NULL,
    [P_EstimatedCost] MONEY NULL,
    [P_Location]      TEXT  NULL,
    [P_Status]        TEXT  NULL,
    PRIMARY KEY CLUSTERED ([Project_ID] ASC),
    CONSTRAINT [FK_Project_Client] FOREIGN KEY ([Client_ID]) REFERENCES [dbo].[Client] ([Client_ID])
);

