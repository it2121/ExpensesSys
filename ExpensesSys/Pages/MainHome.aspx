<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="MainHome.aspx.cs" Inherits="ExpensesSys.Pages.MainHome" %>
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






        <div class="row  justify-content-between" style="padding-left: 1em; padding-right: 1em;">


            <div class="col-xs-6 col-md-2  HeaderDiv text-center" style="background-color: #ff5d5a;">


                <div class="row">
                    <div class="col-7  text-center" style="">

                        <div class="row">

                            <asp:Label runat="server" ID="Button7" Style="font: bolder; width: 100%;" Width="100%" Font-Size="Medium" ForeColor="White" class="m-2" role="button" Text="عدد الموظفين"></asp:Label>



                        </div>
                        <div class="row">

                            <asp:Label runat="server" ID="EmpCountLbl" Style="font: bolder; width: 100%;" Width="100%" Font-Size="XX-Large" ForeColor="White" class="" role="button" Text="31"></asp:Label>



                        </div>
                    </div>
                    <div class="col-5  text-center  align-middle" style="">
                        <i class="fa fa-users mt-4 mr-2 fa-3x text-center justify-content-center align-middle" aria-hidden="true" style="color: white;"></i>
                    </div>



                </div>




            </div>



            <div class="col-xs-6 col-md-2  HeaderDiv text-center" style="background-color: #459aea;">


                <div class="row">
                    <div class="col-7  text-center" style="">

                        <div class="row">

                            <asp:Label runat="server" ID="Button17" Style="font: bolder; width: 100%;" Width="100%" Font-Size="Medium" ForeColor="White" class="m-2" role="button" Text="عدد المشاريع"></asp:Label>



                        </div>
                        <div class="row">

                            <asp:Label runat="server" ID="projectsCountLbl" Style="font: bolder; width: 100%;" Width="100%" Font-Size="XX-Large" ForeColor="White" class="" role="button" Text="31"></asp:Label>



                        </div>
                    </div>
                    <div class="col-5  text-center  align-middle" style="">
                        <i class="fa-solid fa-building mt-4 mr-2 fa-3x text-center justify-content-center align-middle" aria-hidden="true" style="color: white;"></i>
                    </div>



                </div>




            </div>


            <div class="col-xs-6 col-md-2  HeaderDiv text-center" style="background-color: #5eb75b;">


                <div class="row">
                    <div class="col-7  text-center" style="">

                        <div class="row">

                            <asp:Label runat="server" ID="Button1722" Style="font: bolder; width: 100%;" Width="100%" Font-Size="Medium" ForeColor="White" class="m-2" role="button" Text="ايرادات اخر 30 يوم"></asp:Label>



                        </div>
                        <div class="row">

                            <asp:Label runat="server" ID="Last30DaysIncome" Style="font: bolder; width: 100%;" Width="100%" Font-Size="Medium" ForeColor="White" class="" role="button" Text="31"></asp:Label>



                        </div>
                    </div>
                    <div class="col-5  text-center  align-middle" style="">
                        <i class="fa-solid fa-money-bill-trend-up mt-4 mr-2 fa-3x text-center justify-content-center align-middle" aria-hidden="true" style="color: white;"></i>
                    </div>



                </div>




            </div>


            <div class="col-xs-6 col-md-2  HeaderDiv text-center" style="background-color: #efad4c;">


                <div class="row">
                    <div class="col-7  text-center" style="">

                        <div class="row">

                            <asp:Label runat="server" ID="Button1711" Style="font: bolder; width: 100%;" Width="100%" Font-Size="Medium" ForeColor="White" class="m-2" role="button" Text="مصروفات اخر 30 يوم"></asp:Label>



                        </div>
                        <div class="row">

                            <asp:Label runat="server" ID="Last30DaysSpendings" Style="font: bolder; width: 100%;" Width="100%" Font-Size="Medium" ForeColor="White" class="" role="button" Text="31"></asp:Label>



                        </div>
                    </div>
                    <div class="col-5  text-center  align-middle" style="">
                        <i class="fa-solid fa-hand-holding-dollar mt-4 mr-2 fa-3x text-center justify-content-center align-middle" aria-hidden="true" style="color: white;"></i>
                    </div>



                </div>




            </div>








        </div>

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
                </div>
            </div>

        </div>
    </asp:Panel>


    


    
         <asp:Panel runat="server" ID="Panel1">
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








        <div class="row  m-4" style="padding-left: 1em; padding-right: 1em;">





            <div class="col   text-center ">
                <asp:Button runat="server" ID="ManagmentBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToMainProjectMan" role="button" Text="ادارة المشروع"></asp:Button>
            </div>
            </div>
                <div class="row m-4 " style="padding-left: 1em; padding-right: 1em;">

            <div class="col   text-center ">

                <asp:Button runat="server" ID="FinanceBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToMainFinancetMan" role="button" Text="حسابات المشروع"></asp:Button>
            </div>
            </div>

        <div class="row  m-4" style="padding-left: 1em; padding-right: 1em;">

            <div class="col   text-center ">
                <asp:Button runat="server" ID="TechBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToMainTechMan" role="button" Text="القسم الفني"></asp:Button>




            </div>
        </div>
  

     


        <div class="row ">
        </div>





    </article>



</asp:Content>
