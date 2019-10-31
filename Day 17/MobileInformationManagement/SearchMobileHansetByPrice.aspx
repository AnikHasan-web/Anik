<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchMobileHansetByPrice.aspx.cs" Inherits="MobileInformationManagement.SearchMobileHansetByPrice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <br/>
    <h2>Search By Price Range</h2>
    <br/>
    <div class="form-group">
        <label for="inputPrice1">Price Between</label>
        <input type="text" class="form-control" runat="server" id="inputPrice1">
    </div>
    <div class="form-group">
        <label for="inputPrice2">and</label>
        <input type="text" class="form-control" runat="server" id="inputPrice2">
    </div>
  
    <br/>
    <br/>

    <asp:Button ID="searchByPriceButton" runat="server" Text="Search" OnClick="searchByPriceButton_Click" />
    <br/>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
