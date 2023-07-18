<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfileEdit.aspx.cs" Inherits="dummyRamen.View.ProfileEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Username" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Email" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="emailadd" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Gender" runat="server" Text="Gender: "></asp:Label>
            <asp:TextBox ID="gen" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Password" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="pass" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="updateBtn" runat="server" Text="Confirm Update" OnClick="updateBtn_Click" />
        </div>
    </form>
</body>
</html>
