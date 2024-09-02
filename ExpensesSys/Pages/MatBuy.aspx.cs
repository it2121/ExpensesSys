using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class MatBuy : System.Web.UI.Page
    {
        public static int ProjectID = 0; 
        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "Expences";

            if (!IsPostBack)
            {

                DataTable dt = BBAALL.GetMatBuyOfAProject(ProjectID);
                PageProjectNameLbl.Text = BBAALL.getProjectNameByID(ProjectID).Rows[0]["Name"].ToString();

                DataGridUsers.DataSource = dt;
                DataGridUsers.DataBind();



            }
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {

                    Label TotlaCostLbl = (e.Row.FindControl("lbl_TotalCost") as Label);
                    Label RecAmountLbl = (e.Row.FindControl("lbl_RecAmount") as Label);

                    int TotlaCostint = Convert.ToInt32(TotlaCostLbl.Text);
                    int RecAmountint = Convert.ToInt32(RecAmountLbl.Text);


                    if (TotlaCostint- RecAmountint <=0)
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

        protected void MyGridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {//GoToPay
            string x = e.CommandName;//returns "Select" for both asp:CommandField columns

            if (x.Equals("GoToPay"))
            {

                Pay.RecId = Convert.ToInt32(e.CommandArgument.ToString());
                Pay.ProjectID = ProjectID;



               

                Response.Redirect("Pay.aspx");

            }


        }

        protected void GoToNewItem(object sender, EventArgs e)
        {

            //  MatBuyEditor.ProjectID = ProjectID;
            MatBuyEditor.ProjectID = ProjectID;
            MatBuyEditor.MatBuyRecId = 0;

            Response.Redirect("MatBuyEditor.aspx");

        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;


            MatBuyEditor.MatBuyRecId = Convert.ToInt32(id.Text);
           MatBuyEditor.ProjectID = ProjectID;


            Response.Redirect("MatBuyEditor.aspx");


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