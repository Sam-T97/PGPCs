<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"  CodeFile="AdminAddItem.aspx.cs" Inherits="AdminPages_Admin_Add_Item" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h1> So you want to add an item....</h1>
            <div class="form-horizontal">
                <h4>Adding a new item to the database</h4>
                <hr />
                    <asp:ValidationSummary runat="server" CssClass="text-danger" />
                <div class="=form-group">
                    <asp:Label runat="server" AssociatedControlID="ProductCat" CssClass="col-md-2 control-label">Product Category:</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="ProductCat" SelectMethod="GetCategories" runat="server" DataTextField="CATEGORY_NAME" DataValueField="CATEGORY_ID"  CssClass="form-control"/>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ProductCat" CssClass="text-danger" ErrorMessage="You need to select a category first" />
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
                        <asp:TextBox textmode="MultiLine" runat="server" ID="ProductDesc" CssClass="form-control" Columns="20" Rows="10" MaxLength="1000" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ProductDesc" cssClass="text-danger" ErrorMessage="You need to enter a Product Description" />
                    </div>
                </div>
                    <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ProductPrice" CssClass="col-md-2 control-label">Product Price £:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox textmode="Number" runat="server" ID="ProductPrice" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ProductPrice" cssClass="text-danger" ErrorMessage="You need to enter a Product Price" />
                    </div>
                </div>
                    <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ImageName" CssClass="col-md-2 control-label">Image:</asp:Label>
                    <div class="col-md-10">
                        <asp:FileUpload ID="ImageName" runat="server" />
                    </div>
                </div>
            <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="NewProduct_Click" Text="Add Item" CssClass="btn btn-default" />
                <asp:Label runat="server" ID="ErrorMessage" />
            </div>
        </div>
            </div>
</asp:Content>