<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Seguridad.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
</head>
<body class="container">
    <section id="main-content">
        <section class="panel">
            <header class="panel-heading d-flex justify-content-center">
                <h3>Acceso de usuarios</h3>
            </header>
        </section>
    </section>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-3 mx-auto">
                <div class="text-center">
                    <div class="form-group">
                        <div class="col-md-4">
                            <asp:Label runat="server">Usuario:</asp:Label>
                        </div>
                        <div class="col-md-8">
                            <asp:TextBox runat="server" ID="txtUsuario" ValidationGroup="usuario" Enabled="true" CssClass="form-control" placeholder="Nombre usuario" title="Ingrese su usuario"></asp:TextBox>
                        </div>
                        <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="txtUsuario" 
                            ValidationGroup="usuario" Display="Static" 
                            ErrorMessage="Este campo es requerido!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                     <div class="form-group">
                        <div class="col-md-4">
                            <asp:Label runat="server">Contraseña:</asp:Label>
                        </div>
                        <div class="col-md-8">
                            <asp:TextBox runat="server" ID="txtClave" ValidationGroup="usuario" Enabled="true" 
                                CssClass="form-control" TextMode="Password" title="Ingrese su contraseña"></asp:TextBox>
                        </div>
                        <asp:RequiredFieldValidator ID="rfvClave" runat="server" ControlToValidate="txtClave" 
                            ValidationGroup="usuario" Display="Static" 
                            ErrorMessage="Este campo es requerido!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <div class="col-md-4">
                            <asp:Label runat="server">Rol:</asp:Label>
                        </div>
                        <div class="col-md-8">
                            <asp:DropDownList runat="server" ID="ddlRol" name="ddlRol" ValidationGroup="usuario" Enabled="true"
                                CssClass="form-control input-sm"></asp:DropDownList>
                        </div>
                        <asp:RequiredFieldValidator ID="rfvDdlRol" runat="server" ControlToValidate="ddlRol" 
                            ValidationGroup="usuario" Display="Static" 
                            ErrorMessage="Este campo es requerido!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        
                        <div class="col-md-12">
                            <asp:Button ID="btnEntrar" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary btn-sm col" OnClick="btnEntrar_Click" />
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
         <asp:ScriptManager runat="server">
        <Scripts>
                        <%--Para obtener más información sobre la unión de scripts en ScriptManager, consulte https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                        <%--Scripts de marco--%>
                        <asp:ScriptReference Name="MsAjaxBundle" />
                        <asp:ScriptReference Name="jquery" />
                        <asp:ScriptReference Name="bootstrap" />
                        <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                        <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                        <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                        <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                        <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                        <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                        <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                        <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                        <asp:ScriptReference Name="WebFormsBundle" />
                        <%--Scripts del sitio--%>
                    </Scripts>
     </asp:ScriptManager>
    </form>

   
</body>
</html>
