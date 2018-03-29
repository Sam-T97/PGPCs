<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron" style="width:100%; background-color:lightgrey"><h1>Shopping Cart:</h1></div>
    <asp:GridView ID="ShoppingCartList" runat="server" AutoGenerateColumns="false" CellPadding="4" ShowFooter="true" GridLines="Vertical" 
        ItemType="PGPCs.SHOPPINGCARTITEMS" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="PRODUCT.PRODUCT_NAME" HeaderText="Product" />
            <asp:BoundField DataField="PRODUCT.PRICE" HeaderText="Price" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="PurchaseAmount" Width="40" runat="server" Text="<%#: Item.QUANTITY %>" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Item Subtotal:">
                <ItemTemplate>
                    <%#: String.Format("{0:c}", (Convert.ToDouble(Item.QUANTITY) * Convert.ToDouble(Item.PRODUCT.PRICE))) %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button runat="server" Text="Checkout" ID="btnCheckout" OnClick="btnCheckout_Click" />
</asp:Content>

