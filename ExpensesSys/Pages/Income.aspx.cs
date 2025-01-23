using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class Income : System.Web.UI.Page
    {
        public static int ProjectID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Button5.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات") ;


            }


        }
        protected void Return(object sender, EventArgs e)
        {

            
            Response.Redirect("MainFinance.aspx");



        }
        protected void GoToGeneralIncome(object sender, EventArgs e)
        {

            GeneralIncome.ProjectID = ProjectID;
            Response.Redirect("GeneralIncome.aspx");

        }

        protected void GoToUnitIncome(object sender, EventArgs e)
        {

            UnitIncome.ProjectID = ProjectID;
            Response.Redirect("UnitIncome.aspx");

        }


    }
}