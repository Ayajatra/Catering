<%@ Page Title="Manage Orders" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageOrders.aspx.cs" Inherits="Catering.Views.ManageOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center text-3xl text-bold">Order Headers</h1>
    <div class="mx-auto h-0.5 w-52 rounded bg-gray-700 mt-2 mb-6"></div>

    <table class="table-auto border border-gray-600 border-collapse mx-auto">
        <thead>
            <tr class="bg-indigo-600 text-white font-semibold">
                <th class="border border-gray-500 p-2">Order Id</th>
                <th class="border border-gray-500 p-2">Username</th>
                <th class="border border-gray-500 p-2">Payment Status</th>
                <th class="border border-gray-500 p-2">Order Status</th>
                <th class="border border-gray-500 p-2">Order Date</th>
                <th class="border border-gray-500 p-2">Action</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td class="border border-gray-500 p-2"><%# Eval("OrderHeaderId") %></td>
                        <td class="border border-gray-500 p-2"><%# Eval("User.Username") %></td>
                        <td class="border border-gray-500 p-2"><%# Eval("PaymentStatus.PaymentStatusName") %></td>
                        <td class="border border-gray-500 p-2"><%# Eval("OrderStatus.OrderStatusName") %></td>
                        <td class="border border-gray-500 p-2"><%# Eval("OrderDate") %></td>
                        <td class="border border-gray-500 p-2">
                            <a class="underline text-blue-500 cursor-pointer" href='<%# $"/Views/ManageOrderDetails?id={Eval("OrderHeaderId")}" %>' runat="server">View Details</a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
