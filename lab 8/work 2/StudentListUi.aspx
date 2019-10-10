<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentListUi.aspx.cs" Inherits="work_2.Student_List_Ui" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        .auto-style4 {
            width: 215px;
        }

        .auto-style7 {
            width: 215px;
            height: 45px;
            font-size: medium;
        }

        .auto-style8 {
            height: 45px;
        }

        .auto-style10 {
            margin-right: 0px;
        }
        .auto-style12 {
            width: 215px;
            height: 23px;
        }
        .auto-style13 {
            height: 23px;
        }
        .auto-style14 {
            text-align: right;
        }
        .auto-style15 {
            text-align: right;
            height: 26px;
        }
        .auto-style16 {
            width: 215px;
            height: 26px;
        }
        .auto-style17 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
               <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">Student Information Management</td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style14">First Name:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="firstNameTextBox" autocomplete="off" runat="server" Width="274px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style14">Last Name:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="lastNameTextBox" autocomplete="off" runat="server" CssClass="auto-style10" Width="274px"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style14">User Name:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="userNameTextBox" autocomplete="off" runat="server" Width="274px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style14">Reg No:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="regTextBox" autocomplete="off" runat="server" Width="274px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style14">Email:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="emailTextBox" autocomplete="off" runat="server" Width="274px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="emailShowLabel" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">Age:</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="ageTextBox" autocomplete="off" runat="server" Width="274px"></asp:TextBox>
                    </td>
                    <td class="auto-style17"></td>
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
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">
                        <asp:ListBox ID="studentListBox" runat="server" Height="171px" Width="282px"></asp:ListBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td class="auto-style12">
                    </td>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                                
            </table>
        </div>
    </form>
</body>
</html>
