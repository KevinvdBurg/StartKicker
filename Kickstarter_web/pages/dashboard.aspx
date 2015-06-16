<%@ Page Title="" Language="C#" MasterPageFile="~/masters/LoggedIn.master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="Kickstarter_web.pages.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="container_jumbo" runat="server">
    
    <h1>Dashboard</h1>
    <asp:Label ID="Gebruiker_ID" runat="server" Text="Label"></asp:Label>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container_bottom" runat="server">

    <asp:ObjectDataSource ID="myProjects" runat="server" SelectMethod="GetallFromAccountProjects" TypeName="Kickstarter_web.Administrator">
        <SelectParameters>
            <asp:SessionParameter Name="accountID" SessionField="accountID" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:Literal ID="NoRecords" runat="server"></asp:Literal>
    <asp:Repeater ID="Repeater_projects" runat="server" DataSourceID="myProjects" OnPreRender="Repeater_projects_PreRender">
        <SeparatorTemplate>
             <hr/>
        </SeparatorTemplate>
        <ItemTemplate>
                 <div>
                     <h2><%# Eval("Title") %></h2>
                     <table class="table">
                     <tr><td width="30%">ShortBlurb</td><td width="70%"><%# Eval("ShortBlurb") %></td></tr>          
                     <tr><td>ProjectDescription</td><td><%# Eval("ProjectDescription") %></td></tr>         
                     <tr><td>FundingDuration</td><td><%# Eval("FundingDuration") %></td></tr>        
                     <tr><td>FundingGoal</td><td><%# Eval("FundingGoal") %></td></tr>          
                     <tr><td>ProjectVideo</td><td><%# Eval("ProjectVideo") %></td></tr>     
                     <tr><td>Category</td><td><%# Eval("Category.Name") %></td></tr>  
                     <!--tr><td>SubCategory</td><td><%# Eval("SubCategory") %></td></tr-->    
                     <tr><td>RisksAndChallenges</td><td><%# Eval("RisksAndChallenges") %></td></tr> 
                     <tr><td>Location</td><td><%# Eval("ProjectLocation") %></td></tr>
                         <tr>
                             <td><asp:Button ID='AddReward' runat="server" Text="Add Reward"  ViewStateMode="Enabled" PostBackUrl='<%# "/pages/addreward.aspx?projectID=" + Eval("ProjectID") %>'/></td>
                             <td><asp:Button ID='BackProject' runat="server" Text="ProductPage"  ViewStateMode="Enabled" PostBackUrl='<%# "/pages/project.aspx?projectID=" + Eval("ProjectID") %>'/></td>
                         </tr>        
                      </table>
                  </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
