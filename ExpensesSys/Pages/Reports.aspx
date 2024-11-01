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


    <article class="panel is-info" style="background-color: white;">
        <p class="panel-heading text-center">التقارير</p>
    
        
         <div class="row  " style="padding-left :1em; padding-right:1em; margin-bottom:1em;">
        
          

            <div class="col-4 mt-3 text-center ">

                   
                <asp:Button
                   
                Style="width: 100%; height: 4rem; font-size:larger;font-weight:700;"
                class=" d-flex justify-content-center Button  js-modal-trigger button is-warning is-bold"
                ID="ExportBtn" runat="server"
                    
                    OnClick="GoToFullReportInAndOutWithDate"
                Text=" - تقارير الصرفيات والايرادات - "></asp:Button>
           

            </div>
                    <div class="col-4 mt-3 text-center ">

                   
                <asp:Button
                   
                Style="width: 100%; height: 4rem; font-size:larger;font-weight:700;"
                class=" d-flex justify-content-center Button  js-modal-trigger button is-warning is-bold"
                ID="WarehouseBtn" runat="server"
                    
                    OnClick="GoToFullReportInAndOutWithDate"
                Text=" - تقارير المخزن - "></asp:Button>
           

            </div>
                    <div class="col-4 mt-3  text-center ">

                   
                <asp:Button
                   
                Style="width: 100%; height: 4rem; font-size:larger;font-weight:700;"
                class=" d-flex justify-content-center Button  js-modal-trigger button is-warning is-bold"
                ID="ContractBtn" runat="server"
                    
                    OnClick="GoToFullReportInAndOutWithDate"
                Text=" - تقارير عقود العمل - "></asp:Button>
           

            </div>
                
     

            </div> 


        <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>



        <hr />

        <div class="row m-2 ">



      <%--      <div class="col-6 justify-content-center ">
               <div class="justify-content-center" style="width:100%; height:90% ;display: flex;
    align-items: center;
    flex-wrap: wrap;">
            <canvas id="myChart"></canvas>
        </div>

            </div>  --%> 

   <div class="col-12 justify-content-center ">
               <div class="justify-content-center" style="width:100% ;display: flex;
    align-items: center;
    flex-wrap: wrap;">
            <canvas id="LineChart" height="75rem"></canvas>
        </div>

            </div>
            
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
                      labels: ['مصروفات عامة', 'اخرى', 'الرواتب', 'عقود شراء المواد'],
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
              var m1 = '<%= m[0] %>';
              var m2 = '<%= m[1] %>';
              var m3 = '<%= m[2] %>';
              var m4 = '<%= m[3] %>';
              var m5 = '<%= m[4] %>';
              var m6 = '<%= m[5] %>';
              var m7 = '<%= m[6] %>';
              var m8 = '<%= m[7] %>';
              var m9 = '<%= m[8] %>';
              var m10 = '<%= m[9] %>';
              var m11 = '<%= m[10] %>';
              var m12 = '<%= m[11] %>';
              var m13 = '<%= m[12] %>';
              var m14 = '<%= m[13] %>';
              var m15 = '<%= m[14] %>';
              var m16 = '<%= m[15] %>';
              var m17 = '<%= m[16] %>';
              var m18 = '<%= m[17] %>';
              var m19 = '<%= m[18] %>';
              var m20 = '<%= m[19] %>';
              var m21 = '<%= m[20] %>';
              var m22 = '<%= m[21] %>';
              var m23 = '<%= m[22] %>';
              var m24 = '<%= m[23] %>';
              var m25 = '<%= m[24] %>';
              var m26 = '<%= m[25] %>';
              var m27 = '<%= m[26] %>';
              var m28 = '<%= m[27] %>';
              var m29 = '<%= m[28] %>';
              var m30 = '<%= m[29] %>';

           

              var mm1 = '<%= mm[0] %>';
              var mm2 = '<%= mm[1] %>';
              var mm3 = '<%= mm[2] %>';
              var mm4 = '<%= mm[3] %>';
              var mm5 = '<%= mm[4] %>';
              var mm6 = '<%= mm[5] %>';
              var mm7 = '<%= mm[6] %>';
              var mm8 = '<%= mm[7] %>';
              var mm9 = '<%= mm[8] %>';
              var mm10 = '<%= mm[9] %>';
              var mm11 = '<%= mm[10] %>';
              var mm12 = '<%= mm[11] %>';
              var mm13 = '<%= mm[12] %>';
              var mm14 = '<%= mm[13] %>';
              var mm15 = '<%= mm[14] %>';
              var mm16 = '<%= mm[15] %>';
              var mm17 = '<%= mm[16] %>';
              var mm18 = '<%= mm[17] %>';
              var mm19 = '<%= mm[18] %>';
              var mm20 = '<%= mm[19] %>';
              var mm21 = '<%= mm[20] %>';
              var mm22 = '<%= mm[21] %>';
              var mm23 = '<%= mm[22] %>';
              var mm24 = '<%= mm[23] %>';
              var mm25 = '<%= mm[24] %>';
              var mm26 = '<%= mm[25] %>';
              var mm27 = '<%= mm[26] %>';
              var mm28 = '<%= mm[27] %>';
              var mm29 = '<%= mm[28] %>';
              var mm30 = '<%= mm[29] %>';

              const ctx3 = document.getElementById('LineChart');

              new Chart(
                  ctx3, {

                      type: 'line',
                  data: {
                      labels: [

                          mm1, mm2, mm3, mm4, mm5, mm6, mm7, mm8, mm9, mm10,
                          mm11, mm12, mm13, mm14, mm15, mm16, mm17, mm18, mm19, mm20,
                          mm21, mm22, mm23, mm24, mm25, mm26, mm27, mm28, mm29, mm30



                      ],
                      datasets: [{
                          label: ' ايرادات الدفعات لاخر 30 يوم',
                          data: [

                              m1, m2, m3, m4, m5, m6, m7, m8, m9, m10,
                              m11, m12, m13, m14, m15, m16, m17, m18, m19, m20,
                              m21, m22, m23, m24, m25, m26, m27, m28, m29, m30


                          ],

                          backgroundColor: [
                              'rgba(255, 99, 132, 1)'



                          ], borderColor: [
                              'rgb(255, 99, 132)'

                          ],
                          hoverOffset: 1,
                          tension: 0.1
                           
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
