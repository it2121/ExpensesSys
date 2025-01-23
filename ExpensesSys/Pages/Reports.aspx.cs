using DocumentFormat.OpenXml.Drawing;
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
    public partial class Reports : System.Web.UI.Page
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

        public static double[] m = new double[30];
        public static string[] mm = new string[30];


        public static double m1 = 0;
        public static double m2 = 0;
        public static double m3 = 0;
        public static double m4 = 0;
        public static double m5 = 0;
        public static double m6 = 0;
        public static double m7 = 0;
        public static double m8 = 0;
        public static double m9 = 0;
        public static double m10 = 0;


        public static string mm1 = "";
        public static string mm2 = "";
        public static string mm3 = "";
        public static string mm4 = "";
        public static string mm5 = "";
        public static string mm6 = "";
        public static string mm7 = "";
        public static string mm8 = "";
        public static string mm9 = "";
        public static string mm10 = "";













        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Main.openPage = "Reports";
                GR = 1;
                BL = 1;
                AB = 1;
                Outcome = Convert.ToInt32(BBAALL.GetAllOutcomeSum().Rows[0][0].ToString());
                Income = Convert.ToInt32(BBAALL.GetAllIncomeSum(ProjectID).Rows[0][0].ToString());

                DataTable Out30 = BBAALL.GetAllOutcomeSum();
                DataTable Inc30 = BBAALL.GetAllIncomeSum(ProjectID);
                // DateTime enteredDate;
                //  foreach(DataRow row in Out30.Rows)
                //  {
                //     enteredDate = DateTime.Parse(row[""]);
                //   }
                ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());

                GetAllMatBuySum = Convert.ToInt32(BBAALL.GetAllMatBuySum(ProjectID).Rows[0][0].ToString());
                GetAllSalarySum = Convert.ToInt32(BBAALL.GetAllSalarySum(ProjectID).Rows[0][0].ToString());
                GetAllCompSum = Convert.ToInt32(BBAALL.GetAllCompSum(ProjectID).Rows[0][0].ToString());
                GetAllNthSum = Convert.ToInt32(BBAALL.GetAllNthSum().Rows[0][0].ToString());
                setUpLineChart();


            }
            else
            {

                GR = 1;
                BL = 1;
                AB = 1;


                Outcome = Convert.ToInt32(BBAALL.GetAllOutcomeSum().Rows[0][0].ToString());

                Income = Convert.ToInt32(BBAALL.GetAllIncomeSum(ProjectID).Rows[0][0].ToString());
                GetAllMatBuySum = Convert.ToInt32(BBAALL.GetAllMatBuySum(ProjectID).Rows[0][0].ToString());
                GetAllSalarySum = Convert.ToInt32(BBAALL.GetAllSalarySum(ProjectID).Rows[0][0].ToString());
                GetAllCompSum = Convert.ToInt32(BBAALL.GetAllCompSum(ProjectID).Rows[0][0].ToString());
                GetAllNthSum = Convert.ToInt32(BBAALL.GetAllNthSum().Rows[0][0].ToString());
                setUpLineChart();
            }


        }

        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("MainFinance.aspx");



        }

        public void setUpLineChart()
        {
            DataTable IncomeTable = BBAALL.REP_GetAllIncomeRecords(ProjectID);

           

            int convertion = -29;

            DateTime start = DateTime.Now.AddDays(convertion);

            string startDate = start.ToString("dd/MM/yyyy");

            DataTable unitthingy = BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(startDate, startDate, Convert.ToInt32(Session["ProjectID"].ToString()));
            m[0] = Convert.ToInt32(unitthingy.Rows[0][0].ToString());
            mm[0] = startDate;

            for (int i = 1; i <=29; i++)
            {
                convertion++;
                unitthingy = BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"), DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"), Convert.ToInt32(Session["ProjectID"].ToString()));
                m[i] = Convert.ToInt32(unitthingy.Rows[0][0].ToString());
                mm[i] = DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy");


            }
           

          /*  convertion++;
            unitthingy = BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"), DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"));
            m2 = Convert.ToInt32(unitthingy.Rows[0][0].ToString());
            mm2 = DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy");

            convertion++;
            unitthingy = BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"), DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"));
            m3 = Convert.ToInt32(unitthingy.Rows[0][0].ToString());
            mm3= DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy");

            convertion++;
            unitthingy = BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"), DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"));
            m4 = Convert.ToInt32(unitthingy.Rows[0][0].ToString());
            mm4 = DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy");

            convertion++;
            unitthingy = BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"), DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"));
            m5 = Convert.ToInt32(unitthingy.Rows[0][0].ToString());
            mm5 = DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy");

            convertion++;
            unitthingy = BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"), DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"));
            m6 = Convert.ToInt32(unitthingy.Rows[0][0].ToString());
            mm6 = DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy");

            convertion++;
            unitthingy = BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"), DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"));
            m7 = Convert.ToInt32(unitthingy.Rows[0][0].ToString());
            mm7 = DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy");

            convertion++;
            unitthingy = BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"), DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"));
            m8 = Convert.ToInt32(unitthingy.Rows[0][0].ToString());
            mm8 = DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy");

            convertion++;
            unitthingy = BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"), DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"));
            m9 = Convert.ToInt32(unitthingy.Rows[0][0].ToString());
            mm9 = DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy");

            convertion++;
            unitthingy = BBAALL.REP_GetAllIncomeRecordsUnitSumWithDates(DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"), DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy"));
            m10 = Convert.ToInt32(unitthingy.Rows[0][0].ToString());
            mm10 = DateTime.Now.AddDays(convertion).ToString("dd/MM/yyyy");
*/


            /*    m1 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/01" + "/" + DateTime.Now.Year, "31/01" + "/" + DateTime.Now.Year), "المبلغ");
                m2 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/02" + "/" + DateTime.Now.Year, "28/02" + "/" + DateTime.Now.Year), "المبلغ");
                m3 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/03" + "/" + DateTime.Now.Year, "31/03" + "/" + DateTime.Now.Year), "المبلغ");
                m4 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/04" + "/" + DateTime.Now.Year, "30/04" + "/" + DateTime.Now.Year), "المبلغ");
                m5 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/05" + "/" + DateTime.Now.Year, "31/05" + "/" + DateTime.Now.Year), "المبلغ");
                m6 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/06" + "/" + DateTime.Now.Year, "30/06" + "/" + DateTime.Now.Year), "المبلغ");
                m7 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/07" + "/" + DateTime.Now.Year, "31/07" + "/" + DateTime.Now.Year), "المبلغ");
                m8 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/08" + "/" + DateTime.Now.Year, "31/08" + "/" + DateTime.Now.Year), "المبلغ");
                m9 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/09" + "/" + DateTime.Now.Year, "30/09" + "/" + DateTime.Now.Year), "المبلغ");
                m10 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/10" + "/" + DateTime.Now.Year, "31/10" + "/" + DateTime.Now.Year), "المبلغ");
    */

            /*          DataTable Nth = BBAALL.REP_GetAllNthRecords();
                      DataTable Comp = BBAALL.REP_GetAllCompRecords();
                      DataTable Salary = BBAALL.REP_GetAllSalaryRecords();
                      DataTable MatBuy = BBAALL.REP_GetAllMatBuyRecords();

                      mm1 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/01" + "/" + DateTime.Now.Year, "31/01" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/01" + "/" + DateTime.Now.Year, "31/01" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/01" + "/" + DateTime.Now.Year, "31/01" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/01" + "/" + DateTime.Now.Year, "31/01" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                          ;
                      mm2 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/02" + "/" + DateTime.Now.Year, "28/02" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/02" + "/" + DateTime.Now.Year, "28/02" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/02" + "/" + DateTime.Now.Year, "28/02" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/02" + "/" + DateTime.Now.Year, "28/02" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                          ;
                      mm3 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/03" + "/" + DateTime.Now.Year, "31/03" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/03" + "/" + DateTime.Now.Year, "31/03" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/03" + "/" + DateTime.Now.Year, "31/03" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/03" + "/" + DateTime.Now.Year, "31/03" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                          ;
                      mm4 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/04" + "/" + DateTime.Now.Year, "30/04" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/04" + "/" + DateTime.Now.Year, "30/04" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/04" + "/" + DateTime.Now.Year, "30/04" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/04" + "/" + DateTime.Now.Year, "30/04" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                          ;
                      mm5 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/05" + "/" + DateTime.Now.Year, "31/05" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/05" + "/" + DateTime.Now.Year, "31/05" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/05" + "/" + DateTime.Now.Year, "31/05" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/05" + "/" + DateTime.Now.Year, "31/05" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                          ;
                      mm6 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/06" + "/" + DateTime.Now.Year, "30/06" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/06" + "/" + DateTime.Now.Year, "30/06" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/06" + "/" + DateTime.Now.Year, "30/06" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/06" + "/" + DateTime.Now.Year, "30/06" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                          ;
                      mm7 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/07" + "/" + DateTime.Now.Year, "31/07" + "/" + DateTime.Now.Year), "الكلفة")
                              + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/07" + "/" + DateTime.Now.Year, "31/07" + "/" + DateTime.Now.Year), "الكلفة")
                              + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/07" + "/" + DateTime.Now.Year, "31/07" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                              + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/07" + "/" + DateTime.Now.Year, "31/07" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                          ;
                      mm8 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/08" + "/" + DateTime.Now.Year, "31/08" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/08" + "/" + DateTime.Now.Year, "31/08" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/08" + "/" + DateTime.Now.Year, "31/08" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/08" + "/" + DateTime.Now.Year, "31/08" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                          ;
                      mm9 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/09" + "/" + DateTime.Now.Year, "30/09" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/09" + "/" + DateTime.Now.Year, "30/09" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/09" + "/" + DateTime.Now.Year, "30/09" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/09" + "/" + DateTime.Now.Year, "30/09" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                          ;
                      mm10 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/10" + "/" + DateTime.Now.Year, "31/10" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/10" + "/" + DateTime.Now.Year, "31/10" + "/" + DateTime.Now.Year), "الكلفة")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/10" + "/" + DateTime.Now.Year, "31/10" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                          + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/10" + "/" + DateTime.Now.Year, "31/10" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                          ;
            */


        }
        protected void GoToFullReportInAndOutWithDate(object sender, EventArgs e)
        {


            Response.Redirect("FullReportInAndOutWithDate.aspx");



        }
    }
}