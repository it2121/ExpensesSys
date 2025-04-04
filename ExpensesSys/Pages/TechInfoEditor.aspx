﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="TechInfoEditor.aspx.cs" Inherits="ExpensesSys.Pages.TechInfoEditor" %>
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
  .BigCheckBox input {
      
      
      
      width:23px; height:23px;

       border-radius: 7px;
  border: solid 1px #bbbbbb;




  }
  .BigCheckBox tr, .BigCheckBox tr td, .BigCheckBox tr th
{
  background-color: #eeeeee;
  padding: 3px;
  border: solid 1px #bbbbbb;
  vertical-align: top;
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
        <p class="panel-heading ">المعلومات</p>


               <div class="row m-2">

                <div class="col-12">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="BuiType"  class="form__field" ReadOnly="true" type="input" placeholder="نوع الوحدة" />

    <label for="name" class="form__label">نوع الوحدة</label>
</div>
           



            </div>


                
                <div class="col-6">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="ComPre"  class="form__field" type="input" Visible="false" placeholder="نسبة الانجاز" />

<%--    <label for="name" class="form__label">نسبة الانجاز</label>--%>
</div>
           
            </div>


                
                <div class="col-12">


           
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="ComStage"  class="form__field" type="input"  Visible="false" placeholder="مرحلة الانجاز" />

<%--    <label for="name" class="form__label">مرحلة الانجاز</label>--%>
</div>
           
            </div>
                          


                   
                          <div class="col-12 align-content-center  text-center"  >

    <div class="content-1 align-content-center text-center">
        <div id="Layer1" style="position:relative;height:450px;
overflow:scroll;">
      <asp:CheckBoxList runat="server" ID="WeightReachedRecordID_CB"    CssClass="BigCheckBox"  Font-Size="2em" Font-Bold="true" > 

                    </asp:CheckBoxList>
                                        <label for="name" class="form__label">تحديد مرحلة الانجاز</label>


        </div>
              
               
            
 
                
            </div>
           

           
            </div>




            </div>

            






                  <br />

                  <br /> 
        
        
        
        <br />

                  <br />

        <div class="row m-2">

            <div class="col-md-12 text-center ">

                <asp:Button runat="server" ID="CreateBtn" Style="width: 20em" OnClick="CreateItem" class="button is-primary text-center is-large" Text="تاكيد"></asp:Button>
            </div>

        </div>
        <div class="row m-2">

            <div class="col-md-12 text-center ">

                <asp:Button runat="server" ID="SelectAndAddBtn" Style="width: 20em" OnClick="SelectAndAdd" class="button is-primary text-center is-large " Text="تحديد واضافة"></asp:Button>
            </div>

        </div>

        <hr />


        <br />
    </article>

    <script>

        function radioMe(e) {
            if (!e) e = window.event;
            var sender = e.target || e.srcElement;

            if (sender.nodeName != 'INPUT') return;
            var checker = sender;
            var chkBox = document.getElementById('<%= WeightReachedRecordID_CB.ClientID %>');
            var chks = chkBox.getElementsByTagName('INPUT');
            for (i = 0; i < chks.length; i++) {
                if (chks[i] != checker)
                    chks[i].checked = false;
            }
        }


    </script>
</asp:Content>
