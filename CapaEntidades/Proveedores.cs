using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Proveedores
    {
        private int idProveedor;
        private string razonSocial;
        private string rfc;
        private long telefono;
        private string correo;

        public Proveedores(int idProveedor, string razonSocial, string rfc, long telefono, string correo)
        {
            this.IdProveedor = idProveedor;
            this.RazonSocial = razonSocial;
            this.RFC = rfc;
            this.Telefono = telefono;
            this.Correo = correo;
        }

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string RFC { get => rfc; set => rfc = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }

    }
}
