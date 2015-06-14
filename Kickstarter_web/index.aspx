<%@ Page Title="" Language="C#" MasterPageFile="~/masters/one.master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Kickstarter_web.index2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="container_jumbo" runat="server">
    <h1>StartKicker</h1>
    <p></p>
    <p><a class="btn btn-primary btn-lg" href="/pages/allprojects.aspx" role="button" id="jumbo">To the Projects &raquo;</a></p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container_bottom" runat="server">
    <div class="row text-center">
            <asp:ObjectDataSource ID="randProject" runat="server" SelectMethod="Get4RandomProject" TypeName="Kickstarter_web.Administrator">
            </asp:ObjectDataSource>
            <asp:Repeater ID="Repeater_randProject" runat="server" DataSourceID="randProject" >
                <ItemTemplate>
                    <div class="col-md-3 col-sm-6 hero-feature">
                        <div class="thumbnail">
                            
                           <%-- Not Seems to work :( <iframe id="player" type="text/html" width="100%" height="100%"
                              src="<%# Eval("ProjectVideo") %>"
                              frameborder="0"></iframe>--%>
                          
                            <%--<img src="http://placehold.it/800x500" alt="">--%>
                            <div class="caption">
                                <h3><%# Eval("Title") %></h3>
                                <p><%# Eval("ShortBlurb") %></p>
                                <p>
                                    <asp:Button ID="info1" runat="server" Text="More Info!" class="btn btn-default" PostBackUrl='<%# "/pages/project.aspx?projectID="+Eval("ProjectID") %>'/>
                                </p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
    </div>
</asp:Content>
