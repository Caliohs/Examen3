CREATE PROCEDURE [dbo].[ProductoObtener]
	@ProductoId INT=NULL
AS
BEGIN
  SET NOCOUNT ON

SELECT 
      ProductoId
	, Descripcion
	, Estado
FROM Producto
WHERE (@ProductoId IS NULL OR ProductoId=@ProductoId)

END

