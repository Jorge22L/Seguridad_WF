using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Seguridad
{
    public partial class Login : System.Web.UI.Page
    {
        NG_Rol ngr = new NG_Rol();
        NG_Usuario ngu = new NG_Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarCombo();
            }
        }

        protected void llenarCombo()
        {
            this.ddlRol.DataSource = ngr.ListarRolNegocio();
            this.ddlRol.DataTextField = "descripcion";
            this.ddlRol.DataValueField = "idrol";
            this.ddlRol.DataBind();
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = "";
            string pwd = "";
            int rol = 0;
            bool entrar = false;

            user = this.txtUsuario.Text.Trim();
            pwd = this.txtClave.Text.Trim();
            rol = Convert.ToInt32(this.ddlRol.SelectedValue);

            entrar = ngu.ValidarCredencialesNeg(user, pwd, rol);
            if (entrar)
            {
                Response.Redirect("~/Usuarios.aspx");
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}