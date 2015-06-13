<%@ Page Title="" Language="C#" MasterPageFile="~/masters/one.master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Kickstarter_web.index2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="container_jumbo" runat="server">
    <h1>Hello, world!</h1>
    <p>This is a template for a simple marketing or informational website. It includes a large callout called a jumbotron and three supporting pieces of content. Use it as a starting point to create something more unique.</p>
    <p><a class="btn btn-primary btn-lg" href="#" role="button" id="jumbo">Learn more &raquo;</a></p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container_bottom" runat="server">
    <div class="row text-center">
                    <div class="col-md-3 col-sm-6 hero-feature">
                        <div class="thumbnail">
                            <img src="http://placehold.it/800x500" alt="">
                            <div class="caption">
                                <h3>Feature Label</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
                                <p>
                                    <asp:Button ID="backNow1" runat="server" Text="Back Now!" class="btn btn-primary" />
                                    <asp:Button ID="info1" runat="server" Text="More Info!" class="btn btn-default" />
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 hero-feature">
                        <div class="thumbnail">
                            <img src="http://placehold.it/800x500" alt="">
                            <div class="caption">
                                <h3>Feature Label</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
                                <p>
                                    <asp:Button ID="backNow2" runat="server" Text="Back Now!" class="btn btn-primary" />
                                    <asp:Button ID="info2" runat="server" Text="More Info!" class="btn btn-default" />
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 hero-feature">
                        <div class="thumbnail">
                            <img src="http://placehold.it/800x500" alt="">
                            <div class="caption">
                                <h3>Feature Label</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
                                <p>
                                    <asp:Button ID="backNow3" runat="server" Text="Back Now!" class="btn btn-primary" />
                                    <asp:Button ID="info3" runat="server" Text="More Info!" class="btn btn-default" />
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 hero-feature">
                        <div class="thumbnail">
                            <img src="http://placehold.it/800x500" alt="">
                            <div class="caption">
                                <h3>Feature Label</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
                                <p>
                                    <asp:Button ID="backNow4" runat="server" Text="Back Now!" class="btn btn-primary" />
                                    <asp:Button ID="info4" runat="server" Text="More Info!" class="btn btn-default" />
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
</asp:Content>
