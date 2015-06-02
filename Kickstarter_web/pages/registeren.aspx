<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registeren.aspx.cs" Inherits="Kickstarter_web.index" %>
    <!doctype html>
    <!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang=""> <![endif]-->
    <!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8" lang=""> <![endif]-->
    <!--[if IE 8]>         <html class="no-js lt-ie9" lang=""> <![endif]-->
    <!--[if gt IE 8]><!-->
    <html class="no-js" lang="">
    <!--<![endif]-->

    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <title></title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="apple-touch-icon" href="../apple-touch-icon.png">
        <link rel="stylesheet" href="../css/bootstrap.min.css">
        <style>
        body {
            padding-top: 50px;
            padding-bottom: 20px;
        }
        </style>
        <link rel="stylesheet" href="../css/bootstrap-theme.min.css">
        <link rel="stylesheet" href="../css/main.css">
        <script src="../js/vendor/modernizr-2.8.3-respond-1.4.2.min.js"></script>
    </head>

    <body>
        <form runat="server">
            <!--[if lt IE 8]>
            <p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
        <![endif]-->
            <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
                <div class="container">
                    <div class="navbar-header">
                        <a class="navbar-brand" href="#">Brand</a>
                        <ul class="nav navbar-nav navbar-left">
                            <li><a href="#">Link</a></li>
                            <li><a href="#">Link</a></li>
                            <li><a href="#">Link</a></li>
                            <li><a href="#">Link</a></li>
                        </ul>
                    </div>
                    <ul class="nav navbar-nav navbar-right">
                        <li><a href="#">Link</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false">Dropdown <span class="caret"></span></a>
                            <ul class="dropdown-menu" role="menu">
                                <form action="/" method="post">
                                    <li>
                                        <div class="input-group">
                                            <span class="input-group-addon" id="basic-addon1">@</span>
                                            <input type="text" class="form-control" placeholder="Username" aria-describedby="basic-addon1">
                                        </div>
                                    </li>
                                    <li>
                                        <div class="input-group">
                                            <input type="text" class="form-control" placeholder="Password" aria-describedby="basic-addon1">
                                        </div>
                                    </li>
                                    <li>
                                        <asp:Button ID="signin" class="btn btn-success" runat="server" Text="Sign in" />
                                    </li>
                                </form>
                                <li class="divider"></li>
                                <li>
                                    <a href="#"><input type="button" name="registeren" class="btn btn-success" value="Registreren" /></a>
                                    
                                </li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </nav>
            <div class="container">
                <!-- Page Features -->
                <div class="row text-center">
                    <div class="col-md-12 col-sm-6 ">
                        <form role="form">
                          <div class="form-group">
                            <label for="email">Email address:</label>
                            <input type="email" class="form-control" id="email">
                          </div>
                          <div class="form-group">
                            <label for="pwd">Password:</label>
                            <input type="password" class="form-control" id="pwd">
                          </div>
                          <div class="checkbox">
                            <label><input type="checkbox"> Remember me</label>
                          </div>
                          <button type="submit" class="btn btn-default">Submit</button>
                        </form>
                    </div>
                </div>
                <!-- /.row -->
                <hr>
                <footer>
                    <p>&copy; Company 2015</p>
                </footer>
            </div>
            <!-- /container -->
            <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
            <script>
                window.jQuery || document.write('<script src="../js/vendor/jquery-1.11.2.min.js"><\/script>')
            </script>
            <script src="../js/vendor/bootstrap.min.js"></script>
            <script src="../js/main.js"></script>
        </form>
    </body>

    </html>
