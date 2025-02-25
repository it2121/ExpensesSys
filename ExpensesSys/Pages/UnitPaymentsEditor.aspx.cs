﻿using System;
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
        public static int ProjectID = 0;
        public static string  Paid = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());

                if (PaymentID != 0)
                {

                    DataTable PayTbl = BBAALL.GetUnitPaymentByID(PaymentID);
                   // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + PayTbl.Rows.Count+ "');", true);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in PayTbl.Rows)
                    {
                      



                            PayNo.Text = dt["PayNo"].ToString();
                            Amount.Text = dt["Amount"].ToString();
                            Paid = dt["Paid"].ToString();


                        

                    }
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة دفعة جديدة";

                  

                    PayNo.Text = "";
                    Amount.Text = "";

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
                //if (Convert.ToInt32(Amount.Text) == Convert.ToInt32(PaidAmount.Text)) { paid = "1"; }

                BBAALL.InsertIntoUnitPayments(Convert.ToInt32(PayNo.Text), Convert.ToInt32(Amount.Text) ,ProjectID ,RecID, paid);

                //   MyStringManager.GetDateAfterCheckingFormating(DateOfPay.Text)



                UnitPaymentsPaymentsEditor.ID = 0;
                UnitPaymentsPaymentsEditor.OriginalPaymentID = Convert.ToInt32(BBAALL.GetLastAddedOriginalPayment().Rows[0][0].ToString());

                Response.Redirect("UnitPaymentsPaymentsEditor.aspx");



            }
            else
            {
               // string paid = "0";

           //     if (Convert.ToInt32(Amount.Text) == Convert.ToInt32(PaidAmount.Text)) { paid = "1"; }


                BBAALL.UpdateUnitPayments(Convert.ToInt32(PayNo.Text), Convert.ToInt32(Amount.Text),
                                       RecID, PaymentID);

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


       /*     DateTime dateTime = DateTime.UtcNow.Date;
            DateOfPay.Text = dateTime.ToString("dd/MM/yyyy");
*/

            PayNo.Text = "";
            Amount.Text = "";
  
            Paid = "";

            Response.Redirect("UnitPayments.aspx");



        }
    }
}