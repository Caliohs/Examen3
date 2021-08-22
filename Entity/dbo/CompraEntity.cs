using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CompraEntity:EN
    {
        public CompraEntity()
        {
            Cliente = Cliente ?? new ClientesEntity();
            Producto = Producto ?? new ProductoEntity();
           
        }
        public int? IdCompra { get; set; }
        public DateTime FechaCompra { get; set; } = DateTime.Now;
       
        public decimal Monto { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public string Observaciones { get; set; }


        public int? ClientesId { get; set; }
        public virtual ClientesEntity Cliente { get; set; }

        public int? ProductoId { get; set; }
        public virtual ProductoEntity Producto { get; set; }

    }
}
