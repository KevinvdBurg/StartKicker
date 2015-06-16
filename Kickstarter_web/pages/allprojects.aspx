<%@ Page Title="" Language="C#" MasterPageFile="~/masters/one.master" AutoEventWireup="true" CodeBehind="allprojects.aspx.cs" Inherits="Kickstarter_web.pages.allprojects" %>
<%@ Import Namespace="Kickstarter_web.classes" %>
<%@ Import Namespace="Kickstarter_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="container_jumbo" runat="server">
    <h2>All Projecten</h2>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="container_bottom" runat="server">     
    <asp:ObjectDataSource ID="ProjectAll" runat="server" SelectMethod="GetallProject" TypeName="Kickstarter_web.Administrator"></asp:ObjectDataSource>
    <asp:Literal ID="NoRecords" runat="server"></asp:Literal>
    <asp:Repeater ID="Repeater_projects" runat="server" DataSourceID="ProjectAll" OnPreRender="Repeater_projects_PreRender"  >
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
                     <tr><td>
                         <asp:Button ID='BackProject' runat="server" Text="More Info"  ViewStateMode="Enabled" PostBackUrl='<%# "/pages/project.aspx?projectID=" + Eval("ProjectID") %>'/></td><td>
                      </table>
                  </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
