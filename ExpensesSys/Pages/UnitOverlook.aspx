<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="UnitOverlook.aspx.cs" Inherits="ExpensesSys.Pages.UnitOverlook" %>

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
        }  .Worded {
            font-size: 1.2em;
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
          <p class="panel-heading text-center " style="background-color:#3399ff;">                <asp:Label  runat ="server" ID ="OverseeingOfUnit" CssClass="is-large" Font-Size="XX-Large" Text="" ></asp:Label>
<i class="fa-solid fa-file-invoice-dollar"></i></p>
        <br />
        
            <div class="row m-2" >

            <div class="col-12 align-content-center text-center">
                <label class="align-content-center text-center" style="font-size:2em;">المعلومات العامة</label>
            </div>
        </div>
        <br />
        
               <div class="row m-2">

                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="FullName"  class="form__field" type="input" ReadOnly="true"     placeholder="الاسم" />

    <label for="name" class="form__label">الاسم</label>
</div>
           



            </div>


                
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="PhoneNumber"  class="form__field" type="input" ReadOnly="true" placeholder="رقم الهاتف" />

    <label for="name" class="form__label">رقم الهاتف</label>
</div>
           
            </div>


                
                <div class="col-4">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="Address"  class="form__field" type="input" ReadOnly="true" placeholder="العنوان" />

    <label for="name" class="form__label">العنوان</label>
</div>
           
            </div>
                          



            </div>

             <div class="row m-2">

           
                 
                 <div class="col-3">


                         <div class="form__group field">
     <asp:TextBox runat="server" ID="UniNumAndCat"  class="form__field" type="input"  ReadOnly="true" placeholder="رقم السجل والصفحة" />

    <label for="name" class="form__label">رقم السجل والصفحة</label>
</div>
            </div> 
                  <div class="col-3">
                 
                           <div class="form__group field">
     <asp:TextBox runat="server" ID="ProNum"  class="form__field" type="input"  ReadOnly="true" placeholder="رقم الطابو" />
    <label for="name" class="form__label">رقم الطابو</label>
</div>

                     


                
                      
            </div>   
                 
                 <div class="col-3">
                 
                           <div class="form__group field">
     <asp:TextBox runat="server" ID="BuildArea"  class="form__field" type="input" ReadOnly="true" placeholder="مساحة البناء" />
    <label for="name" class="form__label">مساحة البناء</label>
</div>
</div>

                   <div class="col-3">
                 
                           <div class="form__group field">
     <asp:TextBox runat="server" ID="UniArea"  class="form__field" type="input" ReadOnly="true" placeholder="مساحة الوحدة" />
    <label for="name" class="form__label">مساحة الوحدة</label>
</div>

                     


                
                      
            </div>
                     <div class="col-3">
                 
                           <div class="form__group field">
     <asp:TextBox runat="server" ID="ProPrice"  class="form__field" type="input" ReadOnly="true" placeholder="سعر الوحدة" />
    <label for="name" class="form__label">سعر الوحدة</label>
</div>

                     


                
                      
            </div>
                     <div class="col-3">
                 
                           <div class="form__group field">



     <asp:CheckBox runat="server" ID="Emp"  class="form__field" type="input" ReadOnly="true" placeholder="موظف" />
    <label for="name" class="form__label">موظف</label>
</div>

                     


                
                      
            </div>
                     <div class="col-3">
                 
                           <div class="form__group field">
     <asp:CheckBox runat="server" ID="Loan"  class="form__field" type="input" ReadOnly="true" placeholder="مقترض" />
    <label for="name" class="form__label">مقترض</label>
</div>

                                   
                      
            </div>  <div class="col-3">
                 
                           <div class="form__group field">
    <asp:TextBox runat="server" ID="Warn"  class="form__field" type="input" ReadOnly="true" placeholder="حالة الانذار" />

    <label for="name" class="form__label">حالة الانذار</label>
</div>

                     


                
                      
            </div> 
                     
                                      <div class="col-3">
                                                          <asp:Label runat="server" ID="ProPriceLbl" Text="ok" ForeColor="Green" class="form__label Worded"></asp:Label>

                                                      </div> 
                                      <div class="col-3">
                                                      </div> 
                                      <div class="col-3">
                                                      </div> 
                                      <div class="col-3">
                                                      </div> 

                 <div class="col-12">
                     <br />
                  </div> 
                      
            </div>  <div class="col-12 mt-6">
                 
                           <div class="form__group field">
    <asp:TextBox runat="server" ID="GINote"  class="form__field" type="input" ReadOnly="true" placeholder="الملاحظات" />

    <label for="name" class="form__label">الملاحظات</label>
</div>

                     


                
                      
            </div>   
       
        <br />
                  <div class="row m-2">


 <div class="col-6 mr-auto ml-auto 
                        text-center">
                 
                           <div class="form__group field">
                <asp:Button runat="server" ID="Button1" Style="width: 20em" OnClick="GoToGenralInfo" class="button is-primary is-large text-center " Text="تعديل المعلومات العامة"></asp:Button>

</div>


                      
            </div> 

</div>





                  <br />

                  <br /> 
        



        <hr />
  <br />

          <div class="row m-2">


            <div class="col-12 align-content-center text-center">
                <label class="align-content-center text-center" style="font-size:2em;" >المعلومات المالية</label>
            </div>
        </div>
        <br />
        <div class="row m-2">

            <div class="col-4">



                <div class="form__group field">
                    <asp:TextBox runat="server" ID="RecIDTB" class="form__field" type="input" ReadOnly="true" placeholder="رقم الوحدة" />

                    <label for="name" class="form__label">رقم الوحدة</label>
                </div>




            </div>



            <div class="col-8">



                <div class="form__group field">
                    <asp:TextBox runat="server" ID="Total" class="form__field" ReadOnly="true" type="input" placeholder="اجمالي المبلغ" />

                    <label for="name" class="form__label">اجمالي المبلغ</label>
                </div>

            </div>
      








        </div>

        <div class="row m-2">

            <div class="col-4">
            </div>

            <div class="col-8">
                <asp:Label runat="server" ID="TotalLbl" Text="ok" ForeColor="Green" class="form__label" Worded></asp:Label>


            </div>


        </div>

        <br />
        <br />
        <div class="row m-2">


            <div class="col-3">



                <div class="form__group field">
                    <asp:TextBox runat="server" ID="Paid" class="form__field" type="input" ReadOnly="true" placeholder="المدفوع" />

                    <label for="name" class="form__label">المدفوع</label>
                </div>

            </div>

            <div class="col-3">


                <div class="form__group field">
                    <asp:TextBox runat="server" ID="RemAmount" class="form__field" ReadOnly="true" type="input" placeholder="المتبقي" />


                    <label for="name" class="form__label">المتبقي</label>
                </div>
            </div>
            <div class="col-3">

                <div class="form__group field">
                    <asp:TextBox runat="server" ID="RemBasedOnPrecentage" class="form__field" ReadOnly="true" type="input" placeholder="المتبقي حسب مرحلة الانجاز" />
                    <label for="name" class="form__label">المتبقي حسب مرحلة الانجاز</label>
                </div>






            </div>       <div class="col-3">

                <div class="form__group field">
                    <asp:TextBox runat="server" ID="RemBasedOnPrecentageOLD" class="form__field" ReadOnly="true" type="input" placeholder="المتبقي حسب نسبة الانجاز" />
                    <label for="name" class="form__label">المتبقي حسب نسبة الانجاز</label>
                </div>






            </div>




        </div>


        <div class="row m-2">

            <div class="col-3">
                <asp:Label runat="server" ID="PaidLbl" Text="ok" ForeColor="Green" class="form__label Worded"></asp:Label>

            </div>

            <div class="col-3">
                <asp:Label runat="server" ID="RemLbl" Text="ok" ForeColor="Green" class="form__label Worded"></asp:Label>


            </div>


            <div class="col-3">
                <asp:Label runat="server" ID="RemPrecLbl" Text="ok" ForeColor="Green" class="form__label Worded"></asp:Label>

            </div>   <div class="col-3">
                <asp:Label runat="server" ID="RemPrecLblOLD" Text="ok" ForeColor="Green" class="form__label Worded"></asp:Label>

            </div>

        </div>






        <br />

        <br />
               <br />
                  <div class="row m-2">


 <div class="col-6 mr-auto ml-auto 
                        text-center">
                 
                           <div class="form__group field">
                <asp:Button runat="server" ID="Button2" Style="width: 20em" OnClick="GoToFinance" class="button is-primary is-large text-center " Text="تعديل المعلومات المالية"></asp:Button>

</div>


                      
            </div> 

</div>
        <hr />
            <div class="row m-2">

            <div class="col-md-6 text-center ">

                <asp:Button runat="server" ID="Payments" Style="width: 20em" OnClick="GoToUnitPayments" class="button is-warning is-large text-center " Text="الدفعات"></asp:Button>
            </div>
            <div class="col-md-6 text-center ">

                <asp:Button runat="server" ID="LoanPayments" Style="width: 20em" OnClick="GoToLoanPayments" class="button is-warning is-large text-center " Text="دفعات القرض او المبادرة"></asp:Button>
            </div>

        </div>
  <br />
  <br />

        <div class="row m-2">

            <div class="col-12 align-content-center text-center">
                <label class="align-content-center text-center" style="font-size:2em;" >المعلومات الفنية</label>
            </div>
        </div>
  <br />
    
        
               <div class="row m-2">

                <div class="col-6">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="BuiType"  class="form__field" ReadOnly="true" type="input" placeholder="نوع الوحدة" />

    <label for="name" class="form__label">نوع الوحدة</label>
</div>
           



            </div>


                
                <div class="col-6">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="ComPre"  class="form__field" ReadOnly="true" type="input" placeholder="نسبة الانجاز" />

    <label for="name" class="form__label">نسبة الانجاز</label>
</div>
           
            </div>


                
                <div class="col-12">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="ComStage"  class="form__field" ReadOnly="true" type="input" placeholder="مرحلة الانجاز - غير معتمد" />

    <label for="name" class="form__label">مرحلة الانجاز - غير معتمد</label>
</div>
           
            </div>
                        
                <div class="col-12">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="CompStageVerfied"  class="form__field" ReadOnly="true" type="input" placeholder="مرحلة الانجاز - معتمد" />

    <label for="name" class="form__label">مرحلة الانجاز - معتمد</label>
</div>
           
            </div>
                          



            </div>

            


        <br />

        <br />
               <br />
                  <div class="row m-2">


 <div class="col-6 mr-auto ml-auto 
                        text-center">
                 
                           <div class="form__group field">
                <asp:Button runat="server" ID="Button3" Style="width: 20em" OnClick="GoToTechInfo" class="button is-primary is-large text-center " Text="تعديل المعلومات الفنية"></asp:Button>

</div>


                      
            </div> 

</div>
                <br />

                <br />


    

        <hr />


        <br />

    </article>

</asp:Content>
