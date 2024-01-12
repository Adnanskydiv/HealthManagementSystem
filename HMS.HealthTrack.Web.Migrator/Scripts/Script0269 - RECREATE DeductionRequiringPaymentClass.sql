/****** Object:  View [Inventory].[DeductionRequiringPaymentClass]    Script Date: 27-May-16 4:32:45 PM ******/
DROP VIEW [Inventory].[DeductionRequiringPaymentClass]
GO

/****** Object:  View [Inventory].[DeductionRequiringPaymentClass]    Script Date: 27-May-16 4:32:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE view [Inventory].[DeductionRequiringPaymentClass] as
SELECT        sa.StockAdjustmentId, s.StockId, sa.AdjustedOn, sa.AdjustedBy, sa.DeletedOn, sa.Quantity, p.ProductId, p.SPC, p.Description, p.Manufacturer, p.PrimarySupplier, p.SecondarySupplier, 
                         p.IsConsignment, p.MinimumOrder, p.OrderMultiple, p.ReorderThreshold, p.TargetStockLevel, pat.patient_ID, pat.firstName, pat.surname, pat.dob, pat.mrn, pat.patientType, pat.homePhone, pat.workPhone, 
                         pat.mobile, pat.email, pat.pStatus, pat.medicare, pat.medicareRefNo, pat.MediExpYYYY, pat.MediExpMM, pat.medicareVerifyDate, pat.vetAffairs, pat.healthFundID, pat.fundNumber, pat.fundNumberUPI, 
                         pat.fundExpYYYY, pat.fundExpMM, pat.fundPlan, pat.feeTable_ID, pat.billingType, pat.HospitalBillingClass, pat.pensionNumber, pat.MRN_Feed, b.dateTimeStart, b.booking_ID, 
                         b.dateTimeStart AS BookingStartedOn, b.dateTimeEnd, b.duration, b.type, b.location_ID, b.room_ID, b.PaymentClass, b.PaymentClassUserUpdated, b.PaymentClassDateUpdated, sa.ClinicalRecordId, pat.title
FROM            Inventory.StockAdjustment AS sa INNER JOIN
                         dbo.MR_Container AS cr ON cr.container_ID = ClinicalRecordId INNER JOIN
                         dbo.Booking AS b ON cr.booking_ID = b.booking_ID INNER JOIN
                         dbo.Patient AS pat ON cr.patient_ID = pat.patient_ID INNER JOIN
                         Inventory.StockAdjustmentStock sas ON sa.StockAdjustmentId = sas.StockAdjustmentId INNER JOIN
						 Inventory.Stock AS s ON sas.StockId = s.StockId INNER JOIN
                         Inventory.Product AS p ON s.ProductId = p.ProductId
WHERE        sa.IsPositive = 0 AND (p.ProductId IN
                             (SELECT        ProductId
                               FROM            Inventory.ProductSetting AS ps
                               WHERE        (SettingId = 'RPC')))
GO


