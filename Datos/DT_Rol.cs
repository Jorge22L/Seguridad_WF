using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DT_Rol
    {
        SeguridadEntities modelo = new SeguridadEntities();
        public List<rol> ListarRol()
        {
            return modelo.rol.ToList();
        }
    }
}
