/****** Object:  View [Inventory].[ConsumptionPricing]    Script Date: 10/10/2017 11:34:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [Inventory].[ConsumptionPricing]
AS
SELECT        u.invUsed_ID AS UsedId, 
				u.invItem_ID AS HealthTrackProductId, 
				u.container_ID AS ContainerId, 
				u.patient_ID AS PatientId,
				epm.InventoryProductId, 
				cpc.ItemValue AS PaymentClass,
				pp.BuyPrice,
				pp.SellPrice,
				p.RebateCode
FROM            dbo.Inventory_Used AS u
join [Inventory].[ExternalProductMapping] epm on u.invItem_ID = epm.ExternalProductId AND DeletedOn IS NULL
join [Inventory].[Product] p on epm.InventoryProductId = p.ProductId
join [Inventory].[ContainerPaymentClass] cpc on u.container_ID = cpc.container_ID
join [Inventory].[PaymentClassMapping] pcm on pcm.PaymentClass = cpc.ItemValue
join inventory.ProductPrice pp on epm.InventoryProductId = pp.ProductId
	and pp.PriceTypeId = pcm.PriceTypeId
WHERE epm.DeletedOn IS NULL
GO

