CREATE TABLE [dbo].[ApplicationUserApplicationRole]
(
	[ApplicationUserApplicationRoleId] BIGINT NOT NULL CONSTRAINT PK_ApplicationUserApplicationRole PRIMARY KEY IDENTITY, 
    [ApplicationUserId] BIGINT NOT NULL, 
    [ApplicationRoleId] SMALLINT NOT NULL, 
    CONSTRAINT [FK_ApplicationUserApplicationRole_ApplicationUser] FOREIGN KEY ([ApplicationUserId]) REFERENCES [ApplicationUser]([ApplicationUserId]), 
    CONSTRAINT [FK_ApplicationUserApplicationRole_ApplicationRole] FOREIGN KEY ([ApplicationRoleId]) REFERENCES [ApplicationRole]([ApplicationRoleId])
)
