<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Invoice.aspx.cs" Inherits="Account_Invoice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1 style="position:center; text-align:center">Price Gouger PCs Invoice</h1>
    <div style="text-align:left; display:inline-block">
        <asp:ListView runat="server" ItemType="PGPCs.Models.CUSTOMER" ID="CustomerDetails">
            <ItemTemplate>
                <address>
                    <%#:Item.CUSTOMER_FIRST_NAME %> <%#:Item.CUSTOMER_LAST_NAME %> <br />
                    <%#: Item.HOUSE_NUMBER %> <br />
                    <%#: Item.ADDRESS_LINE_1 %> <br />
                    <%#: Item.ADDRESS_LINE_2 %> <br />
                    <%#: Item.CITY %> <br />
                    <%#: Item.COUNTY %>
                </address>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <div style="text-align:right; display:inline-block; float:right">
        <address>
            trgtg <br/>
            rtgrtg <br/>
            rtgrtg <br/>
            rrtgrt <br/>
            rtggg <br/>
        </address>
    </div>
                <div style="margin:0 auto; width:50%; align-content:center">
    <h1><b>Your Order:</b></h1>
        <asp:GridView runat="server" ItemType="PGPCs.Models.ORDERS" AutoGenerateColumns="false"
        ID="orders" CellPadding="4" GridLines="Vertical" CssClass="table table-bordered table-striped" 
        ShowHeaderWhenEmpty="true" EmptyDataText="No Orders Placed">
        <Columns>
            <asp:BoundField DataField="ORDER_ID" HeaderText="Order ID" />
            <asp:BoundField DataField="ORDER_PLACED" HeaderText="Order Placed On" />
        </Columns>
    </asp:GridView>
    <asp:GridView runat="server" ItemType="PGPCs.Models.ORDERITEMS" AutoGenerateColumns="false"
        ID="orderDetails" CellPadding="4" GridLines="Vertical" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="PRODUCT.PRODUCT_NAME" HeaderText="Product Name:" />
            <asp:BoundField DataField="QUANTITY" HeaderText="Quantity:" />
            <asp:BoundField DataField="PRODUCT.PRICE" HeaderText="Price Per Unit" />
            <asp:TemplateField HeaderText="Item Subtotal">
                <ItemTemplate>
                    <%#: Convert.ToDouble(Item.QUANTITY * Item.PRODUCT.PRICE)%>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
                        <br />
    <br />
                        Thank you for your custom we hope you will shop with us again soon!
            </div>
        </form>

</body>
</html>
