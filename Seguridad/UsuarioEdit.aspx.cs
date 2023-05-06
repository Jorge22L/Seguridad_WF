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
    public partial class UsuarioEdit : System.Web.UI.Page
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
            usuario data_usuario = (usuario)Session["DatosUsuario"];

            this.txtIdUsuarioEdit.Text = data_usuario.idusuario.ToString();
            this.txtNombreEdit.Text = data_usuario.nombre.ToString();
            this.txtApellidoEdit.Text = data_usuario.apellido.ToString();
            this.txtNombreUsuarioEdit.Text = data_usuario.nombreusuario.ToString();
        }

        protected void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            DateTime fecha_creacion = DateTime.Today;
            usuario usuario_editar = new usuario();
            usuario_editar.idusuario = Int32.Parse(this.txtIdUsuarioEdit.Text);
            usuario_editar.nombre = this.txtNombreEdit.Text;
            usuario_editar.apellido = this.txtApellidoEdit.Text;
            usuario_editar.nombreusuario = this.txtNombreUsuarioEdit.Text;
            usuario_editar.pwd = this.txtClaveEdit.Text;
            usuario_editar.fechaCreacion = fecha_creacion;
            usuario_editar.estado = 2;
            try
            {
                ngu.NG_EditarUsuario(usuario_editar);
            }
            catch (Exception)
            {

                throw;
            }
            
            Response.Redirect("~/Usuarios.aspx");

        }
    }
}