<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="GeneralFinanceNav.aspx.cs" Inherits="ExpensesSys.Pages.GeneralFinanceNav" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
          <style>
        .HeaderDiv {
            box-shadow: 4px 4px 20px Black;
            border-radius: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    
         <asp:Panel runat="server" ID="ButtonsBar">
        <div class="row " style="margin-bottom: 1em">
                 
                
            <div class="col-auto">
                <div class="field buttons align-items-end">
                </div>
            </div>


            <div class="col-auto">
                <div class="field buttons align-items-end">
                </div>
            </div>
            <div class="col-lg">
            </div>
            <div class="col-auto">
            </div>
            <div class="col-auto  ">
            </div>
            <div class="col-auto">
                <div class="field buttons align-items-end">


                              <div class="col-auto">
                <div class="field buttons align-items-end">

     <asp:LinkButton  runat="server"  style="background-color: white; color: #33B3FF; font: bold; border-color:#33B3FF" text="الرجوع"
      
         data-target="modal-js-example"
                                 onclick="Return"

                        class="js-modal-trigger button is-fullwidth  align align-content-center  button is-ou">الرجوع
                       
                        <i class="fas fa-home " style="margin-left: 1em">

                        </i></asp:LinkButton>
                </div>
            </div>
                </div>
            </div>

        </div>

    </asp:Panel>
  
    
    
    <article class="panel is-info" style="background-color: white; padding-bottom: 2em;">

        <p class="panel-heading text-center " style="background-color: #3399ff;">الــرئيسيـــة <i class="fa-solid fa-file-invoice-dollar"></i></p>




        <br />







          <div class="row   m-4" style="padding-left: 1em; padding-right: 1em;">





            <div class="col   text-center ">
                                 <asp:Button runat="server" ID="Button1" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToGeneralIn" role="button" Text="الواردات العامة"></asp:Button>
            </div>



            </div>

          <div class="row  m-4" style="padding-left: 1em; padding-right: 1em;">





            <div class="col   text-center ">
                             <asp:Button runat="server" ID="SalaryManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToGeneralOut" role="button" Text="المصروفات العامة"></asp:Button>
            </div>



            </div>

           <div class="row  m-4" style="padding-left: 1em; padding-right: 1em;">





            <div class="col   text-center ">
                             <asp:Button runat="server" ID="Button2" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToGeneralFinanceReports" role="button" Text="تقارير الحسابات العامة"></asp:Button>
            </div>



            </div>



   

  

        <div class="row ">
        </div>





    </article>












</asp:Content>
