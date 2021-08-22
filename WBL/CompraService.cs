using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ICompraService
    {
        Task<DBEntity> Create(CompraEntity entity);
        Task<DBEntity> Delete(CompraEntity entity);
        Task<IEnumerable<CompraEntity>> Get();
        Task<CompraEntity> GetById(CompraEntity entity);
        Task<DBEntity> Update(CompraEntity entity);
    }

    public class CompraService : ICompraService
    {
        private readonly IDataAccess sql;

        public CompraService(IDataAccess _sql)
        {
            sql = _sql;
        }


        public async Task<IEnumerable<CompraEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<CompraEntity, ClientesEntity, ProductoEntity>(sp: "CompraObtener", split: "ClientesId,ProductoId");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }



        public async Task<CompraEntity> GetById(CompraEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<CompraEntity>("CompraObtener", new
                {
                    entity.IdCompra
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public async Task<DBEntity> Create(CompraEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("CompraInsertar", new
                {
                    entity.ClientesId,
                    entity.ProductoId,
                    entity.FechaCompra,
                    entity.Monto,
                    entity.Impuesto,
                    Total = (entity.Monto * (entity.Impuesto / 100)) + entity.Monto,
                    entity.Observaciones,
                    entity.Estado,

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<DBEntity> Update(CompraEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("CompraActualizar", new
                {
                    entity.IdCompra,
                    entity.ClientesId,
                    entity.ProductoId,
                    entity.FechaCompra,
                    entity.Monto,
                    entity.Impuesto,
                    Total = (entity.Monto * (entity.Impuesto / 100)) + entity.Monto,
                    entity.Observaciones,
                    entity.Estado,

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<DBEntity> Delete(CompraEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("CompraEliminar", new
                {
                    entity.IdCompra,
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
