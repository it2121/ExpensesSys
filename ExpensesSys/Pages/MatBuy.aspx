<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="MatBuy.aspx.cs" Inherits="ExpensesSys.Pages.MatBuy" %>
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
     
    
         <asp:Panel runat="server" ID="Panel1">
        <div class="row " style="margin-bottom: 1em">
                 
                
              <div class="col-auto">
                <div class="field buttons align-items-end">





     <asp:LinkButton  runat="server"  ID="AddnewBtn" style="background-color: white; color: #33B3FF; font: bold; border-color:#33B3FF" text="اضافة قيد شراء جديد"
        
         
         data-target="modal-js-example"
                                 onclick="GoToNewItem"

                        class="js-modal-trigger button is-fullwidth  align align-content-center  button is-ou">اضافة قيد شراء جديد 
                       
                        <i class="fas fa-add " style="margin-left: 1em">

                        </i></asp:LinkButton>

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
        
        


 
     <div class="row ">
        
          
                <div class="container-fluid d-flex flex-column">
        <div class="row m-2" >

            <div class="col-12">
              
      <div class="content-1">
           


                        <asp:GridView ShowHeaderWhenEmpty="true" ID="DataGridUsers" runat="server" AutoGenerateColumns="False"  class="table table-striped  table-hover border-0 " CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"

OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"
                            HeaderStyle-HorizontalAlign="Center"
                          OnRowCommand="MyGridView_OnRowCommand"
                             OnRowDataBound="GridView1_RowDataBound"

                            >
            <Columns>
        

                <asp:TemplateField ItemStyle-HorizontalAlign="Center" Visible="false" HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                
                     <asp:TemplateField ItemStyle-HorizontalAlign="Center" Visible="false" HeaderText="FileID">
                    <ItemTemplate>
                        <asp:Label ID="lbl_IDFileID" runat="server" Text='<%#Eval("FileID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    

                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="رقم العقد">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR4" runat="server" Text='<%#Eval("ContractNumber") %>' Font-Bold="true" Font-Size="Medium"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>      
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="التاريخ">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR3" runat="server" Text='<%#Eval("ContractDate") %>' Font-Bold="true" Font-Size="Medium"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="أسم المادة">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR" runat="server" Text='<%#Eval("MatName") %>' Font-Bold="true" Font-Size="Medium"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="الكمية">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_Quant" runat="server" Text='<%#Eval("Quant") %>' Font-Bold="true" Font-Size="Medium"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>   
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="المجهز">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_Count" runat="server" Text='<%#Eval("NameOfSupplyer") %>' Font-Bold="true" Font-Size="Medium"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>   <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="النوع">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_Type" runat="server" Text='<%#Eval("MatType") %>' Font-Bold="true" Font-Size="Medium"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="اجمالي الكلفة">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_TotalCost" runat="server" Text='<%#Eval("TotalCost") %>' Font-Bold="true" Font-Size="Medium"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField><asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="المدفوع">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_RecAmount" runat="server" Text='<%#Eval("RecAmount") %>' Font-Bold="true" Font-Size="Medium"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

           
             
    
           
                      <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                      Font-Bold="true"                          class="js-modal-trigger button  is-bold is-info is-outlined"
                                    style="Width:50%; Height:25px"  

                            ID="btn_Edit" runat="server" Text="تعديل" CommandName="Edit" />
                    </ItemTemplate>
            
                </asp:TemplateField>
                  <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button Font-Bold="true"
                                                                class="js-modal-trigger button  is-bold is-primary is-outlined"
                                    style="Width:50%; Height:25px"  
                                                        Visible='<%#Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات") %>'

                            CommandArgument='<%#Eval("ID") %>' CommandName="GoToPay"
                            ID="btn_Edit1" runat="server" Text="الدفعات"  />
                    </ItemTemplate>
            
                </asp:TemplateField>

                        <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button  is-bold is-info "
                                    style="Width:60%; Height:25px"  

                            ID="RepoPrinto" runat="server"   Font-Size="Medium" Text="سحب التقرير" CommandArgument='<%#Eval("ID") %>' CommandName="PrintReport" />
                    </ItemTemplate>
            
                </asp:TemplateField>


                  <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button is-warning "
                                    style="Width:60%; Height:25px"  

                            ID="UnitDocks" runat="server"   Font-Size="Medium" Text="المستمسكات" CommandArgument='<%#Eval("FileID") %>' CommandName="Docks" />
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
