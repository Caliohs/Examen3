using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IProductoService
    {
        Task<DBEntity> Create(ProductoEntity entity);
        Task<DBEntity> Delete(ProductoEntity entity);
        Task<IEnumerable<ProductoEntity>> Get();
        Task<ProductoEntity> GetById(ProductoEntity entity);
        Task<IEnumerable<ProductoEntity>> GetLista();
        Task<DBEntity> Update(ProductoEntity entity);
    }

    public class ProductoService : IProductoService
    {
        private readonly IDataAccess sql;

        public ProductoService(IDataAccess _sql)
        {
            sql = _sql;
        }


        public async Task<IEnumerable<ProductoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<ProductoEntity>("ProductoObtener");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }



        }

        public async Task<IEnumerable<ProductoEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<ProductoEntity>("ProductoLista");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }



        }


        public async Task<ProductoEntity> GetById(ProductoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ProductoEntity>("ProductoObtener", new
                {

                    entity.ProductoId

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }



        }


        public async Task<DBEntity> Create(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ProductoInsertar", new
                {

                    entity.Descripcion,
                    entity.Estado

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }



        }

        public async Task<DBEntity> Update(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ProductoActualizar", new
                {
                    entity.ProductoId,
                    entity.Descripcion,
                    entity.Estado

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }



        }

        public async Task<DBEntity> Delete(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ProductoEliminar", new
                {
                    entity.ProductoId,


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }



        }

    }
}
