<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="LoanEditor.aspx.cs" Inherits="ExpensesSys.Pages.LoanEditor" %>
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
  font-size: 23px;
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
        <p class="panel-heading ">معلومات الوحدة المالية</p>


               <div class="row m-2">

                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="RecIDTB"  class="form__field" type="input" ReadOnly="true" placeholder="رقم الوحدة" />

    <label for="name" class="form__label">رقم الوحدة</label>
</div>
           



            </div>


                
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="DateOfInv"  class="form__field" type="input" placeholder="تاريخ الشمول" />

    <label for="name" class="form__label">تاريخ الشمول</label>
</div>
           
            </div>   
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="Type"  class="form__field"  ReadOnly="false" type="input" placeholder="النوع" />

    <label for="name" class="form__label">النوع</label>
</div>
           
            </div>

               

              
                          



            </div>



        <br />
        <br />
             <div class="row m-2">

             
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="TotalLoanAmount"  class="form__field" type="input"  ReadOnly="false" placeholder="المبلغ الكامل" />

    <label for="name" class="form__label">المبلغ الكامل</label>
</div>
           
            </div>
                 
             
                 
                   <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="RecAmount"  class="form__field" type="input"  ReadOnly="true" placeholder="المبلغ المستلم" />

    <label for="name" class="form__label">المبلغ المستلم</label>
</div>
           
            </div>
                 

                   <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="RemAmount"  class="form__field" type="input"  ReadOnly="true" placeholder="المبلغ المتبقي" />

    <label for="name" class="form__label">المبلغ المتبقي</label>
</div>
           
            </div>
                 




            </div>


         <div class="row m-2">

                  <div class="col-4">
                                                 <asp:Label runat="server" ID ="TotalLoanAmountLbl" Text="ok" ForeColor="Green" class="form__label"></asp:Label>

                                </div> 
              
                 <div class="col-4">
                                                 <asp:Label runat="server" ID ="RecLbl" Text="ok" ForeColor="Green" class="form__label"></asp:Label>

                                </div> 

                 <div class="col-4">
                                                 <asp:Label runat="server" ID ="RemLbl" Text="ok" ForeColor="Green" class="form__label"></asp:Label>

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
