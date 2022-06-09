<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Catering.Views.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mx-auto bg-gray-200 rounded py-4 px-7" style="width: 440px;">
        <h1 class="text-center text-3xl text-bold">Login</h1>
        <div class="mx-auto h-0.5 w-1/4 rounded bg-gray-700 mt-2 mb-4"></div>

        <div class="mb-3">
            <asp:Label AssociatedControlID="TextBoxUsername" Text="Username" CssClass="font-semibold" runat="server" />
            <asp:TextBox ID="TextBoxUsername" CssClass="block w-full rounded" runat="server" />
        </div>
        <div class="mb-6">
            <asp:Label AssociatedControlID="TextBoxPassword" Text="Password" CssClass="font-semibold" runat="server" />
            <asp:TextBox ID="TextBoxPassword" TextMode="Password" CssClass="block w-full rounded" runat="server" />
        </div>
        <asp:Label ID="LabelError" CssClass="mb-3 text-red-600" runat="server" />
        <asp:Button ID="ButtonLogin" Text="Login" CssClass="block w-full py-3 bg-indigo-600 text-white" OnClick="ButtonLogin_Click" runat="server" />
    </div>

</asp:Content>
