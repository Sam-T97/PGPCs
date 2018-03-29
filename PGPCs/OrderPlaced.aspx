<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="OrderPlaced.aspx.cs" Inherits="OrderPlaced" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <img src="Assets/Thumbnails/OrderPlaced.png" style="width:350px; height:300px; position:relative;"/>
    <div class="jumbotron" style="font-size:30px; background-color:lightgrey; text-align:center">
        <b>Your order has been placed!</b><br />
            <p>To see your order head over to the 'My Account' page<br />
                <a href="Account/MyAccount">My Account</a>
            </p>
    </div>
</asp:Content>

