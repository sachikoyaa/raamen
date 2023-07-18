<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateRamen.aspx.cs" Inherits="dummyRamen.View.UpdateRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Ramen Name"></asp:Label>
            <br />
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
             <asp:Label ID="Label3" runat="server" Text="Meat ID"></asp:Label>
            <br />
            <asp:DropDownList ID="addMeatDD" runat="server" AutoPostBack="True">
                <asp:ListItem Value="1">Beef</asp:ListItem>
                <asp:ListItem Value="2">Chicken</asp:ListItem>
                <asp:ListItem Value="3">Pork</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Broth"></asp:Label>
            <br />
            <asp:TextBox ID="broth" runat="server"></asp:TextBox>
            <br />
             <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>
            <br />
            <asp:TextBox ID="price" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="addBack_btn" runat="server" Text="Back" OnClick="addBack_btn_Click" />
            <asp:Button ID="btn_update" runat="server" Text="Update Ramen" OnClick="btn_update_Click" />
            <br />
            <asp:Label ID="updateStatus_txt" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
