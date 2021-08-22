"use strict";
var App;
(function (App) {
    var AxiosProvider;
    (function (AxiosProvider) {
        //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );
        AxiosProvider.ClientesEliminar = function (id) { return ServiceApi.delete("api/Clientes/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClientesGuardar = function (entity) { return ServiceApi.post("api/Clientes", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClientesActualizar = function (entity) { return ServiceApi.put("api/Clientes", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoEliminar = function (id) { return ServiceApi.delete("api/Producto/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoGuardar = function (entity) { return ServiceApi.post("api/Producto", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoActualizar = function (entity) { return ServiceApi.put("api/Producto", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.UsuarioRegistrar = function (entity) { return ServiceApi.post("api/Usuarios/Registrar", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.UsuarioLogin = function (entity) { return axios.post("Login", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CompraEliminar = function (id) { return ServiceApi.delete("api/Compra/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CompraGuardar = function (entity) { return ServiceApi.post("api/Compra", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CompraActualizar = function (entity) { return ServiceApi.put("api/Compra", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
    })(AxiosProvider = App.AxiosProvider || (App.AxiosProvider = {}));
})(App || (App = {}));
//# sourceMappingURL=AxiosProvider.js.map