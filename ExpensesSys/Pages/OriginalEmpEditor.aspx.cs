using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{

    public partial class OriginalEmpEditor : System.Web.UI.Page
    {
        public static int ID = 0;
        public static int ProjectID = 0;
        public static string InvolvmentType = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (ID != 0)
                {
                    DataTable OrEmpTbl = BBAALL.getOrigenalEmpByID(ID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in OrEmpTbl.Rows)
                    {
                        if (ID.Equals(dt[0]))
                        {



                            EmpName.Text = dt["EmpName"].ToString();
                            EmpJob.Text = dt["EmpJob"].ToString();
                            Depart.Text = dt["Depart"].ToString();
                            Address.Text = dt["Address"].ToString();
                            Note.Text = dt["Note"].ToString();
                            InvolvmentType = dt["InvolvmentType"].ToString();


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


                    EmpName.Text = "";
                    EmpJob.Text = "";
                    Depart.Text = "";
                    Address.Text = "";
                    Note.Text = "";


                }
            }
        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("OriginalEmp.aspx");



        }
        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);




                BBAALL.InsertIntoOrigenalEmp(EmpName.Text,
                    EmpJob.Text,Depart.Text,Address.Text,Note.Text,InvolvmentType,ProjectID);

                Response.Redirect("OriginalEmp.aspx");

            }
            else
            {


                BBAALL.UpdateOrigenalEmp(EmpName.Text,
                     EmpJob.Text, Depart.Text, Address.Text, Note.Text, InvolvmentType, ProjectID,ID);

                ID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة قيد جديد";


                Response.Redirect("OriginalEmp.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteOriginalEmp(ID);
            ID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة قيد جديد";



            EmpName.Text = "";
            EmpJob.Text = "";
            Depart.Text = "";
            Address.Text = "";
            Note.Text = "";



            Response.Redirect("OriginalEmp.aspx");



        }
    }
}