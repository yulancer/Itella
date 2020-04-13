<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AddBook.aspx.cs" Inherits="AddBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
    <asp:FormView runat="server" ID="addBookForm" HeaderText="Добавление новой книги"
                  ItemType="Itella.Database.Entities.Book" 
                  InsertMethod="Insert" DefaultMode="Insert"
                  RenderOuterTable="false" OnItemInserted="addBookForm_OnItemInserted">
        <InsertItemTemplate>
            <fieldset name="Новая книга">
                <ol>
                    <asp:DynamicEntity runat="server" Mode="Insert" />
                </ol>
                <asp:Button runat="server" Text="Добавить" CommandName="Insert" />
                <asp:Button runat="server" Text="Отмена" CausesValidation="false" OnClick="OnCancelClick" />
            </fieldset>
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>

