<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewRamen.aspx.cs" Inherits="dummyRamen.View.ViewRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ProfileBtn" runat="server" Text="Profile" OnClick="ProfileBtn_Click" />
            <asp:Button ID="LogOutBtn" runat="server" Text="Log Out" OnClick="LogOutBtn_Click" />
            <br /><br /><br />

            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="No." />
                    <asp:BoundField DataField="MeatId" HeaderText="Meat" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Borth" HeaderText="Broth" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:TemplateField HeaderText="Add to Cart">
                        <ItemTemplate>
                            <asp:Button ID="addToCartBtn" runat="server" Text="Add to Cart" CommandName="AddToCart" CommandArgument='<%# Container.DataItemIndex %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <asp:Button ID="CartBtn" runat="server" Text="Cart" />
            <br />
            
            <asp:Button ID="HistoryBtn" runat="server" Text="History" />
        </div>
    </form>
</body>
</html>
