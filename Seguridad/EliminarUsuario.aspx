<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarUsuario.aspx.cs" Inherits="Seguridad.EliminarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h4>¿Desea eliminar el usuario?</h4>
    </div>
    <br />
   
    <asp:TextBox ID="txtIdUsuarioEliminar" Visible="false" runat="server" Enabled="false" />
    <asp:Label runat="server">Nombre: </asp:Label>
    <asp:TextBox ID="txtNombreEliminar" Enabled="false" runat="server" />
    <br />
    <asp:Label runat="server">Apellido</asp:Label>
    <asp:TextBox ID="txtApellidoEliminar" Enabled="false" runat="server" />
    <br />
    <asp:Label runat="server">Nombre Usuario</asp:Label>
    <asp:TextBox ID="txtNombreUsuarioEliminar" Enabled="false" runat="server" />
    <br />
    
    <asp:Label runat="server">Clave</asp:Label>
    <asp:TextBox ID="txtClaveEliminar" runat="server" Enabled="false" TextMode="Password" />
    <br />
    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar Usuario"></asp:Button>
    
    <br />
    
</asp:Content>