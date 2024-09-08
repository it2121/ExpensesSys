using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class Salary : System.Web.UI.Page
    {

        public static string StartOfMonthDate ="";
        public static string EndOfMonthDate =""; 
        public static int ProjectID = 0;
        string DateStarterString ;
        public static bool fromItSelf = false;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (!fromItSelf) { 
                if (Convert.ToInt32(DateTime.Now.Month.ToString()) < 10)
                {
                    DateStarterString = "0" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                        Session["Month"] = DateStarterString; 
                }
                else
                {
                    DateStarterString =   DateTime.Now.Month + "/" + DateTime.Now.Year;
                        Session["Month"] = DateStarterString;

                    }
                
                }
                MonthYearSelector.Text = Session["Month"].ToString() ;

                SetUpDate();

            }
         

        }

        public void SetUpDate()
        {


            PageProjectNameLbl.Text = "رواتب موظفي مشروع - " + BBAALL.getProjectNameByID(ProjectID).Rows[0]["Name"].ToString();

            DataTable SalaryTbl = BBAALL.getSalaryByProjectID(ProjectID);
            DataTable EmpTbl = BBAALL.GetEmpOfProject(ProjectID);

            DataTable EmpAfterTermDate = EmpTbl.Clone();
            
            foreach(DataRow dr in EmpTbl.Rows)
            {
                EmpAfterTermDate.ImportRow(dr);

            }

            foreach (DataRow dr in EmpAfterTermDate.Rows)
            {
                    if(dr["TreminationDate"].Equals("0"))
                {
                    dr["TreminationDate"] = "03/02/3024";

                }
                    
            }


            string datetobewithin =  "01/" + MonthYearSelector.Text;


            EmpAfterTermDate = MyStringManager.GetTableAferDateIsWithTheTwoDatesFromTheTable(EmpAfterTermDate, "HiringDate", "TreminationDate",
               datetobewithin);
            EmpTbl = EmpAfterTermDate;

            DataTable EmpAndSalaryTbl = null;

            EmpAndSalaryTbl = EmpTbl.Clone();
            EmpAndSalaryTbl.Clear();

            DataColumn SalaryID = new DataColumn("SalaryID", typeof(int));
            DataColumn EmpID = new DataColumn("EmpID", typeof(string));
            DataColumn RecDate = new DataColumn("RecDate", typeof(string));
            DataColumn Salary = new DataColumn("Salary", typeof(int));
            DataColumn Paid = new DataColumn("Paid", typeof(int));

            EmpAndSalaryTbl.Columns.Add(SalaryID);
            EmpAndSalaryTbl.Columns.Add(EmpID);
            EmpAndSalaryTbl.Columns.Add(RecDate);
            EmpAndSalaryTbl.Columns.Add(Salary);
            EmpAndSalaryTbl.Columns.Add(Paid);

            int counter = 0;
            foreach (DataRow row in EmpTbl.Rows)
            {

                EmpAndSalaryTbl.Rows.Add(EmpAndSalaryTbl.NewRow());
                EmpAndSalaryTbl.Rows[counter]["EmpName"] = row["EmpName"];
                EmpAndSalaryTbl.Rows[counter]["EmpJob"] = row["EmpJob"];
                EmpAndSalaryTbl.Rows[counter]["EmpSalary"] = row["EmpSalary"];
                EmpAndSalaryTbl.Rows[counter]["EmpID"] = row["ID"];
                EmpAndSalaryTbl.Rows[counter]["EmpSalary"] = row["EmpSalary"];

                EmpAndSalaryTbl.Rows[counter]["SalaryID"] = 0;
                EmpAndSalaryTbl.Rows[counter]["RecDate"] = "";
                EmpAndSalaryTbl.Rows[counter]["Salary"] = 0;
                EmpAndSalaryTbl.Rows[counter]["Paid"] = 0;


                counter++;

            }

            foreach (DataRow row in SalaryTbl.Rows)
            {
                foreach (DataRow rowMain in EmpAndSalaryTbl.Rows)
                {



                    if (rowMain["EmpID"].ToString().Equals(row["EmpID"].ToString()))
                    {
                        if (StartOfMonthDate.Length > 0) { 
                        DateTime Date = DateTime.ParseExact(row["RecDate"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        DateTime Startdate = DateTime.ParseExact(StartOfMonthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        DateTime Enddate = DateTime.ParseExact(EndOfMonthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                        int startResult = DateTime.Compare(Date, Startdate);
                        int endResult = DateTime.Compare(Enddate, Date);

                        if (startResult >= 0 && endResult >= 0)
                        {
                            rowMain["SalaryID"] = row["ID"];
                            rowMain["RecDate"] = row["RecDate"];
                            rowMain["Salary"] = row["Salary"];
                            rowMain["Paid"] = 1;
                            SalaryTbl.AcceptChanges();

                        }

                        }
                        else
                        {
                            //  DateTime.Now.ToString("MM");

                            //    string startTemp = "01/" + DateTime.Now.Month + "/" + DateTime.Now.Year +"";
                            string startTemp = "";
                            if (Convert.ToInt32(DateTime.Now.Month.ToString()) < 10) {
                                 startTemp = "01/0" + DateTime.Now.Month + "/" + DateTime.Now.Year ;

                            }
                            else
                            {
                                 startTemp = "01/" + DateTime.Now.Month + "/" + DateTime.Now.Year ;


                            }

                            DateTime Date = DateTime.ParseExact(row["RecDate"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);


                            DateTime Startdate = DateTime.ParseExact(startTemp, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            string tempend = "";
                            if (Convert.ToInt32(DateTime.Now.Month.ToString()) < 10)
                            {
                                 tempend = MyStringManager.GetLastDayOfTheMonth(DateTime.Now.Month) + "/0" + DateTime.Now.Month + "/" + DateTime.Now.Year;

                            }
                            else
                            {
                                 tempend = MyStringManager.GetLastDayOfTheMonth(DateTime.Now.Month) + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;


                            }


                            DateTime Enddate = DateTime.ParseExact(tempend, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                            int startResult = DateTime.Compare(Date, Startdate);
                            int endResult = DateTime.Compare(Enddate, Date);

                            if (startResult >= 0 && endResult >= 0)
                            {
                                rowMain["SalaryID"] = row["ID"];
                                rowMain["RecDate"] = row["RecDate"];
                                rowMain["Salary"] = row["Salary"];
                                rowMain["Paid"] = 1;
                                SalaryTbl.AcceptChanges();

                            }


                        }


                    }

                }

            }


            DataGridUsers.DataSource = EmpAndSalaryTbl;
            DataGridUsers.DataBind();




        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {

                    Label ChecrLbl = (e.Row.FindControl("lbl_ORName12s2") as Label);



                    if (ChecrLbl.Text.Equals("✓"))
                    {
                        e.Row.BackColor = Color.FromName("#e6ffe3");
                    }
                    else 
                    {
                        e.Row.BackColor = Color.FromName("#ffe3e3");

                    }
                 

                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();



            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;
            Label emdID = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID123as") as Label;



            if (!id.Text.Equals("0"))
            {

                SalaryEditor.SalaryRecID = Convert.ToInt32(id.Text);
                SalaryEditor.ProjectID = ProjectID;
                SalaryEditor.EmpId = Convert.ToInt32(emdID.Text);

            }
            else {



                SalaryEditor.EmpId = Convert.ToInt32(emdID.Text); ;
                SalaryEditor.SalaryRecID = 0 ;
                SalaryEditor.ProjectID = ProjectID;

            }
   

             Response.Redirect("SalaryEditor.aspx");


        }
      
        protected void monthSelected(object sender, EventArgs e)
        {


           // MyStringManager.GetUntilOrEmpty(MonthYearSelector.Text, "/");

             StartOfMonthDate = "01/" + MonthYearSelector.Text;
             EndOfMonthDate = MyStringManager.GetLastDayOfTheMonth(Convert.ToInt32(MyStringManager.GetUntilOrEmpty(MonthYearSelector.Text, "/"))) + "/" + MonthYearSelector.Text;
            Session["Month"] = MonthYearSelector.Text;
            SetUpDate();

        }
        protected void MyGridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            string x = e.CommandName;//returns "Select" for both asp:CommandField columns

                if (x.Equals("AutoIn"))
            {

                string EmpID = e.CommandArgument.ToString();
                
                DateTime dateTime = DateTime.UtcNow.Date;
                string dateForAutoIn = "";
                    
                if (Convert.ToInt32(DateTime.Now.Day.ToString()) < 10)
                {
                    dateForAutoIn = "0" + DateTime.Now.Day + "/" + MonthYearSelector.Text;

                }
                else
                {
                    dateForAutoIn = DateTime.Now.Day + "/" + MonthYearSelector.Text;


                }

                BBAALL.AutoInsertSalary(Convert.ToInt32(EmpID), dateForAutoIn, ProjectID,BBAALL.getProjectNameByID(ProjectID).Rows[0][0].ToString());
    
                MonthYearSelector.Text = DateStarterString;
                fromItSelf = true;
                Response.Redirect("Salary.aspx");

            }


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

        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Home.aspx");



        }
    }
}