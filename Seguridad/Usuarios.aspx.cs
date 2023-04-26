using Datos;
using Entidades;
using Negocio;
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
        NG_Usuario ngu = new NG_Usuario();

        private void listarUsuarios()
        {
            gvUsuario.AutoGenerateColumns = true;
            gvUsuario.DataSource = ngu.ListaUsuarios();
            gvUsuario.DataBind();
            
        }
        
        private void GuardarUsuario()
        {
            DateTime fecha_creacion = DateTime.Today;
            usuario modelo = new usuario()
            {
                nombre = usuario_nombre.Text,
                apellido = usuario_apellido.Text,
                nombreusuario = usuario_name.Text,
                fechaCreacion = fecha_creacion,
                pwd = usuario_clave.Text,
                estado = 1
            };
            ngu.GuardarUsuario(modelo);
            listarUsuarios();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            listarUsuarios();
        }

        protected void guardarUsuario_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
        }

        // El tipo devuelto puede ser modificado a IEnumerable, sin embargo, para ser compatible con
        //paginación y ordenación // , se deben agregar los siguientes parametros:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        //public IQueryable<usuario> gvUsuarios_GetData()
        //{
        //    Dt_Usuario dtu = new Dt_Usuario();
        //    return dtu.getUsuario();
        //}
    }
}