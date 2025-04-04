﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="UnitsOfContracts.aspx.cs" Inherits="ExpensesSys.Pages.UnitsOfContracts" %>
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
    <article class="panel is-info" style="background-color: white;padding-bottom:2em;">
        <p class="panel-heading text-center" style="background-color:#3399ff;">                <asp:Label  runat ="server" ID ="PageProjectNameLbl" Text="" ></asp:Label>
<i class="fa-solid fa-file-invoice-dollar"></i></p>
        
        

 
     <div class="row ">
        
          
                <div class="container-fluid d-flex flex-column">
        <div class="row m-2" >

            <div class="col-12">
              
      <div class="content-1">
           


                        <asp:GridView ShowHeaderWhenEmpty="true" ID="DataGridUsers" runat="server" AutoGenerateColumns="False"  class="table table-striped  table-hover border-0 " CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"
                                                        OnRowCommand="MyGridView_OnRowCommand"

OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"
                            HeaderStyle-HorizontalAlign="Center"
                          
                            >
            <Columns>
        

                <asp:TemplateField ItemStyle-HorizontalAlign="Center" Visible="false" HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="رقم العقد">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR" runat="server" Text='<%#Eval("ContractNumber") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="نوع العقد">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR1" runat="server" Text='<%#Eval("ContractType") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="الاسم">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR23" runat="server" Text='<%#Eval("NameOfPersonal") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>   
                
                
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="اجمالي الكلفة">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR22ggd33" runat="server" Text='<%#Eval("TotalCost") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                      
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="عدد الوحدات المشمولة">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR2b2dd33" runat="server" Text='<%#Eval("UnitCount") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
              
            


                   <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button is-primary "
                                    style="Width:75%; Height:25px"  

                            ID="GoToUnitsBtn" runat="server"   Font-Size="Medium" Text="تحديد الوحدات المشمولة" CommandArgument='<%#Eval("ID") %>' CommandName="GoToUnits" />
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
