<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginFake.aspx.cs" Inherits="Dieta1.LoginFake" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Usuario:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Contraseña:
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Entrar" />
            <br />
            <br />
            ¿No tienes cuenta?<br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Regresar</asp:LinkButton>
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
