using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class ItemsEditor : System.Web.UI.Page
    {
        public static int ItemID = 0;
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ItemID != 0)
                {
                    DataTable ProjectDT = BBAALL.getItemByID(ItemID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in ProjectDT.Rows)
                    {
                        if (ItemID.Equals(dt[0]))
                        {



                            ItemName.Text = dt["Name"].ToString();


                        }

                    }
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {
                    ItemID = 0;
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة مادة جديدة";

                    ItemName.Text = "";


                }
            }
        }

        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Expences.aspx");



        }
        protected void CreateItem(object sender, EventArgs e)
        {
            if (ItemID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertItem(ItemName.Text,ProjectID);




                Response.Redirect("Expences.aspx");

            }
            else
            {


                BBAALL.UpdateItem(ItemName.Text, ItemID);

                ItemID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة مادة جديدة";

                Response.Redirect("Expences.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteItem(ItemID);
            ItemID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة مادة جديدة";


            ItemName.Text = "";

            Response.Redirect("Expences.aspx");



        }
    }
}