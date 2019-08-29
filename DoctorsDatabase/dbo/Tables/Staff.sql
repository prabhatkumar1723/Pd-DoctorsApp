CREATE TABLE [dbo].[Staff] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Name]        NVARCHAR (100)   NOT NULL,
    [Address]     NVARCHAR (250)   NOT NULL,
    [PhoneNumber] VARCHAR (10)     NULL,
    [Email]       NVARCHAR (50)    NULL,
    [PositionId]  UNIQUEIDENTIFIER NOT NULL,
    [HospitalId]  UNIQUEIDENTIFIER NOT NULL
);

