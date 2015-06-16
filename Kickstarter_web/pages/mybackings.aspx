<%@ Page Title="" Language="C#" MasterPageFile="~/masters/LoggedIn.master" AutoEventWireup="true" CodeBehind="mybackings.aspx.cs" Inherits="Kickstarter_web.pages.mybackings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="container_jumbo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container_bottom" runat="server">
    <asp:ObjectDataSource ID="MyBackings" runat="server" SelectMethod="GetMyBackings" TypeName="Kickstarter_web.Administrator">
        <SelectParameters>
            <asp:SessionParameter Name="accountID" SessionField="accountID" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:Literal ID="NoRecords" runat="server"></asp:Literal>
    <asp:Repeater ID="Repeater_Backings" runat="server" DataSourceID="MyBackings" OnPreRender="Repeater_Backings_PreRender"  >
        <SeparatorTemplate>
             <hr/>
        </SeparatorTemplate>
        <ItemTemplate>
                 <div>
                     <h2>Backing for <%# Eval("ProjectID.Title") %></h2>
                     <table class="table">        
                     <tr><td>ProjectDescription</td><td><%# Eval("ProjectID.ProjectDescription") %></td></tr>   
                      <tr><td>Plegde Amount</td><td><%# Eval("PledgeAmount") %></td></tr>                
                     <tr><td>
                         <asp:Button ID='BackProject' runat="server" Text="To Project Page"  ViewStateMode="Enabled" PostBackUrl='<%# "/pages/project.aspx?projectID=" + Eval("ProjectID.ProjectID") %>'/></td><td>
                      </table>
                  </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
