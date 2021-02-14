<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="searchGroup.aspx.cs" Inherits="TFMProject.searchGroup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-8">
            <asp:Panel ID="PanelErrorResult" Visible="false" runat="server" CssClass="alert alert-dismissable alert-danger">
            <button type="button" class="close" data-dismiss="alert">
                <span aria-hidden="true">&times;</span>
            </button>
            <asp:Label ID="Lbl_err" runat="server"></asp:Label>
            </asp:Panel>
            <div class="panel panel-info">
                <div class="panel-heading">
                    <h3 class="panel-title">Search</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:Label ID="lb_grpId" runat="server" Text="Group Id:"></asp:Label>
                        <asp:TextBox ID="tb_grpId" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnGetGroups" runat="server" CssClass="btn btn-default" Text="Get" OnClick="btnGetGroup_Click" />
                </div>
            </div>
            <asp:Panel ID="PanelCust" Visible="false" runat="server">
                <div class="panel panel-info">
                    <div class="panel-heading">Results:</div>
                    <div class="panel-body">
                        <div class="row">
                            <label for="lb_groupId" class="col-sm-2 col-form-label">Id :</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lb_id" runat="server"></asp:Label>
                            </div>
                            <label for="Lbl_name" class="col-sm-2 col-form-label">Name:</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lb_name" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <label for="Lbl_description" class="col-sm-2 col-form-label">Description:</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lb_description" runat="server"></asp:Label>
                            </div>
                            <label for="Lbl_createdAt" class="col-sm-2 col-form-label">Created At:</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lb_createdAt" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <label for="Lbl_deleted" class="col-sm-2 col-form-label">Deleted:</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lb_deleted" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>