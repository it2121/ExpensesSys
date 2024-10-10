using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class GeneralFinanceNav : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("SeperateProjectSelector.aspx");



        }
        protected void GoToGeneralFinanceReports(object sender, EventArgs e)
        {
            Session["ProjectID"] = "0";

            Response.Redirect("GeneralFinanceReports.aspx");
        }   protected void GoToGeneralIn(object sender, EventArgs e)
        {
            Session["ProjectID"] = "0";

            GeneralInAndOut.RecType = "In";
            Response.Redirect("GeneralInAndOut.aspx");
        }

        protected void GoToGeneralOut(object sender, EventArgs e)
        {
            Session["ProjectID"] = "0";

            GeneralInAndOut.RecType = "Out";

            Response.Redirect("GeneralInAndOut.aspx");
        }

    }
}