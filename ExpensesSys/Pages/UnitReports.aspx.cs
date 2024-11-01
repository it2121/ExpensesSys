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
    public partial class UnitReports : System.Web.UI.Page
    {
        public static DataTable IncomeSet;
        public DataTable Income;
        string UnittypeStr = "";
        string Emp = "";
        string Loan = "";
        string Warn = "";
        int Money = 0;
        string MoneyType = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                UnitType.Items.Add("A");
                UnitType.Items.Add("B");
                UnitType.Items.Add("C");
                


            }
        }

        public DataTable ReturnTableWithoutDates()
        {
            DataTable MoneyTable = IncomeSet.Clone();
            foreach(DataRow dr in IncomeSet.Rows) { MoneyTable.ImportRow(dr); }
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




            OutComeTable.DataSource = ReturnTableWithoutDates();
            OutComeTable.DataBind();




        }

        protected void ShowWarnDates(object sender, EventArgs e) {

         


            OutComeTable.DataSource = ReturnTableWithoutMoney();
            OutComeTable.DataBind();




        }
        protected void CalclateAllTables(object sender, EventArgs e)
        {
            EmpCount.Text = EmpRadioLost.SelectedItem.Value;

         //   Income = BBAALL.REP_GetAllIncomeRecords();

            if (PrjectNameCheck.Checked)
                UnittypeStr = UnitType.Text;


            if (EmpPanelCheck.Checked)
                Emp = EmpRadioLost.SelectedValue;

            if (LoanCheck.Checked)
                Loan = LoanRadioLost.SelectedValue;

            if (WarnCheck.Checked)
                Warn = WarnList.Text;

            if (MoneyFilterCheck.Checked)
            {

                Money =Convert.ToInt32(MoneyTB.Text);
                MoneyType = MoneyList.SelectedValue;

            }


            IncomeSet = BBAALL.UnitReport(UnittypeStr,  Emp ,  Loan ,  Warn ,  Money ,  MoneyType ,StartDate.Text);





            RecevedSum.Text = MyStringManager.GetNumberWithComas(MyStringManager.GetSumOfRowsWithCondition(IncomeSet, "الواصل") +"") + " IQD مجموع المبالغ المستلمة";
           PendningAcordingToCompStage.Text = MyStringManager.GetNumberWithComas(MyStringManager.GetSumOfRowsWithCondition(IncomeSet, "المطلوب") +"") + " IQD مجموع المبالغ المطلوبة حسب مرحلة الانجاز";
            AllRemAmount.Text = MyStringManager.GetNumberWithComas(MyStringManager.GetSumOfRowsWithCondition(IncomeSet, "المبلغ_المتبقي") +"") + " IQD مجموع المبالغ المتبقية";
            EmpCount.Text = (MyStringManager.GetCountOfRowsWithCondition(IncomeSet, "التوظيف","موظف")) +"" + " : عدد الموظفين ";
            NonEmpCount.Text = (MyStringManager.GetCountOfRowsWithCondition(IncomeSet, "التوظيف","غير موظف")) +"" + " : عدد غير الموظفين ";
            LoanCount.Text = (MyStringManager.GetCountOfRowsWithCondition(IncomeSet, "الاقتراض", "مقترض")) +"" + " : عدد المقترضين ";
            NonLoanCount.Text = (MyStringManager.GetCountOfRowsWithCondition(IncomeSet, "الاقتراض", "غير مقترض")) +"" + " : عدد غير المقترضين ";
            TotalCount.Text = IncomeSet.Rows.Count+"" + "  : العدد الكلي"; 


           // IncomeSet = MyStringManager.ReturnTableWithCurrencyCommas(IncomeSet, "المبلغ_الكامل");
           // IncomeSet = MyStringManager.ReturnTableWithCurrencyCommas(IncomeSet, "المبلغ_المتبقي");
            //IncomeSet = MyStringManager.ReturnTableWithCurrencyCommas(IncomeSet, "المبلغ_الكامل");
           // IncomeSet = MyStringManager.ReturnTableWithCurrencyCommas(IncomeSet, "المبلغ_الكامل");

            OutComeTable.DataSource = ReturnTableWithoutDates();
            OutComeTable.DataBind();

            OutComeTablePanel.Visible = true;
            ExportBtn.Visible = true;
            showmoneyBtn.Visible = true;
            showdatesBtn.Visible = true;
        }

        protected void ChckedChanged(object sender, EventArgs e)
        {
            if (UnMarkedDate.Checked == true)
            {
                StartDate.Enabled = true;


            }
            else
            {

                StartDate.Text = "";
                StartDate.Enabled = false;

            }
        }
        protected void CreateInReport(object sender, EventArgs e)
        {





            OutComeTable.DataSource = IncomeSet;

            OutComeTable.DataBind();
            OutComeTablePanel.Visible = true;

            //Response.Redirect("Reports.aspx");



        }
        protected void ChckedChangedProjectName(object sender, EventArgs e)
        {
            if (PrjectNameCheck.Checked == true)
            {

                UnitType.Enabled = true;


            }
            else
            {

                UnitType.Enabled = false;



            }
        } 
        protected void ChckedChangedEmpStatus(object sender, EventArgs e)
        {
            if (EmpPanelCheck.Checked == true)
            {

                EmpRadioLost.Enabled = true;


            }
            else
            {
                EmpRadioLost.Enabled = false;




            }
        } 
        
        
        protected void ChckedChangedWarnStatus(object sender, EventArgs e)
        {
            if (WarnCheck.Checked == true)
            {

                WarnList.Enabled = true;


            }
            else
            {
                WarnList.Enabled = false;




            }
        }     
        protected void ChckedChangedMoneyStatus(object sender, EventArgs e)
        {
            if (MoneyFilterCheck.Checked == true)
            {

                MoneyList.Enabled = true;
                MoneyTB.Enabled = true;

            }
            else
            {
                MoneyList.Enabled = false;
                MoneyTB.Enabled = false;




            }
        }    
        protected void ChckedChangedLoanStatus(object sender, EventArgs e)
        {
            if (LoanCheck.Checked == true)
            {

                LoanRadioLost.Enabled = true;


            }
            else
            {
                LoanRadioLost.Enabled = false;




            }
        }
        protected void GoToFullReportInAndOutWithDate(object sender, EventArgs e)
        {


         //   Response.Redirect("FullReportInAndOutWithDate.aspx");



        }
        protected void Return(object sender, EventArgs e)
        {
            if (Session["Role"].Equals("ادارة")) { 
            
             Response.Redirect("MainProjMan.aspx");

            }
            else { 
            Response.Redirect("MainFinance.aspx");
            }


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
            IncomeExTbl.TableName = "التقرير";
            wb.Worksheets.Add(IncomeExTbl);
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