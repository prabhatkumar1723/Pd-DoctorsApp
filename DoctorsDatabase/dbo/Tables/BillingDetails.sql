CREATE TABLE [dbo].[BillingDetails] (
    [Id]                   UNIQUEIDENTIFIER NOT NULL,
    [TreatmentId]          UNIQUEIDENTIFIER NOT NULL,
    [TreatmentDescription] NVARCHAR (150)   NULL,
    [PatientName]          NVARCHAR (50)    NULL,
    [PatientAddress]       NVARCHAR (250)   NOT NULL,
    [PhoneNumber]          VARCHAR (10)     NOT NULL,
    [Charges]              INT              NOT NULL,
    [Total]                INT              NOT NULL,
    [StatusId]             INT              NULL,
    [CreatedDate]          DATETIME         NOT NULL
);

