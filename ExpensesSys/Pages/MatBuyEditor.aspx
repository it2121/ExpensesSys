<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="MatBuyEditor.aspx.cs" Inherits="ExpensesSys.Pages.MatBuyEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:ScriptManager ID="ScriptManager11" runat="server"></asp:ScriptManager>
      <asp:Panel runat="server" ID="ButtonsBar" >
            <div class="row " style="margin-bottom:1em">
    
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
        <p class="panel-heading ">معلومات قيد الشراء</p>

        <div class="panel-block">
            <br />
            <br />
            <br />
            <br />
            <br />
            <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="MatName" class="input is-info" type="text" placeholder="اسم المادة" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>  
       
              <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="Quant" class="input is-info" type="text" placeholder="الكمية" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>  

              <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="Count" class="input is-info" type="text" placeholder="العدد" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>  

             <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="MatType" class="input is-info" type="text" placeholder="نوع المادة" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>  

            

        



        </div>
        <div class="panel-block">
            <br />
            <br />
            <br />
            <br />
            <br />
            
       
              <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="TotalCost" class="input is-info" type="text" placeholder="اجمالي الكلفة" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>  
            <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="RecPayCount" class="input is-info" ReadOnly="true"  type="text" placeholder="عدد الدفعات المدفوعة" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>  

              <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="RecAmount" class="input is-info"  ReadOnly="true" type="text" placeholder="المدفوع" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>  <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="RemAmount" class="input is-info"  ReadOnly="true" type="text" placeholder="المتبقي" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>  

             

            

        



        </div>
     
       <div class="panel-block">
            <br />
            <br />
            <br />
            <br />
            <br />
            
       
              <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="BuyingParty" class="input is-info" type="text" placeholder="جهة الشراء" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>  
            <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="Buyer" class="input is-info" ReadOnly="false"  type="text" placeholder="المشتري" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>  

         


        </div>
     
      <div class="row m-2">
           
                   <div class="col-md-12 text-center ">

              <asp:Button runat="server" ID="CreateBtn" style="width:20em" OnClick="CreateItem" class="button is-primary text-center " Text="اضافة قيد شراء جديد"></asp:Button>
          </div>

      </div>
    
<hr />    
      

        <div class="row m-2">
           <div class="col-md-12 text-center ">
              <asp:Button runat="server" Visible="false" 
                   UseSubmitBehavior="true" 
    OnClientClick="return confirmation();"  ID="DelBtn" style="width:20em" OnClick="DelProv" class="button is-danger text-center" Text="حذف نهائياً"></asp:Button>
          </div>
          </div>
        <br />
    </article>

    <script>function confirmation() {
            return confirm("هل انت متاكد, سوف تحذف البيانات نهائياً?");
        }</script>




</asp:Content>
