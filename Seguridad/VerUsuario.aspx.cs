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
    public partial class VerUsuario : System.Web.UI.Page
    {
        NG_Usuario ngu = new NG_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoadComplete(EventArgs e)
        {
            usuario detalles = RecuperarUsuario();
            
            this.txtNombre.Text = detalles.nombre;
            this.txtApellido.Text = detalles.apellido;
            this.txtNombreUsuario.Text = detalles.nombreusuario;
            this.txtFechaCreacion.Text = detalles.fechaCreacion.ToString();
            this.txtClave.Text = "";
            base.OnLoadComplete(e);
        }

        protected usuario RecuperarUsuario()
        {
            var id_usuario = Session["idUsuario"];
            try
            {
                usuario usuario_detalle = ngu.NG_VerUsuario(Convert.ToInt32(id_usuario));
                return usuario_detalle;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}