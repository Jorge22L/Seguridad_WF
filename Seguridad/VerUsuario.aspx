<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="VerUsuario.aspx.cs" Inherits="Seguridad.VerUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="txtIdUsuarioEdit" Visible="false" runat="server" />
    <asp:Label runat="server">Nombre: </asp:Label>
    <asp:TextBox ID="txtNombre" runat="server" />
    <br />
    <asp:Label runat="server">Apellido</asp:Label>
    <asp:TextBox ID="txtApellido" runat="server" />
    <br />
    <asp:Label runat="server">Nombre Usuario</asp:Label>
    <asp:TextBox ID="txtNombreUsuario" runat="server" />
    <br />
    <asp:Label runat="server">Clave</asp:Label>
    <asp:TextBox ID="txtClave" runat="server" />
    <br />
    <asp:Label runat="server">Fecha de Creación</asp:Label>
    <asp:TextBox ID="txtFechaCreacion" runat="server" />
    
    <br />
</asp:Content>