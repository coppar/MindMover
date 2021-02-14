<%@ Page Language="C#" MasterPageFile="~/StudentDashboard.Master" AutoEventWireup="true" CodeBehind="addGroup.aspx.cs" Inherits="TFMProject.addGroup" %>
<asp:Content ID="StudentBodyContent" ContentPlaceHolderID="StudentBodyContent" runat="server">
    <div>
    <h3>Create Group</h3>
    <table style="width:100%;">
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Name:</td>
            <td>
                <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Description:</td>
            <td>
                <asp:TextBox ID="tbDesc" runat="server"></asp:TextBox>
            </td>
        </tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="77px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>
                <asp:Label ID="lbMsg" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    </div>
</asp:Content>
