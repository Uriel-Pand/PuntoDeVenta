using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetallesVentas
    {
        private int idDetallesVentas;
        private float stock;
        private float precio;
        private string fecha;

        public DetallesVentas(){ }

        public DetallesVentas(int idDetallesVentas, float stock, float precio, string fecha)
        {
            this.IdDetallesVentas = idDetallesVentas;
            this.Stock = stock;
            this.Precio = precio;
            this.Fecha = fecha;
        }

        public int IdDetallesVentas { get => idDetallesVentas; set => idDetallesVentas = value; }
        public float Stock { get => stock; set => stock = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Fecha { get => fecha; set => fecha = value; }

    }
}
