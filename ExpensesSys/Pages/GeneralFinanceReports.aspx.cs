using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class GeneralFinanceReports : System.Web.UI.Page
    {
        public static DataTable OutcomeSet;
        public static DataTable IncomeSet;
        public DataTable Income;
        public DataTable Outcome;
        string UnittypeStr = "";
        string Emp = "";
        string Loan = "";
        string Warn = "";
        int Money = 0;
        string MoneyType = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ChckedChanged(object sender, EventArgs e)
        {
            if (UnMarkedDate.Checked == true)
            {
                StartDate.Text = "";
                StartDate.Enabled = false;
                EndDate.Text = "";
                EndDate.Enabled = false;

            }
            else
            {
                StartDate.Enabled = true;
                EndDate.Enabled = true;


            }
        }


        public DataTable ReturnTableWithoutDates()
        {
            DataTable MoneyTable = IncomeSet.Clone();
            foreach (DataRow dr in IncomeSet.Rows) { MoneyTable.ImportRow(dr); }
            MoneyTable.Columns.Remove("الانذار_الاولي");
            MoneyTable.Columns.Remove("تسليم_الانذار_الاولي");
            MoneyTable.Columns.Remove("الانذار_النهائي");
            MoneyTable.Columns.Remove("تسليم_الانذار_النهائي");


            return MoneyTable;
        }
        public DataTable ReturnTableWithoutMoney()
        {
            DataTable WarnTable = IncomeSet.Clone();
            foreach (DataRow dr in IncomeSet.Rows) { WarnTable.ImportRow(dr); }

            WarnTable.Columns.Remove("المبلغ_الكامل");
            WarnTable.Columns.Remove("المبلغ_المتبقي");
            WarnTable.Columns.Remove("المطلوب");
            WarnTable.Columns.Remove("الواصل");


            return WarnTable;
        }

        protected void ShowMoney(object sender, EventArgs e)
        {




            OutComeTable.DataSource = OutcomeSet;
            OutComeTable.DataBind();




        }

        protected void ShowWarnDates(object sender, EventArgs e)
        {




            OutComeTable.DataSource = IncomeSet;
            OutComeTable.DataBind();




        }
        protected void CalclateAllTables(object sender, EventArgs e)
        {

            Income = BBAALL.GetAllInForReports();
            Outcome = BBAALL.GetAllOutForReports();





            IncomeSet = MyStringManager.GetTableAfterDateCheck(Income, StartDate.Text, EndDate.Text);
            OutcomeSet = MyStringManager.GetTableAfterDateCheck(Outcome, StartDate.Text, EndDate.Text);





            RecevedSum.Text = MyStringManager.GetNumberWithComas(MyStringManager.GetSumOfRowsWithCondition(IncomeSet, "المبلغ") + "") + " IQD مجموع المبالغ الواردة";
            PendningAcordingToCompStage.Text = MyStringManager.GetNumberWithComas(MyStringManager.GetSumOfRowsWithCondition(OutcomeSet, "المبلغ") + "") + " IQD مجموع المبالغ المصروفه";



            OutComeTable.DataSource = IncomeSet;
            OutComeTable.DataBind();

            OutComeTablePanel.Visible = true;
            ExportBtn.Visible = true;
            showmoneyBtn.Visible = true;
            showdatesBtn.Visible = true;
        }

    
        protected void CreateInReport(object sender, EventArgs e)
        {





            OutComeTable.DataSource = IncomeSet;

            OutComeTable.DataBind();
            OutComeTablePanel.Visible = true;

            //Response.Redirect("Reports.aspx");



        }
        
   
        protected void Return(object sender, EventArgs e)
        {

            
            Response.Redirect("GeneralFinanceNav.aspx");



        }
        protected void ExportToExcel(object sender, EventArgs e)
        {

            ExportBtnc();





        }
        public static void ExportBtnc()
        {

            string pathandname = HttpRuntime.AppDomainAppPath + "/Images/تقرير.xlsx";


            var wb = new XLWorkbook();
            int sheetCounter = 0;
            DataTable IncomeExTbl = IncomeSet;
            IncomeExTbl.TableName = "الواردات";
            wb.Worksheets.Add(IncomeExTbl);
            sheetCounter++;


            DataTable OutcomeExTbl = OutcomeSet;
            OutcomeExTbl.TableName = "الصادرات";
            wb.Worksheets.Add(OutcomeExTbl);
            sheetCounter++;


            wb.SaveAs(pathandname);





            byte[] bytes = GetBinaryFile(pathandname);



            System.IO.FileInfo file = new System.IO.FileInfo(pathandname);
            HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
            HttpContext.Current.Response.AddHeader("Content-Length", file.Length.ToString());
            HttpContext.Current.Response.ContentType = "text/plain";
            HttpContext.Current.Response.TransmitFile(file.FullName);
            HttpContext.Current.Response.End();








        }

        public static byte[] GetBinaryFile(string filename)
        {
            byte[] bytes;
            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
            }
            return bytes;
        }
    }
}
