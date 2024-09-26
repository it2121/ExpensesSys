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
                ProjectID = Global.ProjecID;

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
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();


            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;


            ContractsEditor.ContractID = Convert.ToInt32(id.Text);



            //  PayEdit.ProjectID = ProjectID;


            Response.Redirect("ContractsEditor.aspx");


        }
        protected void Return(object sender, EventArgs e)
        {

            /* if (RecdirectTo.Length != 0)
             {
                 UnitOverlook.RecID = RecID;
                 string temp = RecdirectTo;
                 RecdirectTo = "";
                 Response.Redirect(temp);

             }
             else
             {

                 Response.Redirect("UnitIncome.aspx");

             }
 */
            Response.Redirect("LawHome.aspx");


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



    }
}