CREATE TABLE [dbo].[Booking] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [TreatmentId] UNIQUEIDENTIFIER NOT NULL,
    [PatientId]   UNIQUEIDENTIFIER NOT NULL,
    [Subject]     NVARCHAR (200)   NOT NULL,
    [Description] NVARCHAR (500)   NULL,
    [BookingSlot] DATETIME         NOT NULL,
    [CreatedDate] DATETIME         NULL,
    [DoctorId]    UNIQUEIDENTIFIER NULL,
    [BookingDate] DATETIME         NULL,
    [StatusId]    INT              NULL,
    [HospitalId]  UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Booking_Treatment] FOREIGN KEY ([TreatmentId]) REFERENCES [dbo].[Treatment] ([Id]),
    CONSTRAINT [FK_BookingPatientId_PatientDetailsId] FOREIGN KEY ([PatientId]) REFERENCES [dbo].[PatientDetails] ([Id])
);

