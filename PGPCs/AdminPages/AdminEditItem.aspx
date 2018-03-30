<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AdminEditItem.aspx.cs" Inherits="AdminPages_AdminEditItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <div class="form-group" style="padding-top:3em">
            <asp:Label runat="server" AssociatedControlID="prodID" CssClass="control-label">Product ID Number: </asp:Label>
            <asp:TextBox runat="server" ID="prodID" TextMode="Number" CssClass="form-control" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="prodID" CssClass="text-danger" ErrorMessage="You must enter the Product ID" />
        </div>
            <asp:Button runat="server"  ID="btnSearch" Text="Search" CssClass="btn btn-default" OnClick="btnSearch_Click" />
        <asp:GridView runat="server" ID="ProductInfo" AutoGenerateColumns="false" CellPadding="4" GridLines="Vertical"
         CssClass="table table-striped table-bordered" ItemType="PGPCs.Models.PRODUCT">
        <Columns>
            <asp:BoundField DataField="PRODUCT_ID" HeaderText="Product ID:" />
            <asp:BoundField DataField="PRODUCT_NAME" HeaderText="Product Name:" />
            <asp:BoundField DataField="PRODUCT_DESCRIPTION" HeaderText="Product Description:" />
            <asp:BoundField DataField="IMAGE_NAME" HeaderText="Image Name:" />
            <asp:BoundField DataField="PRICE" HeaderText="Product Price:" />
            <asp:BoundField DataField="CATEGORY_ID" HeaderText="Category ID:" />
        </Columns>
    </asp:GridView>
</asp:Content>