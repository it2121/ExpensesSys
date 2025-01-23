<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="Salary.aspx.cs" Inherits="ExpensesSys.Pages.Salary" %>
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
        <div class="row " style="margin-bottom: 1em">
                       <div class="col-auto">
                <div class="field buttons align-items-end">




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
    <article class="panel is-info" style="background-color: white;padding-bottom:2em;">
          <p class="panel-heading text-center" style="background-color:#3399ff;">                <asp:Label  runat ="server" ID ="PageProjectNameLbl" Text="" ></asp:Label>
<i class="fa-solid fa-file-invoice-dollar"></i></p>
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/js/bootstrap-datepicker.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/css/bootstrap-datepicker.min.css" rel="stylesheet" />   

         




        <div class="row">


            <div class="col-12 text-center">




            </div>
            
            <div class="col-4 text-center" >            </div>

            <div class="col-4 text-center form__group field" >
<div class='input-group date datepicker text-center' id='datepicker'  style="width:100%;">
    <asp:TextBox runat="server" ID="MonthYearSelector"   type='text' class="form-control form__field text-center" />
                            <label   for="name" class="form__label" >يرجى تحديد الشهر</label>

    <span class="input-group-addon ">
        <span class="glyphicon glyphicon-calendar"></span>
    </span>
</div>



            </div>
            
            <div class="col-4 ">


            </div>   
            <div class="col-4 ">


            </div>
            <div class="col-4 text-center">
                 <asp:Button
                   
                Style="width: 100%; height: 2.5rem; font-size:medium;font-weight:200;"
                class=" d-flex justify-content-center Button  js-modal-trigger button text-center is-warning "
                ID="MonthSelectorButton" runat="server"
                    
                    OnClick="monthSelected"
                Text=" - بحث - "></asp:Button>



            </div>
            </div>
           


        <hr />

            <script>
                $(function () {
                    $('#datepicker').datepicker({
                        format: 'mm/yyyy',  
                        startView: "months",
                        minViewMode: "months",
                        language: "tr"
                    });
                });
            </script>
     <div class="row ">
        
          
                <div class="container-fluid d-flex flex-column">
        <div class="row m-2" >

            <div class="col-12">
              
      <div class="content-1">
           


                        <asp:GridView ShowHeaderWhenEmpty="true" ID="DataGridUsers" runat="server" AutoGenerateColumns="False"  class="table table-striped  table-hover border-0 " CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"
                            OnRowCommand="MyGridView_OnRowCommand"
OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"
                            HeaderStyle-HorizontalAlign="Center"
 OnRowDataBound="GridView1_RowDataBound"
                            >
            <Columns>
        
                <asp:TemplateField ItemStyle-HorizontalAlign="Center" Visible="false" HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="lbl_ID123as" runat="server" Text='<%#Eval("EmpID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>  
                <asp:TemplateField ItemStyle-HorizontalAlign="Center" Visible="false" HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("SalaryID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="أسم الموظف">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR" runat="server" Text='<%#Eval("EmpName") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="الوظيفة">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_ORName1" runat="server" Text='<%#Eval("EmpJob") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>  
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="المرتب">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_ORName12" runat="server" Text='<%#Eval("EmpSalary") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>   <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="تاريخ استلام الراتب">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_ORName12s" runat="server" Text='<%#Eval("RecDate") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="حالة الاستلام">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_ORName12s2" runat="server" class='<%# Eval("Paid").ToString() == "0" ? "js-modal-trigger button is-danger is-outlined" :"js-modal-trigger button is-primary is-outlined"  %>' Text='<%# Eval("Paid").ToString() == "0" ? "X" :"✓"  %>' Font-Bold="true" Font-Size="Small"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>








                      <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button is-info is-outlined"
                                    style="Width:40%; Height:25px"  
                                                                                    Visible='<%#Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات") %>'

                            ID="btn_Edit" runat="server" Font-Size="Small" Text="ادخال يدوي" CommandName="Edit" />
                    </ItemTemplate>
            
                </asp:TemplateField>

                   <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button is-warning "
                                    style="Width:40%; Height:25px"  

                            ID="AutoIn" runat="server"  Visible ='<%# (Eval("RecDate").ToString().Length > 0 )&& (Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات"))? false :true  %>' Font-Size="Small" Text="ادخال تلقائي" CommandArgument='<%#Eval("EmpID") %>' CommandName="AutoIn" />
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

</asp:Content>
