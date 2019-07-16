using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Clientes
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private string telefono;
        private string correo;
        private string rfc;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string RFC { get => rfc; set => rfc = value; }

        public Clientes(int idCliente, string nombre, string apellido, string telefono, string correo, string rfc)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.correo = correo;
            this.rfc = rfc;
        }
    }
}
