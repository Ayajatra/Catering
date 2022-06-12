<%@ Page Title="Manage Order Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageOrderDetails.aspx.cs" Inherits="Catering.Views.ManageOrderDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center text-3xl text-bold">Order Details</h1>
    <div class="mx-auto h-0.5 w-52 rounded bg-gray-700 mt-2 mb-6"></div>

    <div class="mx-auto bg-gray-200 rounded py-4 px-7" style="width: 440px;">
        <div class="mb-3">
            <asp:Label AssociatedControlID="TextBoxOrderHeaderId" Text="Order Header Id" CssClass="font-semibold" runat="server" />
            <asp:TextBox ID="TextBoxOrderHeaderId" Enabled="false" CssClass="block w-full rounded bg-gray-200" runat="server" />
        </div>
        <div class="mb-3">
            <asp:Label AssociatedControlID="TextBoxUsername" Text="Username" CssClass="font-semibold" runat="server" />
            <asp:TextBox ID="TextBoxUsername" Enabled="false" CssClass="block w-full rounded bg-gray-200" runat="server" />
        </div>
        <div class="mb-3">
            <asp:Label AssociatedControlID="TextBoxOrderDate" Text="Order Date" CssClass="font-semibold" runat="server" />
            <asp:TextBox ID="TextBoxOrderDate" Enabled="false" CssClass="block w-full rounded bg-gray-200" runat="server" />
        </div>
        <div class="mb-3">
            <asp:Label AssociatedControlID="DropDownPaymentStatus" Text="Payment Status" CssClass="font-semibold" runat="server" />
            <asp:DropDownList ID="DropDownPaymentStatus" CssClass="block w-full rounded" runat="server" />
        </div>
        <div class="mb-6">
            <asp:Label AssociatedControlID="DropDownListOrderStatus" Text="Order Status" CssClass="font-semibold" runat="server" />
            <asp:DropDownList ID="DropDownListOrderStatus" CssClass="block w-full rounded" runat="server" />
        </div>
        <asp:Button ID="ButtonUpdate" Text="Update" OnClick="ButtonUpdate_Click" CssClass="block w-full py-3 bg-yellow-400 text-white" runat="server" />
    </div>
    <table class="border border-gray-600 border-collapse mx-auto mt-2" style="width: 440px;">
        <thead>
            <tr class="bg-indigo-600 text-white font-semibold">
                <th class="border border-gray-500 p-2">Food Name</th>
                <th class="border border-gray-500 p-2">Quantity</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td class="border border-gray-500 p-2"><%# Eval("Food.FoodName") %></td>
                        <td class="border border-gray-500 p-2"><%# Eval("FoodQuantity") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
