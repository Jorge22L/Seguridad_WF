<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Seguridad.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <%--<asp:GridView runat="server" ID="gvUsuarios" ItemType="Entidades.usuario" DataKeyNames="idusuario" 
        SelectMethod="gvUsuarios_GetData" AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="idusuario" />
            <asp:DynamicField DataField="nombre" />
            <asp:DynamicField DataField="apellido"/>
            <asp:DynamicField DataField="nombreusuario" />
            <asp:DynamicField DataField="fechaCreacion" />
        </Columns>
    </asp:GridView>--%>
    <br />
    <asp:TextBox ID="txtId_usuario" Visible="false" runat="server" />
    <asp:Label runat="server">Nombre: </asp:Label>
    <asp:TextBox ID="txtNombre" runat="server" />
    <br />
    <asp:Label runat="server">Apellido</asp:Label>
    <asp:TextBox ID="usuario_apellido" runat="server" />
    <br />
    <asp:Label runat="server">Nombre Usuario</asp:Label>
    <asp:TextBox ID="usuario_name" runat="server" />
    <br />
    
    <asp:Label runat="server">Clave</asp:Label>
    <asp:TextBox ID="usuario_clave" runat="server" TextMode="Password" />
    <br />
    <asp:Button ID="guardarUsuario" runat="server" OnClick="guardarUsuario_Click" Text="Guardar Usuario"></asp:Button>
    <asp:Button ID="editarUsuarioButton" runat="server" OnClick="editarUsuarioButton_Click" Text="Editar Usuario"></asp:Button>
    <br />
    <br />
    <asp:GridView ID="gvUsuario" runat="server" OnRowDataBound="gvUsuario_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="Acciones">
                <ItemTemplate>
                    <asp:Button runat="server" Text="Editar" ID="btnEditarUsuario" OnClick="btnEditarUsuario_Click" />
                    <asp:Button runat="server" Text="Eliminar" ID="btnEliminarUsuario" OnClick="btnEliminarUsuario_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
</asp:Content>
