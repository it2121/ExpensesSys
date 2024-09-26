<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="FullReportInAndOutWithDate.aspx.cs" Inherits="ExpensesSys.Pages.FullReportInAndOutWithDate" %>

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


            <div class="col-4">
                <asp:Panel ID="DatePanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="true">




                    <div class="row  m-4">




                        <asp:CheckBox runat="server" ID="UnMarkedDate" class="input is-info border-0 checkbox " Width="100%" Checked="true" AutoPostBack="true" OnCheckedChanged="ChckedChanged" type="text" Text="من دون تحديد فترة زمنية" TextAlign="Right" placeholder="من دون تحديد فترة زمنية" />
                    </div>

                    <asp:UpdatePanel ID="UpdatePanelDates" runat="server" style="width: 100%;" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="row m-4">
                                <div class="col-6">

                                    <p class="control has-icons-left">

                                        <asp:TextBox runat="server" ID="StartDate" Enabled="false" class="input is-info" type="text" placeholder="من تاريخ" />
                                        <span class="icon is-left">
                                            <i class="fas fa-book" aria-hidden="true"></i>
                                        </span>
                                    </p>
                                </div>
                                <div class="col-6">


                                    <p class="control has-icons-left">
                                        <asp:TextBox runat="server" Enabled="false" ID="EndDate" class="input is-info" type="text" placeholder="الى تاريخ" />
                                        <span class="icon is-left">
                                            <i class="fas fa-book" aria-hidden="true"></i>
                                        </span>
                                    </p>
                                </div>
                            </div>

                        </ContentTemplate>
                    </asp:UpdatePanel>

                </asp:Panel>

            </div>

            <div class="col-4">

                <asp:Panel ID="WithdrowPartyPanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="true">




                    <div class="row  m-4">




                        <asp:CheckBox runat="server" ID="PrjectNameCheck" class="input is-info border-0 checkbox " Width="100%" Checked="true" AutoPostBack="true" OnCheckedChanged="ChckedChangedProjectName" type="text" Text="من دون تحديد مشروع" TextAlign="Right" placeholder="من دون تحديد مشروع" />
                    </div>

                    <asp:UpdatePanel ID="ProjectNameUpdatePanel" runat="server" style="width: 100%;" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="row m-4">
                                <div class="col-12">

                                    <p class="control has-icons-left">

                                        <asp:DropDownList
                                            ID="ProjectName" Enabled="false"
                                            class="input is-info" type="text" placeholder="المشروع"
                                            AutoPostBack="True"
                                            runat="server">
                                        </asp:DropDownList>
                                        <span class="icon is-left">
                                            <i class="fas fa-book" aria-hidden="true"></i>
                                        </span>
                                    </p>
                                </div>
                            </div>

                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:Label runat="server" ID="Label2" Font-Bold="true" Font-Size="Small" ForeColor="Red" Text="المصروفات العامة لا تتاثر بهذا الفلتر * "></asp:Label>

                </asp:Panel>
            </div>

            <div class="col-4">

                <asp:Panel ID="ProjectNamePanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="true">




                    <div class="row  m-4">




                        <asp:CheckBox runat="server" ID="WithdrowPartyCheck" class="input is-info border-0 checkbox " Width="100%" Checked="true" AutoPostBack="true" OnCheckedChanged="ChckedChangedWithdowParty" type="text" Text="من دون تحديد جهة السحب" TextAlign="Right" placeholder="من دون تحديد مشروع" />
                    </div>

                    <asp:UpdatePanel ID="WithdrowPartyUpdatePanel" runat="server" style="width: 100%;" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="row m-4">
                                <div class="col-12">

                                    <p class="control has-icons-left">

                                        <asp:DropDownList ID="WithdrowParty" Enabled="false"
                                            class="input is-info" type="text" placeholder="المشروع"
                                            AutoPostBack="True"
                                            runat="server">
                                        </asp:DropDownList>
                                        <span class="icon is-left">
                                            <i class="fas fa-book" aria-hidden="true"></i>
                                        </span>
                                    </p>
                                </div>
                            </div>

                        </ContentTemplate>
                    </asp:UpdatePanel>

                </asp:Panel>
            </div>





        </div>



  
        <div class="row m-2">
            <asp:Button runat="server" ID="Button5" Style="width: 100%; margin-top: 1.6rem;" OnClick="CalclateAllTables" class="button is-primary text-center" Font-Size="Larger" Text="انشاء التقرير"></asp:Button>

        </div>    <div class="row m-2">

                    <asp:LinkButton runat="server" Visible="false"  ID="ExportBtn" Style="background-color: white; color: #beae00; font: bold; border-color: #beae00; word-spacing:3px;" Text="Excel تصدير الى"
                        data-target="modal-js-example"
                        OnClick="ExportToExcel"
                        class="js-modal-trigger button is-fullwidth  align align-content-center mt-2 button is-ou">Excel تصدير الى
                       
                        <i class="fa-solid fa-file-arrow-down" style="margin-left: 1em">

                        </i></asp:LinkButton>
        </div>
        <hr />

        <div class="row m-2">

            <div class="col-md-4 text-center ">

                <asp:Button runat="server" ID="CreateBtn" Style="width: 20em; margin-top: 1.6rem;" OnClick="CreateInReport" class="button  is-outlined is-primary text-center " Text="اضهار تقرير الوارد"></asp:Button>
            </div>
            <div class="col-md-8 text-center ">
                <div class="row m-2">
                    <div class="col-6 text-center ">

                        <asp:Button runat="server" ID="Button1" Style="width: 100%" OnClick="CreateNthReport" class="button  is-outlined is-danger text-center " Text="اضهار تقرير المصروفات العامة"></asp:Button>
                    </div>
                    <div class="col-md-6 text-center ">

                        <asp:Button runat="server" ID="Button2" Style="width: 100%" OnClick="CreateMatBuyReport" class="button  is-outlined  is-danger text-center " Text="اضهار تقرير المواد"></asp:Button>
                    </div>
                </div>
                <div class="row m-2">
                    <div class="col-md-6 text-center ">

                        <asp:Button runat="server" ID="Button3" Style="width: 100%" OnClick="CreateSalaryReport" class="button  is-outlined  is-danger text-center " Text="اضهار تقرير الرواتب"></asp:Button>
                    </div>
                    <div class="col-md-6 text-center ">

                        <asp:Button runat="server" ID="Button4" Style="width: 100%" OnClick="CreateCompReport" class="button is-outlined  is-danger text-center " Text="اضهار تقرير الاخرى"></asp:Button>
                    </div>
                </div>
            </div>
        </div>

        <hr />


        <br />
        <div style="background-color: #f2fff3; width: 100%;" class="text-center">
            <div class="row">

                <div class="col-md-4  text-center ">
                    <asp:Label runat="server" ID="IncomeSum" Font-Bold="true" ForeColor="DarkCyan" Text="0 IQD مجموع الوارد"></asp:Label>

                </div>

                <div class="col-md-8 text-center  ">
                    <div class="row m-2">
                        <div class="col-6 text-center ">



                            <asp:Label runat="server" ID="NthSum" ForeColor="DarkOrange" Font-Bold="true" Text="0 IQD مجموع المصروفات العامة "></asp:Label>





                        </div>
                        <div class="col-6 text-center ">



                            <asp:Label runat="server" ID="MatBuySum" ForeColor="DarkOrange" Font-Bold="true" Text="0 IQD مجموع صرفيات المواد"></asp:Label>





                        </div>


                    </div>
                    <div class="row m-2">
                        <div class="col-6 text-center ">



                            <asp:Label runat="server" ID="SalarySum" ForeColor="DarkOrange" Font-Bold="true" Text="0 IQD مجموع الرواتب"></asp:Label>





                        </div>
                        <div class="col-6 text-center ">



                            <asp:Label runat="server" ID="CompSum" ForeColor="DarkOrange" Font-Bold="true" Text="0 IQD مجموع الصرفيات الاخرى"></asp:Label>





                        </div>


                    </div>
                </div>
            </div>
        </div>

        <asp:Panel ID="IncomePanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="false">

            <div class="row ">

                <div class="col-12  text-center">
                   <br />
                    <asp:Label runat="server" ID="Label1" ForeColor="DarkGreen"  Font-Size="Larger" Font-Bold="true" Text="الايرادات والتمويل"></asp:Label>
                </div>
                <br />

                <div class="container-fluid d-flex flex-column">
                    <div class="row m-2">

                        <div class="col-12">

                            <div class="content-1">



                                <asp:GridView ShowHeaderWhenEmpty="true" Visible="true" ID="IncomeTbl" runat="server" AutoGenerateColumns="True" class="table table-striped display table-hover border-0 " CellPadding="6"
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
        <asp:Panel ID="MatBuyPanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="false">




            <div class="row ">

                <div class="col-12 text-center">
                    <br />
                  
                    <asp:Label runat="server" ID="Label3" ForeColor="DarkGreen" Font-Size="Larger" Font-Bold="true" Text="صرفيات المواد"></asp:Label>
                </div>
                <div class="container-fluid d-flex flex-column">
                    <div class="row m-2">

                        <div class="col-12">

                            <div class="content-1">



                                <asp:GridView ShowHeaderWhenEmpty="true" Visible="true" ID="MatBuyTbl" runat="server" AutoGenerateColumns="True" class="table table-striped  table-hover border-0 " CellPadding="6"
                                    Font-Bold="true"
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
        <asp:Panel ID="SalaryPanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="false">


            <div class="row ">

                <div class="col-12 text-center">
                    <br />
                    
                    <asp:Label runat="server" ID="Label4" ForeColor="DarkGreen" Font-Size="Larger" Font-Bold="true" Text="صرفيات الرواتب"></asp:Label>
                </div>
                <div class="container-fluid d-flex flex-column">
                    <div class="row m-2">

                        <div class="col-12">

                            <div class="content-1">



                                <asp:GridView ShowHeaderWhenEmpty="true" Visible="true" ID="SalaryTbl" runat="server" AutoGenerateColumns="True" class="table table-striped  table-hover border-0 " CellPadding="6"
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

        <asp:Panel ID="CompPanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="false">

            <div class="row ">

                <div class="col-12 text-center">
                    <br />
                   
                    <asp:Label runat="server" ID="Label5" ForeColor="DarkGreen" Font-Size="Larger" Font-Bold="true" Text="صرفيات خرى"></asp:Label>
                </div>
                <div class="container-fluid d-flex flex-column">
                    <div class="row m-2">

                        <div class="col-12">

                            <div class="content-1">



                                <asp:GridView ShowHeaderWhenEmpty="true" Visible="true" ID="CompTbl" runat="server" AutoGenerateColumns="True" class="table table-striped  table-hover border-0 " CellPadding="6"
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
        <asp:Panel ID="NthPanel" Width="95%" HorizontalAlign="Center" CssClass="container-fluid" BorderColor="LightGreen" BorderStyle="Solid" BorderWidth="0.2em" runat="server" Visible="false">
            <div class="row ">
                <div class="col-12 text-center">
                    <br />
                  
                    <asp:Label runat="server" ID="Label6" ForeColor="DarkGreen" Font-Size="Larger" Font-Bold="true" Text="الصرفيات العامة"></asp:Label>
                </div>

                <div class="container-fluid d-flex flex-column">
                    <div class="row m-2">

                        <div class="col-12">

                            <div class="content-1">



                                <asp:GridView ShowHeaderWhenEmpty="true" Visible="true" ID="NthTbl" runat="server" AutoGenerateColumns="True" class="table table-striped  table-hover border-0 " CellPadding="6"
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
        new DataTable('#IncomeTbl');
        var table = $('#IncomeTbl').DataTable();

        new DataTable.Responsive(table);

    </script>


    <script>

        var table1 = $('#NthTbl').DataTable();

        new DataTable.Responsive(table1);

    </script>
    <script>

        var table2 = $('#CompTbl').DataTable();

        new DataTable.Responsive(table2);

    </script>
    <script>

        var table3 = $('#SalaryTbl').DataTable();

        new DataTable.Responsive(table3);

    </script>
    <script>

        var table4 = $('#MatBuyTbl').DataTable();

        new DataTable.Responsive(table4);

    </script>



</asp:Content>
