﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dieta.aspx.cs" Inherits="Dieta1.Dieta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Inicio</asp:LinkButton>
            <br />
            <br />
            Mi Dieta<br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
&nbsp;</div>
    </form>
</body>
</html>
