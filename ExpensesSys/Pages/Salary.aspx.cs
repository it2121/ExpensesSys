using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class Salary : System.Web.UI.Page
    {
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                
                PageProjectNameLbl.Text = "رواتب موظفي مشروع - " + BBAALL.getProjectNameByID(ProjectID).Rows[0]["Name"].ToString();

                DataTable SalaryTbl = BBAALL.getSalaryByProjectID(ProjectID);
                DataTable EmpTbl = BBAALL.GetEmpOfProject(ProjectID);

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
                    EmpAndSalaryTbl.Rows[counter]["Paid"] =0;


                        counter ++;

                }

                foreach (DataRow row in SalaryTbl.Rows)
                {
                    foreach (DataRow rowMain in EmpAndSalaryTbl.Rows)
                {
                   
                    

                        if (rowMain["EmpID"].ToString().Equals(row["EmpID"].ToString())) {

                                rowMain["SalaryID"] = row["ID"];
                                rowMain["RecDate"] = row["RecDate"];
                                rowMain["Salary"] = row["Salary"];
                                rowMain["Paid"] = 1;
                            SalaryTbl.AcceptChanges();
                        }

                }
                
                }


                 DataGridUsers.DataSource = EmpAndSalaryTbl;
                 DataGridUsers.DataBind();



            }


        }

        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();



            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;
            Label emdID = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID123as") as Label;



            if (id.Text.Length > 0)
            {

                SalaryEditor.SalaryRecID = Convert.ToInt32(id.Text);
                SalaryEditor.ProjectID = ProjectID;
            }
            else {



                SalaryEditor.EmpId = Convert.ToInt32(emdID.Text); ;
                SalaryEditor.SalaryRecID = 0 ;
                SalaryEditor.ProjectID = ProjectID;

            }


           Response.Redirect("SalaryEditor.aspx");


        }
        protected void MyGridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            string x = e.CommandName;//returns "Select" for both asp:CommandField columns

                if (x.Equals("AutoIn"))
            {

                string EmpID = e.CommandArgument.ToString();
                
                DateTime dateTime = DateTime.UtcNow.Date;

                BBAALL.AutoInsertSalary(Convert.ToInt32(EmpID), dateTime.ToString("dd/MM/yyyy"), ProjectID);
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