CREATE TABLE [dbo].[Rating] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [BookingId]   UNIQUEIDENTIFIER NOT NULL,
    [GivenBy]     NVARCHAR (50)    NOT NULL,
    [RatingValue] INT              NULL
);

