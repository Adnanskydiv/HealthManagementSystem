BEGIN TRANSACTION

ALTER TABLE Inventory.ProductImportData
ALTER COLUMN [Name] [varchar](300) NULL

COMMIT