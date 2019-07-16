using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos.Contratos
{
    interface IContratoUsuario : IContraro<Usuarios>
    {
        Usuarios seleccionarNombreUsuario(String nombreUsuario);
        String seleccionarContrasena(String idUsuario);
        bool confirmarContrasena(String idUsuario, String contrasena);
        bool confirmarExistencia(String idUsuario, String contrasena);
        bool registrarUsuario(Usuarios usuario, DetallesUsuarios detallesUsuario);
        bool actualizarContrasena(String idUsuario, String nuevaContrasena);
        bool actualizarDatos(Usuarios usuario, DetallesUsuarios detallesUsuario);
    }
}
