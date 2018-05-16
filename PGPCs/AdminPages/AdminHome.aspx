<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AdminHome.aspx.cs" Inherits="AdminPages_AdminHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="padding-top:4em">
    <div class="navbar navbar-inverse navbar-center">
        <div class="container-fluid">
        <ul class="nav navbar-nav">
            <li><a href="AdminAddItem">Add an Item</a></li>
            <li><a href="#">Remove an Item</a></li>
            <li><a href="AdminEditItem">Update an Items Details</a></li>
            <li><a href="AdminOrders">View Active Orders</a></li>
            <li><a href="FreezeAccounts">Freeze Customer Accounts</a></li>
            <li><a href="ApproveNewAccounts">Approve New Accounts</a></li>
        </ul>
       </div>
    </div>
        </div>
</asp:Content>

