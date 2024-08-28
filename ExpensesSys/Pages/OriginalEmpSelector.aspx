<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="OriginalEmpSelector.aspx.cs" Inherits="ExpensesSys.Pages.OriginalEmpSelector" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style>
        .HeaderDiv {
  box-shadow: 4px 4px 20px Black;
    border-radius: 10px;




}


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
                </div>
            </div>

        </div>
    </asp:Panel>
    <article class="panel is-info" style="background-color: white; padding-bottom: 2em;">

        <p class="panel-heading text-center" style="background-color: #3399ff;">تحديد نوع الملاك<i class="fa-solid fa-file-invoice-dollar"></i></p>



 













      

       


        <br />

        <div class="row  " style="padding-left: 1em; padding-right: 1em;">



            <div class="col-6   text-center ">

                <asp:Button runat="server" ID="Button5" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToOriginalEmpAsManagment" role="button" Text="الملاك الاداري"></asp:Button>








            </div>

            <div class="col-6   text-center ">
                <asp:Button runat="server" ID="Button2" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToOriginalEmpAsEngineering" role="button" Text="الملاك الهندسي"></asp:Button>




            </div>     
        </div>


     


   



    </article>



</asp:Content>
