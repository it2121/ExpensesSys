using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class NthEdtor : System.Web.UI.Page
    {
        public static int ID = 0;

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

                if (ID != 0)
                {


                    DataTable ProjectDT = BBAALL.getNthByID(ID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in ProjectDT.Rows)
                    {
                        if (ID.Equals(dt[0]))
                        {



                            Name.Text = dt["Name"].ToString();
                            Quant.Text = dt["Quant"].ToString();
                            BuyDate.Text = dt["BuyDate"].ToString();
                            Cost.Text = dt["Cost"].ToString();
                            WithdrowParty.Text = dt["WithdrowParty"].ToString();


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
                    BuyDate.Text = dateTime.ToString("dd/MM/yyyy");

                    Name.Text = "";
                    Quant.Text = "";
                    Cost.Text = "";

                }
            }
        }

        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Nth.aspx");



        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertNth(Name.Text,
                    Convert.ToInt32(Quant.Text),

                    BuyDate.Text, Convert.ToInt32(Cost.Text), WithdrowParty.Text);




                Response.Redirect("Nth.aspx");

            }
            else
            {


                BBAALL.UpdateNth(Name.Text,
                    Convert.ToInt32(Quant.Text),

                    BuyDate.Text, Convert.ToInt32(Cost.Text),ID, WithdrowParty.Text);

                ID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة قيد جديد";


                Response.Redirect("Nth.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteNth(ID);
            ID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة قيد جديد";

            Name.Text = "";
            Quant.Text = "";
            BuyDate.Text = "";
            Cost.Text = "";

            Response.Redirect("Nth.aspx");



        }
    }
}