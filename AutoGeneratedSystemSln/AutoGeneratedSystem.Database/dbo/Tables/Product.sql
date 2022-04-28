CREATE TABLE [dbo].[Product]
(
	[ProductId] BIGINT NOT NULL CONSTRAINT PK_Product PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [ImageUrl] NVARCHAR(500) NOT NULL, 
    [UnitPrice] MONEY NOT NULL
)

GO

CREATE UNIQUE INDEX [UI_Product_Name] ON [dbo].[Product] ([Name])
