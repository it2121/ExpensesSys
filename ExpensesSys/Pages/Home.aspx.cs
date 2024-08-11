using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "Home";
        }


        protected void GoToSalary(object sender, EventArgs e)
        {
            PeojectSeector.GoToPage = "Salary";
            Response.Redirect("PeojectSeector.aspx");


        }   protected void GoToExpences(object sender, EventArgs e)
        {
            PeojectSeector.GoToPage = "Expences";
            Response.Redirect("PeojectSeector.aspx");


        }
        
        protected void GoToProjMan(object sender, EventArgs e)
        {
           
            Response.Redirect("ProjMan.aspx");

        }

        protected void GoToEmpMan(object sender, EventArgs e)
        {
            PeojectSeector.GoToPage = "EmpMan";
            Response.Redirect("PeojectSeector.aspx");

        }
    }



}