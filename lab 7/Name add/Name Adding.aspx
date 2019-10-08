<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Name Adding.aspx.cs" Inherits="Name_add.Name_Adding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<h1>Name</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="nameLabel" runat="server" Text="Name:  "></asp:Label>
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox><br/><br />
            <asp:Button ID="addButton" align="center" runat="server" Text="Add " OnClick="addButton_Click" /><br/>
            
            
                <asp:Button ID="showButton" runat="server" Text="Show " OnClick="showButton_Click" /><br/><br/>
            
           
            <asp:Label ID="showLabel" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
