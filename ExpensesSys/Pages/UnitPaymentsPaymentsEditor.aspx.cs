using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class UnitPaymentsPaymentsEditor : System.Web.UI.Page
    {
        public static int OriginalPaymentID = 0;
        public static int ID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             

                
                if (ID != 0)
                {
                    DataTable PayTbl = BBAALL.GetUnitPaymentsPaymentsByID(ID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in PayTbl.Rows)
                    {
                      



                            PaidAmount.Text = dt["PaidAmount"].ToString();
                            PayDate.Text = dt["PayDate"].ToString();


                        

                    }
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {
                    ID = 0;
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة دفعة جديدة";

                    DateTime dateTime = DateTime.UtcNow.Date;
                    PayDate.Text = dateTime.ToString("dd/MM/yyyy");
                    PaidAmount.Text = "";

                }
            }

        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("UnitPaymentsPayments.aspx");



        }
        void UpdatePaidStatus(int OriginalPayemntID) {



            DataTable dt = BBAALL.GetTheSumAndActualAmountOfOriginalPayment(OriginalPayemntID);
            int Amount = Convert.ToInt32(dt.Rows[0][0].ToString());
            int PaidAmount = Convert.ToInt32(dt.Rows[0][1].ToString());
            string Paid = "0";
            if (PaidAmount >= Amount)
                Paid = "1";

            BBAALL.UpdatePaiStatusOfOriginalPayment(Paid,OriginalPayemntID);
        
        }
        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertIntoUnitPaymentsPayments(OriginalPaymentID,Convert.ToInt32(PaidAmount.Text), MyStringManager.GetDateAfterCheckingFormating(PayDate.Text)
                    );


                UpdatePaidStatus(OriginalPaymentID);


                UnitPaymentsPayments.OriginalPaymentID = OriginalPaymentID;
                Response.Redirect("UnitPaymentsPayments.aspx");

            }
            else
            {


                BBAALL.UpdateUnitPaymentsPayments(MyStringManager.GetDateAfterCheckingFormating(PayDate.Text), Convert.ToInt32(PaidAmount.Text), ID);
                UpdatePaidStatus(OriginalPaymentID);

                ID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة دفعة جديدة";


                Response.Redirect("UnitPaymentsPayments.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteUnitPaymentsPaymentsByID(ID);
            ID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة دفعة جديدة";

            DateTime dateTime = DateTime.UtcNow.Date;
            PayDate.Text = dateTime.ToString("dd/MM/yyyy");
            PaidAmount.Text = "";

            Response.Redirect("UnitPaymentsPayments.aspx");



        }
    }
}