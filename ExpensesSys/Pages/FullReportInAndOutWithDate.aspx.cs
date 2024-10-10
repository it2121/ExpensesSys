using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class FullReportInAndOutWithDate : System.Web.UI.Page
    {
        public DataTable MatBuy;
        public DataTable Salary;
        public DataTable Comp;
        public DataTable Nth;
        public DataTable Income;
        public DataTable UnityPayments;


    public static  DataTable IncomeSet;
    public static  DataTable UnityPayemetsSet;
        public static DataTable CompSet;
   public static DataTable SalarySet;
        public static DataTable MatBuySet;
        public static DataTable NthSet;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DataTable ProjectsNames = BBAALL.GetAllProjects();
                ProjectName.Items.Add("القناة العامة");
                WithdrowParty.Items.Add("تمويل من المستثمر");
                WithdrowParty.Items.Add("قرض");

                foreach (DataRow row in ProjectsNames.Rows)
                {

                    ProjectName.Items.Add(row["Name"].ToString());
                    WithdrowParty.Items.Add(row["Name"].ToString());

                }

            }

        }
        protected void ChckedChangedWithdowParty(object sender, EventArgs e)
        {
            if(WithdrowPartyCheck.Checked == true) {

                WithdrowParty.Enabled = false;
       

            }
            else
            {

                WithdrowParty.Enabled = true;
          


            }
          //  UpdatePanelDates.Update();
        }      
        protected void ChckedChangedProjectName(object sender, EventArgs e)
        {
            if(PrjectNameCheck.Checked == true) { 
         
                ProjectName.Enabled = false;
       

            }
            else
            {
           
                ProjectName.Enabled = true;
          


            }
        }




               protected void ChckedChanged(object sender, EventArgs e)
        {
            if(UnMarkedDate.Checked == true) { 
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


       

       

        protected void CalclateAllTables(object sender, EventArgs e)
        {

            UnityPayments = BBAALL.REP_GetAllUnitPaymentRecords();

            UnityPayemetsSet = MyStringManager.GetTableAfterDateCheck(UnityPayments, StartDate.Text, EndDate.Text);


            
            Income = BBAALL.REP_GetAllIncomeRecords();

             IncomeSet = MyStringManager.GetTableAfterDateCheck(Income, StartDate.Text, EndDate.Text);






            MatBuy = BBAALL.REP_GetAllMatBuyRecords();

             MatBuySet = MyStringManager.GetTableAfterDateCheck(MatBuy, StartDate.Text, EndDate.Text);




            Salary = BBAALL.REP_GetAllSalaryRecords();
             SalarySet = MyStringManager.GetTableAfterDateCheck(Salary, StartDate.Text, EndDate.Text);




            Comp = BBAALL.REP_GetAllCompRecords();
             CompSet = MyStringManager.GetTableAfterDateCheck(Comp, StartDate.Text, EndDate.Text);



            Nth = BBAALL.REP_GetAllNthRecords();

             NthSet = MyStringManager.GetTableAfterDateCheck(Nth, StartDate.Text, EndDate.Text);


            if (PrjectNameCheck.Checked == false)
            {

                IncomeSet = MyStringManager.GetTableAfterCeckProjectName(IncomeSet, ProjectName.Text, "اسم_الجهة_المستلمة");
                UnityPayemetsSet = MyStringManager.GetTableAfterCeckProjectName(UnityPayemetsSet, ProjectName.Text, "اسم_الجهة_المستلمة");
                MatBuySet = MyStringManager.GetTableAfterCeckProjectName(MatBuySet, ProjectName.Text, "المشروع");
                SalarySet = MyStringManager.GetTableAfterCeckProjectName(SalarySet, ProjectName.Text, "المشروع");
                CompSet = MyStringManager.GetTableAfterCeckProjectName(CompSet, ProjectName.Text, "اسم_المشروع");



            }   if (WithdrowPartyCheck.Checked == false)
            {

                IncomeSet = MyStringManager.GetTableAfterCeckWithdorwParty(IncomeSet, WithdrowParty.Text, "اسم_الجهة_المستلمة");
                MatBuySet = MyStringManager.GetTableAfterCeckWithdorwParty(MatBuySet, WithdrowParty.Text, "جهة_السحب");
                SalarySet = MyStringManager.GetTableAfterCeckWithdorwParty(SalarySet, WithdrowParty.Text, "جهة_السحب");
                CompSet = MyStringManager.GetTableAfterCeckWithdorwParty(CompSet, WithdrowParty.Text, "جهة_السحب");
                NthSet = MyStringManager.GetTableAfterCeckWithdorwParty(NthSet, WithdrowParty.Text, "جهة_السحب");



            }


            IncomeSum.Text = MyStringManager.GetNumberWithComas(MyStringManager.ReturnSumOfDTFildInInt(IncomeSet, "المبلغ")+"") + " IQD مجموع الوارد";
            UnitPaymentIncomeSum.Text = MyStringManager.GetNumberWithComas(MyStringManager.ReturnSumOfDTFildInInt(UnityPayemetsSet, "المبلغ_المدفوع") +"") + " IQD مجموع وارد دفعات الوحدات"; 
            NthSum.Text = MyStringManager.GetNumberWithComas(MyStringManager.ReturnSumOfDTFildInInt(NthSet, "الكلفة")+"") + " IQD مجموع الصرفيات العامة";
            CompSum.Text = MyStringManager.GetNumberWithComas(MyStringManager.ReturnSumOfDTFildInInt(CompSet, "الكلفة") +"") + " IQD مجموع الصرفيات الاخرى"; 
            SalarySum.Text = MyStringManager.GetNumberWithComas(MyStringManager.ReturnSumOfDTFildInInt(SalarySet, "المرتب_المستلم")+"") + " IQD مجموع الرواتب"; 
            MatBuySum.Text = MyStringManager.GetNumberWithComas(MyStringManager.ReturnSumOfDTFildInInt(MatBuySet, "مبلغ_الدفعة")+"") + " IQD مجموع صرفيات المواد";

            NthSet = MyStringManager.ReturnTableWithCurrencyCommas(NthSet, "الكلفة");
            CompSet = MyStringManager.ReturnTableWithCurrencyCommas(CompSet, "الكلفة");

            SalarySet = MyStringManager.ReturnTableWithCurrencyCommas(SalarySet, "المرتب_المستلم");
            IncomeSet = MyStringManager.ReturnTableWithCurrencyCommas(IncomeSet, "المبلغ");


            MatBuySet = MyStringManager.ReturnTableWithCurrencyCommas(MatBuySet, "مبلغ_الدفعة");


            HideAll();
            IncomeTbl.DataSource = IncomeSet;

            IncomeTbl.DataBind();
            IncomePanel.Visible = true;
            ExportBtn.Visible = true;
        }
        protected void CreateUnitPayemntReport(object sender, EventArgs e)
        {





            HideAll();
            UnityPaymentsTbl.DataSource = UnityPayemetsSet;

            UnityPaymentsTbl.DataBind();
            UnityPaymentsPanel.Visible = true;

            //Response.Redirect("Reports.aspx");



        }  protected void CreateInReport(object sender, EventArgs e)
        {





            HideAll();
            IncomeTbl.DataSource = IncomeSet;

            IncomeTbl.DataBind();
            IncomePanel.Visible = true;

            //Response.Redirect("Reports.aspx");



        }
        public void HideAll()
        {

            IncomePanel.Visible = false;
            MatBuyPanel.Visible = false;
            SalaryPanel.Visible = false;
            CompPanel.Visible = false;
            NthPanel.Visible = false;
            UnityPaymentsPanel.Visible = false;

/*
            NthTbl.DataSource = null;
            NthTbl.DataBind();


            MatBuyTbl.DataSource = null;
            MatBuyTbl.DataBind();


            SalaryTbl.DataSource = null;
            SalaryTbl.DataBind();


            CompTbl.DataSource = null;
            CompTbl.DataBind();


            IncomeTbl.DataSource = null;
            IncomeTbl.DataBind();*/

        }
       
        protected void CreateMatBuyReport(object sender, EventArgs e)
        {
            HideAll();


            MatBuyTbl.DataSource = MatBuySet;
            MatBuyTbl.DataBind();
            MatBuyPanel.Visible = true;

        }
        protected void CreateSalaryReport(object sender, EventArgs e)
        {
            HideAll();

            SalaryTbl.DataSource = SalarySet;
            SalaryTbl.DataBind();
            SalaryPanel.Visible = true;
        }
        protected void CreateCompReport(object sender, EventArgs e)
        {
            HideAll();

            CompTbl.DataSource = CompSet;
            CompTbl.DataBind();

            CompPanel.Visible = true;

        }
        protected void CreateNthReport(object sender, EventArgs e)
        {
            HideAll();


            NthTbl.DataSource = NthSet;
            NthTbl.DataBind();
            NthPanel.Visible = true;

            //   Response.Redirect("Reports.aspx");


        
        }
        protected void ExportToExcel(object sender, EventArgs e)
        {

            ExportBtnc();





        }      protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Reports.aspx");



        }
        public static void ExportBtnc()
        {

            string pathandname = HttpRuntime.AppDomainAppPath + "/Images/تقرير.xlsx";


            var wb = new XLWorkbook();
            int sheetCounter = 0;
            DataTable IncomeExTbl = IncomeSet;
            IncomeExTbl.TableName = "الوارد";
            wb.Worksheets.Add(IncomeExTbl);
            sheetCounter++;

            DataTable MatBuyTbl = MatBuySet;
            MatBuyTbl.TableName = "صرفيات المواد";
            wb.Worksheets.Add(MatBuyTbl);
            sheetCounter++;
            
            DataTable  SalaryTbl = SalarySet;
            SalaryTbl.TableName = "صرفيات الرواتب";
            wb.Worksheets.Add(SalaryTbl);
            sheetCounter++;
            
            DataTable NthTbl = NthSet;
            NthTbl.TableName = "الصرفيات العامة";
            wb.Worksheets.Add(NthTbl);
            sheetCounter++;
            
            DataTable CompTbl = CompSet;
            CompTbl.TableName = "صرفيات اخرى";
            wb.Worksheets.Add(CompTbl);
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