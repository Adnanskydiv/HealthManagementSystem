UPDATE Inventory.Property
SET PropertyValue = 'False'
WHERE PropertyName = 'StockTakesEnabled' AND PropertyValue = '0'

UPDATE Inventory.Property
SET PropertyValue = 'True'
WHERE PropertyName = 'StockTakesEnabled' AND PropertyValue = '1'