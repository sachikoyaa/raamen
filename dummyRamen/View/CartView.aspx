<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="dummyRamen.View.CartView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Cart"></asp:Label>
            <asp:GridView ID="Cartgv" runat="server"></asp:GridView>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ramen:"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="true" OnSelectedIndexChanging="GridView1_SelectedIndexChanging"></asp:GridView>
        </div>
    </form>
</body>
</html>
