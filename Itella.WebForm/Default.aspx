﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Книги библиотеки</h1>
        <asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
        <asp:HyperLink NavigateUrl="AddBook.aspx" Text="Добавить новую книгу" runat="server" />
        <br/>
        <asp:Label runat="server">Фильтр по вхождению в название</asp:Label>
        <asp:TextBox runat="server" ID="nameFilter"></asp:TextBox>
        <asp:GridView ID="GridView" runat="server" 
                      ItemType="Itella.Database.Entities.Book"
                      SelectMethod="SelectBook"
                      UpdateMethod="Update"
                      DeleteMethod="Delete"
                      DataKeyNames="Id"
                      AutoGenerateColumns="False"
                      AutoGenerateEditButton="true"
                      AutoGenerateDeleteButton="true" 
                      AllowSorting="True"
                      AllowPaging="True" PageSize="25">
            <Columns>
                <asp:DynamicField DataField="Id" ReadOnly="True"/>
                <asp:DynamicField DataField="Name" HeaderText="Наименование"/>
                <asp:DynamicField DataField="PageCount" HeaderText="Количество страниц"/>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
