using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Collections;

namespace CapaDatos.Contratos
{
    interface IContraro <CapaEntidades> where CapaEntidades : class
    {
        bool Alta(CapaEntidades entidades);
        bool Baja(object id);
        bool Cambio(object id, CapaEntidades entidades);
        CapaEntidades SeleccionarId(Object id);
        List<CapaEntidades> SeleccionarTodo();
    }
}
