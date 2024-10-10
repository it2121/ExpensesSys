using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class ProjectAndUnits : System.Web.UI.Page
    {
        public static int ProjectID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "ProjMan";
            if (!IsPostBack)
            {
                ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());

                DataTable allProjects = BBAALL.GetAllProjects();
                DataTable temp = allProjects.Clone();
                foreach (DataRow dr in allProjects.Rows)
                {
                    if (dr["ID"].Equals(ProjectID + "") || ProjectID == 0)
                    {
                        temp.ImportRow(dr);
                    }
                }


                DataGridUsers.DataSource = allProjects;


                DataGridUsers.DataBind();

            }
        }
        protected void MyGridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            string x = e.CommandName;//returns "Select" for both asp:CommandField columns

            if (x.Equals("UnitMan"))
            {

                string ID = e.CommandArgument.ToString();
                PeojectUnit.ProjectID = Convert.ToInt32(ID);
                Response.Redirect("PeojectUnit.aspx");

            }


        }
        protected void GoToReports(object sender, EventArgs e)
        {


            Response.Redirect("UnitReports.aspx");



        }
        protected void Return(object sender, EventArgs e)
        {

            
            Response.Redirect("MainProjMan.aspx");



        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;


            ProjEditor.ProjID = Convert.ToInt32(id.Text);


            Response.Redirect("ProjEditor.aspx");


        }

        protected void GoToWeightMan(object sender, EventArgs e)
        {
            Weights.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("Weights.aspx");

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

        protected void GoToNewItem(object sender, EventArgs e)
        {
            Response.Redirect("ProjEditor.aspx");

        }
    }
}