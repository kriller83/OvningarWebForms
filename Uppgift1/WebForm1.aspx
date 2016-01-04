<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Uppgift1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Skriv in antal liter:
        <asp:TextBox ID="LiterBox" runat="server"></asp:TextBox><br/>
        Konvertera till dl, cl eller ml. <br/>
        <asp:Button ID="DeciliterButton" runat="server" Text="Deciliter" OnClick="DeciliterButton_Click" />
        <asp:Button ID="CentiliterButton" runat="server" Text="Centiliter" OnClick="CentiliterButton_Click" />
        <asp:Button ID="MilliliterButton" runat="server" Text="Milliliter" OnClick="MilliliterButton_Click" />
        <br/>
        <asp:Label ID="ResultatLabel" runat="server" Text="Resultat"></asp:Label>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Alla resultat" OnClick="Button1_Click" /><br/>
        Deciliter: <asp:Label ID="Label1" runat="server" Text="Deciliter"></asp:Label><br/>
        Centiliter: <asp:Label ID="Label2" runat="server" Text="Centiliter"></asp:Label><br/>
        Milliliter: <asp:Label ID="Label3" runat="server" Text="Milliliter"></asp:Label><br/>
    </form>
</body>
</html>
