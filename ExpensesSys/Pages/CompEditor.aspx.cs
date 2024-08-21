using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class CompEditor : System.Web.UI.Page
    {
        public static int ID = 0;
        public static int ProjectID = 0;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable ProjectsNames = BBAALL.GetAllProjects();
                WithdrowParty.Items.Add("وارد المستثمر");

                foreach (DataRow row in ProjectsNames.Rows)
                {

                    WithdrowParty.Items.Add(row["Name"].ToString());

                }
                if (ID != 0)
                {

                  
                    DataTable CompTbl = BBAALL.getCompByID(ID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in CompTbl.Rows)
                    {
                        if (ID.Equals(dt[0]))
                        {



                            NameOrReason.Text = dt["NameOrReason"].ToString();
                            Cost.Text = dt["Cost"].ToString();
                            PayDate.Text = dt["PayDate"].ToString();
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
                    PayDate.Text = dateTime.ToString("dd/MM/yyyy");

                    Cost.Text = "";
                    NameOrReason.Text = "";
         

                }
            }



        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Comp.aspx");



        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);




                BBAALL.InsertComp( NameOrReason.Text, Convert.ToInt32(Cost.Text),

                   PayDate.Text,ProjectID,WithdrowParty.Text);

                Response.Redirect("Comp.aspx");

            }
            else
            {


                BBAALL.UpdateComp(ID,NameOrReason.Text,
                    Convert.ToInt32(Cost.Text),

                    PayDate.Text, WithdrowParty.Text);

                ID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة قيد جديد";


                Response.Redirect("Comp.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteNth(ID);
            ID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة قيد جديد";

            Cost.Text = "";
            NameOrReason.Text = "";
            PayDate.Text = "";



            Response.Redirect("Comp.aspx");



        }
    }
}