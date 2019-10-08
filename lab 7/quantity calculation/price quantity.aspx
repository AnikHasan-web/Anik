<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="price quantity.aspx.cs" Inherits="quantity_calculation.price_quantity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Calculator</h1>
        <div>
            <asp:Label ID="unitLabel" runat="server" Text="Unit Price:  "></asp:Label>
            <asp:TextBox ID="unitTextBox" runat="server"></asp:TextBox>
            <br /><br/>
            <asp:Label ID="quantityLabel" runat="server" Text="Total Quantity:  "></asp:Label>
            <asp:TextBox ID="quantityTextBox" runat="server"></asp:TextBox>
            <br /><br/>
            <asp:Button ID="calButton" runat="server" Text="Cal" OnClick="calButton_Click" />
            <br /><br/>
            <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
            <br /><br/>
            <asp:Label ID="priceLabel" runat="server" Text="Total Price:  "></asp:Label>
            <asp:TextBox ID="priceTextBox" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
