using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class MainHome : System.Web.UI.Page
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


                double sumUnitIn = 0;

/*
                DataTable allpayments = BBAALL.REP_GetAllIncomeRecordsUnit();
                foreach (DataRow Row in allpayments.Rows)
                {
                    DataTable Payment = BBAALL.GetUnitPaymentByID(Convert.ToInt32(Row["ID"].ToString()));

                    foreach (DataRow innerRow in Payment.Rows)
                    {

                        BBAALL.UpdateUnitPayments(Convert.ToInt32(innerRow["PayNo"].ToString()),
                            Convert.ToInt32(innerRow["Amount"].ToString()),
                         MyStringManager.GetDateAfterCheckingFormating(innerRow["DateOfPay"].ToString())
, Convert.ToInt32(innerRow["PaidAmount"].ToString())
, innerRow["RecID"].ToString(), innerRow["Paid"].ToString(), Convert.ToInt32(Row["ID"].ToString()));

                    }




                }*/



                sumUnitIn += Convert.ToDouble(BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(startDate, endtDate).Rows[0][0].ToString());
                sumUnitIn += MyStringManager.ReturnSumOfDTFildInInt(IncomeSet, "المبلغ");

                Last30DaysIncome.Text = MyStringManager.GetNumberWithComas(sumUnitIn + "") + " IQD ";



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
                double sum = 0;
                sum += MyStringManager.ReturnSumOfDTFildInInt(NthSet, "الكلفة");
                sum += MyStringManager.ReturnSumOfDTFildInInt(CompSet, "الكلفة");
                sum += MyStringManager.ReturnSumOfDTFildInInt(SalarySet, "المرتب_المستلم");
                sum += MyStringManager.ReturnSumOfDTFildInInt(MatBuySet, "مبلغ_الدفعة");
                sum += MyStringManager.ReturnSumOfDTFildInInt(WorkContractsPaymentSet, "مبلغ_الدفعة");
                Last30DaysSpendings.Text = MyStringManager.GetNumberWithComas(sum + "") + " IQD ";

                //kill switch


                /*  if (MyStringManager.CheckIfTodayIsGreaterThanDate("21/12/2025"))
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
        {

            ManagmentBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("ادارة");
            Button1.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("ادارة");
            FinanceBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات") ;
            searchPanel.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات") ;
            TechBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الفنية") ;



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
        protected void Return(object sender, EventArgs e)
        {

            
            Response.Redirect("SeperateProjectSelector.aspx");



        }
        protected void GoToSelectAndExtract(object sender, EventArgs e)
        {

            SelectAndExtract.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("SelectAndExtract.aspx");





        }
        protected void BackUp(object sender, EventArgs e)
        {

            BBAALL.BackupDatabases();

             ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('تم انشاء نسخة احتياطية لقاعدة البيانات في - C/Users/GC/Documents/DB_BackUps ');", true);




        }
        protected void GoToGeneralDep(object sender, EventArgs e)
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
        protected void GoToWarehouse(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "Warehouse";
            Warehouse.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("Warehouse.aspx");
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
        void GoToNth(object sender, EventArgs e)
        {
            //PeojectSeector.GoToPage = "Nth";
            Response.Redirect("Nth.aspx");

        }







        protected void Search(object sender, EventArgs e)
        {

            DataTable dt = BBAALL.GetSearchListByWord(ProjectID, SearchBox.Text);
            DataGridUsers.DataSource = dt;
            DataGridUsers.DataBind();

        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_OR23") as Label;


            UnitOverlook.RecID = id.Text;
            UnitOverlook.ProjectID = ProjectID;


            Response.Redirect("UnitOverlook.aspx");


        }

        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update
            //  Label id = DataGridUsers.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            //  TextBox city = DataGridUsers.Rows[e.RowIndex].FindControl("txt_City") as TextBox;

            //updating the record
            //  BBAALL.EditAmountOfItemsProvided(Convert.ToInt32(id.Text), Convert.ToInt32(city.Text));


            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview
            //  DataGridUsers.EditIndex = -1;
            //Call ShowData method for displaying updated data
            //  showstuff();
        }//
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview
            //  DataGridUsers.EditIndex = -1;
            // showstuff();
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

        protected void GoToMainTechMan(object sender, EventArgs e)
        {
            Response.Redirect("MainTechMan.aspx");

        }
        protected void GoToMainFinancetMan(object sender, EventArgs e)
        {
            Response.Redirect("MainFinance.aspx");

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