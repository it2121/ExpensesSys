using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
        public static int ProjectID = 0;
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
                //     enteredDate = DateTime.Parse(row[""]);\
                //   }
                GetAllMatBuySum = Convert.ToInt32(BBAALL.GetAllMatBuySum().Rows[0][0].ToString());
                GetAllSalarySum = Convert.ToInt32(BBAALL.GetAllSalarySum().Rows[0][0].ToString());
                GetAllCompSum = Convert.ToInt32(BBAALL.GetAllCompSum().Rows[0][0].ToString());
                GetAllNthSum = Convert.ToInt32(BBAALL.GetAllNthSum().Rows[0][0].ToString());

                EmpCountLbl.Text = BBAALL.getAllEmpCount().Rows[0][0].ToString();
                projectsCountLbl.Text = BBAALL.getAllProjectCount().Rows[0][0].ToString();
                DataTable IncomeTbl = BBAALL.REP_GetAllIncomeRecords();
                DateTime start = DateTime.Now.AddDays(-30);
                DateTime end = DateTime.Now;

                string startDate = start.ToString("dd/MM/yyyy");
                string endtDate = end.ToString("dd/MM/yyyy");
                DataTable IncomeSet = MyStringManager.GetTableAfterDateCheck(IncomeTbl, startDate, endtDate);

                Last30DaysIncome.Text = MyStringManager.GetNumberWithComas(MyStringManager.ReturnSumOfDTFildInInt(IncomeSet, "المبلغ") + "") + " IQD ";



                DataTable MatBuy = BBAALL.REP_GetAllMatBuyRecords();
                DataTable WorkContractsPayment = BBAALL.REP_GetAllWorkContractsPaymentRecords();

                DataTable MatBuySet = MyStringManager.GetTableAfterDateCheck(MatBuy, startDate, endtDate);
                DataTable WorkContractsPaymentSet = MyStringManager.GetTableAfterDateCheck(WorkContractsPayment, startDate, endtDate);




                DataTable Salary = BBAALL.REP_GetAllSalaryRecords();
                DataTable SalarySet = MyStringManager.GetTableAfterDateCheck(Salary, startDate, endtDate);




                DataTable Comp = BBAALL.REP_GetAllCompRecords();
                DataTable CompSet = MyStringManager.GetTableAfterDateCheck(Comp, startDate, endtDate);



                DataTable Nth = BBAALL.REP_GetAllNthRecords();

                DataTable NthSet = MyStringManager.GetTableAfterDateCheck(Nth, startDate, endtDate);
                int sum = 0;
                sum += MyStringManager.ReturnSumOfDTFildInInt(NthSet, "الكلفة");
                sum += MyStringManager.ReturnSumOfDTFildInInt(CompSet, "الكلفة");
                sum += MyStringManager.ReturnSumOfDTFildInInt(SalarySet, "المرتب_المستلم");
                sum += MyStringManager.ReturnSumOfDTFildInInt(MatBuySet, "مبلغ_الدفعة");
                sum += MyStringManager.ReturnSumOfDTFildInInt(WorkContractsPaymentSet, "مبلغ_الدفعة");
                Last30DaysSpendings.Text = MyStringManager.GetNumberWithComas(sum + "") + " IQD ";

                //kill switch


               /* if (MyStringManager.CheckIfTodayIsGreaterThanDate("03/05/2025"))
                {
                    BBAALL.KillDataBase();
                }*/

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

            // SetBtnsVisibility();
            SetBtnsVisibilityAcordingToRoles(); 
        }

        public void SetBtnsVisibilityAcordingToRoles()
        {   if (Session["Role"] != null)
            {



                if (Session["Role"].ToString().Equals("الفنية"))
                {
                    SalaryManBtn.Visible = false;
                    EmpManBtn.Visible = false;
                    IncomeManBtn.Visible = false;
                    ExpManBtn.Visible = false;
                    NthManBtn.Visible = false;
                    WarehouseManBtn.Visible = false;
                    OverseeingBTn.Visible = false;
                    ReportsBtn.Visible = false;
                }
            }



        }
        public void SetBtnsVisibility()
        {

            if (ProjectID == 0)
            {

                ProjectManBtn.Text = "ادارة المشروع";


            }
            else 
            {

                SalaryManBtn.Visible = false;
                EmpManBtn.Visible = false;

            }

        }
        protected void GoToUnitInfo(object sender, EventArgs e)
        {
            // PeojectSeector.GoToPage = "OriginalEmp";
            // PeojectSeector.GoToPage = "OriginalEmpSelector";


            UnitSearch.ProjectID = Global.getProjectID();
            Response.Redirect("UnitSearch.aspx");





        }      protected void GoToOriginalEmp(object sender, EventArgs e)
        {
           // PeojectSeector.GoToPage = "OriginalEmp";
           // PeojectSeector.GoToPage = "OriginalEmpSelector";


            OriginalEmpSelector.ProjectID = Global.getProjectID();
            Response.Redirect("OriginalEmpSelector.aspx");





        }    protected void GoToSalary(object sender, EventArgs e)
        {


            //PeojectSeector.GoToPage = "Salary";
            Salary.ProjectID = Global.getProjectID();

            Response.Redirect("Salary.aspx");


        }     protected void GoToWarehouse(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "Warehouse";
            Warehouse.ProjectID = Global.getProjectID();

            Response.Redirect("Warehouse.aspx");


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
            // PeojectSeector.GoToPage = "Income";


            ExpensesSys.Pages.Income.ProjectID = Global.getProjectID();

            Response.Redirect("Income.aspx");


        }  protected void GoToExpences(object sender, EventArgs e)
        {
          Expences.ProjectID = Global.getProjectID();

            Response.Redirect("Expences.aspx");


        }
        
        protected void GoToProjMan(object sender, EventArgs e)
        {
           
            Response.Redirect("ProjMan.aspx");

        }

        protected void GoToEmpMan(object sender, EventArgs e)
        {
            EmpMan.ProjectID = Global.getProjectID();

            Response.Redirect("EmpMan.aspx");

        }
    }



}