<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoTecnicos.aspx.cs" Inherits="BancoUH.CatalogoTecnicos" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Catálogo de Técnicos</title>
</head>
<body style="font-family: Arial, sans-serif; margin: 0; background-color: #f4f4f9;">

   
    <div style="background-color: #222; overflow: hidden; padding: 12px;">
        <a href="Default.aspx" style="color: white; padding: 10px 15px; text-decoration: none;">Inicio</a>
        <a href="CatalogoUsuarios.aspx" style="color: white; padding: 10px 15px; text-decoration: none;">Usuarios</a>
        <a href="CatalogoTecnicos.aspx" style="color: white; padding: 10px 15px; text-decoration: none; font-weight: bold;">Técnicos</a>
    </div>

    <form id="form1" runat="server" style="padding: 30px;">
        <h2>Catálogo de Técnicos</h2>
        <p>Bienvenido al catálogo de técnicos de soporte.</p>

       
        <div style="margin-bottom: 20px;">
            <asp:Label ID="lblID" runat="server" Text="ID Técnico (Para actualizar/eliminar):" AssociatedControlID="txtTecnicoID"></asp:Label><br />
            <asp:TextBox ID="txtTecnicoID" runat="server" Width="300px" Style="padding: 5px; margin-bottom: 10px;"></asp:TextBox><br />

            <asp:Label ID="lblNombre" runat="server" Text="Nombre:" AssociatedControlID="txtNombre"></asp:Label><br />
            <asp:TextBox ID="txtNombre" runat="server" Width="300px" Style="padding: 5px; margin-bottom: 10px;"></asp:TextBox><br />

            <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad:" AssociatedControlID="txtEspecialidad"></asp:Label><br />
            <asp:TextBox ID="txtEspecialidad" runat="server" Width="300px" Style="padding: 5px; margin-bottom: 20px;"></asp:TextBox><br />
        </div>

        
        <div>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" Style="background-color: #4CAF50; color: white; border: none; padding: 10px 20px; cursor: pointer; margin-right: 5px;" />
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" Style="background-color: #2196F3; color: white; border: none; padding: 10px 20px; cursor: pointer; margin-right: 5px;" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Style="background-color: #f44336; color: white; border: none; padding: 10px 20px; cursor: pointer;" />
        </div>
    </form>
</body>
</html>
