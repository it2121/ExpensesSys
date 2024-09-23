using System;   
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{

    public partial class Main : System.Web.UI.MasterPage
    {
        public static string openPage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["redirected"] = "0";
            if (Session["Name"] == null && Session["redirected"].ToString().Equals("0"))
            {
                Session["redirected"] = "1";
                // redirected=true;
                Response.Redirect("LogInSeprate.aspx");

            }
            else if (Session["Name"] != null)
            {


            }
            TLbl.Text= Session["Name"].ToString();
            NameL.Text = Session["Role"].ToString();
            MainLbl.Text = "   نظــــام الصومعــــة  -" + "   مشروع   " + BBAALL.getProjectNameByID(Global.getProjectID()).Rows[0][0].ToString();

            //SetBtnsVisibility();

            setSelectedPageBGColor(openPage);
            SetBtnsVisibilityAcordingToRoles();

        }
        public void SetBtnsVisibilityAcordingToRoles()
        {

            if (Session["Role"].ToString().Equals("الفنية"))
            {
                Income.Visible = false;
                Expences.Visible = false;
                Salary.Visible = false;
                EmpMan.Visible = false;
                General.Visible = false;
                Reports.Visible = false;
          

            }
            else if (Session["Role"].ToString().Equals("القانونية"))
            {
                Income.Visible = false;
                Expences.Visible = false;
                Salary.Visible = false;
                EmpMan.Visible = false;
                General.Visible = false;
                Reports.Visible = false;
                ProjMan.Visible = false;
                LawPeople.Visible = true;
                LawArch.Visible = true;
            }


        }  
        
        
        public void SetBtnsVisibility()
        {

            if (Global.getProjectID() == 0)
            {

                ProjectManBtn.Text = "ادارة المشروع";


            }
            else
            {

                Salary.Visible = false;
                EmpMan.Visible = false;

            }

        }
        public void setSelectedPageBGColor(string pageName) {

            if (pageName.Equals("Home"))
            {
                Home.BackColor = ColorTranslator.FromHtml("#3399ff");


            }
            else if (pageName.Equals("ProjMan")) {
                ProjMan.BackColor = ColorTranslator.FromHtml("#3399ff");


            }

            else if (pageName.Equals("EmpMan"))
            {
                EmpMan.BackColor = ColorTranslator.FromHtml("#3399ff");


            }   else if (pageName.Equals("Expences"))
            {
                Expences.BackColor = ColorTranslator.FromHtml("#3399ff");


            } else if (pageName.Equals("Salary"))
            {
                Salary.BackColor = ColorTranslator.FromHtml("#3399ff");


            }else if (pageName.Equals("Income"))
            {
                Income.BackColor = ColorTranslator.FromHtml("#3399ff");


            }else if (pageName.Equals("Reports"))
            {
                Reports.BackColor = ColorTranslator.FromHtml("#3399ff");


            }else if (pageName.Equals("LawPeople"))
            {
                LawPeople.BackColor = ColorTranslator.FromHtml("#3399ff");


            }else if (pageName.Equals("LawArch"))
            {
                LawArch.BackColor = ColorTranslator.FromHtml("#3399ff");


            }


        }
        protected void LogOut(object sender, EventArgs e)
        {
            Session["redirected"] = "0";
            TLbl.Text = "";
            NameL.Text = "";
            Response.Redirect("LogInSeprate.aspx");

        }  
        protected void GoToHome(object sender, EventArgs e)
        {
            if (Global.GetRole().Equals("القانونية"))
            {
                Response.Redirect("LawHome.aspx");

                //   ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + GoToPage + "');", true);

            }else
            {
                Response.Redirect("Home.aspx");

            }


        }    protected void GoToLawArch(object sender, EventArgs e)
        {

            Response.Redirect("Arch.aspx");

        }    protected void GoToLawPeople(object sender, EventArgs e)
        {

            Response.Redirect("People.aspx");

        }   
        protected void GoToReports(object sender, EventArgs e)
        {

            Response.Redirect("Reports.aspx");

        }   
        
        
        protected void GoToProjMan(object sender, EventArgs e)
        {

            Response.Redirect("ProjMan.aspx");

        }  protected void GoToIncome(object sender, EventArgs e)
        {

            ExpensesSys.Pages.Income.ProjectID = Global.getProjectID();

            Response.Redirect("Income.aspx");

        }protected void GoToEmpMan(object sender, EventArgs e)
        {

            ExpensesSys.Pages.EmpMan.ProjectID = Global.getProjectID();

            Response.Redirect("EmpMan.aspx");

        }
        protected void GoToExpences(object sender, EventArgs e)
        {
            ExpensesSys.Pages.Expences.ProjectID = Global.getProjectID();

            Response.Redirect("Expences.aspx");


        }   protected void GoToSalary(object sender, EventArgs e)
        {
            ExpensesSys.Pages.Salary.ProjectID = Global.getProjectID();

            Response.Redirect("Salary.aspx");


        }
    }
}