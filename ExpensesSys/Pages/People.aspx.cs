using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages.Law
{
    public partial class People : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "LawPeople";

            if (!IsPostBack) { 
            PageProjectNameLbl.Text = BBAALL.getProjectNameByID(Convert.ToInt32(Session["ProjectID"].ToString())).Rows[0][0].ToString();
            }
        }

        protected void Search(object sender, EventArgs e)
        {

            DataTable dt = BBAALL.GetSearchListByWord(Convert.ToInt32(Session["ProjectID"].ToString()), SearchBox.Text);
            DataGridUsers.DataSource = dt;
            DataGridUsers.DataBind();

        }
        protected void MyGridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            string x = e.CommandName;


            if (x.Equals("Docks"))
            {

                string ID = e.CommandArgument.ToString();
                Documents.RecID = ID;
                Response.Redirect("Documents.aspx");

            }


        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_OR23") as Label;





            GeneralInfoEditor.RecID = id.Text;

            GeneralInfoEditor.RecdirectTo = "People.aspx";
            GeneralInfoEditor.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("GeneralInfoEditor.aspx");

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