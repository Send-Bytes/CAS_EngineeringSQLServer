CREATE TABLE [dbo].[Employee] (
    [Employee_ID]       INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]         NVARCHAR (50) NULL,
    [LastName]          NVARCHAR (50) NULL,
    [Rank]              NVARCHAR (50) NULL,
    [Password]          NVARCHAR (50) NULL,
    [ID Number]         TEXT          NULL,
    [Email]             TEXT          NULL,
    [Date_Of_Birth]     DATE          NULL,
    [Emergency Contact] TEXT          NULL,
    [Next_Of_Kin]       NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Employee_ID] ASC)
);

