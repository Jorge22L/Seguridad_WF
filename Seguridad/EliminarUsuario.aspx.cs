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
    public partial class EliminarUsuario : System.Web.UI.Page
    {
        NG_Usuario ngu = new NG_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoadComplete(EventArgs e)
        {
            RecuperarDatos();
            base.OnLoadComplete(e);
        }


        protected void RecuperarDatos()
        {
            usuario data_usuario = (usuario)Session["DatosUsuarioEliminar"];

            this.txtIdUsuarioEliminar.Text = data_usuario.idusuario.ToString();
            this.txtNombreEliminar.Text = data_usuario.nombre.ToString();
            this.txtApellidoEliminar.Text = data_usuario.apellido.ToString();
            this.txtNombreEliminar.Text = data_usuario.nombreusuario.ToString();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            usuario usuario_delete = new usuario();
            usuario_delete.idusuario = Int32.Parse(this.txtIdUsuarioEliminar.Text);
            usuario_delete.estado = 3;

            ngu.NG_EliminarUsuario(usuario_delete);
            Response.Redirect("~/Usuarios.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Usuarios.aspx");
        }
    }
}