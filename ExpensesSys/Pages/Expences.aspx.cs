using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class Expences : System.Web.UI.Page
    {
        public static int ProjectID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GoToItemMan(object sender, EventArgs e)
        {

            ItemsMan.ProjectID = ProjectID;
            Response.Redirect("ItemsMan.aspx");

        }

        protected void GoToSalary(object sender, EventArgs e)
        {
  
            Salary.ProjectID = ProjectID;
            Salary.fromItSelf = false;

            Response.Redirect("Salary.aspx");

        }  
        
        protected void GoToContr(object sender, EventArgs e)
        {
           // PeojectSeector.GoToPage = "Salary";
           // Response.Redirect("PeojectSeector.aspx");


        }
        
        protected void GoToMatBuy(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "MatBuy";


            MatBuy.ProjectID = ProjectID;
            Response.Redirect("MatBuy.aspx");


        }
          protected void GoToWorkContracts(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "MatBuy";


            WorkContracts.ProjectID = ProjectID;
            Response.Redirect("WorkContracts.aspx");


        }
        
        
        protected void GoToH5(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "Salary";
            //Response.Redirect("PeojectSeector.aspx");
            Comp.ProjectID = ProjectID;
            Response.Redirect("Comp.aspx");

        }
    }
}