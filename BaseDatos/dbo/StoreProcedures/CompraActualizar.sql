CREATE PROCEDURE dbo.CompraActualizar
    @IdCompra INT,
	@ClientesId INT,
	@ProductoId INT,
	@FechaCompra DATETIME ,
    @Monto DECIMAL(18,2),
	@Impuesto DECIMAL(18,2),
	@Total DECIMAL(18,2),
	@Observaciones VARCHAR(1000),
	@Estado BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	
	
		
	UPDATE dbo.Compra SET
	      ClientesId=@ClientesId,
		  ProductoId=@ProductoId,
		  FechaCompra=@FechaCompra,
		  Monto=@Monto,
		  Impuesto=@Impuesto,
		  Total=@Total,
		  Observaciones=@Observaciones,
		  Estado=@Estado

	WHERE IdCompra=@IdCompra

	SELECT 0 AS CodeError, '' AS MsgError

		

		COMMIT TRANSACTION TRASA



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH


END
