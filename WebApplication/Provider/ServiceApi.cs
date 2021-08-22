using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication
{
    public class ServiceApi
    {
        private readonly HttpClient client;

        public ServiceApi(HttpClient client )
        {
            this.client = client;
        }

        #region Clientes
        public async Task<IEnumerable<ClientesEntity>> ClientesGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ClientesEntity>>("api/Clientes");

            return result;
        
        }
        public async Task<IEnumerable<ClientesEntity>> ClientesGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ClientesEntity>>("api/Clientes/Lista");

            return result;

        }

        public async Task<ClientesEntity> ClientesGetById(int id)
        {
            var result = await client.ServicioGetAsync<ClientesEntity>("api/Clientes/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }

        
        #endregion

        #region Usuarios
        public async Task<UsuariosEntity> UsuarioLogin(UsuariosEntity entity)
        {
            var result = await client.ServicioPostAsync<UsuariosEntity>("api/Usuarios/Login", entity);

            return result;

        }

        #endregion


        #region Compra
        public async Task<IEnumerable<CompraEntity>> CompraGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<CompraEntity>>("api/Compra");

            return result;

        }

        public async Task<CompraEntity> CompraGetById(int id)
        {
            var result = await client.ServicioGetAsync<CompraEntity>("api/Compra/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }

        #endregion

        #region Producto
        public async Task<IEnumerable<ProductoEntity>> ProductoGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ProductoEntity>>("api/Producto/Lista");

            return result;

        }
        public async Task<IEnumerable<ProductoEntity>> ProductoGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ProductoEntity>>("api/Producto");

            return result;

        }
        public async Task<ProductoEntity> ProductoGetById(int id)
        {
            var result = await client.ServicioGetAsync<ProductoEntity>("api/Producto/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }
        #endregion
    }
}
