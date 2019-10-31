<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SaveInformation.aspx.cs" Inherits="MobileInformationManagement.SaveInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <br/>
    <h2>Save</h2>
    <br/>
        <div class="form-group">
            <label for="inputModelName">Model Name</label>
            <input type="text" class="form-control" runat="server" id="inputModelName">
        </div>
        <div class="form-group">
            <label for="inputImei">IMEI</label>
            <input type="text" class="form-control" runat="server" id="inputImei">
        </div>
    <div class="form-group">
        <label for="inputPrice">Price</label>
        <input type="text" class="form-control" runat="server" id="inputPrice">
    </div>
    <br/>
    <br/>

    <asp:Button ID="saveButton" runat="server" Text="Save"  class="btn btn-primary" OnClick="saveButton_Click" />
    
    <asp:Label ID="saveLabel" runat="server"></asp:Label>
    
    </asp:Content>
