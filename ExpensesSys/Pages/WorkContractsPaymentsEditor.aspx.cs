using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class WorkContractsPaymentsEditor : System.Web.UI.Page
    {

        public static int RecID = 0;
        public static int MainRecID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable ProjectsNames = BBAALL.GetAllProjects();
                WithdrowParty.Items.Add("تمويل من المستثمر");
                WithdrowParty.Items.Add("قرض");

                foreach (DataRow row in ProjectsNames.Rows)
                {

                    WithdrowParty.Items.Add(row["Name"].ToString());

                }
                if (RecID != 0)
                {
                    DataTable PayTbl = BBAALL.getWorkContractPayByID(RecID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in PayTbl.Rows)
                    {
                        if (RecID.Equals(dt[0]))
                        {



                            PaidAmount.Text = dt["PaidAmount"].ToString();
                            Date.Text = dt["Date"].ToString();
                            WithdrowParty.Text = dt["WithdrowParty"].ToString();


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


            Response.Redirect("WorkContractsPayments.aspx");



        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (RecID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertWorkContractPay(Convert.ToInt32(PaidAmount.Text), Date.Text, MainRecID, WithdrowParty.Text);




                Response.Redirect("WorkContractsPayments.aspx");

            }
            else
            {


                BBAALL.updateWorkContractPay(Convert.ToInt32(PaidAmount.Text), Date.Text, MainRecID, RecID, WithdrowParty.Text);

                RecID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة دفعة جديدة";


                Response.Redirect("WorkContractsPayments.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteWorkContractPay(RecID, MainRecID);
            RecID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة دفعة جديدة";

            DateTime dateTime = DateTime.UtcNow.Date;
            Date.Text = dateTime.ToString("dd/MM/yyyy");
            PaidAmount.Text = "";

            Response.Redirect("WorkContractsPayments.aspx");



        }

    }
}