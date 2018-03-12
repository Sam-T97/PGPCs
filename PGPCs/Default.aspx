<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="position:center; text-align:center; font-family:Calibri; font-size:30px; background-color:lightgrey; padding-top:0em">
        Welcome to Price Gouger PCs! <br />
        <asp:Label id="Message" runat="server" />
    </div>
</asp:Content>
