<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="Products_ProductList" %>

<asp:Content ID="ProductList" ContentPlaceHolderID="MainContent" Runat="Server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>
            <asp:ListView ID="productList" runat="server"
                DataKeyNames="PRODUCT_ID" GroupItemCount="4"
                ItemType="PGPCs.Models.PRODUCT" SelectMethod="GetProducts">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data was returned. The server may be experiancing an issue. Try again later</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <GroupTemplate>
                    <table>
                        <tr id ="itemPlaceholderContainer" runat="server">
                            <td id="itemPlaceholder" runat="server"></td>
                        </tr>
                    </table>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                    <table>
                        <tr>
                            <td>      
                                <a href="ProductDetails.aspx?ID=<%#:Item.PRODUCT_ID%>">
                                    <img src="/Assets/Thumbnails/<%#:Item.IMAGE_NAME %>"
                                        width="300" height="300" style="border:dashed" />
                                </a>
                                <br />
                                <span>
                                    <a href="ProductDetails.aspx?ID=<%#: Item.PRODUCT_ID %>" style="font-family:Calibri; text-decoration:none">
                                    <b><%# Item.PRODUCT_NAME %></b>
                                </span>
                                </a>
                                <br />
                                <span>
                                    <b>Price: £</b> <%# Item.PRICE%> 
                                </span>
                                <br />
                                <asp:Button runat="server" OnClick="BtnAddToCartClick" Text="Add To Cart" CssClass="btn btn-default"/>
                            </td>
                         </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <LayoutTemplate>
                    <table>
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>

