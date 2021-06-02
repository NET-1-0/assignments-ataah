<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HospitalGridView.aspx.cs" Inherits="gridViewExample.HospitalGridView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="lblShow" runat="server" Text="Label"></asp:Label>

    <asp:GridView ID="gvHospital" runat="server" AutoGenerateColumns="False" DataKeyNames="id" OnRowCancelingEdit="gvHospital_RowCancelingEdit" OnRowDeleting="gvHospital_RowDeleting" OnRowEditing="gvHospital_RowEditing" OnRowUpdating="gvHospital_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="id" InsertVisible="False" SortExpression="id">
                <EditItemTemplate>
                    <asp:Label ID="lblID" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblID" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="name" SortExpression="name">
                <EditItemTemplate>
                    <asp:TextBox ID="txtName" runat="server" Text='<%# Eval("name") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="city" SortExpression="city">
                <EditItemTemplate>
                    <asp:TextBox ID="txtCity" runat="server" Text='<%# Eval("city") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblCity" runat="server" Text='<%# Eval("city") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Actions" SortExpression="Actions">
                <EditItemTemplate>
                    <asp:ImageButton ID="btnUpdate" runat="server" CommandName="Update" ImageUrl="~/Images/update.ico" Width="20px" />
                    <asp:ImageButton ID="btnCancel" runat="server" CommandName="Cancel" ImageUrl="~/Images/cncl.ico" Width="20px" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:ImageButton ID="btnEdit" runat="server" CommandName="Edit" ImageUrl="~/Images/edit.ico" Width="20px" />
                    <asp:ImageButton ID="btnDelete" runat="server" CommandName="Delete" ImageUrl="~/Images/delete.ico" Width="20px" />
                </ItemTemplate>
                <HeaderStyle BackColor="Tomato" ForeColor="White" />
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
