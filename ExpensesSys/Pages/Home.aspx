<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs"  Inherits="ExpensesSys.Pages.Home" %>
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

        
        
        <div class="row  " style="padding-left :1em; padding-right:1em;">
        
          

            <div class="col-6 mt-3  text-center ">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
              
                  <asp:Button runat="server"  ID="Button5"  style="font:bolder; width:100%;" class="button-89" OnClick="GoToProjMan" role="button" Text="ادارة المشاريع"></asp:Button>
               
              
                   
           
             



            </div>
                
                <div class="col-6 mt-3  text-center ">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                       <asp:Button runat="server"  ID="Button2"  style="font:bolder; width:100%;" class="button-89" OnClick="GoToEmpMan" role="button" Text="ادارة الموظفيـــن"></asp:Button>
               
              


            </div>
            </div>   
              <div class="row  " style="padding-left :1em; padding-right:1em;">
        
          
            <div class="col-12 mt-3  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                   <asp:Button runat="server"  ID="Button1"  style="font:bolder; width:100%;" class="button-89" OnClick="GoToIncome" role="button" Text="الايرادات"></asp:Button>
               
              


            </div> 
                  

            <div class="col-12 mt-3  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                   <asp:Button runat="server"  ID="Button6"  style="font:bolder; width:100%;" class="button-89" OnClick="GoToExpences" role="button" Text="مصروفـــات المشاريــــع"></asp:Button>
               
              


            </div> 
                  
                  
                
            </div>     <div class="row  " style="padding-left :1em; padding-right:1em;">
        
          

            <div class="col-12 mt-3  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                   <asp:Button runat="server"  ID="Button3"  style="font:bolder; width:100%;" class="button-89" OnClick="GoToNth" role="button" Text="النثريــــات"></asp:Button>
               
              


            </div> 
                
             
            </div>  <div class="row  " style="padding-left :1em; padding-right:1em;">
        
          

            <div class="col-12 mt-1  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                   <asp:Button runat="server"  ID="Button4"  style="font:bolder; width:100%;" class="button-89" OnClick="GoToReports" role="button" Text="التقاريــــر"></asp:Button>
               
              


            </div> 
                
             
            </div>


 
     <div class="row ">
        
          

                <!-- HTML !-->





          
            </div>



    

    </article>


</asp:Content>
