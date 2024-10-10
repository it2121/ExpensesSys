using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class LoanPayments : System.Web.UI.Page
    {
        public static string RecID = "";
        public static string RecdirectTo = "";
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "Loan";

            if (!IsPostBack)
            {
                ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());

                DataTable dt = BBAALL.GatAllLoanPaymentOfRecID(RecID);
                PageProjectNameLbl.Text = BBAALL.getProjectNameByID(ProjectID).Rows[0][0].ToString();

                DataGridUsers.DataSource = dt;
                DataGridUsers.DataBind();



            }
            NewPayemnt.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");


        }


        protected void GoToNewItem(object sender, EventArgs e)
        {

            LoanPaymentsEditor.RecID = RecID;
            LoanPaymentsEditor.PaymentID = 0;

            Response.Redirect("LoanPaymentsEditor.aspx");

        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();


            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;


            LoanPaymentsEditor.RecID = RecID;
            LoanPaymentsEditor.PaymentID = Convert.ToInt32(id.Text);



            //  PayEdit.ProjectID = ProjectID;


            Response.Redirect("LoanPaymentsEditor.aspx");


        }
        protected void Return(object sender, EventArgs e)
        {

            if (RecdirectTo.Length != 0)
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



        }
        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            
        }
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
        
        }
    }
}