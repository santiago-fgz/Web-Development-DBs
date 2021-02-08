<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Dieta1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Mi Dieta</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Salir</asp:LinkButton>
&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Editar mis datos</asp:LinkButton>
&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Visible="False">Editar dietas</asp:LinkButton>
            <br />
            <br />
            NutriAyuda<br />
            <br />
            ¡Hola
            <asp:Label ID="Label1" runat="server"></asp:Label>
            !<br />
            <br />
            &nbsp;<asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            ¿Qué comiste hoy?<br />
            <br />
            Vegetales&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Agregar Vegetal" OnClick="Button1_Click" />
            <br />
            Frutas</div>
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button2" runat="server" Text="Agregar Fruta" OnClick="Button2_Click" />
        <br />
        Semillas<br />
        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button3" runat="server" Text="Agregar Semillas" OnClick="Button3_Click" />
        <br />
        Cereales y Pasta<br />
        <asp:DropDownList ID="DropDownList4" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button4" runat="server" Text="Agregar Cereales y Pastas" OnClick="Button4_Click" />
        <br />
        Legumbres<br />
        <asp:DropDownList ID="DropDownList5" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button5" runat="server" Text="Agregar Legumbres" OnClick="Button5_Click" />
        <br />
        Lacteos<br />
        <asp:DropDownList ID="DropDownList6" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button6" runat="server" Text="Agregar Lácteos" OnClick="Button6_Click" />
        <br />
        Carnes<br />
        <asp:DropDownList ID="DropDownList7" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button7" runat="server" Text="Agregar Carnes" OnClick="Button7_Click" />
        <br />
        Pescados y Mariscos<br />
        <asp:DropDownList ID="DropDownList8" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button8" runat="server" Text="Agregar Pescados y Mariscos" OnClick="Button8_Click" />
        <br />
        Varios<br />
        <asp:DropDownList ID="DropDownList9" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button9" runat="server" Text="Agregar Varios" OnClick="Button9_Click" />
        <br />
    </form>
</body>
</html>
