<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FreezeAccounts.aspx.cs" Inherits="AdminPages_FreezeAccounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="form-group" style="padding-top:3em">
        <asp:Label runat="server" AssociatedControlID="txtID" CssClass="control-label">Customer ID Number: </asp:Label>
        <asp:TextBox runat="server" ID="txtID" TextMode="Number" CssClass="form-control" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtID"
            CssClass="text-danger" ErrorMessage="You must enter the customer ID" />
        <br />
        <asp:Button runat="server"  ID="btnSearch" Text="Search" CssClass="btn btn-default" OnClick="btnSearch_Click" />
    </div>
    <asp:GridView runat="server" ID="AccountDetails" AutoGenerateColumns="false" CellPadding="4" GridLines="Vertical"
         CssClass="table table-striped table-bordered" ItemType="PGPCs.Models.CUSTOMER">
        <Columns>
            <asp:BoundField DataField="CUSTOMER_FIRST_NAME" HeaderText="First Name:" />
            <asp:BoundField DataField="CUSTOMER_LAST_NAME" HeaderText="Last Name:" />
            <asp:BoundField DataField="FROZEN" HeaderText="Currently Frozen:" />
            <asp:ButtonField Text="Freeze Account" ButtonType="Button" HeaderText="Freeze This Account:"/>
            <asp:ButtonField Text="Unfreeze Account" ButtonType="Button" HeaderText="Unfreeze This Account:" />
        </Columns>
    </asp:GridView>
</asp:Content>

