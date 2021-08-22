
namespace App.AxiosProvider   {

    //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );

   
    export const ClientesEliminar = (id) => ServiceApi.delete<DBEntity>("api/Clientes/" + id).then(({ data }) => data);

    export const ClientesGuardar = (entity) => ServiceApi.post<DBEntity>("api/Clientes", entity).then(({ data }) => data);

    export const ClientesActualizar = (entity) => ServiceApi.put<DBEntity>("api/Clientes", entity).then(({ data }) => data);


    export const ProductoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Producto/" + id).then(({ data }) => data);

    export const ProductoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Producto", entity).then(({ data }) => data);

    export const ProductoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Producto", entity).then(({ data }) => data);


    export const UsuarioRegistrar = (entity) => ServiceApi.post<DBEntity>("api/Usuarios/Registrar", entity).then(({ data }) => data);

    export const UsuarioLogin = (entity) => axios.post<DBEntity>("Login", entity).then(({ data }) => data);


    export const CompraEliminar = (id) => ServiceApi.delete<DBEntity>("api/Compra/" + id).then(({ data }) => data);

    export const CompraGuardar = (entity) => ServiceApi.post<DBEntity>("api/Compra", entity).then(({ data }) => data);

    export const CompraActualizar = (entity) => ServiceApi.put<DBEntity>("api/Compra", entity).then(({ data }) => data);


}




