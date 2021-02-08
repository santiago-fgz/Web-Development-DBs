<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Dieta1.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Bienvenido a NutriAyuda<br />
            <br />
            ¿Ya tienes cuenta?<br />
            <asp:Button ID="Button1" runat="server" Text="Iniciar Sesion" OnClick="Button1_Click" />
            <br />
            <br />
            Crear una cuenta<br />
            <asp:Button ID="Button2" runat="server" Text="Registrarse" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
