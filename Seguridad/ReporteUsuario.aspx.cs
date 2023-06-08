using Entidades;
using Microsoft.Reporting.WebForms;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Seguridad
{
    public partial class ReporteUsuario : System.Web.UI.Page
    {
        NG_Usuario ngu = new NG_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarRptListUsuario();
            }
        }

        protected void cargarRptListUsuario()
        {
            List<usuario> listaUsuario = new List<usuario>();
            listaUsuario = ngu.ListaUsuarios();
            ReportDataSource datasource = new ReportDataSource("DataSet1", listaUsuario);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
            ReportViewer1.LocalReport.Refresh();
            //ReportViewer1.Reset();
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Seguridad.rptUsuario.rdlc";
        }
    }
}