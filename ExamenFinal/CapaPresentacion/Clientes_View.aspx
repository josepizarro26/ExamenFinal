<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Clientes_View.aspx.cs" Inherits="ExamenFinal.Capa_Presentacion.Clientes_View" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/Form.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>     
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <body>
        <div class="container d-flex align-items-center flex-column">
            <h1>Gestión de Clientes</h1>
        </div>        

        <div class="container d-flex align-items-center flex-column">
            Nombre:
            <asp:TextBox runat="server" type="text" id="nombre" name="nombre"></asp:TextBox>
            Email:
            <asp:TextBox runat="server" type="email" id="email" name="email"></asp:TextBox>
            Teléfono:
            <asp:TextBox runat="server" type="tel" id="telefono" name="telefono"></asp:TextBox>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar Cliente" OnClick="btnAgregarCliente_Click" />
        </div>
        <br /><br />

        <div  class="container d-flex align-items-center flex-column">
            ID del Cliente:
            <asp:TextBox runat="server" type="number" id="idBorrar" name="idBorrar"></asp:TextBox>
            <asp:Button ID="btnBorrar" runat="server" Text="Borrar Cliente" OnClick="btnBorrarCliente_Click" />
        </div>
        <br /><br />

        <div  class="container d-flex align-items-center flex-column">
            ID del Cliente:
            <asp:TextBox runat="server"  type="number" id="idModificar" name="idModificar"></asp:TextBox>
            Nuevo Nombre:
            <asp:TextBox runat="server"  type="text" id="nombreModificar" name="nombreModificar"></asp:TextBox>
            Nuevo Email:
            <asp:TextBox runat="server"  type="email" id="emailModificar" name="emailModificar"></asp:TextBox>
            Nuevo Teléfono:
            <asp:TextBox runat="server"  type="tel" id="telefonoModificar" name="telefonoModificar"></asp:TextBox>
            <asp:Button ID="btnModificar" runat="server" Text="Modificar Cliente" OnClick="btnModificarCliente_Click" />
        </div>
        <br /><br />

        <div  class="container d-flex align-items-center flex-column">
            <h1>Reporte de Clientes</h1>  
            <asp:GridView ID="gvClientes" runat="server"></asp:GridView>
        </div>
    </body>
</html >
</asp:Content >