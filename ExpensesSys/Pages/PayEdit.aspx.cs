using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class PayEdit : System.Web.UI.Page
    {
        public static int RecID = 0;
        public static int MainRecID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (RecID != 0)
                {
                    DataTable PayTbl = BBAALL.getAllPayByRecID(RecID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in PayTbl.Rows)
                    {
                        if (RecID.Equals(dt[0]))
                        {



                            PaidAmount.Text = dt["PaidAmount"].ToString();
                            Date.Text = dt["Date"].ToString();


                        }

                    }
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {
                    RecID = 0;
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة دفعة جديدة";

                    DateTime dateTime = DateTime.UtcNow.Date;
                    Date.Text = dateTime.ToString("dd/MM/yyyy");
                 PaidAmount.Text = "";

                }
            }

        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Pay.aspx");



        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (RecID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertPay(Convert.ToInt32(PaidAmount.Text), Date.Text, MainRecID );




                Response.Redirect("Pay.aspx");

            }
            else
            {


                BBAALL.updatePay(Convert.ToInt32(PaidAmount.Text), Date.Text, MainRecID,RecID);

                RecID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة دفعة جديدة";


                Response.Redirect("Pay.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteEmp(RecID);
            RecID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة دفعة جديدة";

            DateTime dateTime = DateTime.UtcNow.Date;
            Date.Text = dateTime.ToString("dd/MM/yyyy");
            PaidAmount.Text = "";

            Response.Redirect("Pay.aspx");



        }
    }
}