CREATE TABLE [dbo].[Company]
(
	[CompanyId] BIGINT NOT NULL CONSTRAINT PK_Company PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Country] NVARCHAR(50) NOT NULL, 
    [NumberOfEmployees] INT NOT NULL 
)
