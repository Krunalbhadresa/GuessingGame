<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label3" runat="server" Text="Tries left : "></asp:Label>
        <asp:Label ID="tries" runat="server" Text="100"></asp:Label>
    
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter a number between 1 and 100"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter" />
        </p>
        <p>
            <asp:Label ID="hint" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="slabel" runat="server" Text="Score : "></asp:Label>
            <asp:Label ID="score" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
