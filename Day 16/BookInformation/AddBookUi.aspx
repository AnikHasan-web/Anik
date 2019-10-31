<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBookUi.aspx.cs" Inherits="BookInformation.AddBookUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <table>
            <tr>
                <h1>Add Book</h1>
                <td>Name </td>
                <td><asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                 <td>ISBN </td>
                <td><asp:TextBox ID="isbnTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Author </td>
                <td><asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button class="btn btn-success" ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click"></asp:Button>
                </td>

            </tr>
            <tr><td><asp:Label ID="messageLabel" runat="server" ></asp:Label></td></tr>
        </table>
    </div>
</asp:Content>
