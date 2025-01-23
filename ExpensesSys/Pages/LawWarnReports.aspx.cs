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
    public partial class LawWarnReports : System.Web.UI.Page
    {
        public static DataTable IncomeSet;
        public static int ProjectID;
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
                ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());

                UnitType.Items.Add("A");
                UnitType.Items.Add("B");
                UnitType.Items.Add("C");



            }
        }
   
        public DataTable ReturnTableWithoutMoney()
        {
           //quick fix 
          


            return IncomeSet;
        }

     

        protected void ShowWarnDates(object sender, EventArgs e)
        {




            OutComeTable.DataSource = ReturnTableWithoutMoney();
            OutComeTable.DataBind();




        }
        protected void CalclateAllTables(object sender, EventArgs e)
        {
            EmpCount.Text = EmpRadioLost.SelectedItem.Value;

            Income = BBAALL.REP_GetAllIncomeRecords(ProjectID);

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

                Money = Convert.ToInt32(MoneyTB.Text);
                MoneyType = MoneyList.SelectedValue;

            }


            IncomeSet = BBAALL.UnitReportForLaw(UnittypeStr, Emp, Loan, Warn, Money, MoneyType);





            EmpCount.Text = (MyStringManager.GetCountOfRowsWithCondition(IncomeSet, "التوظيف", "موظف")) + "" + " : عدد الموظفين ";
            NonEmpCount.Text = (MyStringManager.GetCountOfRowsWithCondition(IncomeSet, "التوظيف", "غير موظف")) + "" + " : عدد غير الموظفين ";
            LoanCount.Text = (MyStringManager.GetCountOfRowsWithCondition(IncomeSet, "الاقتراض", "مقترض")) + "" + " : عدد المقترضين ";
            NonLoanCount.Text = (MyStringManager.GetCountOfRowsWithCondition(IncomeSet, "الاقتراض", "غير مقترض")) + "" + " : عدد غير المقترضين ";
            TotalCount.Text = IncomeSet.Rows.Count + "" + "  : العدد الكلي";



            OutComeTable.DataSource = ReturnTableWithoutMoney();
            OutComeTable.DataBind();

            OutComeTablePanel.Visible = true;
            ExportBtn.Visible = true;
    
        }

        protected void ChckedChanged(object sender, EventArgs e)
        {

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


            Response.Redirect("LawHome.aspx");



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