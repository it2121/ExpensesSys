using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class MainProjMan : System.Web.UI.Page
    {
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void GoToReports(object sender, EventArgs e)
        {


            Response.Redirect("UnitReports.aspx");



        }
        protected void GoToProjAndUnit(object sender, EventArgs e)
        {
            
            Response.Redirect("ProjectAndUnits.aspx");

        }  protected void OneUnitOverView(object sender, EventArgs e)
        {
            UnitSearch.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("UnitSearch.aspx");

        }
        protected void ManyUnitOverView(object sender, EventArgs e)
        {
            SelectAndExtract.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("SelectAndExtract.aspx");

        }
        protected void Return(object sender, EventArgs e)
        {

            
            Response.Redirect("MainHome.aspx");



        }
    }
}