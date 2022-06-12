<%@ Page Title="Order Food" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderFood.aspx.cs" Inherits="Catering.Views.OrderFood" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center text-3xl text-bold">Orders</h1>
    <div class="mx-auto h-0.5 w-32 rounded bg-gray-700 mt-2 mb-6"></div>

    <div class="text-center mb-3">
        <a class="px-4 py-2 rounded bg-green-600 text-white" href="~/Views/NewOrder" runat="server">New Order</a>
    </div>
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
                            <asp:Button
                                Text="Notify Payment"
                                OnCommand="NotifyPaymentButton_Click"
                                CommandArgument='<%# Eval("OrderHeaderId") %>'
                                Visible='<%# (int)Eval("PaymentStatusId") == 1 %>'
                                CssClass="px-4 py-2 bg-green-600 text-white cursor-pointer"
                                runat="server" />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
