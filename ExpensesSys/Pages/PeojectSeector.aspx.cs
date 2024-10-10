using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class PeojectSeector : System.Web.UI.Page
    {
        public static string GoToPage = "Home";
        protected void Page_Load(object sender, EventArgs e)
        {
           // Main.openPage = "ProjectSelector";
            if (!IsPostBack)

            {

                if (Session["Role"].ToString().Equals("القانونية"))
                {
                    GoToPage = "LawHome";
                  //   ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + GoToPage + "');", true);

                }

                DataTable allProjects = BBAALL.GetAllProjects();
                DataGridUsers.DataSource = allProjects;


                DataGridUsers.DataBind();

            }
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


            }           else if (GoToPage.Equals("OriginalEmp"))
            {
                OriginalEmp.ProjectID = 0;


            }
                       else if (GoToPage.Equals("OriginalEmpSelector"))
            {
                OriginalEmpSelector.ProjectID = 0;


            }     else if (GoToPage.Equals("Warehouse"))
            {
                Warehouse.ProjectID = 0;


            }   else if (GoToPage.Equals("Home"))
            {
                Home.ProjectID = 0;
                Session["ProjectID"] = "0";


            }


            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + GoToPage + "');", true);
            //Response.Redirect(GoToPage + ".aspx");
          //  Response.Redirect(GoToPage + ".aspx");


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
            else if (GoToPage.Equals("EmpEditor")) {
               // EmpEditor.EmpId = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("ItemsEditor")) {
               // ItemsEditor.ItemID = Convert.ToInt32(id.Text);


            }  else if (GoToPage.Equals("EmpMan")) {
                EmpMan.ProjectID = Convert.ToInt32(id.Text);


            }else if (GoToPage.Equals("Expences")) {
                Expences.ProjectID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("Salary")) {
                Salary.ProjectID = Convert.ToInt32(id.Text);


            } else if (GoToPage.Equals("Nth")) {
                Nth.ProjectID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("Income")) {
                Income.ProjectID = Convert.ToInt32(id.Text);


            }
            else if (GoToPage.Equals("OriginalEmp"))
            {
                OriginalEmp.ProjectID = Convert.ToInt32(id.Text);


            }     else if (GoToPage.Equals("OriginalEmpSelector"))
            {
                OriginalEmpSelector.ProjectID = Convert.ToInt32(id.Text);


            }  else if (GoToPage.Equals("Warehouse"))
            {
                Warehouse.ProjectID = Convert.ToInt32(id.Text);


            }else if (GoToPage.Equals("Home"))
            {
                Home.ProjectID = Convert.ToInt32(id.Text);

                                Session["ProjectID"] = id.Text;

            }



           // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + GoToPage + "');", true);
           // Response.Redirect(GoToPage+ ".aspx");



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


           // Response.Redirect("Home.aspx");



        }


    }
}