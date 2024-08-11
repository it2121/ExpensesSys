using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class EmpEditor : System.Web.UI.Page
    {
        public static int EmpId = 0;
        public static int ProjectID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (EmpId != 0)
                {
                    DataTable ProjectDT = BBAALL.getEmpByID(EmpId);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in ProjectDT.Rows)
                    {
                        if (EmpId.Equals(dt[0]))
                        {



                            EmpName.Text = dt["EmpName"].ToString();
                            EmpJob.Text = dt["EmpJob"].ToString();
                            EmpSal.Text = dt["EmpSalary"].ToString();


                        }

                    }
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {
                    EmpId = 0;
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة موظف جديد";


                    EmpName.Text = "";
                    EmpJob.Text = "";
                    EmpSal.Text = "";

                }
            }
        }


        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("EmpMan.aspx");



        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (EmpId == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertEmp(EmpName.Text , EmpJob.Text, Convert.ToInt32(EmpSal.Text),ProjectID);




                Response.Redirect("EmpMan.aspx");

            }
            else
            {


                BBAALL.UpdateEmp(EmpName.Text, EmpJob.Text,Convert.ToInt32(EmpSal.Text), EmpId, ProjectID);

                EmpId = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة موظف جديد";


                Response.Redirect("EmpMan.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteEmp(EmpId);
            EmpId = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة موظف جديد";


            EmpName.Text = "";
            EmpJob.Text = "";
            EmpSal.Text = "";

            Response.Redirect("EmpMan.aspx");



        }
    }
}