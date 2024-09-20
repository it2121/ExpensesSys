using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages.Law
{
    public partial class LawHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GoToPeople(object sender, EventArgs e)
        {
            Response.Redirect("People.aspx");
        }
        protected void GoToArchiving(object sender, EventArgs e)
        {
            Response.Redirect("GoToArchiving.aspx");
        }
    }
}