using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Seguridad
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // El tipo devuelto puede ser modificado a IEnumerable, sin embargo, para ser compatible con
        //paginación y ordenación // , se deben agregar los siguientes parametros:
                                //     int maximumRows
                                //     int startRowIndex
                                //     out int totalRowCount
                                //     string sortByExpression
        public IQueryable<usuario> gvUsuarios_GetData()
        {
            Dt_Usuario dtu = new Dt_Usuario();
            return dtu.getUsuario();
        }
    }
}