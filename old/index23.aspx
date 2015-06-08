<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="index23.aspx.cs" Inherits="Kickstarter_web.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="jumbotron" runat="server">
    <div class="container">
        <h1>Hello, world!</h1>
        <p>This is a template for a simple marketing or informational website. It includes a large callout called a jumbotron and three supporting pieces of content. Use it as a starting point to create something more unique.</p>
        <p><a class="btn btn-primary btn-lg" href="#" role="button" id="jumbo">Learn more &raquo;</a></p>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="kick1" runat="server">
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
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="kick2" runat="server">
    <div class="thumbnail">
        <img src="http://placehold.it/800x500" alt="">
        <div class="caption">
            <h3>Feature Label</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Back Now!" class="btn btn-primary" />
                <asp:Button ID="Button2" runat="server" Text="More Info!" class="btn btn-default" />
            </p>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="kick3" runat="server">
    <div class="thumbnail">
        <img src="http://placehold.it/800x500" alt="">
        <div class="caption">
            <h3>Feature Label</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
            <p>
                <asp:Button ID="Button3" runat="server" Text="Back Now!" class="btn btn-primary" />
                <asp:Button ID="Button4" runat="server" Text="More Info!" class="btn btn-default" />
            </p>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content7" ContentPlaceHolderID="kick4" runat="server">
    <div class="thumbnail">
        <img src="http://placehold.it/800x500" alt="">
        <div class="caption">
            <h3>Feature Label</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
            <p>
                <asp:Button ID="Button5" runat="server" Text="Back Now!" class="btn btn-primary" />
                <asp:Button ID="Button6" runat="server" Text="More Info!" class="btn btn-default" />
            </p>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content6" ContentPlaceHolderID="footer" runat="server">
    <p>ICT4Events</p>
</asp:Content>
