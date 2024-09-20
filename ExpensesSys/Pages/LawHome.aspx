<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="LawHome.aspx.cs" Inherits="ExpensesSys.Pages.Law.LawHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style>
        .HeaderDiv {
  box-shadow: 4px 4px 20px Black;
    border-radius: 10px;




}


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <article class="panel is-info" style="background-color: white; padding-bottom: 2em;">

        <p class="panel-heading text-center "  style="background-color: #3399ff;">القانونية<i class="fa-solid fa-file-invoice-dollar"></i></p>














  



        <div class="row  " style="padding-left: 1em; padding-right: 1em;">



            

            <div class="col   text-center ">
                <asp:Button runat="server" ID="SalaryManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToPeople" role="button" Text="الوحدات"></asp:Button>
            </div> 
            
            <div class="col   text-center ">

                <asp:Button runat="server" ID="ProjectManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToArchiving" role="button" Text="الارشفة"></asp:Button>
            </div>
            
       
        </div>




 



        <div class="row ">
        </div>





    </article>




</asp:Content>
