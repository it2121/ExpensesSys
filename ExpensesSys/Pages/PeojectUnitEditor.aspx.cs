using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class PeojectUnitEditor : System.Web.UI.Page
    {
        public static int ID = 0;
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ID != 0)
                {
                    DataTable ProjectDT = BBAALL.getUnitByID(ID);

                    foreach (DataRow dt in ProjectDT.Rows)
                    {
                        if (ID.Equals(dt[0]))
                        {



                            IDOFUnitIfExist.Text = dt["IDOFUnitIfExist"].ToString();
                            NameOfUnit.Text = dt["NameOfUnit"].ToString();


                        }

                    }
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {
                    ID = 0;
                   

                    CreateBtn.Text = "اضافة وحدة جديد";


                    NameOfUnit.Text = "";
                    IDOFUnitIfExist.Text = "";


                }
            }

        }

        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("PeojectUnit.aspx");



        }
        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertUnit(NameOfUnit.Text, IDOFUnitIfExist.Text, ProjectID);




                Response.Redirect("PeojectUnit.aspx");

            }
            else
            {


                BBAALL.UpdateUnit(NameOfUnit.Text, IDOFUnitIfExist.Text, ProjectID,ID);

                ID = 0;

                CreateBtn.Text = "اضافة وحدة جديد";

                NameOfUnit.Text = "";
                IDOFUnitIfExist.Text = "";
                Response.Redirect("PeojectUnit.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteUnit(ID);
            ID = 0;

            CreateBtn.Text = "اضافة وحدة جديد";

            NameOfUnit.Text = "";
            IDOFUnitIfExist.Text = "";

            Response.Redirect("PeojectUnit.aspx");



        }
    }
}