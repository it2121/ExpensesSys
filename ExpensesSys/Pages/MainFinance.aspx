﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="MainFinance.aspx.cs" Inherits="ExpensesSys.Pages.MainFinance" %>
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
  
    
    
    <article class="panel is-info" style="background-color: white; padding-bottom: 2em;">

        <p class="panel-heading text-center " style="background-color: #3399ff;">الــرئيسيـــة <i class="fa-solid fa-file-invoice-dollar"></i></p>




        <br />







          <div class="row m-4 " style="padding-left: 1em; padding-right: 1em;">





               <div class="col   text-center ">
                <asp:Button runat="server" ID="Button3" Style="font: bolder; width: 100%;" class="btn" OnClick="ManyUnitOverView" role="button" Text="كشف الوحدات السكنية المتعدد"></asp:Button>
            </div>
              
            <div class="col   text-center ">
                <asp:Button runat="server" ID="Button2" Style="font: bolder; width: 100%;" class="btn" OnClick="OneUnitOverView" role="button" Text="كشف وحدة سكنية واحدة"></asp:Button>
            </div>

            </div>

       



        <div class="row   m-4 " style="padding-left: 1em; padding-right: 1em;">





            <div class="col   text-center ">
                <asp:Button runat="server" ID="SalaryManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToUpdateUnitTechInfo" role="button" Text="الايرادات و التمويل"></asp:Button>
            </div>
            <div class="col   text-center ">

                <asp:Button runat="server" ID="ProjectManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToWeightMan" role="button" Text="مصروفات المشاريع"></asp:Button>
            </div>


            </div>
          

        <div class="row   m-4 " style="padding-left: 1em; padding-right: 1em;">

            <div class="col   text-center ">
                <asp:Button runat="server" ID="EmpManBtn" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToWarehouse" role="button" Text="مصروفات عامة"></asp:Button>




            </div>
              <div class="col   text-center ">
                <asp:Button runat="server" ID="UnitSelectionthingy" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToContractUnitEmp" role="button" Text="ادارة رواتب الموظفين"></asp:Button>




            </div>
        </div>  
 
     <div class="row  m-4 " style="padding-left: 1em; padding-right: 1em;">

            <div class="col   text-center ">
                <asp:Button runat="server" ID="TechRep" Style="font: bolder; width: 100%; " class="btn" OnClick="GoToContractUnit" role="button" Text="تقارير الوحدات"></asp:Button>




            </div>
           <div class="col   text-center ">
                <asp:Button runat="server" ID="Button1" Style="font: bolder; width: 100%;" class="btn" OnClick="GoToTechReports" role="button" Text="تقارير الصرفيات والايرادات"></asp:Button>




            </div>
        </div>
  
        

        <div class="row ">
        </div>





    </article>












</asp:Content>
