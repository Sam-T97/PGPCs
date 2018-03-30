<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AdminOrderDetails.aspx.cs" Inherits="AdminPages_AdminOrderDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Ship To:</h1>
    <asp:GridView runat="server" ItemType="PGPCs.Models.CUSTOMER" AutoGenerateColumns="false"
        ID="customerDetails" CellPadding="4" GridLines="Vertical" CssClass="table table-bordered table-striped">
        <Columns>
            <asp:TemplateField HeaderText="Address:" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <address>
                    Name: <%#:Item.CUSTOMER_FIRST_NAME %> <%#:Item.CUSTOMER_LAST_NAME %> <br />
                    House Number: <%#: Item.HOUSE_NUMBER %> <br />
                    Address 1: <%#: Item.ADDRESS_LINE_1 %> <br />
                    Address 2: <%#: Item.ADDRESS_LINE_2 %> <br />
                    City: <%#: Item.CITY %> <br />
                    County: <%#: Item.COUNTY %>
                    </address>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <h2>Items:</h2>
    <asp:GridView runat="server" ItemType="PGPCs.Models.ORDERITEMS" AutoGenerateColumns="false"
        ID="orderDetails" CellPadding="4" GridLines="Vertical" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="PRODUCT_ID" HeaderText="Product SKU:"/>
            <asp:BoundField DataField="QUANTITY" HeaderText="Quantity:" />
        </Columns>
    </asp:GridView>
    <asp:Label runat="server" AssociatedControlID="ddlStat">New Status of Item: </asp:Label>
    <asp:DropDownList runat="server" ID="ddlStat">
        <asp:ListItem>Picking</asp:ListItem>
        <asp:ListItem>Packing</asp:ListItem>
        <asp:ListItem>Dispatched</asp:ListItem>
    </asp:DropDownList>
    <asp:RequiredFieldValidator runat="server" ControlToValidate="ddlStat" ErrorMessage="Select an option" />
    <asp:Button runat="server" ID="btnUpdate" Text="Update Order Status" OnClick="btnUpdate_Click" />
</asp:Content>

