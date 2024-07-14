<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ExpensesSys.Pages.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
    <article class="panel is-info" style="background-color: white;padding-bottom:2em;">
        <p class="panel-heading text-center" style="background-color:#3399ff;">الرئيسيـــة <i class="fa-solid fa-file-invoice-dollar"></i></p>

        
              <div class="row  " style="padding:1em;">
        
          

            <div class="col-6 mt-3  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
              <button class="button-64" role="button" style="font:bolder;" ><span class="text">   <i class="fa-solid fa-list-check mt-1 mr-3"></i> مصروفـــات المشاريــــع</span></button>



            </div> <div class="col-6 mt-3  text-center ">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>

                              <button class="button-64" role="button" style="font:bolder;" ><span class="text">   <i class="fa-solid fa-gear mt-1 mr-3"></i> ادارة المشاريــــع</span></button>


            </div>
            </div>
        
        <div class="row  " style="padding:1em;">
        
          

            <div class="col-6 mt-3  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                              <button class="button-64" role="button" style="font:bolder;" ><span class="text">   <i class="fa-solid fa-money-bill-wave mt-1 mr-3"></i> رواتـــب الموظفيــــن</span></button>



            </div> 
                
                <div class="col-6 mt-3  text-center ">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
              <button class="button-64" role="button" style="font:bolder;" ><span class="text">   <i class="fa-solid fa-gear mt-1 mr-3"></i> ادارة الموظفيـــن</span></button>



            </div>
            </div>        <div class="row  " style="padding:1em;">
        
          

            <div class="col-12 mt-3  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                              <button class="button-64" role="button" style="font:bolder;" ><span class="text">   <i class="fa-solid fa-cart-shopping mt-1 mr-3"></i> مصروفـــات عامــــة</span></button>



            </div> 
                
             
            </div>  <div class="row  " style="padding:1em;">
        
          

            <div class="col-12 mt-3  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                              <button class="button-64" role="button" style="font:bolder;" ><span class="text">   <i class="fa-solid fa-scroll mt-1 mr-3"></i> التقاريــــر</span></button>



            </div> 
                
             
            </div>


 
     <div class="row ">
        
          

                <!-- HTML !-->





          
            </div>



    

    </article>


</asp:Content>
