<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AdminEditItem.aspx.cs" Inherits="AdminPages_AdminEditItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <div class="form-group" style="padding-top:3em">
            <asp:Label runat="server" AssociatedControlID="prodID" CssClass="control-label">Product ID Number: </asp:Label>
            <asp:TextBox runat="server" ID="prodID" TextMode="Number" CssClass="form-control" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="prodID" CssClass="text-danger" ErrorMessage="You must enter the Product ID" />
        </div>
            <asp:Button runat="server"  ID="btnSearch" Text="Search" CssClass="btn btn-default" OnClick="btnSearch_Click" />
    <br />
    <br />
    <asp:Label runat="server" ID="prodNam" CssClass="control-label">Product Name: </asp:Label>
                <asp:TextBox runat="server" ID="ProdNametxt" CssClass="form-control" />
    <asp:Label runat="server" ID="prodDesc" CssClass="control-label">Product Description: </asp:Label>
                <asp:TextBox runat="server" ID="ProdDesctxt" CssClass="form-control" />
    <asp:Label runat="server" ID="ImageName" CssClass="control-label">Product Image Name: </asp:Label>
                <asp:TextBox runat="server" ID="ImageNametxt" CssClass="form-control" />
    <asp:Label runat="server" ID="prodPrice" CssClass="control-label">Product Price: </asp:Label>
                <asp:TextBox runat="server" ID="PriceTxt" CssClass="form-control" />
    <br />
    <asp:Button runat="server"  ID="btnSave" Text="Save Changes" CssClass="btn btn-default" OnClick="btnSave_Click" />
</asp:Content>