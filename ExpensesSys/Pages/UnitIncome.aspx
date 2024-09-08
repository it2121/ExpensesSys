<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="UnitIncome.aspx.cs" Inherits="ExpensesSys.Pages.UnitIncome" %>
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
                       <div class="col-auto">
             
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
        <p class="panel-heading text-center" style="background-color:#3399ff;">ادارة وحدات المشاريع<i class="fa-solid fa-file-invoice-dollar"></i></p>

        
        


 
     <div class="row ">
        
          
                <div class="container-fluid d-flex flex-column">
        <div class="row m-2" >

            <div class="col-12">
              
      <div class="content-1">
           


                        <asp:GridView ShowHeaderWhenEmpty="true" ID="DataGridUsers" runat="server" AutoGenerateColumns="False"  class="table table-striped  table-hover border-0 " CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"

OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"
                            HeaderStyle-HorizontalAlign="Center"
                                                                                  OnRowCommand="MyGridView_OnRowCommand"
                           

                            >
            <Columns>
        

                <asp:TemplateField ItemStyle-HorizontalAlign="Center" Visible="false" HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="أسم الوحدة">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR" runat="server" Text='<%#Eval("RecID") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
           <%--      <asp:TemplateField  Visible="true" HeaderText="Provider">
                    <ItemTemplate>
                        <asp:Label ID="lbl_ProviderID" runat="server" Text='<%#Eval("ProviderID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
           


                

                     <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button is-primary is-outlined "
                                    style="Width:60%; Height:25px"  

                            ID="FinanceInfoBtn" runat="server"   Font-Size="Medium" Text="المعلومات المالية" CommandArgument='<%#Eval("RecID") %>' CommandName="Finance" />
                    </ItemTemplate>
            
                </asp:TemplateField>
                     <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button is-primary "
                                    style="Width:60%; Height:25px"  

                            ID="PaymentsBtn" runat="server"   Font-Size="Medium" Text="الدفعات" CommandArgument='<%#Eval("RecID") %>' CommandName="Payments" />
                    </ItemTemplate>
            
                </asp:TemplateField>

                
                     <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button is-info is-outlined "
                                    style="Width:60%; Height:25px"  

                            ID="LoanBtn" runat="server"   Font-Size="Medium" Text="معلومات المبادرة او القرض" CommandArgument='<%#Eval("RecID") %>' CommandName="Loan" />
                    </ItemTemplate>
            
                </asp:TemplateField>
                     <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button is-info "
                                    style="Width:60%; Height:25px"  

                            ID="LoanPaymentsBtn" runat="server"   Font-Size="Medium" Text="دفعات المبادرة او القرض" CommandArgument='<%#Eval("RecID") %>' CommandName="LoanPayments" />
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
