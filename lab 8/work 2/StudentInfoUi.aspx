<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfoUi.aspx.cs" Inherits="work_2.work_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }

        .auto-style2 {
            width: 339px;
        }

        .auto-style3 {
            height: 23px;
            width: 339px;
            text-align: right;
        }

        .auto-style4 {
            width: 215px;
        }

        .auto-style5 {
            height: 23px;
            width: 215px;
        }

        .auto-style6 {
            width: 339px;
            height: 45px;
        }

        .auto-style7 {
            width: 215px;
            height: 45px;
            font-size: medium;
            text-align: center;
            color: #0000FF;
        }

        .auto-style8 {
            height: 45px;
        }

        .auto-style9 {
            width: 339px;
            text-align: right;
        }

        .auto-style10 {
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7"><strong>Student Information Management</strong></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style9">First Name:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="firstNameTextBox" autocomplete="off" runat="server" Width="274px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Last Name:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="lastNameTextBox" autocomplete="off" runat="server" CssClass="auto-style10" Width="274px"></asp:TextBox>
                    </td>
                    <td>
                        Full Name:<asp:Label ID="fullNameLabel" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">User Name:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="userNameTextBox" autocomplete="off" runat="server" Width="274px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Reg No:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="regTextBox" autocomplete="off" runat="server" Width="274px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Email:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="emailTextBox" autocomplete="off" runat="server" Width="274px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="emailShowLabel" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Age:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="ageTextBox" autocomplete="off" runat="server" Width="274px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="messageLabel" runat="server" ></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">First Name:</td>
                    <td class="auto-style4">
                        <asp:Label ID="firstNameLabel" runat="server" Text=""></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Last Name:</td>
                    <td class="auto-style4">
                        <asp:Label ID="lastNameLabel" runat="server" Text=""></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">UserName:</td>
                    <td class="auto-style4">
                        <asp:Label ID="userNameLabel" runat="server" Text=""></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Reg No:</td>
                    <td class="auto-style4">
                        <asp:Label ID="regLabel" runat="server" Text=""></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Email:</td>
                    <td class="auto-style4">
                        <asp:Label ID="emailLabel" runat="server" Text=""></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Age:</td>
                    <td class="auto-style4">
                        <asp:Label ID="ageLabel" runat="server" Text=""></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Button ID="studentListButton" runat="server" Text="Go to Student List" OnClick="studentListButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
