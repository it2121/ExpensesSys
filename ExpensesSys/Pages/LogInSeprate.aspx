<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogInSeprate.aspx.cs" Inherits="ExpensesSys.Pages.LogInSeprate" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link href="../Libs/jquery.dataTables.min.css" rel="stylesheet" />
     <script src="../Libs/bootstrap.min.js"></script>
        <script src="../Libs/jquery.min.js"></script>
        <script src="../Libs/popper.min.js"></script>
        <script src="../Libs/jquery.mCustomScrollbar.concat.min.js"></script>
        <script src="../Libs/main.js"></script>
        <script src="../Libs/jquery-3.3.1.slim.min.js"></script>
        <script src="../Libs/jquery.dataTables.min.js"></script>
        <link href="../Libs/bootstrap.min.css" rel="stylesheet" />
        <link href="../Libs/jquery.mCustomScrollbar.min.css" rel="stylesheet" />
        <link href="../Libs/all.css" rel="stylesheet" />
        <link href="../Libs/main.css" rel="stylesheet" />
        <link href="../Libs/sidebar-themes.css" rel="stylesheet" />
        <script src="../Libs/dataTables.bulma.min.js"></script>
        <link href="../Libs/bulma.min.css" rel="stylesheet" />
            <link href="../Libs/dataTables.bulma.min.css" rel="stylesheet" />
        <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/334e818a85.js" crossorigin="anonymous"></script>

     <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css" rel="stylesheet" />
          <style>
          body {
  background-image: url("../Images/bgbg.jpg");

  background-repeat: repeat;
    
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

  <section class="hero is-fullheight">



        <div class="hero-body">
            <div class="container">
                <div class="columns is-centered">
                    <div class="column is-6-tablet is-5-desktop is-4-widescreen">


                        <h1 class="title"><%--Please sign in--%></h1>
                        <div class="card">
                            <div class="card-content">
                                <center>
                             <%--         <img src="../Images/SCLogo.png" width="212px" >--%>
                                    </center>
                                <div class="field" >
                                    <label for="" class="label">اسم المستخدم</label>
                                    <div class="control has-icons-left">
                                        <asp:TextBox runat="server" ID="UsernameTB" type="text" placeholder="اسم المستخدم" class="input" required />
                                        <span class="icon is-small is-left">
                                            <i class="fa fa-envelope"></i>
                                        </span>
                                    </div>
                                </div>
                                <div class="field">
                                    <label for="" class="label">الرمز السري</label>
                                    <div class="control has-icons-left">
                                        <asp:TextBox runat="server" ID="PassTB" type="password" placeholder="*******" class="input" required />
                                        <span class="icon is-small is-left">
                                            <i class="fa fa-lock"></i>
                                        </span>
                                    </div>
                                </div>
                           

                                <div class="field buttons">
                                    <asp:Button runat="server" OnClick="SubmitBtn_Click" ID="btn" Text="تسجيل الدخول" class="button is-fullwidth is-success" BackColor="#33B3FF"></asp:Button>
                                </div>

                          

                            </div>


                        </div>

                    </div>
                </div>
                <center>
                    <asp:Panel runat="server" ID="NotFound" Visible="false" Width="40%">



                        <article class="message is-danger" >
  <div class="message-header">
    <p>Not Found</p>
    <button class="delete" aria-label="delete"></button>
  </div>
  <div class="message-body">
  Account not found. Please make sure to use the correct username and password 
  </div>
</article>


                    </asp:Panel>
                    </center>

            </div>

        </div>
    </section>
        </div>
    </form>
</body>
</html>
