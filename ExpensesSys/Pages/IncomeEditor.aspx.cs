using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class IncomeEditor : System.Web.UI.Page
    {
        public static int ID = 0;
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
        

                if (ID != 0)
                {
                    DataTable IncomeTbl = BBAALL.getIncomeByID(ID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in IncomeTbl.Rows)
                    {
                        if (ID.Equals(dt[0]))
                        {



                            TypeOfIncome.Text = dt["TypeOfIncome"].ToString();
                            Amount.Text = dt["Amount"].ToString();
                            IncomeDate.Text = dt["IncomeDate"].ToString();
                            Note.Text = dt["Note"].ToString();


                        }

                    }
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {
                    ID = 0;
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة قيد جديد";


                    DateTime dateTime = DateTime.UtcNow.Date;
                    IncomeDate.Text = dateTime.ToString("dd/MM/yyyy");

           


                    TypeOfIncome.Text = "";
                    Amount.Text = "";
                    Note.Text = "";


                }
                CreateBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
                DelBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
            }

        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Income.aspx");



        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);




                BBAALL.InserIncome(
                    TypeOfIncome.Text,
                    Convert.ToInt32(Amount.Text),
ProjectID,
                   IncomeDate.Text, Note.Text);

                Response.Redirect("Income.aspx");

            }
            else
            {


                BBAALL.UpdateIncome(
                    TypeOfIncome.Text,
                    Convert.ToInt32(Amount.Text),
ProjectID,
                   IncomeDate.Text, Note.Text,ID);

                ID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة قيد جديد";


                Response.Redirect("Income.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteIncome(ID);
            ID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة قيد جديد";



            TypeOfIncome.Text = "";
            Amount.Text = "";
            Note.Text = "";



            Response.Redirect("Income.aspx");



        }
    }
}