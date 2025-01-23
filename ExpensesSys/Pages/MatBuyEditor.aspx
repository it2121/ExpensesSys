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

                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="ContractNumber"  class="form__field" type="input" placeholder="رقم العقد" />

    <label for="name" class="form__label">رقم العقد</label>
</div>
</div>      
                
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="ContractDate"  class="form__field" type="input" placeholder="التاريخ" />

    <label for="name" class="form__label">التاريخ</label>
</div>
</div>              
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="NameOfSupplyer"  class="form__field" type="input" placeholder="اسم المجهز" />

    <label for="name" class="form__label">اسم المجهز</label>
</div>
</div>

    <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="MatType"  class="form__field" type="input" placeholder="نوع التجهيز" />

    <label for="name" class="form__label">نوع التجهيز</label>
</div>
</div>  <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="NumberOfSupplyer"  class="form__field" type="input" placeholder="رقم الهاتف" />

    <label for="name" class="form__label">رقم الهاتف</label>
</div>
</div> 
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="AddressOfSupplyer"  class="form__field" type="input" placeholder="العنوان" />

    <label for="name" class="form__label">العنوان</label>
</div>
</div>   <div class="col-4">


        
</div> <div class="col-4">
                       <div class="form__group field">
     <asp:TextBox runat="server" ID="Buyer"  class="form__field"   type="input" placeholder="المشتري" />

    <label for="name" class="form__label">المشتري</label>
</div>

        
</div>



</div>
          
<hr />
 <div class="row m-2">

                <div class="col-3">

                                             <div class="form__group field">
     <asp:TextBox runat="server" ID="MatName"  class="form__field" type="input" placeholder="اسم المادة" />

    <label for="name" class="form__label">اسم المادة</label>
</div>                                 



            </div>      <div class="col-3">

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
     <asp:TextBox runat="server" ID="MatUnit"  class="form__field" type="input" placeholder="الوحدة" />

    <label for="name" class="form__label">الوحدة</label>
</div>


            </div>

</div>
           <hr />  
            <div class="row m-2">


                
                <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="TotalCost"  class="form__field"  type="input" placeholder="اجمالي الكلفة" />

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
     <asp:TextBox runat="server" ID="RemAmount"  class="form__field" ReadOnly="true" type="input" placeholder="المتبقي" />

    <label for="name" class="form__label">المتبقي</label>
</div>
</div>



</div>
          
<hr />
      <div class="row m-2">


                
                <div class="col-2">
                                        </div>              

                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="ProvidedQuant"  class="form__field"  ReadOnly="true" type="input" placeholder="الكمية المجهزة" />

    <label for="name" class="form__label">الكمية المجهزة</label>
</div>
</div>              
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="ProvidedQuantPrice"  class="form__field"   ReadOnly="true" type="input" placeholder="كلفة الكمية المجهزة" />

    <label for="name" class="form__label">كلفة الكمية المجهزة</label>
</div>
</div>

  


</div>
          
<hr />

     

      <div class="row m-2">
           
                   <div class="col-md-12 text-center ">

              <asp:Button runat="server" ID="CreateBtn" style="width:20em" OnClick="CreateItem" class="button is-primary text-center " Text="اضافة قيد شراء جديد"></asp:Button>
          </div>

      </div>


            <div class="row m-2">
           
                   <div class="col-md-12 text-center ">

              <asp:Button runat="server" ID="Button1" style="width:20em" OnClick="PrintAndCreate" class="button is-primary text-center " Text="اضافة وطباعة"></asp:Button>
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
