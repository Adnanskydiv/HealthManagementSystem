﻿
/****** Object:  View [Inventory].[ClinicalConsumption]    Script Date: 17/03/2015 3:08:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER view [Inventory].[ClinicalConsumption] AS
 
SELECT        Inventory.Consumption.ConsumptionId, mrn.RemotePatient_ID, dbo.MR_Container.container_ID, Inventory.Stock.SerialNumber, Inventory.Product.Description, Inventory.Product.ProductId, Inventory.Product.SPC, 
                         Inventory.Product.Manufacturer, dbo.MR_Container.patient_ID, dbo.MR_Container.testDate, dbo.Patient.firstName, dbo.Patient.surname, dbo.Patient.patientType, dbo.Patient.healthFundID, 
                         dbo.Staff_Used.StaffName, dbo.Staff_Used.AdditionalInfo
FROM            dbo.Patient INNER JOIN
                         dbo.MR_Container ON dbo.Patient.patient_ID = dbo.MR_Container.patient_ID INNER JOIN
                         Inventory.Consumption ON dbo.MR_Container.container_ID = Inventory.Consumption.ClinicalRecordId INNER JOIN
                         Inventory.Stock ON Inventory.Consumption.StockId = Inventory.Stock.StockId AND Inventory.Consumption.StockId = Inventory.Stock.StockId INNER JOIN
                         Inventory.Product ON Inventory.Stock.ProductId = Inventory.Product.ProductId AND Inventory.Stock.ProductId = Inventory.Product.ProductId INNER JOIN
                         dbo.Staff_Used ON dbo.MR_Container.container_ID = dbo.Staff_Used.Container_ID AND Staff_Used.AdditionalInfo = 'R'
                   left outer JOIN [inventory].PatientContainerMRN mrn on MR_Container.Container_ID = mrn.container_id
GO



