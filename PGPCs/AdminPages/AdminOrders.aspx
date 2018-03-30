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
                    <table border="1">
                        <tr>
                            <td>
                                 <b>Order ID: </b><%#:Item.ORDER_ID%> &nbsp;
                                 <b>Order Placed: </b><%#:Item.ORDER_PLACED%> &nbsp;
                                 <b>Reported Status: </b><%#: Item.STATUS %> &nbsp;
                                 <asp:LinkButton runat="server" ID="ViewDetails" Text="View Details" OnCommand="ViewDetails_Command" CommandArgument="<%#: Item.ORDER_ID %>" />
                                 <br />
                            </td>
                           </tr>
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