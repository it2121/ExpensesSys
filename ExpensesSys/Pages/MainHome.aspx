<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="MainHome.aspx.cs" Inherits="ExpensesSys.Pages.MainHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
        .HeaderDiv {
            box-shadow: 4px 4px 20px Black;
            border-radius: 10px;
        }
    </style>
     <style>

        .form__group {
  position: relative;
  padding: 20px 0 0;
  width: 100%;
}

.form__field {
  font-family: inherit;
  width: 100%;
  border: none;
  border-bottom: 2px solid #9b9b9b;
  outline: 0;
  font-size: 17px;
  color: #000;
  padding: 7px 0;
  background: transparent;
  transition: border-color 0.2s;
}

.form__field::placeholder {
  color: transparent;
}

.form__field:placeholder-shown ~ .form__label {
  font-size: 17px;
  cursor: text;
  top: 20px;
}

.form__label {
  position: absolute;
  top: 0;
  display: block;
  transition: 0.2s;
  font-size: 17px;
  color: #9b9b9b;
  pointer-events: none;
}

.form__field:focus {
  padding-bottom: 6px;
  font-weight: 700;
  border-width: 3px;
  border-image: linear-gradient(to right, #116399, #38caef);
  border-image-slice: 1;
}

.form__field:focus ~ .form__label {
  position: absolute;
  top: 0;
  display: block;
  transition: 0.2s;
  font-size: 17px;
  color: #38caef;
  font-weight: 700;
}

/* reset input */
.form__field:required, .form__field:invalid {
  box-shadow: none;
}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Panel runat="server" ID="ButtonsBar">




         <asp:Panel runat="server" ID="HeaderLabels" Visible ="true">

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
             </asp:Panel>
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


          <asp:Panel runat="server" ID="searchPanel" Visible="false" BorderStyle="Dashed" BorderColor="#38caef" BorderWidth="1px">
           <asp:Panel runat="server" DefaultButton="SearchBtn"   >

           <div class="row m-2" >

            <div class="col-12 mt-2">


      


                         <div class="form__group field">
     <asp:TextBox runat="server" ID="SearchBox"   class="form__field align-content-center text-center align-items-center" ReadOnly="false" type="input" placeholder="" />

    <label for="name" class="form__label"></label>
</div>      
                    
                    </div>
           

                 <div class="col-md-12 text-center  mt-2">

                <asp:Button runat="server" ID="SearchBtn" Style="width: 20em" OnClick="Search" class="button is-primary text-center" Text="- بــحــث -"></asp:Button>
            </div>

                </div>
 </asp:Panel>
     
           <div class="row ">
        
          
                <div class="container-fluid d-flex flex-column">
        <div class="row m-2" >

            <div class="col-12">
              
      <div class="content-1">
           


                        <asp:GridView ShowHeaderWhenEmpty="true" ID="DataGridUsers" runat="server" AutoGenerateColumns="False"  class="table table-striped  table-hover border-0 " CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"
                            
OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"
                            HeaderStyle-HorizontalAlign="Center"
                          
                            >
            <Columns>
        

                
              <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="الوحدة">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR23" runat="server" Text='<%#Eval("RecID") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="الاسم">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR1" runat="server" Text='<%#Eval("FullName") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

               
                   <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="رقم الهاتف">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR" runat="server" Text='<%#Eval("PhoneNumber") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
           
                      <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button is-info is-outlined"
                                    style="Width:50%; Height:25px; letter-spacing:1px;"  

                            ID="btn_Edit" runat="server" Text="تحديد" CommandName="Edit" />
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
            </asp:Panel>

        <hr />








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
  <br />
           <div class="row  m-4" style="padding-left: 1em; padding-right: 1em;">

            <div class="col   text-center ">
                <asp:Button runat="server" ID="Button1" Style="font: bolder; width: 100%;" class="btn" OnClick="BackUp" role="button" Text="انشاء نسخة احتياطية"></asp:Button>




            </div>
        </div>
    <div class="row  m-4" style="padding-left: 1em; padding-right: 1em;">

            <div class="col   text-center ">
                <asp:Button runat="server" ID="Button2" Style="font: bolder; width: 100%;" class="btn" OnClick="syncTechDep" role="button" Text="مزامنة البيانات الفنية"></asp:Button>




            </div>
        </div>
      
        <div class="row ">
        </div>





    </article>



</asp:Content>
