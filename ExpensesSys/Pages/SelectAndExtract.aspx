<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="SelectAndExtract.aspx.cs" Inherits="ExpensesSys.Pages.SelectAndExtract" %>
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
  .BigCheckBox input {width:23px; height:23px;}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       
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
    <article class="panel is-info" style="background-color: white;padding-bottom:2em;">
        <p class="panel-heading text-center" style="background-color:#3399ff;">                <asp:Label  runat ="server" ID ="PageProjectNameLbl" Text="" ></asp:Label>
<i class="fa-solid fa-file-invoice-dollar"></i></p>
                                       <asp:Panel runat="server" >

   
           <div class="row m-2" >

            <div class="col-12 mt-2  align-content-center text-center align-items-center">


      


                         <div class="form__group field  align-content-center text-center align-items-center">
     <asp:Label runat="server" ID="SearchBox"   class="form__field align-content-center text-center align-items-center" ReadOnly="false" type="input" placeholder="" Text="الرجاء تحديد الوحدات" />

    <label for="name" class="form__label"></label>
</div>      
                    
                    </div>
           

                 <div class="col-md-12 text-center  mt-2">

          
                  <asp:LinkButton runat="server" Visible="true" ID="ExportBtn" Style="background-color: white; color: #beae00; font: bold; border-color: #beae00; word-spacing: 3px;" Text="Excel تصدير الى"
                data-target="modal-js-example"
                OnClick="ExportToExcel"
                class="js-modal-trigger button is-fullwidth  align align-content-center mt-2 button is-ou">Excel تصدير الى
                       
                        <i class="fa-solid fa-file-arrow-down" style="margin-left: 1em">

                        </i></asp:LinkButton>    
                 
                 </div>

                </div>
 </asp:Panel>

     <div class="row ">
        
          
                <div class="container-fluid d-flex flex-column">
         <div class="row m-3  text-center align-content-center" >

       

                                                                 <div class="col-5 align-content-center  text-center"  >
                                                                             </div>


                          <div class="col-2 align-content-center  text-center"  >

    <div class="content-1 align-content-center text-center">
        <div id="Layer1" style="position:relative;height:450px;
overflow:scroll;">
      <asp:CheckBoxList runat="server" ID="ChBoxList"   CssClass="BigCheckBox"  Font-Size="2em" Font-Bold="true" > 
                        
                    </asp:CheckBoxList>


        </div>
              
               
            
 
                
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
