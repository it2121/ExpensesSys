<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="Income.aspx.cs" Inherits="ExpensesSys.Pages.Income" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
      <asp:Panel runat="server" ID="ButtonsBar">
        <div class="row " style="margin-bottom: 1em">



        </div>
    </asp:Panel>
    <article class="panel is-info" style="background-color: white;padding-bottom:2em;">

        <p class="panel-heading text-center" style="background-color:#3399ff;">الايرادات<i class="fa-solid fa-file-invoice-dollar"></i></p>

        
              <div class="row  " style="padding:1em;">
        
          

            <div class="col-6 mt-3  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                   <asp:Button runat="server"  ID="Button6"  style="font:bolder; width:100%;" class="btn" OnClick="GoToGeneralIncome" role="button" Text="ايرادات عامة"></asp:Button>
               
              


            </div> <div class="col-6 mt-3  text-center ">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
              
                  <asp:Button runat="server"  ID="Button5"  style="font:bolder; width:100%;" class="btn" OnClick="GoToUnitIncome" role="button" Text="ايرادات الوحدات"></asp:Button>
               
              
                   
           
             



            </div>
            </div>
        
              
      
           




    

    </article>

</asp:Content>
