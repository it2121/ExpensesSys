<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="GeneralFinanceNav.aspx.cs" Inherits="ExpensesSys.Pages.GeneralFinanceNav" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
          <style>
        .HeaderDiv {
            box-shadow: 2px 2px 10px Gray;
            border-radius: 5px;
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


                  <div class="col-xs-6 col-md-12  HeaderDiv text-center" style="background-color: #eeeeee;">


                <div class="row">
                    <div class="col-12  text-center" style="">

                        <div class="row">

                            <asp:Label runat="server" ID="Button1722" Style="font: bolder; width: 100%;" Width="100%" Font-Size="X-Large" ForeColor="Black" class="m-2" role="button" Text="المبلغ المتوفر في الحسابات"></asp:Label>



                        </div>
                        <div class="row">

                            <asp:Label runat="server" ID="WhatsInTheSafeLbl" Style="font: bolder; width: 100%;" Width="100%" Font-Size="XX-Large" ForeColor="DarkGreen" class="" role="button" Text="31"></asp:Label>



                        </div>
                    </div>
                 



                </div>




            </div>





            </div>



        <hr />
          <div class="row   m-4" style="padding-left: 1em; padding-right: 1em;">





       

               <div class="col   text-center ">
                             <asp:Button runat="server" ID="SalaryManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToGeneralOut" BackColor="Salmon" role="button" Text="المصروفات العامة"></asp:Button>
            </div>
                   <div class="col   text-center ">
                                 <asp:Button runat="server" ID="Button1" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToGeneralIn" BackColor="LightGreen" role="button" Text="الواردات العامة"></asp:Button>
            </div>
            </div>

    
        <hr />
           <div class="row  m-4" style="padding-left: 1em; padding-right: 1em;">





            <div class="col   text-center ">
                             <asp:Button runat="server" ID="Button2" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToGeneralFinanceReports" role="button" Text="تقارير الحسابات العامة"></asp:Button>
            </div>



            </div>



   

  

        <div class="row ">
        </div>





    </article>












</asp:Content>
