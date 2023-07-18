<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="dummyRamen.View.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="STAFF"></asp:Label>
            <br />
            <asp:Button ID="ManageRamenBtn" runat="server" Text="Manage Ramen" OnClick="ManageRamenBtn_Click" />
        </div>
    </form>
</body>
</html>
