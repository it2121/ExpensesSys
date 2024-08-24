<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="MatBuyEditor.aspx.cs" Inherits="ExpensesSys.Pages.MatBuyEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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

             
            <div class="row m-2">

                <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="MatName"  class="form__field" type="input" placeholder="اسم المادة" />

    <label for="name" class="form__label">اسم المادة</label>
</div>
</div>      
                
                <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="Quant"  class="form__field" type="input" placeholder="الكمية" />

    <label for="name" class="form__label">الكمية</label>
</div>
</div>              
                <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="Count"  class="form__field" type="input" placeholder="العدد" />

    <label for="name" class="form__label">العدد</label>
</div>
</div>

    <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="MatType"  class="form__field" type="input" placeholder="نوع المادة" />

    <label for="name" class="form__label">نوع المادة</label>
</div>
</div>



</div>
          
<hr />

            
             
            <div class="row m-2">

                <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="TotalCost"  class="form__field" type="input" placeholder="اجمالي الكلفة" />

    <label for="name" class="form__label">اجمالي الكلفة</label>
</div>
</div>      
                
                <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="RecPayCount"  class="form__field"  ReadOnly="true" type="input" placeholder="عدد الدفعات المدفوعة" />

    <label for="name" class="form__label">عدد الدفعات المدفوعة</label>
</div>
</div>              
                <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="RecAmount"  class="form__field"   ReadOnly="true" type="input" placeholder="المدفوع" />

    <label for="name" class="form__label">المدفوع</label>
</div>
</div>

    <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="RemAmount"  class="form__field" type="input" placeholder="المتبقي" />

    <label for="name" class="form__label">المتبقي</label>
</div>
</div>



</div>
          
<hr />

          
            <div class="row m-2">

                <div class="col-6">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="BuyingParty"  class="form__field" type="input" placeholder="جهة الشراء" />

    <label for="name" class="form__label">جهة الشراء</label>
</div>
</div>      
                
                     
                <div class="col-6">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="Buyer"  class="form__field"   ReadOnly="true" type="input" placeholder="المشتري" />

    <label for="name" class="form__label">المشتري</label>
</div>
</div>




</div>
          
<hr />

     
     
<div class="row">

    <div class="col-1">
    </div>

        
<div class="col-10">
 
              
                         <div class="form__group field ">
    <asp:DropDownList ID="WereHouseState"
                    class="form__field mt-2" type="text" placeholder="حالة التخزين"
                    AutoPostBack="True"
                    runat="server">
             
           <asp:ListItem Selected="True" Value="لم تسلم بعد">لم تسلم بعد</asp:ListItem>
                    <asp:ListItem Value="في المخزن">في المخزن</asp:ListItem>
                    <asp:ListItem Value="مستهلكة بالكامل">مستهلكة بالكامل</asp:ListItem>

                </asp:DropDownList>
    <label for="name" class="form__label">المشتري</label>
</div>
<hr />

</div>  <%--                <asp:TextBox runat="server" ID="DepartmentTB" class="input is-info" type="text" placeholder="Department" />--%>


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
