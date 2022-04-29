CREATE TABLE [dbo].[ApplicationUserOrderDetail]
(
	[ApplicationUserOrderDetailId] BIGINT NOT NULL CONSTRAINT PK_ApplicationUserOrderDetail PRIMARY KEY IDENTITY, 
    [ApplicationUserOrderId] BIGINT NOT NULL, 
    [ProductId] BIGINT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [LineTotal] MONEY NOT NULL, 
    CONSTRAINT [FK_ApplicationUserOrderDetail_ApplicationUserOrder] FOREIGN KEY ([ApplicationUserOrderId]) REFERENCES [ApplicationUserOrder]([ApplicationUserOrderId]), 
    CONSTRAINT [FK_ApplicationUserOrderDetail_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([ProductId])
)

GO

CREATE UNIQUE INDEX [UI_ApplicationUserOrderDetail_Product] ON [dbo].[ApplicationUserOrderDetail] ([ApplicationUserOrderId], [ProductId])
