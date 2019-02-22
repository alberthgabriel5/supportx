<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createTicket.aspx.cs" Inherits="SolutionX.createTicket" %>
<!DOCTYPE html>


<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>SUPPORT X</title>
    <!-- fonts -->
    <link href='http://fonts.googleapis.com/css?family=Raleway:400,300,500,600,700' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Roboto+Slab:400,700,300' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Playfair+Display:400,700' rel='stylesheet' type='text/css'>
    <link href='font-awesome/css/font-awesome.css' rel='stylesheet' type='text/css'>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- main css -->
    <link href="style.css" rel="stylesheet">
    <link href="responsive.css" rel="stylesheet">

    <!-- Slider -->
    <link href="css/owl.carousel.css" rel="stylesheet">
    <link href="css/owl.theme.css" rel="stylesheet">
    <link href="css/owl.transitions.css" rel="stylesheet">
    <style>
        * {
            box-sizing: border-box;
        }

        input[type=text], select, textarea {
            width: 100%;
            padding: 12px;
            border: 1px solid #ccc;
            border-radius: 4px;
            resize: vertical;
        }

        label {
            padding: 12px 12px 12px 0;
            display: inline-block;
        }

       

        .container {
            border-radius: 5px;
            background-color: #f2f2f2;
            padding: 20px;
        }

        .col-25 {
            float: left;
            width: 25%;
            margin-top: 6px;
        }

        .col-75 {
            float: left;
            width: 75%;
            margin-top: 6px;
        }

        /* Clear floats after the columns */
        .row:after {
            content: "";
            display: table;
            clear: both;
        }

        /* Responsive layout - when the screen is less than 600px wide, make the two columns stack on top of each other instead of next to each other */
        @media screen and (max-width: 600px) {
            .col-15, .col-75, input[type=submit] {
                width: 100%;
                margin-top: 0;
            }
        }
    </style>

    <!-- lightbox -->
    <link href="css/prettyPhoto.css" rel="stylesheet">
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
          <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
          <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
        <![endif]-->
</head>
<body style="background-color: #7AA4EA;">

    <form id="form1" runat="server">


    <div id="header">



        <div id="believe-nav">
            <!-- Nav -->
            <div class="container">
                <div class="min-marg">
                    <nav class="navbar navbar-default">
                        <!-- <div class="container-fluid"> -->
                        <!-- Brand and toggle get grouped for better mobile display -->
                        <div class="navbar-header">
                            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                                <span class="sr-only">Toggle navigation</span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                            </button>
                        </div>
                        <!-- Collect the nav links, forms, and other content for toggling -->
                        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                            <ul class="nav navbar-nav">
                                <li><a href="index.html">Home</a></li>
                                          <li><a href="createTicket.aspx">Create ticket</a></li>
                                          <li><a href="listTicket.aspx">List tickets</a></li>
                                <li><a href="contact.html">Contact</a></li>
                            </ul>
                        </div>
                    </nav>

                </div>
            </div>
            <!-- Nav -->

        </div>
        <!-- header -->

        <br />
        <form id="Form2" runat="server">

        <div class="container">
            <center>
                   Create ticket
                  <br /> 
               <br />
                Company name:    <input id="companyName" type="text" required="required" requiered Runat="server"/><br />
            <br />

         <br />
           Request detail:   <br />
                      <center>
                      <textArea id="detail" cols="20" name="S1" rows="1" required="required" requiered Runat="server"></textArea><br />
                      </center> 
            
           Attached file:        <input id="file" type="file" /><br>
            
                      <center>
                           <asp:Button ID="send"  Text="Send"  runat="server" OnClick="send_Click" />
                          <asp:Button ID="Reset" type="reset" value="Cancel" runat="server" OnClick="Reset_Click"/>&nbsp;</center>
        </div>

            </form>
        <br />




        <div class="footer-text">
            <div class="container">
                <p>Version 1.0. </p>
                <p>Developed by JYLAN Solution </p>
            </div>

        </div>




        <br />


    </div>
    <!-- wrapper -->
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="js/library.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/jquery.raty.js"></script>
    <script src="js/ui.js"></script>
    <script src="js/jquery.prettyPhoto.js"></script>
    <script src="js/jquery.selectbox-0.2.js"></script>
    <script src="js/theme-script.js"></script>


    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="js/library.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/jquery.raty.js"></script>
    <script src="js/ui.js"></script>
    <script src="js/jquery.prettyPhoto.js"></script>
    <script src="js/jquery.selectbox-0.2.js"></script>
    <script src="js/theme-script.js"></script>
    </form>
</body>
</html>
