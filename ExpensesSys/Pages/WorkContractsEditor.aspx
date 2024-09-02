<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="WorkContractsEditor.aspx.cs" Inherits="ExpensesSys.Pages.WorkContractsEditor" %>
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
  font-size: 23px;
  color: #000;
  padding: 7px 0;
  background: transparent;
  transition: border-color 0.2s;
}

.form__field::placeholder {
  color: transparent;
}

.form__field:placeholder-shown ~ .form__label {
  font-size: 23px;
  cursor: text;
  top: 20px;
}

.form__label {
  position: absolute;
  top: 0;
  display: block;
  transition: 0.2s;
  font-size: 23px;
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
        <p class="panel-heading ">المعلومات</p>




            
            <div class="row m-2">

                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="ContractNumber"  class="form__field" type="input" placeholder="رقم العقد" />

    <label for="name" class="form__label">رقم العقد</label>
</div>
           



            </div>


                
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="ContractType"  class="form__field" type="input" placeholder="نوع العقد" />

    <label for="name" class="form__label">نوع العقد</label>
</div>
           
            </div>


                    
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="NameOfPersonal"  class="form__field" type="input" placeholder="الاسم" />

    <label for="name" class="form__label">الاسم</label>
</div>
           
            </div> 
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="NumberOfPersonal"  class="form__field" type="input" placeholder="رقم الهاتف" />

    <label for="name" class="form__label">رقم الهاتف</label>
</div>
           
            </div>   
                
                <div class="col-4">
                                             <div class="form__group field">
     <asp:TextBox runat="server" ID="AddressOfPersonal"  class="form__field" type="input" placeholder="العنوان" />

    <label for="name" class="form__label">العنوان</label>
</div>
           
          
                                </div>     
                              <div class="col-4">
                                             <div class="form__group field">
     <asp:TextBox runat="server" ID="ContractDate"  class="form__field" type="input" placeholder="تاريخ العقد" />

    <label for="name" class="form__label">تاريخ العقد</label>
</div>
           
          
                                </div>     

           





            </div>


                  <br />



            
            <div class="row m-2">

                <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="Quant"  class="form__field" type="input" placeholder="الكمية" />

    <label for="name" class="form__label">الكمية</label>
</div>
           



            </div>


                
                <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="Feetage"  class="form__field" type="input" placeholder="الذرعة" />

    <label for="name" class="form__label">الذرعة</label>
</div>
           
            </div>


                
                <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="UnityType"  class="form__field" type="input" placeholder="نوع الوحدة" />

    <label for="name" class="form__label">نوع الوحدة</label>
</div>
           
            </div>       

                <div class="col-3">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="UnitPrice"  class="form__field" type="input" placeholder="سعر الوحدة" />

    <label for="name" class="form__label">سعر الوحدة</label>
</div>
           
            </div>
            </div>

        <br />
        <br />
                            <div class="row m-2">
                               
                          <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="TotalCost"  class="form__field" type="input" ReadOnly ="true" placeholder="اجمالي الكلفة - حسب الوحدات المشمولة" />

    <label for="name" class="form__label">اجمالي الكلفة - حسب الوحدات المشمولة</label>
</div>
           
            </div>   <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="PainAmount"  class="form__field" type="input" ReadOnly ="true" placeholder="ابمبلغ المدفوع" />

    <label for="name" class="form__label">المبلغ المدفوع</label>
</div>
           
            </div>   <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="RemAmount"  class="form__field" type="input" ReadOnly ="true" placeholder="المبلغ المتبقي" />

    <label for="name" class="form__label">المبلغ المتبقي</label>
</div>
           
            </div>


            </div>
          


                  <br />




  
     
                  <br />

      <div class="row m-2">
           
                   <div class="col-md-12 text-center ">

              <asp:Button runat="server" ID="CreateBtn" style="width:20em" OnClick="CreateItem" class="button is-primary text-center " Text="اضافة قيد جديد"></asp:Button>
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
