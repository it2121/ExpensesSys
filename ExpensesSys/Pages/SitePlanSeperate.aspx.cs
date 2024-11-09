using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class SitePlanSeperate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GoToUnit(object sender, EventArgs e)
        {
            string unitNumber = (sender as ImageButton).ToolTip;

            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('"+ unitNumber + "');", true);

            // Response.Redirect("Nth.aspx");



        }
    }
}