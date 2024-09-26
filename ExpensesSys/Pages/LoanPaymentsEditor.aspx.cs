using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class LoanPaymentsEditor : System.Web.UI.Page
    {
        public static string RecID = "";
        public static int PaymentID = 0;
        public static string Paid = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (PaymentID != 0)
                {
                    DataTable PayTbl = BBAALL.GatLoanPaymentByID(PaymentID);
                    // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + PayTbl.Rows.Count+ "');", true);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in PayTbl.Rows)
                    {




                        PaymentNumber.Text = dt["PaymentNumber"].ToString();
                        RcvdDate.Text = dt["RcvdDate"].ToString();
                        PaymentAmount.Text = dt["PaymentAmount"].ToString();




                    }
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة دفعة جديدة";

                    DateTime dateTime = DateTime.UtcNow.Date;
                    RcvdDate.Text = dateTime.ToString("dd/MM/yyyy");


                    PaymentNumber.Text = "";
                    PaymentAmount.Text = "";


                }
            }
        }

        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("UnitPayments.aspx");



        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (PaymentID == 0)
            {



                BBAALL.InsertIntoLoanPayments(Convert.ToInt32(PaymentAmount.Text),RcvdDate.Text,RecID,Convert.ToInt32(PaymentNumber.Text));



                
                Response.Redirect("LoanPayments.aspx");

            }
            else
            {
              

                BBAALL.UpdateLoanPayments(Convert.ToInt32(PaymentAmount.Text), RcvdDate.Text, PaymentID
                    , Convert.ToInt32(PaymentNumber.Text));

                RecID = "";
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة دفعة جديدة";


                Response.Redirect("LoanPayments.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteLoanPayment(PaymentID);
            RecID = "";
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة دفعة جديدة";


            DateTime dateTime = DateTime.UtcNow.Date;
            RcvdDate.Text = dateTime.ToString("dd/MM/yyyy");


            PaymentNumber.Text = "";
            PaymentAmount.Text = "";

            Response.Redirect("LoanPayments.aspx");



        }
    }
}