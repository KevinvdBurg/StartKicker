<%@ Page Title="" Language="C#" MasterPageFile="~/masters/one.master" AutoEventWireup="true" CodeBehind="sign_up.aspx.cs" Inherits="Kickstarter_web.pages.sign_up" %>
<%@ Import Namespace="System.Web.UI.WebControls.WebParts" %>
<%@ Import Namespace="System.Web.UI" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls.Expressions" %>
<%@ Import Namespace="System.Web.DynamicData" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="container_jumbo" runat="server">
    <h2>Registreren</h2>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container_bottom" runat="server">
    <div class="row">
        <div class="col-md-8">
            <table class="table">
                <tr>
                    <td>Name*</td>
                    <td>
                        <asp:TextBox ID="regi_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email*</td>
                    <td>
                        <asp:TextBox ID="regi_email" runat="server" TextMode="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Wachtwoord*</td>
                    <td>
                        <asp:TextBox ID="regi_wachtwoord" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Telefoon</td>
                    <td>
                        <asp:TextBox ID="regi_tele" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Biograpie</td>
                    <td>
                        <asp:TextBox ID="regi_bio" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Locatie</td>
                    <td>
                        <asp:TextBox ID="regi_loc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Tijdzone</td>
                    <td>
                        <asp:TextBox ID="regi_tijd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>URL</td>
                    <td>
                        <asp:TextBox ID="regi_url" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>*Mandatory</td>
                    <td>
                        <asp:Button ID="regi_button" runat="server" Text="Registeren" CssClass="btn btn-default" OnClick="regi_button_Click"/>
                    </td>
                </tr>
            </table>
        </div>
        <div class="col-md-4">
            <asp:Literal ID="message" runat="server"></asp:Literal>
        </div>
      </div>
</asp:Content>
