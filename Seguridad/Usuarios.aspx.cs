using Datos;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                nombre = txtNombre.Text,
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

        protected void gvUsuario_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[5].Visible = false;
            e.Row.Cells[7].Visible = false;
            
        }

        protected void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            string id;
            string nombre, apellido, nombre_usuario, clave;
            Button btnConsultar = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)btnConsultar.NamingContainer;
            id = selectedRow.Cells[1].Text;
            nombre = selectedRow.Cells[2].Text;
            apellido = selectedRow.Cells[3].Text;
            nombre_usuario = selectedRow.Cells[4].Text;
            clave = selectedRow.Cells[5].Text;
            //Mandando datos a los campos
            this.txtId_usuario.Text = id;
            this.txtNombre.Text = nombre;
            this.usuario_apellido.Text = apellido;
            this.usuario_name.Text = nombre_usuario;
            this.usuario_clave.Text = clave;
        }

        protected void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

        }

        protected void editarUsuarioButton_Click(object sender, EventArgs e)
        {
            DateTime fecha_creacion = DateTime.Today;
            usuario modelo = new usuario()
            {
                idusuario = Int32.Parse(this.txtId_usuario.Text),
                nombre = this.txtNombre.Text,
                apellido = this.usuario_apellido.Text,
                nombreusuario = this.usuario_name.Text,
                pwd = this.usuario_clave.Text,
                fechaCreacion = fecha_creacion,
                estado = 2
            };
            ngu.NG_EditarUsuario(modelo);
            listarUsuarios();
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