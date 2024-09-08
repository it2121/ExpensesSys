<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="GeneralInfoEditor.aspx.cs" Inherits="ExpensesSys.Pages.GeneralInfoEditor" %>
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
    <asp:Panel runat="server" ID="ButtonsBar">
        <div class="row " style="margin-bottom: 1em">

            <div class="col-auto">
                <div class="field buttons align-items-end">





                    <asp:LinkButton runat="server" Style="background-color: white; color: #33B3FF; font: bold; border-color: #33B3FF" Text="الرجوع"
                        data-target="modal-js-example"
                        OnClick="Return"
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
        <p class="panel-heading ">معلومات الموظف</p>


               <div class="row m-2">

                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="FullName"  class="form__field" type="input" placeholder="الاسم" />

    <label for="name" class="form__label">الاسم</label>
</div>
           



            </div>


                
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="PhoneNumber"  class="form__field" type="input" placeholder="رقم الهاتف" />

    <label for="name" class="form__label">رقم الهاتف</label>
</div>
           
            </div>


                
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="Address"  class="form__field" type="input" placeholder="العنوان" />

    <label for="name" class="form__label">العنوان</label>
</div>
           
            </div>
                          



            </div>

             <div class="row m-2">

           
                 
                 <div class="col-3">


                         <div class="form__group field">
     <asp:TextBox runat="server" ID="UniNumAndCat"  class="form__field" type="input" placeholder="رقم السجل والصفحة" />

    <label for="name" class="form__label">رقم السجل والصفحة</label>
</div>
            </div> 
                  <div class="col-3">
                 
                           <div class="form__group field">
     <asp:TextBox runat="server" ID="ProNum"  class="form__field" type="input" placeholder="رقم الطابو" />
    <label for="name" class="form__label">رقم الطابو</label>
</div>

                     


                
                      
            </div>   
                 
                 <div class="col-3">
                 
                           <div class="form__group field">
     <asp:TextBox runat="server" ID="BuildArea"  class="form__field" type="input" placeholder="مساحة البناء" />
    <label for="name" class="form__label">مساحة البناء</label>
</div>
</div>

                   <div class="col-3">
                 
                           <div class="form__group field">
     <asp:TextBox runat="server" ID="UniArea"  class="form__field" type="input" placeholder="مساحة الوحدة" />
    <label for="name" class="form__label">مساحة الوحدة</label>
</div>

                     


                
                      
            </div>
                     <div class="col-4">
                 
                           <div class="form__group field">
     <asp:TextBox runat="server" ID="ProPrice"  class="form__field" type="input" placeholder="سعر الوحدة" />
    <label for="name" class="form__label">سعر الوحدة</label>
</div>

                     


                
                      
            </div>
                     <div class="col-4">
                 
                           <div class="form__group field">
     <asp:CheckBox runat="server" ID="Emp"  class="form__field" type="input" placeholder="موظف" />
    <label for="name" class="form__label">موظف</label>
</div>

                     


                
                      
            </div>
                     <div class="col-4">
                 
                           <div class="form__group field">
     <asp:CheckBox runat="server" ID="Loan"  class="form__field" type="input" placeholder="مقترض" />
    <label for="name" class="form__label">مقترض</label>
</div>

                     


                
                      
            </div>  <div class="col-12">
                 
                           <div class="form__group field">
    <asp:TextBox runat="server" ID="GINote"  class="form__field" type="input" placeholder="الملاحظات" />

    <label for="name" class="form__label">الملاحظات</label>
</div>

                     


                
                      
            </div>


            </div>







                  <br />

                  <br /> 
        
        
        
        <br />

                  <br />

        <div class="row m-2">

            <div class="col-md-12 text-center ">

                <asp:Button runat="server" ID="CreateBtn" Style="width: 20em" OnClick="CreateItem" class="button is-primary text-center " Text="تاكيد"></asp:Button>
            </div>

        </div>

        <hr />


        <br />
    </article>


</asp:Content>
