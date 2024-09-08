<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeperateProjectSelector.aspx.cs" Inherits="ExpensesSys.Pages.SeperateProjectSelector" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>نظام الصومعة</title>

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
            <link href="../Libs/font-awesome.css"" rel="stylesheet" />

    <script src="../Libs/334e818a85.js" crossorigin="anonymous"></script>
      <script src="path/to/chartjs/dist/chart.umd.js"></script>
            <link rel="icon" type="image/png" href="../Images/logo.ico" sizes="32x32">


          <script type="text/javascript">

               $(document).ready(function () {

                   $(document).ready(function () {
                       $('#DataGridUsers').DataTable();
                   });
                   $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
                   $('.table1').DataTable();
               });

          </script>
     <style>
          @font-face {
  font-family: CustomFont;
src: url('../Libs/Beiruti-VariableFont_wght.ttf');
}
   * :not(i){
font-family: CustomFont, sans-serif !important  ;
  font-optical-sizing: auto !important;
  font-weight: 700 !important;
  font-style: normal !important;
}
          body {
              background-image: url("../Images/bgbg.jpg");
              background-repeat: repeat;
              background-size: 300px;
          }
         .button-89 {
  --b: 3px;   /* border thickness */
  --s: .45em; /* size of the corner */
  --color: #3399ff;
  
  padding: calc(.5em + var(--s)) calc(.9em + var(--s));
  color: var(--color);
  --_p: var(--s);
  background:
    conic-gradient(from 90deg at var(--b) var(--b),White 90deg,var(--color) 0)
    var(--_p) var(--_p)/calc(100% - var(--b) - 2*var(--_p)) calc(100% - var(--b) - 2*var(--_p));
  transition: .3s linear, color 0s, background-color 0s;
  outline: var(--b) solid #0000;
  outline-offset: .6em;
  font-size: 19px;
  font-weight:bold;
  border: 0;

  user-select: none;
  -webkit-user-select: none;
  touch-action: manipulation;
}

.button-89:hover,
.button-89:focus-visible{
  --_p: 0px;
  outline-color: var(--color);
  outline-offset: .05em;
}
html, body {
    margin: 0;
    height: 100%;
}
.button-89:active {
  background: var(--color);
  color: #fff;
}
.btn {
 background-color: #44a2ff;
 padding: 14px 40px;
 color: #fff;
 text-transform: uppercase;
 font-size:2em;
 cursor: pointer;
 border-radius: 10px;
 border: 2px dashed #44a2ff;
 box-shadow: rgba(50, 50, 93, 0.25) 0px 2px 5px -1px, rgba(0, 0, 0, 0.3) 0px 1px 3px -1px;
 transition: .4s;
}

.btn span:last-child {
 display: none;
}

.btn:hover {
 transition: .4s;
 border: 2px dashed #3b9dff;
 background-color: #fff;
 color: #44a2ff;
}

.btn:active {
 background-color: #9bcdff;
}

}
      </style>
    
</head>
<body>


    <form id="form1" runat="server">
        <div>
                <main class="page-content pt-2">
                    <div id="overlay" class="overlay"> </div>
                    <div class="container-fluid p-5">
                    <div class="box align-content-center text-center" style="background-color:#343a40; color:white;">

                
                         
                                <h2></h2>
                                                                    
                              <i class="fa-solid fa-2x fa-file-signature" ></i>
                                        <asp:Label  ID="MainLbl" runat="server"  class="menu-text  text-center text is-size-4">نظــــام الصومعــــة</asp:Label>
                                        <span class="badge badge-pill badge-primary"></span>
                            
                     

                    




            </div>
                                         
   
           

         
            
      <asp:Panel runat="server" ID="ButtonsBar">
        <div class="row " style="margin-bottom: 1em">
                       <div class="col-auto">
                <div class="field buttons align-items-end">

                         <asp:LinkButton  ID="OverseeingManagmntBtn" runat="server"  style="background-color: white; color: #33B3FF; font: bold; border-color:#33B3FF" text="القناة العامة"
        
         
         data-target="modal-js-example"
                                 onclick="GoToProjectZero"

                        class="js-modal-trigger button is-fullwidth  align align-content-center  button is-large">الادارة العامة 
                       
                        <i class="fas " style="margin-left: 1em">

                        </i></asp:LinkButton>


                </div>
            </div>
                
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


                </div>
            </div>
                </div>
            </div>

        </div>
    </asp:Panel>
    <article class="panel is-info" style="background-color: white;padding-bottom:2em;">
        <p class="panel-heading text-center" style="background-color:#3399ff;">تحديد المشروع<i class="fa-solid fa-file-invoice-dollar"></i></p>

        
        


 
     <div class="row ">
        
          
                <div class="container-fluid d-flex flex-column">
        <div class="row m-2" >

            <div class="col-12">
              
      <div class="content-1">
           


                        <asp:GridView ShowHeaderWhenEmpty="true" ID="DataGridUsers" runat="server" AutoGenerateColumns="False"  class="table table-striped  table-hover border-0 " CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"

OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"
                            HeaderStyle-HorizontalAlign="Center"
                            HeaderStyle-Font-Size="X-Large"
                          
                            >
            <Columns>
        

                <asp:TemplateField ItemStyle-HorizontalAlign="Center" Visible="false" HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="false" HeaderText="أسم المشروع">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR" runat="server"  Text='<%#Eval("Name") %>' Font-Bold="true" Font-Size="XX-Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

          
           
                      <asp:TemplateField  ItemStyle-HorizontalAlign="Center"  HeaderText="أسم المشروع">
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button is-info is-outlined"
                                    style="Width:50%; Height:100%"  

                            ID="btn_Edit" Font-Size="XX-Large" runat="server" Text='<%#Eval("Name") %>' CommandName="Edit" />

                       


                    </ItemTemplate>
            
                </asp:TemplateField>   
            </Columns>
                                <EmptyDataTemplate>لا توجد معلومات بعد</EmptyDataTemplate>  

        </asp:GridView>
                </div>




          
            </div>
            </div>
            </div>
            </div>
            </div>



    

    </article>


    
                 <script>

                     var table = $('#DataGridUsers').DataTable();

                     new DataTable.Responsive(table);

                 </script>

        
          </div>
       
             </main>
        </div>

    </form>
</body>
</html>
