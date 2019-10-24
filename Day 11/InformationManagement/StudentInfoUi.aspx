<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentInfoUi.aspx.cs" Inherits="InformationManagement.StudentInfoUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Student Information Form</h2>
    <div class="form-group">
        <label for="inputStudentName">Student Name</label>
        <input type="text" class="form-control" id="inputStudentName" runat="server" placeholder="Enter Name"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="inputStudentName" ForeColor="red" ErrorMessage="Name Can't be empty"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <label for="inputRegNo">Student Reg No</label>
        <input type="text" class="form-control" runat="server" id="inputRegNo" placeholder="Enter Reg No"/>
    </div>
    <div class="form-group">
        <label for="inputEmailAddress">Email Address</label>
        <input type="text" runat="server" class="form-control" id="inputEmailAddress" placeholder="Enter Email"/>
    </div>
    <div class="form-group">
        <label for="inputMobileNo">Mobile No</label>
        <input type="text" runat="server" class="form-control" id="inputMobileNo" placeholder="Enter Mobile No"/>
    </div>
    <div class="form-group">
        <label for="inputAge">Age</label>
        <input type="text" class="form-control" runat="server" id="inputAge" placeholder="Enter Age"/>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ForeColor="red" ControlToValidate="inputAge" Display="Dynamic" Operator="DataTypeCheck" Type="Integer" ErrorMessage="Invalid Input"></asp:CompareValidator>
    </div>
    <div class="form-group">
        <label for="inputAddess">Address</label>
        <input type="text" runat="server" class="form-control" id="inputAddess" placeholder="Enter Address"/>
    </div>
    <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" OnClick="saveButton_Click" />
    <br/>
    <asp:Label ID="messageLabel" runat="server"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="StudentGrirdView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Student Name">
                <ItemTemplate>
                    <%#Eval("StudentName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Reg No">
                <ItemTemplate>
                    <%#Eval("RegNo") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email Address">
                <ItemTemplate>
                    <%#Eval("EmailAddress") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mobile No">
                <ItemTemplate>
                    <%#Eval("MobileNo") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Age">
                <ItemTemplate>
                    <%#Eval("Age") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Address">
                <ItemTemplate>
                    <%#Eval("Address") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>
