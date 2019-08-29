CREATE TABLE [dbo].[DoctorDetails] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [DName]            VARCHAR (50)     NOT NULL,
    [DAddress]         NVARCHAR (150)   NOT NULL,
    [PhoneNumber]      NVARCHAR (10)    NULL,
    [Email]            NVARCHAR (50)    NULL,
    [Gender]           NVARCHAR (20)    NULL,
    [Age]              INT              NULL,
    [YearOfExperience] INT              NULL,
    [Treatments]       NVARCHAR (100)   NULL,
    [BaseCharge]       INT              NULL,
    [Designation]      NVARCHAR (50)    NULL,
    [Qualifications]   NVARCHAR (100)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);





