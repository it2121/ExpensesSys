using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class WorkContracts : System.Web.UI.Page
    {
        public static int ProjectID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {


            Main.openPage = "WorkContracts";

            if (!IsPostBack)
            {

                DataTable dt = BBAALL.GetAllWorkContractsOFAProject(ProjectID);
                PageProjectNameLbl.Text = BBAALL.getProjectNameByID(ProjectID).Rows[0][0].ToString();
                DataTable finalTbl = dt.Clone();
                finalTbl.Clear();

                dt.Columns.Add("UnitCount", typeof(String));
                dt.Columns.Add("PaidAmount", typeof(String));
                dt.Columns.Add("RemAmount", typeof(String));

                foreach (DataRow dr in dt.Rows)
                    
                {

                    dr["UnitCount"] = BBAALL.getCoutOfUnitsForWorkContracts(Convert.ToInt32(dr["ID"])).Rows[0][0].ToString();
                    dr["PaidAmount"] = BBAALL.GetTotalPaidAmountOfWorkContract(Convert.ToInt32(dr["ID"])).Rows[0][0].ToString();
                    dr["RemAmount"] = BBAALL.GetTotalRemAmountOfWorkContract(Convert.ToInt32(dr["ID"])).Rows[0][0].ToString();
                }



                DataGridUsers.DataSource = dt;
                DataGridUsers.DataBind();



            }

        }
        protected void GoToNewItem(object sender, EventArgs e)
        {


            WorkContractsEditor.ProjectID = ProjectID;

            Response.Redirect("WorkContractsEditor.aspx");

        }

        protected void MyGridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            string x = e.CommandName;//returns "Select" for both asp:CommandField columns

            if (x.Equals("GoToUnits"))
            {

                string IDToShare = e.CommandArgument.ToString();




                WorkContractsUnits.ID = Convert.ToInt32(IDToShare);
                WorkContractsUnits.ProjectID = ProjectID;


                Response.Redirect("WorkContractsUnits.aspx");

            }
            else if (x.Equals("GoToContractPaymentsCommand")) {


                string IDToShare = e.CommandArgument.ToString();




                WorkContractsPayments.RecID = Convert.ToInt32(IDToShare);


                Response.Redirect("WorkContractsPayments.aspx");

            }
           


        }


        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;


            WorkContractsEditor.ID = Convert.ToInt32(id.Text);
            WorkContractsEditor.ProjectID = ProjectID;


            Response.Redirect("WorkContractsEditor.aspx");


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