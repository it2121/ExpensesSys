using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class tester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "Income";

            if (!IsPostBack)
            {

                DataTable dt = BBAALL.GetSearchList(1);
                PageProjectNameLbl.Text = BBAALL.getProjectNameByID(1).Rows[0][0].ToString();




                DataGridUsers.DataSource = dt;
                DataGridUsers.DataBind();



            }
        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

           


        }

    }
}