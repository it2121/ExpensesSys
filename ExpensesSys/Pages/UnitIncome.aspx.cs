using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class UnitIncome : System.Web.UI.Page
    {
        public static int ProjectID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "ProjMan";
            if (!IsPostBack)
            {
              //  DataTable allProjects = BBAALL.GetAllUnitsOfAPorject(ProjectID);
               // DataGridUsers.DataSource = allProjects;


            //    DataGridUsers.DataBind();

            }

        }



        protected void Search(object sender, EventArgs e)
        {

            DataTable dt = BBAALL.GetSearchListByWord(ProjectID, SearchBox.Text);
            DataGridUsers.DataSource = dt;
            DataGridUsers.DataBind();

        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Income.aspx");



        }
        protected void MyGridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            string x = e.CommandName;//returns "Select" for both asp:CommandField columns

            if (x.Equals("Finance"))
            {
                // go to gen info


                string RecID = e.CommandArgument.ToString();
                FinanceEditor.RecID = RecID;
                FinanceEditor.ProjectID = ProjectID;
                Response.Redirect("FinanceEditor.aspx");



            }
            else if (x.Equals("Payments"))
            {

                string ID = e.CommandArgument.ToString();
                UnitPayments.RecID = ID;
                UnitPayments.ProjectID = ProjectID;
                Response.Redirect("UnitPayments.aspx");




            }
            else if (x.Equals("Loan"))
            {

                string RecID = e.CommandArgument.ToString();
                LoanEditor.RecID = RecID;
                LoanEditor.ProjectID = ProjectID;
                Response.Redirect("LoanEditor.aspx");




            }
            else if (x.Equals("LoanPayments"))
            {


                string ID = e.CommandArgument.ToString();
                LoanPayments.RecID = ID;
                LoanPayments.ProjectID = ProjectID;
                Response.Redirect("LoanPayments.aspx");



            }


        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

    /*        Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;


            PeojectUnitEditor.ID = Convert.ToInt32(id.Text);
            PeojectUnitEditor.ProjectID = ProjectID;


            Response.Redirect("PeojectUnitEditor.aspx");*/


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