<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarDieta.aspx.cs" Inherits="Dieta1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Edición de Dietas<br />
            <br />
            Selecciona la dieta que quieres editar:<br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Seleccionar dieta" />
            <br />
            <br />
            Eliminar de la dieta:<br />
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Eliminar" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            Agregar a la dieta:<br />
            <br />
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Porciones: <asp:TextBox ID="TextBox1" runat="server" Width="43px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Agregar a la dieta" OnClick="Button3_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
