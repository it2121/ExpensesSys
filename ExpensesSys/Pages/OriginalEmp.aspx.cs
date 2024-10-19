using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class OriginalEmp : System.Web.UI.Page
    {
        public static int ProjectID = 0;
        public static string InvolvmentType = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            Main.openPage = "OriginalEmp";

            if (!IsPostBack)
            {

                DataTable dt = BBAALL.getAllOrigenalEmp(ProjectID, InvolvmentType);
                PageProjectNameLbl.Text = BBAALL.getProjectNameByID(ProjectID).Rows[0][0].ToString();

                DataGridUsers.DataSource = dt;
                DataGridUsers.DataBind();



            }
        }
        protected void Return(object sender, EventArgs e)
        {
            

            Response.Redirect("OriginalEmpSelector.aspx");



        }
        protected void GoToNewItem(object sender, EventArgs e)
        {


            OriginalEmpEditor.ProjectID = ProjectID;
            OriginalEmpEditor.ID = 0;
            OriginalEmpEditor.InvolvmentType = InvolvmentType;

            Response.Redirect("OriginalEmpEditor.aspx");

        }

        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;


            OriginalEmpEditor.ID = Convert.ToInt32(id.Text);
            OriginalEmpEditor.ProjectID = ProjectID;


            Response.Redirect("OriginalEmpEditor.aspx");


        }

        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
           
        }
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
      
        }


    }
}