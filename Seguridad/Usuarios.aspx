<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Seguridad.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="gvUsuarios" ItemType="Entidades.usuario" DataKeyNames="idusuario" 
        SelectMethod="gvUsuarios_GetData" AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="idusuario" />
            <asp:DynamicField DataField="nombre" />
            <asp:DynamicField DataField="apellido"/>
            <asp:DynamicField DataField="nombreusuario" />
            <asp:DynamicField DataField="fechaCreacion" />
        </Columns>
    </asp:GridView>
</asp:Content>
