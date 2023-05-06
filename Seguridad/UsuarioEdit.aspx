<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuarioEdit.aspx.cs" Inherits="Seguridad.UsuarioEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
   
    <asp:TextBox ID="txtIdUsuarioEdit" Visible="false" runat="server" />
    <asp:Label runat="server">Nombre: </asp:Label>
    <asp:TextBox ID="txtNombreEdit" runat="server" />
    <br />
    <asp:Label runat="server">Apellido</asp:Label>
    <asp:TextBox ID="txtApellidoEdit" runat="server" />
    <br />
    <asp:Label runat="server">Nombre Usuario</asp:Label>
    <asp:TextBox ID="txtNombreUsuarioEdit" runat="server" />
    <br />
    
    <asp:Label runat="server">Clave</asp:Label>
    <asp:TextBox ID="txtClaveEdit" runat="server" TextMode="Password" />
    <br />
    <asp:Button ID="btnEditarUsuario" runat="server" OnClick="btnEditarUsuario_Click" Text="Modificar Usuario"></asp:Button>
    
    <br />
    
</asp:Content>
