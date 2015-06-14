<%@ Page Title="" Language="C#" MasterPageFile="~/masters/LoggedIn.master" AutoEventWireup="true" CodeBehind="addreward.aspx.cs" Inherits="Kickstarter_web.pages.addReward" %>
<asp:Content ID="Content1" ContentPlaceHolderID="container_jumbo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container_bottom" runat="server">
    <div class="row">
        <div class="col-md-8">
            <table class="table">
                <tr>
                    <td>Reward Name</td>
                    <td>
                        <asp:TextBox ID="rew_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Price</td>
                    <td>
                        <asp:TextBox ID="rew_price" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Description</td>
                    <td>
                        <asp:TextBox ID="rew_decr" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Shipping Details</td>
                    <td>
                        <asp:TextBox ID="rew_ship" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Prev Reward</td>
                    <td>
                        <asp:DropDownList ID="rew_prevreward" runat="server" DataSourceID="Rewards" DataTextField="Name" DataValueField="ThisReward"></asp:DropDownList>
                        <asp:ObjectDataSource ID="Rewards" runat="server" SelectMethod="GetAllRewards" TypeName="Kickstarter_web.Administrator">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="projectID" QueryStringField="projectID" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>
                
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="rew_button" runat="server" Text="Add Reward" OnClick="rew_button_Click" />
                    </td>
                </tr>

            </table>
        </div>
        <div class="col-md-4">
            
        </div>
      </div>
</asp:Content>
