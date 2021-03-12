<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ejercicio_4_171299.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Lado 1 / Base</div>
        <p>
            <asp:TextBox ID="Num1" runat="server"></asp:TextBox>
        </p>
        <p>
            Lado 2 / Altura</p>
        <p>
            <asp:TextBox ID="Num2" runat="server"></asp:TextBox>
        </p>
        <p>
            Radio</p>
        <p>
            <asp:TextBox ID="Num3" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnCuadro" runat="server" OnClick="Button1_Click" Text="Cuadro" />
        </p>
        <p>
            <asp:Button ID="BtnTriangulo" runat="server" Text="Triangulo" OnClick="BtnTriangulo_Click" />
        </p>
        <p>
            <asp:Button ID="BtnCirculo" runat="server" Text="Circulo" OnClick="BtnCirculo_Click" />
        </p>
        <p>
            <asp:Label ID="Result" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
