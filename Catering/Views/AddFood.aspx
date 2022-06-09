<%@ Page Title="Add Food" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddFood.aspx.cs" Inherits="Catering.Views.AddFood" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mx-auto bg-gray-200 rounded py-4 px-7" style="width: 440px;">
        <h1 class="text-center text-3xl text-bold">Add Food</h1>
        <div class="mx-auto h-0.5 w-1/4 rounded bg-gray-700 mt-2 mb-4"></div>

        <div class="mb-3">
            <asp:Label AssociatedControlID="TextBoxFoodName" Text="Food Name" CssClass="font-semibold" runat="server" />
            <asp:TextBox ID="TextBoxFoodName" CssClass="block w-full rounded" runat="server" />
        </div>
        <div class="mb-3">
            <asp:Label AssociatedControlID="TextBoxFoodPrice" Text="Food Price" CssClass="font-semibold" runat="server" />
            <asp:TextBox ID="TextBoxFoodPrice" CssClass="block w-full rounded" runat="server" />
        </div>
        <div class="mb-3">
            <asp:CheckBox ID="CheckBoxFoodActiveStatus" Text=" Is Food Active" CssClass="block w-full rounded" runat="server" />
        </div>
        <div class="mb-6">
            <asp:Label AssociatedControlID="DropDownFoodCategory" Text="Food Category" CssClass="font-semibold" runat="server" />
            <asp:DropDownList ID="DropDownFoodCategory" CssClass="block w-full rounded" runat="server" />
        </div>
        <asp:Label ID="LabelError" CssClass="mb-3 text-red-600" runat="server" />
        <asp:Button ID="ButtonAdd" Text="Add" OnClick="ButtonAdd_Click" CssClass="block w-full py-3 bg-green-600 text-white" runat="server" />
    </div>

</asp:Content>
