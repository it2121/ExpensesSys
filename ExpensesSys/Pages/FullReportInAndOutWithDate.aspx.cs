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


    public static  DataTable IncomeSet;
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
        }       protected void ChckedChangedProjectName(object sender, EventArgs e)
        {
            if(PrjectNameCheck.Checked == true) { 
         
                ProjectName.Enabled = false;
       

            }
            else
            {
           
                ProjectName.Enabled = true;
          


            }
          //  UpdatePanelDates.Update();
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
              //  StartDate.Text = "";
                StartDate.Enabled = true;
               // EndDate.Text = "";
                EndDate.Enabled = true;


            }
          //  UpdatePanelDates.Update();
        }


       

       

        protected void CalclateAllTables(object sender, EventArgs e)
        {

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
            NthSum.Text = MyStringManager.GetNumberWithComas(MyStringManager.ReturnSumOfDTFildInInt(NthSet, "الكلفة")+"") + " IQD مجموع النثريات";
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
        protected void CreateInReport(object sender, EventArgs e)
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
            NthTbl.TableName = "صرفيات النثريات";
            wb.Worksheets.Add(NthTbl);
            sheetCounter++;
            
            DataTable CompTbl = CompSet;
            CompTbl.TableName = "صرفيات اخرى";
            wb.Worksheets.Add(CompTbl);
            sheetCounter++;


            // DataTable ProvidersTbl = BBAALL.GetAllProvidersExcelExport();
            //  ProvidersTbl.TableName = "ORs";


            //DataTable Inv = BBAALL.SelectAllInv();
            // Inv.TableName = "Invoices";




            /*

                        List<string> rowsToBeBorderdList = new List<string>();

                        List<DataTable> ProvidersItemsTblList = new List<DataTable>();
                        List<DataTable> reqTblList = new List<DataTable>();
                        // int counter = 0;
                        for (int i = 0; i < ProvidersTbl.Rows.Count; i++)
                        {

                            DataTable ProvidersItemsTbl = BBAALL.GetAllProvidersAndThierItemsForExcelExport(ProvidersTbl.Rows[i][0].ToString());


                            ProvidersItemsTbl.Columns.Add("TotalRequested", typeof(int));
                            ProvidersItemsTbl.Columns["TotalRequested"].SetOrdinal(2);
                            ProvidersItemsTbl.Columns.Add("AllCallOffQty", typeof(int));
                            ProvidersItemsTbl.Columns["AllCallOffQty"].SetOrdinal(3);




                            ProvidersItemsTbl.Columns.Add("Remaining", typeof(int));
                            ProvidersItemsTbl.Columns["Remaining"].SetOrdinal(4);
                            foreach (DataRow dt in ProvidersItemsTbl.Rows)
                            {


                                DataTable AllProvidersForTheItem = BBAALL.GetAllMastersOfAnItem(Convert.ToInt32(dt["ItemID"]));
                                int sum = 0;
                                foreach (DataRow row in AllProvidersForTheItem.Rows)
                                {
                                    if (row[3] != null) { }
                                    sum += Convert.ToInt32(row[3]);


                                }

                                dt[3] = sum;

                                DataTable AllCNsOfAnItem = BBAALL.GetAllCNsOfAnItem(Convert.ToInt32(dt["ItemID"]));
                                int TotalRequested = 0;
                                foreach (DataRow row in AllCNsOfAnItem.Rows)
                                {
                                    if (row[2] != null) { }
                                    TotalRequested += Convert.ToInt32(row[2]);


                                }

                                dt[2] = TotalRequested;
                                dt[4] = sum - TotalRequested;




                            }






                            ProvidersItemsTbl.Columns.Remove("ID");
                            ProvidersItemsTbl.Columns.Remove("ItemID");
                            ProvidersItemsTbl.Columns.Remove("ID1");
                            ProvidersItemsTbl.Columns.Remove("ID2");



                            ProvidersItemsTbl.TableName = "Item of " + ProvidersTbl.Rows[i][0].ToString();
                            DataTable reqTbl = BBAALL.GetRequestsAndThierItemsForExcelExport(ProvidersTbl.Rows[i][0].ToString());

                            reqTbl.Columns["Comments"].ColumnName = "PhoneNumber";



                            string newString = "0";


                            int ExcelRowCounter = 0;
                            string ExcelRowCounterString = "";
                            bool first = true;
                            foreach (DataRow dt in reqTbl.Rows)
                            {
                                if (dt["RequestNumber"].ToString().Equals(newString))
                                {
                                    dt["RequestNumber"] = "";
                                    dt["SubmitDate"] = "";
                                    dt["BOCWorknumber"] = "";
                                    dt["Requester"] = "";
                                    dt["Department"] = "";
                                    dt["IssuingDate"] = "";
                                    dt["ReceivedBy"] = "";
                                    dt["PhoneNumber"] = "";
                                    dt["DeliveryNote"] = "";
                                    dt["Complete"] = "";
                                    first = false;

                                }
                                else
                                {

                                    if (ExcelRowCounter != 0)
                                    {



                                        ExcelRowCounterString = "A" + ExcelRowCounterString + ":" + "L" + (ExcelRowCounter - 1 + 2) + "";

                                        rowsToBeBorderdList.Add(ExcelRowCounterString);
                                        ExcelRowCounterString = ExcelRowCounter + 2 + "";
                                    }
                                    if (ExcelRowCounter == reqTbl.Rows.Count - 1)
                                    {
                                        rowsToBeBorderdList.Add(ExcelRowCounterString);


                                    }


                                    newString = dt["RequestNumber"].ToString();
                                    first = true;

                                }




                                if (first)
                                {
                                    ExcelRowCounterString = (ExcelRowCounter + 2) + "";

                                }





                                ExcelRowCounter++;

                            }




                            reqTbl.Columns.Remove("ID");
                            reqTbl.TableName = "Requests & Items of " + ProvidersTbl.Rows[i][0].ToString();
                            ProvidersItemsTblList.Add(ProvidersItemsTbl);
                            reqTblList.Add(reqTbl);
                            //  wb.Worksheets.Add(ProvidersItemsTblList[i]);
                            wb.Worksheets.Add(reqTblList[i]);
                            sheetCounter++;

                            wb.Worksheets.ElementAt(sheetCounter - 1).Cell(reqTblList[i].Rows.Count + 3, 1).InsertTable(ProvidersItemsTblList[i]);
                            wb.Worksheets.ElementAt(sheetCounter - 1).Tables.ElementAt(1).Theme = XLTableTheme.TableStyleMedium3;
                            wb.Worksheets.ElementAt(sheetCounter - 1).Tables.ElementAt(0).Theme = XLTableTheme.TableStyleMedium6;


                            foreach (string st in rowsToBeBorderdList)
                            {

                                if (st.Length > 3)
                                {

                                    wb.Worksheets.ElementAt(sheetCounter - 1).Range(st).Style
                .Border.SetOutsideBorder(XLBorderStyleValues.Thick);

                                }
                                else
                                {
                                    wb.Worksheets.ElementAt(sheetCounter - 1).Range("A" + st + ":" + "L" + st).Style
            .Border.SetOutsideBorder(XLBorderStyleValues.Thick);


                                }

                            }

                            rowsToBeBorderdList.Clear();


                        }
            */



            // ProvidersTbl.Columns.Remove("ID");


            //  wb.Worksheets.Add(ProvidersTbl);
            //  wb.Worksheets.Add(Inv);

            // sheetCounter++;
            //  sheetCounter++;




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