using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class WeightsEditor : System.Web.UI.Page
    {
        public static int ID = 0;
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable ProjectsNames = BBAALL.GetAllUnitTypesOfProject(ProjectID);
              

                foreach (DataRow row in ProjectsNames.Rows)
                {

                    UnitType.Items.Add(row["UnitType"].ToString());

                }
                if (ID != 0)
                {


                    DataTable CompTbl = BBAALL.GetWeightsByID(ID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in CompTbl.Rows)
                    {
                        if (ID.Equals(dt[0]))
                        {



                            Cost.Text = dt["Cost"].ToString();
                            WeightText.Text = dt["WeightText"].ToString();
                            UnitType.Text = dt["UnitType"].ToString();
                            Precentage.Text = dt["Precentage"].ToString();
                


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



                    Cost.Text = "";
                    WeightText.Text = "";
                    UnitType.Text = "";
                    Precentage.Text = "";

                }
            }


        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Weights.aspx");



        }
        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);

              

                BBAALL.InsertIntoWeights(Convert.ToInt32(Cost.Text), WeightText.Text,

                   ProjectID, UnitType.Text,Convert.ToInt32(Precentage.Text));

                Response.Redirect("Weights.aspx");

            }
            else
            {
               
                BBAALL.UpdateWeights(Convert.ToInt32(Cost.Text), WeightText.Text,

                   ProjectID, UnitType.Text,ID, Convert.ToInt32(Precentage.Text));

                ID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة قيد جديد";


                Response.Redirect("Weights.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteWeights(ID);
            ID = 0;
            DelBtn.Visible = false;

      

        



            Response.Redirect("Weights.aspx");



        }

    }
}