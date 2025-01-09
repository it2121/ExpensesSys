using ExpensesSys.Pages.Law;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class SeperateProjectSelector : System.Web.UI.Page
    {
        public static string GoToPage = "MainHome";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Role"] .Equals("القانونية"))
                {
                    GoToPage = "LawHome";
                    //   ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + GoToPage + "');", true);

                    LABtnsPanel.Visible = true;
                }
                else
                {
                    LABtnsPanel.Visible = false;
                    GoToPage = "MainHome";


                }
                DataTable allProjects = BBAALL.GetAllProjects();




                DataTable allProjectsAfterRemoving = allProjects.Clone();

                allProjectsAfterRemoving.Clear();


                DataTable userProjects = BBAALL.GetAllProjectsOfAUser(Convert.ToInt32(Session["ID"]));

                foreach (DataRow row in userProjects.Rows )

                {


                    foreach (DataRow InnerRow in allProjects.Rows)

                    {
                        if(row["ProjectID"] .Equals (InnerRow["ID"]))
                        {

                            allProjectsAfterRemoving.ImportRow(InnerRow);
                        }


                    }
                }

                DataGridUsers.DataSource = allProjectsAfterRemoving;

                DataGridUsers.DataBind();

                //OverseeingManagmntBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("ادارة");
                OverseeingManagmntBtn.Visible = Session["God"].Equals("1");

               // GeneralInAndOutPanel.Visible= Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
                GeneralInAndOutPanel.Visible = Session["God"].Equals("1") ;
                
            
            }

        }



        protected void GoToGeneralFinanceNav(object sender, EventArgs e)
        {
            Session["ProjectID"] = "0";

            Response.Redirect("GeneralFinanceNav.aspx");
        }
        protected void GoToGeneralIn(object sender, EventArgs e)
        {
            Session["ProjectID"] = "0";

            GeneralInAndOut.RecType = "In";
            Response.Redirect("GeneralInAndOut.aspx");
        }

        protected void GoToGeneralOut(object sender, EventArgs e)
        {
            Session["ProjectID"] = "0";

            GeneralInAndOut.RecType = "Out";

            Response.Redirect("GeneralInAndOut.aspx");
        }



        protected void GoToContracts(object sender, EventArgs e)
        {

            Session["ProjectID"] = "0";

            Response.Redirect("LAWContracts.aspx");
        }

        protected void GoToCases(object sender, EventArgs e)
        {

            Session["ProjectID"] = "0";

            Response.Redirect("Cases.aspx");
        }
        protected void GoToProjectZero(object sender, EventArgs e)
        {

            if (GoToPage.Equals("ProjEditor"))
            {
                // ProjEditor.ProjID = Convert.ToInt32(id.Text);
            }
            else if (GoToPage.Equals("EmpEditor"))
            {
                // EmpEditor.EmpId = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("ItemsEditor"))
            {
                // ItemsEditor.ItemID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("EmpMan"))
            {
                EmpMan.ProjectID = 0;


            }
            else if (GoToPage.Equals("Expences"))
            {
                Expences.ProjectID = 0;


            }
            else if (GoToPage.Equals("Salary"))
            {
                Salary.ProjectID = 0;


            }
            else if (GoToPage.Equals("Nth"))
            {
                Nth.ProjectID = 0;


            }
            else if (GoToPage.Equals("Income"))
            {
                Income.ProjectID = 0;


            }
            else if (GoToPage.Equals("OriginalEmp"))
            {
                OriginalEmp.ProjectID = 0;


            }
            else if (GoToPage.Equals("OriginalEmpSelector"))
            {
                OriginalEmpSelector.ProjectID = 0;


            }
            else if (GoToPage.Equals("Warehouse"))
            {
                Warehouse.ProjectID = 0;


            }
            else if (GoToPage.Equals("MainHome"))
            {
                MainHome.ProjectID = 0;

                Session["ProjectID"] = "0";


            }



            Response.Redirect(GoToPage + ".aspx");


        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;

            if (GoToPage.Equals("ProjEditor"))
            {
                // ProjEditor.ProjID = Convert.ToInt32(id.Text);
            }
            else if (GoToPage.Equals("EmpEditor"))
            {
                // EmpEditor.EmpId = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("ItemsEditor"))
            {
                // ItemsEditor.ItemID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("EmpMan"))
            {
                EmpMan.ProjectID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("Expences"))
            {
                Expences.ProjectID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("Salary"))
            {
                Salary.ProjectID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("Nth"))
            {
                Nth.ProjectID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("Income"))
            {
                Income.ProjectID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("OriginalEmp"))
            {
                OriginalEmp.ProjectID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("OriginalEmpSelector"))
            {
                OriginalEmpSelector.ProjectID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("Warehouse"))
            {
                Warehouse.ProjectID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("MainHome"))
            {
                MainHome.ProjectID = Convert.ToInt32(id.Text);


                Session["ProjectID"] = id.Text;

            }
            else if (GoToPage.Equals("LawHome"))
            {
                LawHome.ProjectID = Convert.ToInt32(id.Text);


                Session["ProjectID"] = id.Text;

            }


            Response.Redirect(GoToPage + ".aspx");



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


            Response.Redirect("MainHome.aspx");



        }

    }
}