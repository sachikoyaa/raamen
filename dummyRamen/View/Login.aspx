<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="dummyRamen.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Username" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Password" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="pass" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="errorLabel" runat="server" Text=""></asp:Label>

            <br />
            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
            <asp:Button ID="toRegis" runat="server" Text="Register Now" OnClick="toRegis_Click" />
        </div>
    </form>
</body>
</html>
