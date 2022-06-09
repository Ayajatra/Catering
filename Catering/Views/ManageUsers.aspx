<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="Catering.Views.ManageUsers" %>

<%@ Import Namespace="Catering.Controllers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center text-3xl text-bold">Users</h1>
    <div class="mx-auto h-0.5 w-28 rounded bg-gray-700 mt-2 mb-6"></div>

    <table class="table-auto border border-gray-600 border-collapse mx-auto">
        <thead>
            <tr class="bg-indigo-600 text-white font-semibold">
                <th class="border border-gray-500 p-2">User Id</th>
                <th class="border border-gray-500 p-2">Username</th>
                <th class="border border-gray-500 p-2">Role Name</th>
                <th class="border border-gray-500 p-2">Action</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td class="border border-gray-500 p-2"><%# Eval("UserId") %></td>
                        <td class="border border-gray-500 p-2"><%# Eval("Username") %></td>
                        <td class="border border-gray-500 p-2"><%# Eval("Role.RoleName") %></td>
                        <td class="border border-gray-500 p-2">
                            <asp:Button
                                Text="Delete"
                                OnCommand="DeleteButton_Click"
                                CommandArgument='<%# Eval("UserId") %>'
                                CssClass="px-4 py-2 bg-red-600 text-white cursor-pointer"
                                runat="server" />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
