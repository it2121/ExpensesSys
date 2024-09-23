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

        public static int m1 = 0;
        public static int m2 = 0;
        public static int m3 = 0;
        public static int m4 = 0;
        public static int m5 = 0;
        public static int m6 = 0;
        public static int m7 = 0;
        public static int m8 = 0;
        public static int m9 = 0;
        public static int m10 = 0;
        public static int m11 = 0;
        public static int m12 = 0;
        public static int mm1 = 0;
        public static int mm2 = 0;
        public static int mm3 = 0;
        public static int mm4 = 0;
        public static int mm5 = 0;
        public static int mm6 = 0;
        public static int mm7 = 0;
        public static int mm8 = 0;
        public static int mm9 = 0;
        public static int mm10 = 0;
        public static int mm11 = 0;
        public static int mm12 = 0;












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
                setUpLineChart();


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
                setUpLineChart();
            }


        }
        public void setUpLineChart()
        {

            DataTable IncomeTable = BBAALL.REP_GetAllIncomeRecords();
        
            m1 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/01" + "/" + DateTime.Now.Year, "31/01" + "/" + DateTime.Now.Year), "المبلغ");
            m2 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/02" + "/" + DateTime.Now.Year, "28/02" + "/" + DateTime.Now.Year), "المبلغ");
            m3 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/03" + "/" + DateTime.Now.Year, "31/03" + "/" + DateTime.Now.Year), "المبلغ");
            m4 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/04" + "/" + DateTime.Now.Year, "30/04" + "/" + DateTime.Now.Year), "المبلغ");
            m5 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/05" + "/" + DateTime.Now.Year, "31/05" + "/" + DateTime.Now.Year), "المبلغ");
            m6 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/06" + "/" + DateTime.Now.Year, "30/06" + "/" + DateTime.Now.Year), "المبلغ");
            m7 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/07" + "/" + DateTime.Now.Year, "31/07" + "/" + DateTime.Now.Year), "المبلغ");
            m8 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/08" + "/" + DateTime.Now.Year, "31/08" + "/" + DateTime.Now.Year), "المبلغ");
            m9 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/09" + "/" + DateTime.Now.Year, "30/09" + "/" + DateTime.Now.Year), "المبلغ");
            m10 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/10" + "/" + DateTime.Now.Year, "31/10" + "/" + DateTime.Now.Year), "المبلغ");
            m11 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/11" + "/" + DateTime.Now.Year, "30/11" + "/" + DateTime.Now.Year), "المبلغ");
            m12 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(IncomeTable, "01/12" + "/" + DateTime.Now.Year, "31/12" + "/" + DateTime.Now.Year), "المبلغ");



            DataTable Nth = BBAALL.REP_GetAllNthRecords();
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
            mm11 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/11" + "/" + DateTime.Now.Year, "30/11" + "/" + DateTime.Now.Year), "الكلفة")
                + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/11" + "/" + DateTime.Now.Year, "30/11" + "/" + DateTime.Now.Year), "الكلفة")
                + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/11" + "/" + DateTime.Now.Year, "30/11" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/11" + "/" + DateTime.Now.Year, "30/11" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                ;
            mm12 = MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Nth, "01/12" + "/" + DateTime.Now.Year, "31/12" + "/" + DateTime.Now.Year), "الكلفة")
                + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Comp, "01/12" + "/" + DateTime.Now.Year, "31/12" + "/" + DateTime.Now.Year), "الكلفة")
                + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(Salary, "01/12" + "/" + DateTime.Now.Year, "31/12" + "/" + DateTime.Now.Year), "المرتب_المستلم")
                + MyStringManager.ReturnSumOfDTFildInInt(MyStringManager.GetTableAfterDateCheck(MatBuy, "01/12" + "/" + DateTime.Now.Year, "31/12" + "/" + DateTime.Now.Year), "مبلغ_الدفعة")
                ;


        }
        protected void GoToFullReportInAndOutWithDate(object sender, EventArgs e)
        {


            Response.Redirect("FullReportInAndOutWithDate.aspx");



        }
    }
}