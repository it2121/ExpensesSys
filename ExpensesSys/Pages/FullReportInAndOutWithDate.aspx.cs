using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
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
                WithdrowParty.Items.Add("وارد المستثمر");

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
            CompSum.Text = MyStringManager.GetNumberWithComas(MyStringManager.ReturnSumOfDTFildInInt(CompSet, "الكلفة") +"") + " IQD مجموع المجاملات"; 
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
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Reports.aspx");



        }
    }
}