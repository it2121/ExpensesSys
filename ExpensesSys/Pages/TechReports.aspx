<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="TechReports.aspx.cs" Inherits="ExpensesSys.Pages.TechReports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

      <script type="text/javascript">

        $(document).ready(function () {

            $(document).ready(function () {
                $('#IncomeTbl').DataTable();
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

    <!-- Bootstrap -->

    <!-- Bootstrap -->
    <!-- Bootstrap DatePicker -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/css/bootstrap-datepicker.css" type="text/css" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/js/bootstrap-datepicker.js" type="text/javascript"></script>
    <!-- Bootstrap DatePicker -->
    <script type="text/javascript">
        $(function () {
            $('[id*=StartDate]').datepicker({
                format: "dd/mm/yyyy",
                language: "tr"
            });
        });
    </script>




    <!-- Bootstrap DatePicker -->
    <script type="text/javascript">
        $(function () {
            $('[id*=EndDate]').datepicker({
                format: "dd/mm/yyyy",
                language: "tr"
            });
        });
    </script>
    <article class="panel is-info" style="background-color: white;">

        <p class="panel-heading ">التقارير</p>
        <br />
        <div class="row">



            <div class="col-12">

                <asp:Panel ID="WithdrowPartyPanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="true">
                    <div class="row  m-4">
                        <asp:CheckBox runat="server" ID="PrjectNameCheck" class="input is-info border-0 checkbox " Width="100%" Checked="false" AutoPostBack="true" OnCheckedChanged="ChckedChangedProjectName" type="text" Text="نوع الوحدة" TextAlign="Right" placeholder="تحديد مشروع" />
                    </div>
                    <asp:UpdatePanel ID="ProjectNameUpdatePanel" runat="server" style="width: 100%;" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="row m-4">
                                <div class="col-12">
                                    <p class="control has-icons-left">
                                        <asp:DropDownList ID="UnitType" Enabled="false"
                                            class="input is-info" type="text" placeholder="نوع الوحدة"
                                            AutoPostBack="True"
                                            runat="server">
                                        </asp:DropDownList>

                                    </p>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </asp:Panel>
            </div>









            <div class="col-4">

                <asp:Panel ID="EmpPanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" 
                    BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="false">
                    <div class="row  m-4">
                        <asp:CheckBox runat="server" ID="EmpPanelCheck" class="input is-info border-0 checkbox " Width="100%" Checked="false" AutoPostBack="true" OnCheckedChanged="ChckedChangedEmpStatus" type="text" Text="حالة التوظيف" TextAlign="Right" placeholder="حالة التوظيف" />
                    </div>
                    <asp:UpdatePanel ID="UpdateEmpPanel" runat="server" style="width: 100%;" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="row m-4">
                                <div class="col-12 align-content-center text-center">
                                    <p class="control align-content-center text-center">


                                        <asp:DropDownList ID="EmpRadioLost" Enabled="false"
                                            class="input is-info" type="text" placeholder="نوع الوحدة"
                                            AutoPostBack="True"
                                            runat="server">

                                            <asp:ListItem Selected="True" Value="1">موظف</asp:ListItem>
                                            <asp:ListItem Value="0">غير موظف</asp:ListItem>
                                        </asp:DropDownList>



                                    </p>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </asp:Panel>
            </div>


        <div class="col-4">

                <asp:Panel ID="LoanPanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid"
                    BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="false">
                    <div class="row  m-4">
                        <asp:CheckBox runat="server" ID="LoanCheck" class="input is-info border-0 checkbox " Width="100%" Checked="false" AutoPostBack="true" OnCheckedChanged="ChckedChangedLoanStatus" type="text" Text="حالة الاقتراض" TextAlign="Right" placeholder="حالة الاقتراض" />
                    </div>
                    <asp:UpdatePanel ID="UpdateLoanCheck" runat="server" style="width: 100%;" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="row m-4">
                                <div class="col-12 align-content-center text-center">
                                    <p class="control align-content-center text-center">


                                        <asp:DropDownList ID="LoanRadioLost" Enabled="false"
                                            class="input is-info" type="text" placeholder="حالة الاقتراض"
                                            AutoPostBack="True"
                                            runat="server">

                                            <asp:ListItem Selected="True" Value="1">مقترض</asp:ListItem>
                                            <asp:ListItem Value="0">غير مقترض</asp:ListItem>
                                        </asp:DropDownList>



                                    </p>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </asp:Panel>
            </div>



            
   


                    
        <div class="col-4 mt-3">

                <asp:Panel ID="WarnPanel"  Width="95%" HorizontalAlign="Center" CssClass="container-fluid" 
                    BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="false">
                    <div class="row  m-4">
                        <asp:CheckBox runat="server" ID="WarnCheck" class="input is-info border-0 checkbox " Width="100%" Checked="false" AutoPostBack="true" OnCheckedChanged="ChckedChangedWarnStatus" type="text" Text="حالة الانذار" TextAlign="Right" placeholder="حالة الانذار" />
                    </div>
                    <asp:UpdatePanel ID="UpdateWarnPanel" runat="server" style="width: 100%;" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="row m-4">
                                <div class="col-12 align-content-center text-center">
                                    <p class="control align-content-center text-center">


                                        <asp:DropDownList ID="WarnList" Enabled="false"
                                            class="input is-info" type="text" placeholder="حالة الانذار"
                                            AutoPostBack="True"
                                            runat="server">

                                            <asp:ListItem Selected="True" Value="بلا انذار" Text="بلا انذار">بلا انذار</asp:ListItem>
                                            <asp:ListItem Value="انذار اولي" Text="انذار اولي">انذار اولي</asp:ListItem>
                                            <asp:ListItem Value="انذار نهائي" Text="انذار نهائي">انذار نهائي</asp:ListItem>
                                        </asp:DropDownList>



                                    </p>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </asp:Panel>
            </div>


     <div class="col-8 mt-3">

                <asp:Panel ID="MoneyFilterPanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" 
                    BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="false">
                    <div class="row  m-4">
                        <asp:CheckBox runat="server" ID="MoneyFilterCheck" class="input is-info border-0 checkbox " Width="100%" Checked="false" AutoPostBack="true" 
                            OnCheckedChanged="ChckedChangedMoneyStatus" type="text" Text="فلتر بمقدار المبلغ" TextAlign="Right" placeholder="فلتر بمقدار المبلغ" />
                    </div>
                    <asp:UpdatePanel ID="UpdateMoneyFilterPanel" runat="server" style="width: 100%;" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="row m-4">
                                <div class="col-6 align-content-center text-center">
                                    <p class="control align-content-center text-center">


                                        <asp:DropDownList ID="MoneyList" Enabled="false"
                                            class="input is-info" type="text" placeholder="نوع الفلتر"
                                            AutoPostBack="True"
                                            runat="server">

                                            <asp:ListItem Selected="True" Value="الواصل" Text="الواصل">الواصل</asp:ListItem>
                                            <asp:ListItem Value="المطلوب" Text="المطلوب">المطلوب</asp:ListItem>
                                            <asp:ListItem Value="المتبقي" Text="المتبقي">المتبقي</asp:ListItem>
                                        </asp:DropDownList>



                                    </p>
                                </div>
                                                                <div class="col-6 align-content-center text-center">
                                     
                         <div class="form__group field">
     <asp:TextBox runat="server" ID="MoneyTB"  class="form__field" Enabled="false" type="input" placeholder="المقدار" />

    <label for="name" class="form__label">المقدار</label>
</div>
                            </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </asp:Panel>
            </div>
        </div>


        <div class="row m-2">
            <asp:Button runat="server" ID="Button5" Style="width: 100%; margin-top: 1.6rem;" OnClick="CalclateAllTables" class="button is-primary text-center" Font-Size="Larger" Text="انشاء التقرير"></asp:Button>

        </div>
        <div class="row m-2">

            <asp:LinkButton runat="server" Visible="false" ID="ExportBtn" Style="background-color: white; color: #beae00; font: bold; border-color: #beae00; word-spacing: 3px;" Text="Excel تصدير الى"
                data-target="modal-js-example"
                OnClick="ExportToExcel"
                class="js-modal-trigger button is-fullwidth  align align-content-center mt-2 button is-ou">Excel تصدير الى
                       
                        <i class="fa-solid fa-file-arrow-down" style="margin-left: 1em">

                        </i></asp:LinkButton>
        </div>
     
        
        <br />
        <asp:Panel ID="OutComeTablePanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="false">

            <div class="row ">

                <div class="col-12  text-center">
                    <br />
                    <asp:Label runat="server" ID="Label1" ForeColor="DarkGreen" Font-Size="Larger" Font-Bold="true" Text="التقرير"></asp:Label>
                </div>
                <br />

                <div class="container-fluid d-flex flex-column">
                    <div class="row m-2">

                        <div class="col-12">

                            <div class="content-1">



                                <asp:GridView ShowHeaderWhenEmpty="true" 
                                    HeaderStyle-Font-Size="Small"
                                    Font-Size="Small"
                                    Visible="true" ID="OutComeTable" runat="server" AutoGenerateColumns="True" class="table table-striped display table-hover border-0 " CellPadding="6"
                                    HeaderStyle-HorizontalAlign="Center"
                                    RowStyle-HorizontalAlign="Center">
                                    <Columns>
                                    </Columns>
                                    <EmptyDataTemplate>لا توجد معلومات بعد</EmptyDataTemplate>

                                </asp:GridView>
                            </div>





                        </div>
                    </div>
                </div>
            </div>
        </asp:Panel>


    </article>


    <script>
        new DataTable('#OutComeTable');
        var table = $('#OutComeTable').DataTable();

        new DataTable.Responsive(table);

    </script>


</asp:Content>
