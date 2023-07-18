<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditRamen.aspx.cs" Inherits="dummyRamen.View.EditRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Update Ramen" Font-Bold="true" Font-Underline="true" Font-Size="Large"></asp:Label>
            <asp:GridView ID="editRamenGV" runat="server" OnRowEditing="editRamenGV_RowEditing" AutoGenerateEditButton="true"></asp:GridView>
            <br /><br />
            <asp:Button ID="BackToHomeBtn" runat="server" Text="Back" OnClick="BackToHomeBtn_Click" />
        </div>
    </form>
</body>
</html>
