<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageFoods.aspx.cs" Inherits="Catering.Views.ManageFoods" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center text-3xl text-bold">Foods</h1>
    <div class="mx-auto h-0.5 w-28 rounded bg-gray-700 mt-2 mb-6"></div>

    <div class="text-center mb-3">
        <a class="px-4 py-2 rounded bg-green-600 text-white" href="~/Views/AddFood" runat="server">Add Food</a>
    </div>
    <table class="table-auto border border-gray-600 border-collapse mx-auto">
        <thead>
            <tr class="bg-indigo-600 text-white font-semibold">
                <th class="border border-gray-500 p-2">Food Id</th>
                <th class="border border-gray-500 p-2">Food Name</th>
                <th class="border border-gray-500 p-2">Food Category Name</th>
                <th class="border border-gray-500 p-2">Food Price</th>
                <th class="border border-gray-500 p-2">Food Active Status</th>
                <th class="border border-gray-500 p-2">Action</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td class="border border-gray-500 p-2"><%# Eval("FoodId") %></td>
                        <td class="border border-gray-500 p-2"><%# Eval("FoodName") %></td>
                        <td class="border border-gray-500 p-2"><%# Eval("FoodCategory.FoodCategoryName") %></td>
                        <td class="border border-gray-500 p-2"><%# Eval("FoodPrice") %></td>
                        <td class="border border-gray-500 p-2"><%# Eval("FoodActiveStatus") %></td>
                        <td class="border border-gray-500 p-2">
                            <a class="px-4 py-2 bg-yellow-400 text-white cursor-pointer" href='<%# $"/Views/EditFood?id={Eval("FoodId")}" %>' runat="server">Edit</a>
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
