CREATE TABLE [dbo].[ApplicationRole]
(
	[ApplicationRoleId] SMALLINT NOT NULL CONSTRAINT PK_ApplicationRole PRIMARY KEY IDENTITY, 
    [RoleName] NVARCHAR(50) NOT NULL, 
    [RoleDescription] NVARCHAR(50) NOT NULL 
)
