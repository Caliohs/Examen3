CREATE PROCEDURE [dbo].CompraObtener
@IdCompra INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			CO.IdCompra
		,   CO.FechaCompra
		,   CO.Monto
		,   CO.Impuesto
		,   CO.Total
		,   CO.Observaciones
		,   CO.Estado

		,   CO.ClientesId
		,	C.NombreCompleto

		,   CO.ProductoId
		,	P.Descripcion
				

	FROM dbo.Compra CO
	 INNER JOIN dbo.Clientes C
         ON C.ClientesId = CO.ClientesId
     INNER JOIN dbo.Producto P
         ON CO.ProductoId = P.ProductoId
	 
	WHERE
	     (@IdCompra IS NULL OR CO.IdCompra=@IdCompra)

END