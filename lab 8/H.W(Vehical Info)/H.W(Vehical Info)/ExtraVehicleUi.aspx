<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExtraVehicleUi.aspx.cs" Inherits="H.W_Vehical_Info_.ExtraVehicleUi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 388px;
        }
        .auto-style2 {
            width: 269px;
        }
        .auto-style3 {
            width: 269px;
            font-size: large;
            color: #0000FF;
            text-align: center;
        }
        .auto-style4 {
            width: 388px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    <h2><strong>Vehicle Information</strong></h2>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Vehicle Name:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="nameTextBox" runat="server" Width="240px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="messageLabel" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Reg No:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="regTextBox" runat="server" Width="240px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="createButton" runat="server" Text="Create" OnClick="createButton_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Speed:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="speedTextBox" runat="server" Width="240px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="speedLabel" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="enterButton" runat="server" Text="Enter" OnClick="enterButton_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Max Speed:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="maxTextBox" runat="server" Width="240px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Min Speed:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="minTextBox" runat="server" Width="240px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Avarage Speed:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="avgTextBox" runat="server" Width="240px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2"></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>