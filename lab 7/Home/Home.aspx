<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Home.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
</head>
<body>
<h1>Name</h1>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label ID="Label1" runat="server" Text="First Name:     "></asp:Label>
            <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox><br/>
            <asp:Label ID="Label2" runat="server" Text="Last Name:      "></asp:Label>
            <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox><br/><br/>
            <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" /><br/> 
            <asp:Label ID="Label3" runat="server" Text="Full Name:      "></asp:Label>
            <asp:TextBox ID="fullNameTextBox" runat="server"></asp:TextBox><br/>
                
        </div>
    </form>
</body>
</html>

