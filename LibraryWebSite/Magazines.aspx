<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Magazines.aspx.cs" Inherits="Magazines" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Magazine Information<br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="Id" DataSourceID="SqlDataSource1" Height="50px" Width="291px" AllowPaging="True">
        <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" InsertVisible="False" />
            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" />
            <asp:BoundField DataField="ShelfClassification" HeaderText="Classification" SortExpression="ShelfClassification" />
            <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
            <asp:BoundField DataField="IS_Code" HeaderText="ISSN" SortExpression="IS_Code" />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    </asp:DetailsView>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="495px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" />
                <asp:BoundField DataField="ShelfClassification" HeaderText="Classification" SortExpression="ShelfClassification" />
                <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
                <asp:BoundField DataField="IS_Code" HeaderText="ISSN" SortExpression="IS_Code" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LibraryConnectionString1 %>" SelectCommand="SELECT * FROM [LibraryItems] WHERE ([Type] = @Type)" UpdateCommand="UPDATE [LibraryItems] SET [Type] = @Type, [State] = @State, [Author] = @Author, [Title]=@Title, [Publisher]=@Publisher, [ShelfClassification]=@ShelfClassification, [Genre]=@Genre, [IS_Code]=@IS_Code
WHERE [Id] = @Id;" DeleteCommand="DELETE FROM [LibraryItems] WHERE [Id] = @Id" InsertCommand="INSERT INTO [LibraryItems] ([Type], [State], [Author], [Title], [Publisher], [ShelfClassification], [Genre], [IS_Code]) VALUES (@Type, @State, @Author, @Title, @Publisher, @ShelfClassification, @Genre, @IS_Code)">
            <DeleteParameters>
                <asp:Parameter Name="Id" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Type" />
                <asp:Parameter Name="State" />
                <asp:Parameter Name="Author" />
                <asp:Parameter Name="Title" />
                <asp:Parameter Name="Publisher" />
                <asp:Parameter Name="ShelfClassification" />
                <asp:Parameter Name="Genre" />
                <asp:Parameter Name="IS_Code" />
            </InsertParameters>
            <SelectParameters>
                <asp:Parameter DefaultValue="Magazine" Name="Type" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Type" />
                <asp:Parameter Name="State" />
                <asp:Parameter Name="Author" />
                <asp:Parameter Name="Title" />
                <asp:Parameter Name="Publisher" />
                <asp:Parameter Name="ShelfClassification" />
                <asp:Parameter Name="Genre" />
                <asp:Parameter Name="IS_Code" />
                <asp:Parameter Name="Id" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>

