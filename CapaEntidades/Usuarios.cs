using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuarios
    {
        private int idUsuario;
        private string usuario;
        private string contraseña;
        private bool existencia;
        private int idDetallesUsuario;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public bool Existencia { get => existencia; set => existencia = value; }
        public int IdDetallesUsuario { get => idDetallesUsuario; set => idDetallesUsuario = value; }

        public Usuarios(int idUsuario, string usuario, string contraseña, bool existencia, int idDetallesUsuario)
        {
            this.idUsuario = idUsuario;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.existencia = existencia;
            this.idDetallesUsuario = idDetallesUsuario;
        }

        public Usuarios() { }

    }
}
