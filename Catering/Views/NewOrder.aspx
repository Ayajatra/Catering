<%@ Page Title="New Order" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewOrder.aspx.cs" Inherits="Catering.Views.NewOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center text-3xl text-bold">New Order</h1>
    <div class="mx-auto h-0.5 w-40 rounded bg-gray-700 mt-2 mb-6"></div>

    <div class="text-center mb-6">
        <asp:Button
            ID="ButtonOrder"
            Text="Finalize Order"
            OnClick="ButtonOrder_Click"
            CssClass="px-4 py-2 bg-green-600 text-white cursor-pointer"
            runat="server" />
        <asp:Label ID="LabelError" CssClass="text-red-600" runat="server" />
    </div>
    <div class="text-center mb-2">
        <asp:DropDownList ID="DropDownFood" CssClass="rounded" runat="server" />
        <asp:Button
            ID="ButtonAdd"
            Text="Add"
            OnClick="ButtonAdd_Click"
            CssClass="px-4 py-2 bg-cyan-600 text-white cursor-pointer"
            runat="server" />
    </div>
    <table class="table-auto border border-gray-600 border-collapse mx-auto">
        <thead>
            <tr class="bg-indigo-600 text-white font-semibold">
                <th class="border border-gray-500 p-2">Food Name</th>
                <th class="border border-gray-500 p-2">Quantity</th>
                <th class="border border-gray-500 p-2">Action</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td class="border border-gray-500 p-2"><%# Eval("Food.FoodName") %></td>
                        <td class="border border-gray-500 p-2">
                            <asp:Button
                                Text="-"
                                OnCommand="ReduceQuantity_Click"
                                CommandArgument='<%# Eval("FoodId") %>'
                                CssClass="px-2 py-1 border-2 border-gray-500 cursor-pointer"
                                runat="server" />
                            <span class="px-2 py-1 inline-block -mx-1 border-2 border-gray-500"><%# Eval("FoodQuantity") %></span>
                            <asp:Button
                                Text="+"
                                OnCommand="AddQuantity_Click"
                                CommandArgument='<%# Eval("FoodId") %>'
                                CssClass="px-2 py-1 border-2 border-gray-500 cursor-pointer"
                                runat="server" />
                        </td>
                        <td class="border border-gray-500 p-2">
                            <asp:Button
                                Text="Delete"
                                OnCommand="DeleteButton_Click"
                                CommandArgument='<%# Eval("FoodId") %>'
                                CssClass="px-4 py-2 bg-red-600 text-white cursor-pointer"
                                runat="server" />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
