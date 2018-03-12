<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:GridView ID="ShoppingCartList" runat="server" AutoGenerateColumns="false" CellPadding="4" ShowFooter="true" GridLines="Vertical" 
        ItemType="PGPCs.SHOPPINGCARTITEMS" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="PRODUCT.PRODUCT_NAME" HeaderText="Product" />
            <asp:BoundField DataField="PRODUCT.PRICE" HeaderText="Price" />
        </Columns>
    </asp:GridView>
</asp:Content>

