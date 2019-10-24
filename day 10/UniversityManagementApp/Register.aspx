<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="UniversityManagementApp.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form  >
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Registraion No"></asp:Label>
                   </td> 
                    <td>
                        <asp:TextBox ID="txtReg" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td> 
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
                    </td> 
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Phone"></asp:Label>
                    </td> 
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
    </form>
    
    <asp:Label ID="lblShow" runat="server" Text=""></asp:Label>
</asp:Content>
