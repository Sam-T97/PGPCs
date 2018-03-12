<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Account_Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create a new account.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="col-md-2 control-label">First Name:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstName"
                    cssClass="text-danger" ErrorMessage="The first name field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="LastName" CssClass="col-md-2 control-label">Last Name:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="LastName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                    CssClass="text-danger" ErrorMessage="The last name field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="HouseNumber" CssClass="col-md-2 control-label">House / Building Number:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="HouseNumber" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="HouseNumber"
                    CssClass="text-danger" ErrorMessage="The house number field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="AddressLine1" CssClass="col-md-2 control-label">Address Line 1:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="AddressLine1" CssClass="form-control" MaxLength="30"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="AddressLine1"
                    CssClass="text-danger" ErrorMessage="The address line 1 field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="AddressLine2" CssClass="col-md-2 control-label">Address Line 2:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="AddressLine2" CssClass="form-control" MaxLength="30" />
                <br />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="City" CssClass="col-md-2 control-label">City:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="City" CssClass="form-control" MaxLength="30" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="City"
                    CssClass="text-danger" ErrorMessage="The city field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="County" CssClass="col-md-2 control-label">County:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="County" CssClass="form-control" MaxLength="30" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="County"
                    CssClass="text-danger" ErrorMessage="The county field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="PostCode" CssClass="col-md-2 control-label">Postcode:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="PostCode" CssClass="form-control" MaxLength="7" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="PostCode"
                    CssClass="text-danger" ErrorMessage="The postcode field is required" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="EmailAddress" CssClass="col-md-2 control-label">Email Address:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="EmailAddress" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="EmailAddress"
                    CssClass="text-danger" ErrorMessage="The email address field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirm password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>

