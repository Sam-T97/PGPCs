<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="Products_ProductDetails" %>

<asp:Content ID="ProductDetails" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:FormView ID="productDetails" runat="server" ItemType="PGPCs.Models.PRODUCT" SelectMethod="GetProducts" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#: Item.PRODUCT_NAME %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Assets/Thumbnails/<%#: Item.IMAGE_NAME %>" style="border:none; height:400px; width:300px" />
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align:top; text-align:left">
                        <b>Description:</b><br /><%#:Item.PRODUCT_DESCRIPTION %>
                        <br />
                        <span><b>Price:</b>£ <%#: Item.PRICE %></span>
                        <br />
                        <span><b>Product Number:</b><%#: Item.PRODUCT_ID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>

