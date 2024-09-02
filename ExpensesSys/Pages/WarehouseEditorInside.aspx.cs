using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class WarehouseEditorInside : System.Web.UI.Page
    {
        public static int ProjectID = 0;
        public static string ActionType = "";
        public static int MatBuyRecID = 0;
        public static int ID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ID != 0)
                {
                    DataTable WarehouseTbl = BBAALL.getWarehouseByID(ID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in WarehouseTbl.Rows)
                    {
                        if (ID.Equals(dt[0]))
                        {
                            Quant.Text = dt["Quant"].ToString();
                            ActionType = dt["ActionType"].ToString();
                            MatBuyRecID = Convert.ToInt32( dt["MatBuyID"].ToString());
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


                    Quant.Text = "";



                }
            }
        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("WarehouseEditor.aspx");



        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);




                BBAALL.InsertWarehouse(MatBuyRecID, ActionType,Convert.ToInt32(Quant.Text));

                Response.Redirect("WarehouseEditor.aspx");

            }
            else
            {


       
           

                BBAALL.UpdateWarehouse(MatBuyRecID, ActionType, Convert.ToInt32(Quant.Text),ID);

                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة قيد جديد";

                Response.Redirect("WarehouseEditor.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.deleteWarehouse(ID);
            ID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة قيد جديد";



            Quant.Text = "";



            Response.Redirect("WarehouseEditor.aspx");



        }
    }
}