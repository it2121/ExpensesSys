<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="ExpensesSys.Pages.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                </div>
            </div>

        </div>
    </asp:Panel>
    <article class="panel is-info" style="background-color: white;">
        <p class="panel-heading ">التقارير</p>
    

        <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>





        <div class="row m-2 ">



      <%--      <div class="col-6 justify-content-center ">
               <div class="justify-content-center" style="width:100%; height:90% ;display: flex;
    align-items: center;
    flex-wrap: wrap;">
            <canvas id="myChart"></canvas>
        </div>

            </div>  --%> 
            
            <div class="col-6 justify-content-center ">
               <div class="justify-content-center" style="width:100% ;height:100%;display: flex;
    align-items: center;
    flex-wrap: wrap;">
            <canvas id="myChart1"></canvas>
        </div>

            </div>
       <div class="col-6 justify-content-center ">
               <div class="justify-content-center" style="width:100% ;height:100%;display: flex;
    align-items: center;
    flex-wrap: wrap;">
            <canvas id="myChart2"></canvas>
        </div>

            </div>



        </div>  
        <br />


         <div class="row  " style="padding-left :1em; padding-right:1em; margin-bottom:1em;">
        
          

            <div class="col-4 mt-3  text-center ">

                   
                <asp:Button
                Style="width: 100%; height: 40px;"
                class=" d-flex justify-content-center js-modal-trigger button is-warning is-bold"
                ID="ExportBtn" runat="server"
                    OnClick="GoToFullReportInAndOutWithDate"
                Text=" - تقرير شامل حسب التاريخ - "></asp:Button>
           

            </div>
                
                <div class="col-4 mt-3  text-center ">

                    
                <asp:Button
                Style="width: 100%; height: 40px;"
                class=" d-flex justify-content-center js-modal-trigger button is-warning is-bold"
                ID="Button1" runat="server"

                Text=" - تقرير بالمشروع حسب التاريخ - "></asp:Button>
            </div>

                <div class="col-4 mt-3  text-center ">

                    
                <asp:Button
                Style="width: 100%; height: 40px;"
                class=" d-flex justify-content-center js-modal-trigger button is-warning is-bold"
                ID="Button2" runat="server"

                Text=" - تقرير بالمصروفات العامة حسب التاريخ - "></asp:Button>
            </div>

            </div> 


   

        
         <div class="row  " style="padding-left :1em; padding-right:1em; margin-bottom:1em;">
        
          

            <div class="col-4 mt-3  text-center ">

                   
                <asp:Button
                Style="width: 100%; height: 40px;"
                class=" d-flex justify-content-center js-modal-trigger button is-warning is-bold"
                ID="Button3" runat="server"

                Text=" - تقرير شامل بالرواتب حسب التاريخ - "></asp:Button>
           

            </div>
                
                <div class="col-4 mt-3  text-center ">

                    
                <asp:Button
                Style="width: 100%; height: 40px;"
                class=" d-flex justify-content-center js-modal-trigger button is-warning is-bold"
                ID="Button4" runat="server"

                Text=" - تقرير بالرواتب حسب المشروع والتاريخ - "></asp:Button>
            </div>

                <div class="col-4 mt-3  text-center ">

                    
                <asp:Button
                Style="width: 100%; height: 40px;"
                class=" d-flex justify-content-center js-modal-trigger button is-warning is-bold"
                ID="Button5" runat="server"

                Text=" -  - "></asp:Button>
            </div>

            </div> 
          
        
        
        
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
                    labels: ['المصروفات', 'الايرادات', 'السيولة المتوفرة'],
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
                      labels: ['مصروفات عامة', 'المجاملات', 'الرواتب', ' شراء المواد'],
                      datasets: [{
                          label: 'نظرة تفصيلية بالمصاريف',
                          data: [GetAllNthSum, GetAllCompSum, GetAllSalarySum, GetAllMatBuySum],
                          backgroundColor: [
                              'rgba(0, 102, 204, 0.6)',
                              'rgba(255, 159, 64, 0.6)',
                              'rgba(255, 159, 64, 0.6)',
                              'rgba(144, 238, 144, 0.6)'



                          ], borderColor: [
                              'rgb(255, 99, 132)',
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
        
        
 <%--       <div class="row ">



            <div class="col-11 m-5 ">
                <span class="tag is-primary  is-large">
                    <asp:Label class="label align-text-top " Font-Size="Larger" Style="margin-right: 1em; color: white;" runat="server" ID="NumOfProviders" Text=""></asp:Label></span>


            </div>
        </div>
        <div class="row ">



            <div class="col-11 m-5 ">

                <span class="tag is-primary  is-large" style="background-color: lawngreen;"><i class="fa-solid fa-bell-concierge mt-1 mr-3"></i>
                    <asp:Label class="label align-text-top " Font-Size="Larger" Style="margin-right: 1em; color: white;" runat="server" ID="NumberOfFRs1" Text=""></asp:Label></span>

            </div>
        </div>
        <div class="row ">



            <div class="col-11 m-5 ">
                <span class="tag is-primary  is-large" style="background-color: lightsalmon;"><i class="fa-solid fa-bell-concierge mt-1 mr-3"></i>
                    <asp:Label class="label align-text-top " Font-Size="Larger" Style="margin-right: 1em; color: white;" runat="server" ID="NumberOfFRs2" Text=""></asp:Label></span>


            </div>
        </div>
        <div class="row ">



            <div class="col-11 m-5 ">
                <span class="tag is-primary  is-large" style="background-color: lightblue;"><i class="fa-solid fa-bell-concierge mt-1 mr-3"></i>
                    <asp:Label class="label align-text-top " Font-Size="Larger" Style="margin-right: 1em; color: white;" runat="server" ID="NumberOfFRs3" Text=""></asp:Label></span>



            </div>
        </div>
        <div class="row ">



            <div class="col-11 m-5 ">
                <span class="tag is-primary  is-large" style="background-color: gray;">
                    <asp:Label class="label align-text-top " Font-Size="Larger" Style="margin-right: 1em; color: white;" runat="server" ID="DateOfLastRequestMade" Text=""></asp:Label></span>

            </div>
        </div>--%>
        <div class="row ">



<%--
            <asp:Button
                Style="width: 100%; height: 40px; margin: 2em"
                class=" d-flex justify-content-center js-modal-trigger button is-info is-bold"
                ID="btn_Download" runat="server"
                OnClick="DownloadPDF"
                Text=" - Download - "></asp:Button>--%>


        </div>
        <div class="row ">




       <%--     <asp:Button
                Style="width: 100%; height: 40px; margin: 2em"
                class=" d-flex justify-content-center js-modal-trigger button is-warning is-bold"
                ID="ExportBtn" runat="server"
                OnClick="ExportBtnc"
                Text=" - Download Back Up File - "></asp:Button>--%>


        </div>

        <%--  <div class="row ">
        
          

            <div class="col-11 m-5 ">

                <asp:Label class="label align-text-top " Font-Size="Larger"  runat="server" ID="NumberOfItems" Text=""></asp:Label>

            </div>
            </div>
           <div class="row ">
        
          

            <div class="col-11 m-5 ">

                <asp:Label class="label align-text-top " Font-Size="Larger"  runat="server" ID="TotalQuant" Text=""></asp:Label>

            </div>
            </div>
       
       
        
     
           <div class="row ">
        
          

            <div class="col-11 m-5 ">

                <asp:Label class="label align-text-top " Font-Size="Larger"  runat="server" ID="NumOfItems" Text=""></asp:Label>

            </div>
            </div>--%>
    </article>
</asp:Content>
