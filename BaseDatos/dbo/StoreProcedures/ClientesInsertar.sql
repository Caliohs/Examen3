CREATE PROCEDURE [dbo].ClientesInsertar
		@NombreCompleto VARCHAR(500),
	@Direccion varchar(250),
	@Telefono varchar(250),
    @Estado BIT
	
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY

		
		INSERT INTO dbo.Clientes 
		(	       
	      NombreCompleto,
		  Direccion,
		  Telefono,
		  Estado
		)
		VALUES
		(
		
	      @NombreCompleto,
		  @Direccion,
		  @Telefono,
		  @Estado
		)


		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH


END