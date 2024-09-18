using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class UnitPaymentsEditor : System.Web.UI.Page
    {
        public static string RecID = "";
        public static int PaymentID = 0;
        public static string  Paid = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (PaymentID != 0)
                {
                    DataTable PayTbl = BBAALL.GetUnitPaymentByID(PaymentID);
                   // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + PayTbl.Rows.Count+ "');", true);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in PayTbl.Rows)
                    {
                      



                            PayNo.Text = dt["PayNo"].ToString();
                            Amount.Text = dt["Amount"].ToString();
                            DateOfPay.Text = dt["DateOfPay"].ToString();
                            PaidAmount.Text = dt["PaidAmount"].ToString();
                            Paid = dt["Paid"].ToString();


                        

                    }
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة دفعة جديدة";

                    DateTime dateTime = DateTime.UtcNow.Date;
                    DateOfPay.Text = dateTime.ToString("dd/MM/yyyy");


                    PayNo.Text = "";
                    Amount.Text = "";
                    PaidAmount.Text = "";

                    Paid = "";

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


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);
                string paid = "0";
                if (Convert.ToInt32(Amount.Text) == Convert.ToInt32(PaidAmount.Text)) { paid = "1"; }

                BBAALL.InsertIntoUnitPayments(Convert.ToInt32(PayNo.Text), Convert.ToInt32(Amount.Text),
                    DateOfPay.Text, Convert.ToInt32(PaidAmount.Text),RecID, paid);




                Response.Redirect("UnitPayments.aspx");

            }
            else
            {
                string paid = "0";

                if (Convert.ToInt32(Amount.Text) == Convert.ToInt32(PaidAmount.Text)) { paid = "1"; }


                BBAALL.UpdateUnitPayments(Convert.ToInt32(PayNo.Text), Convert.ToInt32(Amount.Text),
                    DateOfPay.Text, Convert.ToInt32(PaidAmount.Text), RecID, paid, PaymentID);

                RecID = "";
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة دفعة جديدة";


                Response.Redirect("UnitPayments.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteUnitPayments(PaymentID);
            RecID = "";
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة دفعة جديدة";


            DateTime dateTime = DateTime.UtcNow.Date;
            DateOfPay.Text = dateTime.ToString("dd/MM/yyyy");


            PayNo.Text = "";
            Amount.Text = "";
            DateOfPay.Text = "";
            PaidAmount.Text = "";
            Paid = "";

            Response.Redirect("UnitPayments.aspx");



        }
    }
}