<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MyAccount.aspx.cs" Inherits="Account_MyAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron" style="background-color:lightgrey; font-size:30px">
        <h1><b>Your Orders:</b></h1>
    </div>
    <asp:GridView runat="server" ItemType="PGPCs.Models.ORDERS" AutoGenerateColumns="false"
        ID="orders" CellPadding="4" GridLines="Vertical" CssClass="table table-bordered table-striped" 
        ShowHeaderWhenEmpty="true" EmptyDataText="No Orders Placed">
        <Columns>
            <asp:BoundField DataField="ORDER_ID" HeaderText="Order ID" />
            <asp:BoundField DataField="ORDER_PLACED" HeaderText="Order Placed On" />
            <asp:BoundField DataField="STATUS" HeaderText="Current Status" />
            <asp:TemplateField HeaderText="View Details">
                <ItemTemplate>
                    <asp:LinkButton runat="server" Text="View Details" ID="ViewDetails" OnCommand="ViewDetails_Command" CommandArgument="<%#: Item.ORDER_ID %>"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <h2><b>Your Orders Details:</b></h2>
    <asp:GridView runat="server" ItemType="PGPCs.Models.ORDERITEMS" AutoGenerateColumns="false"
        ID="orderDetails" CellPadding="4" GridLines="Vertical" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="PRODUCT_ID" HeaderText="Product SKU:"/>
            <asp:BoundField DataField="PRODUCT.PRODUCT_NAME" HeaderText="Product Name:" />
            <asp:BoundField DataField="QUANTITY" HeaderText="Quantity:" />
            <asp:BoundField DataField="PRODUCT.PRICE" HeaderText="Price Per Unit £" />
            <asp:TemplateField HeaderText="Item Subtotal £">
                <ItemTemplate>
                    <%#: Convert.ToDouble(Item.QUANTITY * Item.PRODUCT.PRICE)%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="View Invoice">
                <ItemTemplate>
                    <a href="Invoice?ID=<%#: Item.ORDER_ID %>" target="_blank">View Invoice</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

