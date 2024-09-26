using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages.Law
{
    public partial class LawHome : System.Web.UI.Page
    {public static int ProjectID =0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GoToContracts(object sender, EventArgs e)
        {
            Response.Redirect("LAWContracts.aspx");
        }

        protected void GoToCases(object sender, EventArgs e)
        {
            Response.Redirect("Cases.aspx");
        }  
        
        protected void GoToPeople(object sender, EventArgs e)
        {
            Response.Redirect("People.aspx");
        }
        protected void GoToArchiving(object sender, EventArgs e)
        {
            Response.Redirect("Archiving.aspx");
        }
    }
}