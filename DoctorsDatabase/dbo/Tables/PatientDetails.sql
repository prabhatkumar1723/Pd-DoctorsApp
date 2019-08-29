CREATE TABLE [dbo].[PatientDetails] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [PName]       NVARCHAR (100)   NOT NULL,
    [PAddress]    NVARCHAR (150)   NOT NULL,
    [PhoneNumber] VARCHAR (10)     NOT NULL,
    [Email]       NVARCHAR (50)    NULL,
    [Gender]      NVARCHAR (20)    NULL,
    [Age]         INT              NULL,
    [Password]    NVARCHAR (50)    NULL,
    CONSTRAINT [PK_PatientDetails] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_PatientDetails_Age]
    ON [dbo].[PatientDetails]([Age] ASC);

