﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="ProjMan.aspx.cs" Inherits="ExpensesSys.Pages.ProjMan" %>
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
                <div class="field buttons align-items-end">





     <asp:LinkButton  runat="server"  style="background-color: white; color: #33B3FF; font: bold; border-color:#33B3FF" text="اضافة وحدة جديد"
        
         
         data-target="modal-js-example"
                                 onclick="GoToNewItem"

                        class="js-modal-trigger button is-fullwidth  align align-content-center  button is-ou">اضافة مشروع جديد 
                       
                        <i class="fas fa-add " style="margin-left: 1em">

                        </i></asp:LinkButton>

                </div>
            </div>       <div class="col-auto">
                <div class="field buttons align-items-end">





     <asp:LinkButton  runat="server"  style="background-color: white; color: #33B3FF; font: bold; border-color:#33B3FF" text="ادارة الاوزان الفنية"
        
         
         data-target="modal-js-example"
                                 onclick="GoToWeightMan"

                        class="js-modal-trigger button is-fullwidth  align align-content-center  button is-ou">ادارة الاوزان الفنية 
                       
                        <i class="fas fa-add " style="margin-left: 1em">

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
                </div>
            </div>

        </div>
    </asp:Panel>
    <article class="panel is-info" style="background-color: white;padding-bottom:2em;">
        <p class="panel-heading text-center" style="background-color:#3399ff;">ادارة المشاريع<i class="fa-solid fa-file-invoice-dollar"></i></p>

        
        


 
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
                
                <asp:TemplateField   ItemStyle-HorizontalAlign="Center" Visible="true" HeaderText="أسم المشروع">
                    <ItemTemplate>
                        <asp:Label  ID="lbl_OR" runat="server" Text='<%#Eval("Name") %>' Font-Bold="true" Font-Size="Large"></asp:Label>
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
                                                                class="js-modal-trigger button is-info is-outlined"
                                    style="Width:50%; Height:25px"  

                            ID="btn_Edit" runat="server" Text="تعديل اسم المشروع" CommandName="Edit" />
                    </ItemTemplate>
            
                </asp:TemplateField>

                    <asp:TemplateField  ItemStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:Button 
                                                                class="js-modal-trigger button is-warning "
                                    style="Width:60%; Height:25px"  

                            ID="UnitMan" runat="server"   Font-Size="Medium" Text="ادارة وحدات المشروع" CommandArgument='<%#Eval("ID") %>' CommandName="UnitMan" />
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
