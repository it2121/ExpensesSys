using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class LAWContracts : System.Web.UI.Page
    {
        public static string ContractID = "";
        public static string RecdirectTo = "";
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "Contracts";

            if (!IsPostBack)
            {
                ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());

                DataTable dt = BBAALL.GetContractOfAProjectLAW(ProjectID);
                PageProjectNameLbl.Text = BBAALL.getProjectNameByID(ProjectID).Rows[0][0].ToString();

                DataGridUsers.DataSource = dt;
                DataGridUsers.DataBind();



            }
        }









        protected void MyGridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            string x = e.CommandName;


            if (x.Equals("Docks"))
            {

                string ID = e.CommandArgument.ToString();
                Documents.RecID = "Contract" + ID;
                Response.Redirect("Documents.aspx");

            }


        }



        protected void GoToNewItem(object sender, EventArgs e)
        {

            ContractsEditor.ContractID = 0;

            Response.Redirect("ContractsEditor.aspx");

        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;


            ContractsEditor.ContractID = Convert.ToInt32(id.Text);

            Response.Redirect("ContractsEditor.aspx");


        }
        protected void Return(object sender, EventArgs e)
        {

         
            if (ProjectID == 0)
            {
                Response.Redirect("SeperateProjectSelector.aspx");

            }
            else
            {
                Response.Redirect("LawHome.aspx");
            }


        }
        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
          
        }
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
         
        }



    }
}