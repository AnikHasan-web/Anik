<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search by IMEI.aspx.cs" Inherits="MobileInformationManagement.Search_by_IMEI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <br/>
    <br/>
    <h2>Search By IMEI</h2>
    <br/>
    <div class="form-group">
    <label for="inputImei">IMEI</label>
    <input type="text" class="form-control" runat="server" id="inputImei">
    <br/>
    
    <asp:Button ID="searchByImeiButton" runat="server" Text="Search" />
    <br/>
    <br/>
        <asp:Label runat="server" Text="Model Name"></asp:Label>
    <br/>
        <asp:Label ID="modelNameLabel" runat="server" ></asp:Label>

        <br/>
    <asp:Label runat="server" Text="IMEI"></asp:Label>
    <br/>

    <asp:Label ID="IMEILabel" runat="server" ></asp:Label>
    <br/>


        <asp:Label runat="server" Text="Price"></asp:Label>
    <br/>
    <asp:Label ID="priceLabel" runat="server" ></asp:Label>
    <br/>

    

</asp:Content>
