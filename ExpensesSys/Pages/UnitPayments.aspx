<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="UnitPayments.aspx.cs" Inherits="ExpensesSys.Pages.UnitPayments" %>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <asp:Panel runat="server" ID="ButtonsBar">
        <div class="row " style="margin-bottom: 1em">
                       <div class="col-3">





     <asp:LinkButton  runat="server" ID ="NewPayemnt" style="background-color: white; color: #33B3FF; font: bold; border-color:#33B3FF" text="اضافة دفعة جديدة"
        
         
         data-target="modal-js-example"
                                 onclick="GoToNewItem"

                        class="js-modal-trigger button is-fullwidth  align align-content-center  button is-ou">اضافة دفعة جديدة 
                       
                        <i class="fas fa-add " style="margin-left: 1em">

                        </i></asp:LinkButton>

                    </div>
   <div class=" col-6">                                                </div>

            <div class=" col-3">
     <asp:LinkButton  runat="server"  style="background-color: white; color: #33B3FF; font: bold; border-color:#33B3FF" text="الرجوع"
        
         
         data-target="modal-js-example"
                                 onclick="Return"

                        class="js-modal-trigger button is-fullwidth  align align-content-center  button is-ou">الرجوع
                       
                        <i class="fas fa-home " style="margin-left: 1em">

                        </i></asp:LinkButton>

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
                </div>
            </div>

        </div>
    </asp:Panel>
    <article class="panel is-info" style="background-color: white;padding-bottom:2em;">
        <p class="panel-heading text-center" style="background-color:#3399ff;">                <asp:Label  runat ="server" ID ="PageProjectNameLbl" Text="" ></asp:Label>
<i class="fa-solid fa-file-invoice-dollar"></i></p>
        
        


 
     <div class="row ">
        
          
                <div class="container-fluid d-flex flex-column">
        <div class="row m-2" >

            <div class="col-12">
              
      <div class="content-1">
           


                        <asp:GridView ShowHeaderWhenEmpty="true" ID="DataGridUsers" runat="server" AutoGenerateColumns="False"  class="table table-striped  table-hover border-0 " CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"

OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"
                                                      OnRowCommand="MyGridView_OnRowCommand"

                            HeaderStyle-HorizontalAlign="Center"
                            >
            <Columns>
        

                <asp:TemplateField ItemStyle-HorizontalAlign="Center" Visible="false" HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="الوحدة">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_RecID" runat="server" Text='<%#Eval("RecID") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="رقم الدفعة">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_Qudgdant" runat="server" Text='<%#Eval("PayNo") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>      
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="مبلغ الدفعة الكامل">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_33Quant1" runat="server" Text='<%#Eval("Amount") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>         <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="المبلغ المدفوع">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_Quant1" runat="server" Text='<%#Eval("PaidAmount") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>         
                
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="تاريخ استلام الدفعة الاخيرة">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_Quant1WithdrowParty" runat="server" Text='<%#Eval("DateOfPay") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>      
                
                    
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="تاريخ الوصل">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_Quant1WithdrowParty2" runat="server" Text='<%#Eval("TicketDate") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>   

                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="عدد الدفعات">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_Quant1WithdrowPartycount" runat="server" Text='<%#Eval("PayemntsPayemntsCount") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>      

                    
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="مدفوعة بالكامل">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_ORName12s2" runat="server" class='<%# Eval("Paid").ToString() == "0" ? "js-modal-trigger button is-danger is-outlined" :"js-modal-trigger button is-primary is-outlined"  %>' Text='<%# Eval("Paid").ToString() == "0" ? "X" :"✓"  %>' Font-Bold="true" Font-Size="Small"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


           
                      <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                      Font-Bold="true"                          class="js-modal-trigger button is-small is-bold is-info is-outlined"
                                    style="Width:50%; Height:25px"  
                            Font-Size="Large"
                            Visible='<%#Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات") %>'
                            ID="btn_Edit" runat="server" Text="تعديل" CommandName="Edit" />
                    </ItemTemplate>
            
                </asp:TemplateField>
       

                   <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button Font-Bold="true"
                                                                class="js-modal-trigger  is-bold button is-warning "
                                    style="Width:50%; Height:25px"  
                            CommandArgument='<%#Eval("ID") %>' CommandName="GoToPay"
                                                        Visible='<%#Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات") %>'

                            ID="btn_Edit1" runat="server" Text="الدفعات"  />
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
