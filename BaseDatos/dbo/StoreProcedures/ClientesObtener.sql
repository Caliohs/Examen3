CREATE PROCEDURE [dbo].ClientesObtener
	@ClientesId INT= null
AS
	begin
	SET NOCOUNT ON


	 SELECT
	 ClientesId,
	 NombreCompleto,
	 Direccion,
	 Telefono,
	 Estado
	
	 FROM dbo.Clientes
	
	 WHERE

	 (@ClientesId IS NULL OR ClientesId=@ClientesId)



	end