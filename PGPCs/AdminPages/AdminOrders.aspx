<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"  CodeFile="AdminOrders.aspx.cs" Inherits="AdminPages_AdminOrders" %>


<asp:Content ID="OrderList" ContentPlaceHolderID="MainContent" Runat="Server">
    <section>
        <div>
            <h1>View current orders.</h1>
            <asp:ListView ID="ordersList" runat="server" DataKeyNames="ORDER_ID" GroupItemCount="1" 
                ItemType="PGPCs.Models.ORDERS" SelectMethod="GetOrders">
                 <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data was returned, there are currently no active orders</td>
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
                                 <b>Order ID:<%#:Item.ORDER_ID%> </b>
                                 <b>Customer ID:<%#:Item.CUSTOMER_ID%> </b>
                                 <b>Order Placed:<%#:Item.ORDER_PLACED%> </b>
                                 <a href="#">View Order Details</a>
                                 <br />
                            </td>
                         </td>
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