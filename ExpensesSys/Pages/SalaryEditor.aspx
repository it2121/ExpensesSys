<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="SalaryEditor.aspx.cs" Inherits="ExpensesSys.Pages.SalaryEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
        <p class="panel-heading ">معلومات المرتب</p>

        <div class="panel-block">
            <br />
            <br />
            <br />
            <br />
            <br />
            <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="EmpName" class="input is-info" type="text" ReadOnly="true" placeholder="اسم الموظف" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>

            <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="EmpJob" class="input is-info" type="text" ReadOnly="true" placeholder="الوظية" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>

            <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="EmpSal" class="input is-info" type="text" placeholder="المرتب" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>
            <p class="control has-icons-left">
                <asp:TextBox runat="server" ID="SalDate" class="input is-info" type="text" placeholder="تاريخ الاستلام" />
                <span class="icon is-left">
                    <i class="fas fa-book" aria-hidden="true"></i>
                </span>
            </p>









        </div>


        <div class="row">



            <div class="col-1">
                <label class="label align-content-end ml-2 mt-1">جهة السحب</label>

            </div>

            <div class="col-11">
                <asp:DropDownList ID="WithdrowParty"
                    class="input is-info" type="text" placeholder="جهة السحب"
                    AutoPostBack="True"
                    runat="server">
                </asp:DropDownList>


            </div>
            <%--                <asp:TextBox runat="server" ID="DepartmentTB" class="input is-info" type="text" placeholder="Department" />--%>
        </div>
        <div class="row m-2">

            <div class="col-md-12 text-center ">

                <asp:Button runat="server" ID="CreateBtn" Style="width: 20em" OnClick="CreateItem" class="button is-primary text-center " Text="اضافة المرتب"></asp:Button>
            </div>

        </div>

        <hr />


        <div class="row m-2">
            <div class="col-md-12 text-center ">
                <asp:Button runat="server" Visible="false"
                    UseSubmitBehavior="true"
                    OnClientClick="return confirmation();" ID="DelBtn" Style="width: 20em" OnClick="DelProv" class="button is-danger text-center" Text="حذف نهائياً"></asp:Button>
            </div>
        </div>
        <br />
    </article>

    <script>function confirmation() {
            return confirm("هل انت متاكد, سوف تحذف بيانات المرتب لهذا الشهر نهائياً?");
        }</script>




</asp:Content>
