<%@ Page Title="" Language="C#" MasterPageFile="~/masters/one.master" AutoEventWireup="true" CodeBehind="allprojects.aspx.cs" Inherits="Kickstarter_web.pages.allprojects" %>
<%@ Import Namespace="Kickstarter_web.classes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="container_jumbo" runat="server">
    <h2>Alle Projecten</h2>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="container_bottom" runat="server">     
    <asp:ObjectDataSource ID="ProjectAll" runat="server" SelectMethod="GetallProject" TypeName="Kickstarter_web.Administrator"></asp:ObjectDataSource>
    
    <asp:Repeater ID="Repeater_projects" runat="server" DataSourceID="ProjectAll" OnItemCommand="Repeater_projects_ItemCommand"  >
        <SeparatorTemplate>
             <hr/>
        </SeparatorTemplate>
        <ItemTemplate>
                 <div>
                     <h2><%# Eval("Title") %></h2>
                     <table class="table">
                     <tr><td width="30%">ShortBlurb</td><%# Eval("ShortBlurb") %><td width="70%"></td></tr>          
                     <tr><td>ProjectDescription</td><td><%# Eval("ProjectDescription") %></td></tr>         
                     <tr><td>FundingDuration</td><td><%# Eval("FundingDuration") %></td></tr>        
                     <tr><td>FundingGoal</td><td><%# Eval("FundingGoal") %></td></tr>          
                     <tr><td>ProjectVideo</td><td><%# Eval("ProjectVideo") %></td></tr>     
                     <tr><td>Category</td><td><%# Eval("Category") %></td></tr>  
                     <tr><td>SubCategory</td><td><%# Eval("SubCategory") %></td></tr>    
                     <tr><td>RisksAndChallenges</td><td><%# Eval("RisksAndChallenges") %></td></tr> 
                      <tr><td>RisksAndChallenges</td><td><%# Eval("ProjectLocation") %></td></tr>         
                     <tr><td>
                         <asp:Button ID='BackProject' runat="server" Text="Back Now" UseSubmitBehavior="False" ViewStateMode="Enabled" PostBackUrl='<%# "/pages/backing.aspx?projectID"+Eval("ProjectID") %>'/></td><td>
                         <asp:TextBox ID='BackAmount' runat="server"></asp:TextBox></td></tr>     
                      </table>
                  </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
