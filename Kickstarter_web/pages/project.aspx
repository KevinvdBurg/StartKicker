<%@ Page Title="" Language="C#" MasterPageFile="~/masters/one.master" AutoEventWireup="true" CodeBehind="project.aspx.cs" Inherits="Kickstarter_web.pages.project" %>
<asp:Content ID="Content1" ContentPlaceHolderID="container_jumbo" runat="server">
    <h2>Project Info</h2>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container_bottom" runat="server">
    
    <asp:ObjectDataSource ID="aProject" runat="server" SelectMethod="GetProject" TypeName="Kickstarter_web.Administrator">
        <SelectParameters>
                <asp:QueryStringParameter  QueryStringField="projectID" Name="projectID" Type="Int32" />
            </SelectParameters>
    </asp:ObjectDataSource>
    
    <asp:Repeater ID="Repeater_aproject" runat="server" DataSourceID="aProject" >
        <SeparatorTemplate>
             <hr/>
        </SeparatorTemplate>
        <ItemTemplate>
                 <div>
                     <asp:HiddenField ID="BackProject" runat="server" Value=<%# Eval("ProjectID") %>/>
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
                         <asp:Button ID="BackNow" runat="server" Text="BackNow"  ViewStateMode="Enabled" OnClick="backProject" EnableViewState="true" /></td><td>
                         <asp:TextBox ID="BackValue" runat="server" EnableViewState="true" TextMode="Number"></asp:TextBox>
                      </table>
                  </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
