using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NG_Usuario
    {
        Dt_Usuario dtu = new Dt_Usuario();
        public List<usuario> ListaUsuarios()
        {
            List<usuario> usuarios = dtu.listarUsuario();
            return usuarios;
        }

        public void GuardarUsuario(usuario modelo)
        {
            try
            {
                dtu.guardarUsuario(modelo);
            }
            catch (Exception e)
            {

                throw new Exception(message: "Error en NG_Usuario: " +e.StackTrace);
            }
        }
    }
}
