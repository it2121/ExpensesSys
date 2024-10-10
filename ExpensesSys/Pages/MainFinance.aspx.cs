using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class MainFinance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GoToTechReports(object sender, EventArgs e)
        {
           

            Response.Redirect("Reports.aspx");





        }
        protected void GoToSelectAndExtract(object sender, EventArgs e)
        {

            SelectAndExtract.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("SelectAndExtract.aspx");





        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("MainHome.aspx");



        }
        protected void GoToContractUnitEmp(object sender, EventArgs e)
        {

            EmpMan.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("EmpMan.aspx");





        }  protected void GoToGeneralDep(object sender, EventArgs e)
        {

            UnitSearch.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("UnitSearch.aspx");





        }
        protected void GoToUnitInfo(object sender, EventArgs e)
        {

            UnitSearch.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("UnitSearch.aspx");





        }

        protected void GoToOriginalEmp(object sender, EventArgs e)
        {
            OriginalEmpSelector.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("OriginalEmpSelector.aspx");
        }
        protected void GoToSalary(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "Salary";
            Salary.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("Salary.aspx");
        }

        protected void GoToUnitReports(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "Nth";
            Response.Redirect("UnitReports.aspx");
        }
        protected void GoToReports(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "Nth";
            Response.Redirect("Reports.aspx");




        }
        protected void GoToContractUnit(object sender, EventArgs e)
        {
            Response.Redirect("UnitReports.aspx");

        }
        protected void GoToReportsFinance(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");

        }  
        
        
        protected void ManyUnitOverView(object sender, EventArgs e)
        {
            SelectAndExtract.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("SelectAndExtract.aspx");

        }   
        protected void OneUnitOverView(object sender, EventArgs e)
        {
            UnitSearch.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("UnitSearch.aspx");

        } 
        
        
        protected void GoToUpdateUnitTechInfo(object sender, EventArgs e)
        {
            Income.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("Income.aspx");

        }


        protected void GoToWeightMan(object sender, EventArgs e)
        {
            Expences.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("Expences.aspx");

        }
        protected void GoToWarehouse(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "Warehouse";
            Nth.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("Nth.aspx");
        }
        void GoToNth(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "Nth";
            Response.Redirect("Nth.aspx");

        }
        protected void GoToIncome(object sender, EventArgs e)
        {
            // PeojectSeector.GoToPage = "Income";

            ExpensesSys.Pages.Income.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());

            Response.Redirect("Income.aspx");

        }
        protected void GoToExpences(object sender, EventArgs e)
        {
            Expences.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("Expences.aspx");

        }

        protected void GoToMainProjectMan(object sender, EventArgs e)
        {
            MainProjMan.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("MainProjMan.aspx");

        }

        protected void GoToEmpMan(object sender, EventArgs e)
        {
            EmpMan.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());

            Response.Redirect("EmpMan.aspx");

        }




    }
}