<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Books.aspx.cs" Inherits="Books" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    Books Information<br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" />
            <asp:BoundField DataField="ShelfClassification" HeaderText="Classification" SortExpression="ShelfClassification" />
            <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
            <asp:BoundField DataField="IS_Code" HeaderText="ISBN" SortExpression="IS_Code" />
        </Columns>
    </asp:GridView>
    <p>
        ID&nbsp;
        <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="ButtonSelect" runat="server" Text="Select" OnClick="ButtonSelect_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <hr />
<p>
        &nbsp;State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListState" runat="server" AutoPostBack="True" Width="127px">
            <asp:ListItem>Free</asp:ListItem>
            <asp:ListItem>Borrowed</asp:ListItem>
            <asp:ListItem>Maintenance</asp:ListItem>
            <asp:ListItem>Reserved</asp:ListItem>
            <asp:ListItem>ReadingRoom</asp:ListItem>
            <asp:ListItem>Removed</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Author&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxAuthor" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxTitle" runat="server" style="margin-bottom: 0px"></asp:TextBox>
    </p>
<p>
        Publisher&nbsp;&nbsp; <asp:TextBox ID="TextBoxPublisher" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Classification&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxClassification" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Genre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxGenre" runat="server"></asp:TextBox>
    </p>
<p>
        ISBN&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBoxISBN" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;</p>
<hr />
    <p>
        <asp:Button ID="ButtonUpdate" runat="server" Text="Update" OnClick="ButtonUpdate_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonInsert" runat="server" OnClick="ButtonInsert_Click" Text="Insert" />
    </p>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LibraryConnectionString1 %>" SelectCommand="SELECT * FROM [LibraryItems] WHERE ([Type] = @Type)">
        <SelectParameters>
            <asp:Parameter DefaultValue="Book" Name="Type" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

