CREATE TABLE [dbo].[ApplicationUserOrder]
(
	[ApplicationUserOrderId] BIGINT NOT NULL CONSTRAINT PK_ApplicationUserOrder PRIMARY KEY IDENTITY, 
    [ApplicationUserId] BIGINT NOT NULL, 
    [OrderTotal] MONEY NOT NULL, 
    [OrderDate] DATETIMEOFFSET NOT NULL DEFAULT GetUtcDate(), 
    CONSTRAINT [FK_ApplicationUserOrder_ApplicationUser] FOREIGN KEY ([ApplicationUserId]) REFERENCES [ApplicationUser]([ApplicationUserId])
)
