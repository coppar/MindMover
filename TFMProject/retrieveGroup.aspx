<%@ Page Language="C#" MasterPageFile="~/StudentDashboard.master" AutoEventWireup="true" CodeBehind="retrieveGroup.aspx.cs" Inherits="TFMProject.retrieveGroup" %>
<asp:Content ID="StudentBodyContent" ContentPlaceHolderID="StudentBodyContent" runat="server">
    <h3>Group List</h3>
    <asp:GridView ID="gvGroup" runat="server" AutoGenerateColumns="False" CellPadding="0" CssClass="myDatagrid">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Id" ReadOnly="True" />
            <asp:BoundField DataField="name" HeaderText="Name" ReadOnly="True" />
            <asp:BoundField DataField="description" HeaderText="Description" ReadOnly="True" />
            <asp:BoundField DataField="createdAt" HeaderText="Created At" ReadOnly="True" />
            <asp:BoundField DataField="deleted" HeaderText="Deleted" ReadOnly="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
