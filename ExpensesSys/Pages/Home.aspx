<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ExpensesSys.Pages.Home" %>

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

                            <asp:Label runat="server" ID="EmpCountLbl" Style="font: bolder; width: 100%;" Width="100%"  Font-Size="XX-Large" ForeColor="White" class="" role="button" Text="31"></asp:Label>



                        </div>
                    </div>
                    <div class="col-5  text-center  align-middle" style="">
<i class="fa fa-users mt-4 mr-2 fa-3x text-center justify-content-center align-middle" aria-hidden="true" style="color:white;"></i>
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

                            <asp:Label runat="server" ID="projectsCountLbl" Style="font: bolder; width: 100%;" Width="100%"  Font-Size="XX-Large" ForeColor="White" class="" role="button" Text="31"></asp:Label>



                        </div>
                    </div>
                    <div class="col-5  text-center  align-middle" style="">
<i class="fa-solid fa-building mt-4 mr-2 fa-3x text-center justify-content-center align-middle" aria-hidden="true" style="color:white;"></i>
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

                            <asp:Label runat="server" ID="Last30DaysIncome" Style="font: bolder; width: 100%;" Width="100%"  Font-Size="Medium" ForeColor="White" class="" role="button" Text="31"></asp:Label>



                        </div>
                    </div>
                    <div class="col-5  text-center  align-middle" style="">
<i class="fa-solid fa-money-bill-trend-up mt-4 mr-2 fa-3x text-center justify-content-center align-middle" aria-hidden="true" style="color:white;"></i>
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

                            <asp:Label runat="server" ID="Last30DaysSpendings" Style="font: bolder; width: 100%;" Width="100%"  Font-Size="Medium" ForeColor="White" class="" role="button" Text="31"></asp:Label>



                        </div>
                    </div>
                    <div class="col-5  text-center  align-middle" style="">
