<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ApproveNewAccounts.aspx.cs" Inherits="AdminPages_ApproveNewAccounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Approve New Accounts:</h1>
    <asp:GridView ID="awaiting" SelectMethod="awaiting_GetData" OnRowCommand="awaiting_RowCommand" ItemType="PGPCs.Models.CUSTOMER" runat="server"
        AutoGenerateColumns="false" CellPadding="4" GridLines="Vertical" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="CUSTOMER_FIRST_NAME" HeaderText="First Name:"/>
            <asp:BoundField DataField="CUSTOMER_LAST_NAME" HeaderText="Last Name:" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button Text="Approve Account" runat="server" CommandArgument="<%#: Item.CUSTOMER_ID %>"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

