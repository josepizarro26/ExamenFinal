<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra.Master"  CodeBehind="Agente_Vista.aspx.cs" Inherits="ExamenFinal.Capa_Presentacion.Agente_Vista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/Form.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container d-flex align-items-center flex-column">
        <h1>Gestión de Agentes</h1>
    </div>
    
    <div class="container d-flex align-items-center flex-column">
        Nombre:
        <asp:TextBox runat="server" id="nombre" name="nombre"></asp:TextBox>
        Email
        <asp:TextBox runat="server" type="email" id="email" name="email"></asp:TextBox>
        Teléfono
        <asp:TextBox runat="server" type="tel" id="telefono" name="telefono"></asp:TextBox>
        Contraseña:
        <asp:TextBox runat="server" id="contraseña" name="contraseña"></asp:TextBox>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar Agente" OnClick="btnAgregarAgente_Click" />
    </div>
    <br /><br />

    <div class="container d-flex align-items-center flex-column">
        ID del Agente:
        <asp:TextBox runat="server" type="number" id="idBorrar" name="idBorrar"></asp:TextBox>
        <asp:Button ID="btnBorrar" runat="server" Text="Borrar Agente" OnClick="btnBorrarAgente_Click" />
    </div>
    <br /><br />

    <div class="container d-flex align-items-center flex-column">
        ID del Agente:
        <asp:TextBox runat="server"  type="number" id="idModificar" name="idModificar"></asp:TextBox>
        Nuevo Nombre:
        <asp:TextBox runat="server"  type="text" id="nombreModificar" name="nombreModificar"></asp:TextBox>
        Nuevo Email:
        <asp:TextBox runat="server"  type="email" id="emailModificar" name="emailModificar"></asp:TextBox>
        Nuevo Teléfono:
        <asp:TextBox runat="server"  type="tel" id="telefonoModificar" name="telefonoModificar"></asp:TextBox>
        <asp:Button ID="btnModificar" runat="server" Text="Modificar Agente" OnClick="btnModificarAgente_Click" />
    </div>
    <br /><br />

    <div class="container d-flex align-items-center flex-column">
        <h1>Reporte de Agente</h1>
  
        <asp:GridView ID="gvAgentes" runat="server"></asp:GridView>
    </div>
</asp:Content>



