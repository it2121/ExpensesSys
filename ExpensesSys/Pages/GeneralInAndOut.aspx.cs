using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class GeneralInAndOut : System.Web.UI.Page
    {
        public static string RecType = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataTable dt = BBAALL.GetAllIn();
                if (RecType.Equals("Out"))
                    dt = BBAALL.GetAllOut();

            


                DataGridUsers.DataSource = dt;
                DataGridUsers.DataBind();



            }
        }


        protected void GoToNewItem(object sender, EventArgs e)
        {


            GeneralInAndOutEditor.ID = 0;
            GeneralInAndOutEditor.RecType = RecType;

            Response.Redirect("GeneralInAndOutEditor.aspx");

        }
        protected void Return(object sender, EventArgs e)
        {
            

            Response.Redirect("SeperateProjectSelector.aspx");



        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
           

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;





            GeneralInAndOutEditor.ID = Convert.ToInt32(id.Text);
            GeneralInAndOutEditor.RecType = RecType;

            Response.Redirect("GeneralInAndOutEditor.aspx");
        }

        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
        
        }
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
           
        }
    }
}