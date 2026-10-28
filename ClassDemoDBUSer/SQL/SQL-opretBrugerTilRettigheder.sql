CREATE LOGIN Peter
WITH PASSWORD = '123!#aswdASWD';
GO


-- Creates a database user for the login created previously.
CREATE USER pele
FOR LOGIN Peter;
GO

Grant ALL PRIVILEGE on dbo.Hotel to pele
Grant select on dbo.Customer to pele

revoke select on dbo.Customer from pele