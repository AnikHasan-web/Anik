<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1user information.aspx.cs" Inherits="user_information.WebForm1user_information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="firstNameLabel" runat="server" Text="First Name: " ></asp:Label>
            <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lastNameLabel" runat="server" Text="Last Name: "></asp:Label>
            <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="userNameLabel" runat="server" Text="User Name: "></asp:Label>
            <asp:TextBox ID="userNameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="regNumberLabel" runat="server" Text="Reg no: "></asp:Label>
            <asp:TextBox ID="regNumberTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="ageLabel" runat="server" Text="Age: "></asp:Label>
            <asp:TextBox ID="ageTextBox" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
        <br />
        <asp:Label ID="showLabel" runat="server" ></asp:Label>
        <br />
        <br />
        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
        <br/>
        
            <asp:Label ID="Label" runat="server" Text="Last Name: "></asp:Label>
        <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
        <br/>
        
            <asp:Label ID="Label3" runat="server" Text="User Name: "></asp:Label>
        <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
        <br/>
        
       
            <asp:Label ID="Label4" runat="server" Text="Reg No: "></asp:Label>
        <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
        <br/>
       
      
            <asp:Label ID="Label5" runat="server" Text="Email: "></asp:Label>
        <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
        <br/>
       
       
            <asp:Label ID="Label6" runat="server" Text="Age: "></asp:Label>
        
        <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
        
    </form>
</body>
</html>
