<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MusicItems.aspx.cs" Inherits="MusicItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    Information of Music Items<br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" />
            <asp:BoundField DataField="ShelfClassification" HeaderText="Classification" SortExpression="ShelfClassification" />
            <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
            <asp:BoundField DataField="IS_Code" HeaderText="ISRC" SortExpression="IS_Code" />
        </Columns>
    </asp:GridView>
        <hr />
<p>
        State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListState" runat="server" AutoPostBack="True" Width="127px">
            <asp:ListItem>Free</asp:ListItem>
            <asp:ListItem>Borrowed</asp:ListItem>
            <asp:ListItem>Maintenance</asp:ListItem>
            <asp:ListItem>Reserved</asp:ListItem>
            <asp:ListItem>ReadingRoom</asp:ListItem>
            <asp:ListItem>Removed</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Author&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxAuthor" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxTitle" runat="server" style="margin-bottom: 0px"></asp:TextBox>
    </p>
<p>
        Publisher&nbsp;&nbsp; <asp:TextBox ID="TextBoxPublisher" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Classification&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxClassification" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Genre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxGenre" runat="server"></asp:TextBox>
    </p>
<p>
        ISRC &nbsp;&nbsp;&nbsp; &nbsp;&nbsp; <asp:TextBox ID="TextBoxISRC" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;</p>
<hr />
    <p>
        <asp:Button ID="ButtonUpdate" runat="server" Text="Update" OnClick="ButtonUpdate_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonInsert" runat="server" OnClick="ButtonInsert_Click" Text="Insert" />
    </p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LibraryConnectionString1 %>" DeleteCommand="DELETE FROM [LibraryItems] WHERE [Id] = @Id" InsertCommand="INSERT INTO [LibraryItems] ([Type], [State], [Author], [Title], [Publisher], [ShelfClassification], [Genre], [IS_Code]) VALUES (@Type, @State, @Author, @Title, @Publisher, @ShelfClassification, @Genre, @IS_Code)" SelectCommand="SELECT * FROM [LibraryItems] WHERE ([Type] = @Type)" UpdateCommand="UPDATE [LibraryItems] SET [Type] = @Type, [State] = @State, [Author] = @Author, [Title] = @Title, [Publisher] = @Publisher, [ShelfClassification] = @ShelfClassification, [Genre] = @Genre, [IS_Code] = @IS_Code WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Type" Type="String" />
            <asp:Parameter Name="State" Type="String" />
            <asp:Parameter Name="Author" Type="String" />
            <asp:Parameter Name="Title" Type="String" />
            <asp:Parameter Name="Publisher" Type="String" />
            <asp:Parameter Name="ShelfClassification" Type="String" />
            <asp:Parameter Name="Genre" Type="String" />
            <asp:Parameter Name="IS_Code" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:Parameter DefaultValue="Music" Name="Type" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="Type" Type="String" />
            <asp:Parameter Name="State" Type="String" />
            <asp:Parameter Name="Author" Type="String" />
            <asp:Parameter Name="Title" Type="String" />
            <asp:Parameter Name="Publisher" Type="String" />
            <asp:Parameter Name="ShelfClassification" Type="String" />
            <asp:Parameter Name="Genre" Type="String" />
            <asp:Parameter Name="IS_Code" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
&nbsp;
</asp:Content>

