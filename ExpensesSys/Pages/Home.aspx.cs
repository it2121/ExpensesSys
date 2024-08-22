using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        public static int GR = 0;
        public static int BL = 0;
        public static int AB = 0;
        public static int Outcome = 0;
        public static int Outcome30 = 0;
        public static int Income = 0;
        public static int Income30 = 0;
        public static int GetAllMatBuySum = 0;
        public static int GetAllSalarySum = 0;
        public static int GetAllNthSum = 0;
        public static int GetAllCompSum = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                Main.openPage = "Reports";
                GR = 1;
                BL = 1;
                AB = 1;
                Outcome = Convert.ToInt32(BBAALL.GetAllOutcomeSum().Rows[0][0].ToString());
                Income = Convert.ToInt32(BBAALL.GetAllIncomeSum().Rows[0][0].ToString());

                DataTable Out30 = BBAALL.GetAllOutcomeSum();
                DataTable Inc30 = BBAALL.GetAllIncomeSum();
                // DateTime enteredDate;
                //  foreach(DataRow row in Out30.Rows)
                //  {
                //     enteredDate = DateTime.Parse(row[""]);
                //   }
                GetAllMatBuySum = Convert.ToInt32(BBAALL.GetAllMatBuySum().Rows[0][0].ToString());
                GetAllSalarySum = Convert.ToInt32(BBAALL.GetAllSalarySum().Rows[0][0].ToString());
                GetAllCompSum = Convert.ToInt32(BBAALL.GetAllCompSum().Rows[0][0].ToString());
                GetAllNthSum = Convert.ToInt32(BBAALL.GetAllNthSum().Rows[0][0].ToString());


            }
            else
            {

                GR = 1;
                BL = 1;
                AB = 1;


                Outcome = Convert.ToInt32(BBAALL.GetAllOutcomeSum().Rows[0][0].ToString());

                Income = Convert.ToInt32(BBAALL.GetAllIncomeSum().Rows[0][0].ToString());
                GetAllMatBuySum = Convert.ToInt32(BBAALL.GetAllMatBuySum().Rows[0][0].ToString());
                GetAllSalarySum = Convert.ToInt32(BBAALL.GetAllSalarySum().Rows[0][0].ToString());
                GetAllCompSum = Convert.ToInt32(BBAALL.GetAllCompSum().Rows[0][0].ToString());
                GetAllNthSum = Convert.ToInt32(BBAALL.GetAllNthSum().Rows[0][0].ToString());
            }
            Main.openPage = "Home";


        }


        protected void GoToSalary(object sender, EventArgs e)
        {
            PeojectSeector.GoToPage = "Salary";
            Response.Redirect("PeojectSeector.aspx");


        }
        protected void GoToReports(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "Nth";
            Response.Redirect("Reports.aspx");

            


        }   protected void GoToNth(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "Nth";
            Response.Redirect("Nth.aspx");

            


        }
        protected void GoToIncome(object sender, EventArgs e)
        {
            PeojectSeector.GoToPage = "Income";
            Response.Redirect("PeojectSeector.aspx");


        }  protected void GoToExpences(object sender, EventArgs e)
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