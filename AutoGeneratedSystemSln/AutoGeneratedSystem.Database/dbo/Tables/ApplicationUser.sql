CREATE TABLE [dbo].[ApplicationUser] (
    [ApplicationUserId] BIGINT             NOT NULL IDENTITY,
    [Name]              NVARCHAR (50)      NOT NULL,
    [Lastname]          NVARCHAR (50)      NOT NULL,
    [Email]             NVARCHAR (50)      NOT NULL,
    [BirthDate]         DATETIMEOFFSET (7) NOT NULL,
    CONSTRAINT [PK_ApplicationUser] PRIMARY KEY CLUSTERED ([ApplicationUserId] ASC)
);

