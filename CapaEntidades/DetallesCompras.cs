using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetallesCompras
    {
        private int idDetallesCompras;
        private float stock;
        private float precio;
        private string fecha;

        public DetallesCompras() { }

        public DetallesCompras(int idDetallesCompras, float stock, float precio, string fecha)
        {
            this.IdDetallesCompras = idDetallesCompras;
            this.Stock = stock;
            this.Precio = precio;
            this.Fecha = fecha;
        }

        public int IdDetallesCompras { get => idDetallesCompras; set => idDetallesCompras = value; }
        public float Stock { get => stock; set => stock = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
