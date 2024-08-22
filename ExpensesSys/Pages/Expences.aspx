<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="Expences.aspx.cs" Inherits="ExpensesSys.Pages.Expences" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <asp:Panel runat="server" ID="ButtonsBar">
        <div class="row " style="margin-bottom: 1em">

            <div class="col-auto">
                <div class="field buttons align-items-end">

           <asp:LinkButton  runat="server"  style="background-color: white; color: #33B3FF; font: bold; border-color:#33B3FF" text="ادارة المواد"
        
         
         data-target="modal-js-example"
                                 onclick="GoToItemMan"

                        class="js-modal-trigger button is-fullwidth  align align-content-center  button is-ou">ادارة المواد                       
                        <i class="fas fa-add " style="margin-left: 1em">

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
    <article class="panel is-info" style="background-color: white;padding-bottom:2em;">

        <p class="panel-heading text-center" style="background-color:#3399ff;">الصرفيات<i class="fa-solid fa-file-invoice-dollar"></i></p>

        
              <div class="row  " style="padding:1em;">
        
          

            <div class="col-6 mt-3  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                   <asp:Button runat="server"  ID="Button6"  style="font:bolder; width:100%;" class="btn" OnClick="GoToMatBuy" role="button" Text="شــــــراء مـــــواد"></asp:Button>
               
              


            </div> <div class="col-6 mt-3  text-center ">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
              
                  <asp:Button runat="server"  ID="Button5"  style="font:bolder; width:100%;" class="btn" OnClick="GoToContr" role="button" Text="العقـــــود"></asp:Button>
               
              
                   
           
             



            </div>
            </div>
        
        <div class="row  " style="padding:1em;">
        
            <div class="col-6 mt-3  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                   <asp:Button runat="server"  ID="Button3"  style="font:bolder; width:100%;" class="btn" OnClick="GoToH5" role="button" Text="مجامـــــلات"></asp:Button>
               
              


            </div> 

            <div class="col-6 mt-3  text-center">
<%--                <span class="tag is-primary  is-large"      >  <asp:Label class="label align-text-top " Font-Size="Larger"  style=" margin-right:1em ; color:white;"  runat="server" ID="NumOfProviders" Text=""></asp:Label></span>--%>
                   <asp:Button runat="server"  ID="Button1"  style="font:bolder; width:100%;" class="btn" OnClick="GoToSalary" role="button" Text="الرواتــــــب"></asp:Button>
               
              


            </div> 
            
            
            </div>       
           


 
     <div class="row ">
        
          

                <!-- HTML !-->





          
            </div>



    

    </article>


</asp:Content>
