<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="dummyRamen.View.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ADMIN"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Staff"></asp:Label>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Label ID="Label3" runat="server" Text="Customer"></asp:Label>
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
            <br />
            <asp:Button ID="ViewReportBtn" runat="server" Text="View Report" OnClick="ViewReportBtn_Click" />
        </div>
    </form>
</body>
</html>