<i class="fa-solid fa-hand-holding-dollar mt-4 mr-2 fa-3x text-center justify-content-center align-middle" aria-hidden="true" style="color:white;"></i>
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
    <article class="panel is-info" style="background-color: white; padding-bottom: 2em;">

        <p class="panel-heading text-center" style="background-color: #3399ff;">الرئيسيـــة <i class="fa-solid fa-file-invoice-dollar"></i></p>



        <script src="../Libs//chart.js"></script>





        <div class="row m-2 ">





            <div class="col-6 justify-content-center ">
                <div class="justify-content-center" style="width: 100%; height: 100%; display: flex; align-items: center; flex-wrap: wrap;">
                    <canvas id="myChart1"></canvas>
                </div>

            </div>
            <div class="col-6 justify-content-center ">
                <div class="justify-content-center" style="width: 100%; height: 100%; display: flex; align-items: center; flex-wrap: wrap;">
                    <canvas id="myChart2"></canvas>
                </div>

            </div>



        </div>
        <br />










        <script>
            var GR = '<%= GR %>';
            var BL = '<%= BL %>';
            var AB = '<%= AB %>';

            var OR = '<%= Outcome %>';
            var IN = '<%= Income %>';
            const ctx = document.getElementById('myChart');

            new Chart(
                ctx, {

                type: 'doughnut',
                data: {
                    labels: ['GRs', 'BLs', 'ABs'],
                    datasets: [{
                        label: 'GRs & BLs & ABs',
                        data: [GR, BL, AB],
                        backgroundColor: [
                            'rgb(124, 252, 0)',
                            'rgb(255, 160, 122)',
                            'rgb(173, 216, 230)'
                        ],
                        hoverOffset: 1
                    }]
                },
                options: {
                    scales: {
                        y: {
                            beginAtZero: true
                        }
                    }
                }

            });

        </script>


        <script>
            var GR = '<%= GR %>';
            var BL = '<%= BL %>';
            var AB = '<%= AB %>';

            var OR = '<%= Outcome %>';
            var IN = '<%= Income %>';
            var Free = IN - OR;
            const ctx1 = document.getElementById('myChart1');

            new Chart(
                ctx1, {

                type: 'bar',
                data: {
                    labels: ['المصروفات', 'الايرادات والتمويل', 'السيولة المتوفرة'],
                    datasets: [{
                        label: 'نظرة عامة',
                        data: [OR, IN, Free],
                        backgroundColor: [
                            'rgba(0, 102, 204, 0.6)',
                            'rgba(255, 159, 64, 0.6)',
                            'rgba(144, 238, 144, 0.6)'



                        ], borderColor: [
                            'rgb(255, 99, 132)',
                            'rgb(255, 99, 132)',
                            'rgb(255, 159, 64)'

                        ],
                        hoverOffset: 1
                    }]
                },
                options: {
                    scales: {
                        y: {
                            beginAtZero: true
                        }
                    }
                }

            });

        </script>
        <script>
            var GR = '<%= GR %>';
            var BL = '<%= BL %>';
            var AB = '<%= AB %>';

            var OR = '<%= Outcome %>';
            var IN = '<%= Income %>';
            var Free = IN - OR;
            var GetAllNthSum = '<%= GetAllNthSum %>';
            var GetAllCompSum = '<%= GetAllCompSum %>';
            var GetAllSalarySum = '<%= GetAllSalarySum %>';
            var GetAllMatBuySum = '<%= GetAllMatBuySum %>';

            const ctx2 = document.getElementById('myChart2');

            new Chart(
                ctx2, {

                type: 'bar',
                data: {
                    labels: ['مصروفات عامة', 'اخرى', 'الرواتب', ' شراء المواد'],
                    datasets: [{
                        label: 'نظرة تفصيلية بالمصاريف',
                        data: [GetAllNthSum, GetAllCompSum, GetAllSalarySum, GetAllMatBuySum],
                        backgroundColor: [
                            'rgba(0, 102, 204, 0.6)',
                            'rgba(255, 159, 64, 0.6)',
                            'rgba(255, 19, 64, 0.6)',
                            'rgba(144, 238, 144, 0.6)'



                        ], borderColor: [
                            'rgb(255, 99, 132)',
                            'rgb(255, 99, 132)',
                            'rgb(255, 19, 32)',
                            'rgb(255, 159, 64)'

                        ],
                        hoverOffset: 1
                    }]
                },
                options: {
                    scales: {
                        y: {
                            beginAtZero: true
                        }
                    }
                }

            });

        </script>




        <div class="row  " style="padding-left: 1em; padding-right: 1em;">



            

            <div class="col   text-center ">
                <asp:Button runat="server" ID="SalaryManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToEmpMan" role="button" Text="ادارة الرواتب"></asp:Button>
            </div> 
            
            <div class="col   text-center ">

                <asp:Button runat="server" ID="ProjectManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToProjMan" role="button" Text="ادارة المشاريع"></asp:Button>
            </div>
            
            
            <div class="col   text-center ">
                <asp:Button runat="server" ID="EmpManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToOriginalEmp" role="button" Text="الادارة والملاك"></asp:Button>




            </div>
        </div>
        <div class="row  " style="padding-left: 1em; padding-right: 1em;">


            <div class="col-4 mt-5  text-center">
                <asp:Button runat="server" ID="IncomeManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToIncome" role="button" Text="الايرادات والتمويل"></asp:Button>




            </div>


            <div class="col-4 mt-5  text-center">
                <asp:Button runat="server" ID="ExpManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToExpences" role="button" Text="مصروفـــات المشاريــــع"></asp:Button>




            </div>

            <div class="col-4 mt-5  text-center">
                <asp:Button runat="server" ID="NthManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToNth" role="button" Text="مصــــروفات عــامة"></asp:Button>




            </div>



        </div>


        <div class="row  " style="padding-left: 1em; padding-right: 1em;">


            <div class="col-4 mt-5  text-center">
<%--                <asp:Button runat="server" ID="Button8" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToIncome" role="button" Text="الايرادات والتمويل"></asp:Button>--%>




            </div>


            <div class="col-4 mt-5  text-center">
                <asp:Button runat="server" ID="WarehouseManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToWarehouse" role="button" Text="ادارة المخـــزن"></asp:Button>




            </div>

    



        </div>





        <div class="row  " style="padding-left: 1em; padding-right: 1em;">



            <div class="col-12 mt-5  text-center">
                                <asp:Button runat="server" ID="Button2" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToUnitInfo" role="button" Text="كشف الوحدات السكنية"></asp:Button>


            </div>


        </div>

        <div class="row  " style="padding-left: 1em; padding-right: 1em;">



            <div class="col-12 mt-5  text-center">
                <asp:Button runat="server" ID="ReportsBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToReports" role="button" Text="التقاريــــر"></asp:Button>


            </div>


        </div>



        <div class="row ">
        </div>





    </article>


</asp:Content>
