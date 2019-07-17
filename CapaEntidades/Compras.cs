using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Compras
    {
        private int idCompra;
        private int idProducto;
        private int idUsurio;
        private int idCliente;
        private int idDetallesVenta;
        private int numeroDeCompra;

        public Compras(int idCompra, int idProducto, int idUsurio, int idCliente, int idDetallesVenta, int numeroDeCompra)
        {
            this.IdCompra = idCompra;
            this.IdProducto = idProducto;
            this.IdUsurio = idUsurio;
            this.IdCliente = idCliente;
            this.IdDetallesVenta = idDetallesVenta;
            this.NumeroDeCompra = numeroDeCompra;
        }

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdUsurio { get => idUsurio; set => idUsurio = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdDetallesVenta { get => idDetallesVenta; set => idDetallesVenta = value; }
        public int NumeroDeCompra { get => numeroDeCompra; set => numeroDeCompra = value; }

    }
}
