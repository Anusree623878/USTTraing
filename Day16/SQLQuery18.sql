USE [Empdb]
GO

DECLARE	@return_value int,
		@addres varchar(255)

EXEC	@return_value = [dbo].[Perssonadress]
		@person_id = 101,
		@addres = @addres OUTPUT

SELECT	@addres as N'@addres'

SELECT	'Return Value' = @return_value

GO
