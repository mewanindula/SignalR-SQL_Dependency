SELECT name, is_broker_enabled FROM sys.databases

ALTER DATABASE Customer
SET ENABLE_broker WITH ROLLBACK IMMEDIATE