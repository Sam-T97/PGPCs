<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AdminEditItem.aspx.cs" Inherits="AdminPages_AdminEditItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <div class="form-group" style="padding-top:3em">
            <asp:Label runat="server" AssociatedControlID="prodID" CssClass="control-label">Product ID Number: </asp:Label>
            <asp:TextBox runat="server" ID="prodID" TextMode="Number" CssClass="form-control" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="prodID" CssClass="text-danger" ErrorMessage="You must enter the Product ID" />
        </div>
            <asp:Button runat="server"  ID="btnSearch" Text="Search" CssClass="btn btn-default" OnClick="btnSearch_Click" />

</asp:Content>