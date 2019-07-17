using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Ventas
    {
        private int idVenta;
        private int idProducto;
        private int idUsurio;
        private int idCliente;
        private int idDetallesVenta;
        private int numeroDeVenta;

        public Ventas(int idVenta, int idProducto, int idUsurio, int idCliente, int idDetallesVenta, int numeroDeVenta)
        {
            this.IdVenta = idVenta;
            this.IdProducto = idProducto;
            this.IdUsurio = idUsurio;
            this.IdCliente = idCliente;
            this.IdDetallesVenta = idDetallesVenta;
            this.NumeroVenta = numeroDeVenta;
        }

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdUsurio { get => idUsurio; set => idUsurio = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdDetallesVenta { get => idDetallesVenta; set => idDetallesVenta = value; }
        public int NumeroVenta { get => numeroDeVenta; set => numeroDeVenta = value; }

    }
}
