<%@ Page Title="" Language="C#" MasterPageFile="~/masters/LoggedIn.master" AutoEventWireup="true" CodeBehind="makeproject.aspx.cs" Inherits="Kickstarter_web.pages.makeproject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="container_jumbo" runat="server">
    <h2>Maak Project</h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container_bottom" runat="server">
    <div class="row">
        <div class="col-md-8">
            <table class="table">
                <tr>
                    <td>Title</td>
                    <td>
                        <asp:TextBox ID="proj_title" runat="server"></asp:TextBox>
                        <asp:CustomValidator ID="CustomValidatorproj_title" runat="server" ControlToValidate="proj_title" ValidateEmptyText="true" ErrorMessage="CustomValidator" Display="Dynamic" OnServerValidate="CustomValidatorproj_title_OnServerValidate" ShowSummary="true"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>Short Blurb</td>
                    <td>
                        <asp:TextBox ID="proj_blurb" runat="server" MaxLength="150" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Category</td>
                    <td>
                        <asp:TextBox ID="proj_category" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Sub Category</td>
                    <td>
                        <asp:TextBox ID="proj_subcategory" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Location</td>
                    <td>
                        <asp:TextBox ID="proj_location" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Funding Duration</td>
                    <td>
                        <asp:TextBox ID="proj_funding_duration" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Funding Goal</td>
                    <td>
                        <asp:TextBox ID="proj_funding_goal" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Video</td>
                    <td>
                        <asp:TextBox ID="proj_video" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Discription</td>
                    <td>
                        <asp:TextBox ID="proj_disc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Risks and Chalenges</td>
                    <td>
                        <asp:TextBox ID="proj_riskcha" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="proj_button" runat="server" Text="Button" OnClick="proj_button_Click" />
                    </td>
                </tr>

            </table>
        </div>
        <div class="col-md-4">
            <asp:Literal ID="proj_message" runat="server"></asp:Literal>
        </div>
      </div>

</asp:Content>
