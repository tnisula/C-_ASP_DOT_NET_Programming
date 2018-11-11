<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    All items in the library database
    <br />
<br />
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="Id">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="ShelfClassification" HeaderText="Classification" SortExpression="ShelfClassification" />
            <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
            <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" />
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="IS_Code" HeaderText="IS Code" SortExpression="IS_Code" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LibraryConnectionString1 %>" DeleteCommand="DELETE FROM [LibraryItems] WHERE [Id] = @Id" InsertCommand="INSERT INTO [LibraryItems] ([Id], [Type], [State], [Title], [ShelfClassification], [Genre], [Publisher], [Author], [IS_Code]) VALUES (@Id, @Type, @State, @Title, @ShelfClassification, @Genre, @BorrowDate, @Publisher, @Author, @IS_Code)" SelectCommand="SELECT [Id], [Type], [State], [Title], [ShelfClassification], [Genre], [Publisher], [Author], [IS_Code] FROM [LibraryItems]" UpdateCommand="UPDATE [LibraryItems] SET [Type] = @Type, [State] = @State, [Title] = @Title, [ShelfClassification] = @ShelfClassification, [Genre] = @Genre, [Publisher] = @Publisher, [Author] = @Author, [IS_Code] = @IS_Code WHERE [Id] = @Id">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Id" Type="Int32" />
        <asp:Parameter Name="Type" Type="String" />
        <asp:Parameter Name="State" Type="String" />
        <asp:Parameter Name="Title" Type="String" />
        <asp:Parameter Name="ShelfClassification" Type="String" />
        <asp:Parameter Name="Genre" Type="String" />
        <asp:Parameter Name="BorrowDate" />
        <asp:Parameter Name="Publisher" Type="String" />
        <asp:Parameter Name="Author" Type="String" />
        <asp:Parameter Name="IS_Code" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Type" Type="String" />
        <asp:Parameter Name="State" Type="String" />
        <asp:Parameter Name="Title" Type="String" />
        <asp:Parameter Name="ShelfClassification" Type="String" />
        <asp:Parameter Name="Genre" Type="String" />
        <asp:Parameter Name="Publisher" Type="String" />
        <asp:Parameter Name="Author" Type="String" />
        <asp:Parameter Name="IS_Code" Type="String" />
        <asp:Parameter Name="Id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
    <br />
    Title contains&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxTitle" runat="server" OnTextChanged="TextBoxTitle_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" Width="145px" />
<br />
<br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnDataBinding="TextBoxTitle_TextChanged" DataKeyNames="Id" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" />
            <asp:BoundField DataField="ShelfClassification" HeaderText="Classification" SortExpression="ShelfClassification" />
            <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
            <asp:BoundField DataField="IS_Code" HeaderText="IS Code" SortExpression="IS_Code" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:LibraryConnectionString1 %>" SelectCommand="spSelectItemByTitle" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="TextBoxTitle" Name="param1" PropertyName="Text" Type="String" DefaultValue="" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
<br />
</asp:Content>

