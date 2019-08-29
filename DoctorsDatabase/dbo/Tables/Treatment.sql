CREATE TABLE [dbo].[Treatment] (
    [Id]                       UNIQUEIDENTIFIER NOT NULL,
    [TreatmentName]            NVARCHAR (50)    NOT NULL,
    [Description]              NVARCHAR (150)   NULL,
    [Price]                    INT              NOT NULL,
    [AvailabilityStatus]       BIT              NOT NULL,
    [TreatmentDurationInHours] INT              CONSTRAINT [DF_Treatment_TreatmentDurationInHours] DEFAULT ((1)) NULL,
    [DurationInHrs]            INT              NULL,
    CONSTRAINT [PK_Treatment] PRIMARY KEY CLUSTERED ([Id] ASC)
);

