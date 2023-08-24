CREATE TABLE [dbo].[Project_Employee] (
    [Project_ID]    INT  NOT NULL,
    [Employee_ID]   INT  NULL,
    [Employee_Role] TEXT NULL,
    CONSTRAINT [FK_Project_Employee_Employee] FOREIGN KEY ([Employee_ID]) REFERENCES [dbo].[Employee] ([Employee_ID]),
    CONSTRAINT [FK_Project_Employee_Project] FOREIGN KEY ([Project_ID]) REFERENCES [dbo].[Project] ([Project_ID])
);

