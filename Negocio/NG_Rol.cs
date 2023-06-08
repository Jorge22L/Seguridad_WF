using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    

    public class NG_Rol
    {
        DT_Rol dtr = new DT_Rol();
        public List<rol> ListarRolNegocio()
        {
            List<rol> listaRol = new List<rol>();
            try
            {
                listaRol = dtr.ListarRol();
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar rol " + e.Message);
            }

            return listaRol;
        }
    }
}
