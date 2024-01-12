/****** Object:  View [Inventory].[HealthTrackConsumption]    Script Date: 18/10/2017 3:48:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [Inventory].[HealthTrackConsumption]
AS
SELECT        u.invUsed_ID AS UsedId, m.Inv_ID AS ProductId, m.Inv_SPC AS SPC, m.Inv_LPC AS LPC, m.Inv_UPN AS ScanCode, m.Inv_Description AS Name,u.LOTNO as LotNumber, u.invUsed_SerialNo AS SerialNumber, 
			  u.invUsed_Qty AS Quantity, ex.RebateCode, u.invUsed_Location AS Location,l.name as LocationName, ISNULL(
                             (SELECT        TOP (1) pm.RemotePatient_ID
                               FROM            dbo.HL7_PatientMapping AS pm INNER JOIN
                                                         dbo.Location AS loc ON u.invUsed_Location = loc.location_ID
                               WHERE        (pm.LocalPatient_ID = u.patient_ID) AND (pm.Feed_ID =
                                                             (SELECT        TOP (1) DEPT_FeedID
                                                               FROM            dbo.Department
                                                               WHERE        (DEPT_ID = loc.Department)))), {fn CONCAT('HT',CONVERT(varchar(50), u.patient_ID))}) AS PatientMRN , u.container_ID AS ContainerId, u.patient_ID AS PatientId, m.Inv_Group AS ClinicalGroup, m.Inv_SubGroup AS ClinicalSubGroup, 
                         m.Manufacturer, m.Inv_GL AS GL, m.Description_Additional AS Description, m.Inv_BuyPrice AS Price, m.Inv_BuyCurrency AS BuyCurrency, 
                         m.Inv_BuyCurrencyRate AS BuyCurrencyRate, u.deleted, u.deletionDate, u.deletionUser, cnm.LastModifiedBy, cnm.LastModifiedOn, u.dateCreated, u.userCreated, cnm.ProcessingStatus, cnm.ProcessingStatusMessage
						 ,cnm.Reported,cnm.ReportedBy,cnm.ReportedOn, mrc.testDate as ConsumedOn, epm.InventoryProductId, cpc.ItemValue AS PaymentClass, cnm.ArchivedBy, cnm.ArchivedOn, mrc.testDate
FROM            dbo.Inventory_Used AS u 
INNER JOIN dbo.Inventory_Master AS m ON u.invItem_ID = m.Inv_ID
left outer join dbo.Location l on l.location_ID = invUsed_Location
left outer join [Inventory].[ConsumptionNotificationManagement] cnm on u.invUsed_ID = cnm.invUsed_ID
left outer join [Inventory].[ExternalProductMapping] epm on m.Inv_ID = epm.ExternalProductId AND DeletedOn IS NULL
left outer join (select map.ExternalProductId, RebateCode
	from inventory.ExternalProductMapping map
	join inventory.product p on map.InventoryProductId = p.ProductId
	where p.rebateCode is not null and map.DeletedOn IS not NULL) ex on ex.ExternalProductId = invItem_ID
left outer join dbo.MR_Container mrc on u.container_ID = mrc.container_ID
left outer join [Inventory].[ContainerPaymentClass] cpc on mrc.container_ID = cpc.container_ID
GO


