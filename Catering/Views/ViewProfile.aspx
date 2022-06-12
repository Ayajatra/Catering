<%@ Page Title="View Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="Catering.Views.ViewProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center text-3xl text-bold">Profile</h1>
    <div class="mx-auto h-0.5 w-28 rounded bg-gray-700 mt-2 mb-6"></div>

    <%
        Catering.Models.User user = (Catering.Models.User)Session["user"];
    %>
    <div class="text-center">
        <span class="font-semibold">Username: </span>
        <span><%= user.Username %></span>
    </div>
    <div class="text-center">
        <span class="font-semibold">Password: </span>
        <span><%= new string('*', user.UserPassword.Length) %></span>
    </div>
    <div class="text-center">
        <a href="~/Views/ChangePassword" class="underline text-blue-500" runat="server">Change Password</a>
    </div>
</asp:Content>
