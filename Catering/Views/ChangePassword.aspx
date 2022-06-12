<%@ Page Title="Change Password" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Catering.Views.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mx-auto bg-gray-200 rounded py-4 px-7" style="width: 440px;">
        <h1 class="text-center text-3xl text-bold">Change Password</h1>
        <div class="mx-auto h-0.5 w-64 rounded bg-gray-700 mt-2 mb-4"></div>

        <div class="mb-3">
            <asp:Label AssociatedControlID="TextBoxOldPassword" Text="Old Password" CssClass="font-semibold" runat="server" />
            <asp:TextBox ID="TextBoxOldPassword" TextMode="Password" CssClass="block w-full rounded" runat="server" />
        </div>
        <div class="mb-3">
            <asp:Label AssociatedControlID="TextBoxNewPassword" Text="New Password" CssClass="font-semibold" runat="server" />
            <asp:TextBox ID="TextBoxNewPassword" TextMode="Password" CssClass="block w-full rounded" runat="server" />
        </div>
        <div class="mb-6">
            <asp:Label AssociatedControlID="TextBoxRepeatPassword" Text="Repeat New Password" CssClass="font-semibold" runat="server" />
            <asp:TextBox ID="TextBoxRepeatPassword" TextMode="Password" CssClass="block w-full rounded" runat="server" />
        </div>
        <asp:Label ID="LabelError" CssClass="mb-3 text-red-600" runat="server" />
        <asp:Button ID="ButtonChangePassword" Text="Change Password" CssClass="block w-full py-3 bg-indigo-600 text-white" OnClick="ButtonChangePassword_Click" runat="server" />
    </div>
</asp:Content>
