<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"  CodeFile="AdminAddItem.aspx.cs" Inherits="AdminPages_Admin_Add_Item" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h1> So you want to add an item....</h1>
            <div class="form-horizontal">
                <h4>Adding a new item to the database</h4>
                <hr />
                    <asp:ValidationSummary runat="server" CssClass="text-danger" />
                    <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ProductID" CssClass="col-md-2 control-label">Product ID:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="ProductID" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ProductID" cssClass="text-danger" ErrorMessage="You need to enter a Product ID" />
                    </div>
                </div>
                    <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ProductName" CssClass="col-md-2 control-label">Product Name:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="ProductName" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ProductName" cssClass="text-danger" ErrorMessage="You need to enter a ProductName" />
                    </div>
                </div>
                    <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ProductDesc" CssClass="col-md-2 control-label">Product Description:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="ProductDesc" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ProductDesc" cssClass="text-danger" ErrorMessage="You need to enter a Product Description" />
                    </div>
                </div>
                    <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ProductPrice" CssClass="col-md-2 control-label">Product Price:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="ProductPrice" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ProductPrice" cssClass="text-danger" ErrorMessage="You need to enter a Product Price" />
                    </div>
                </div>
                    <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ImageName" CssClass="col-md-2 control-label">Image Name:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="ImageName" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ImageName" cssClass="text-danger" ErrorMessage="You need to enter an Image Name" />
                    </div>
                </div>
            <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="NewProduct_Click" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
            </div>
</asp:Content>