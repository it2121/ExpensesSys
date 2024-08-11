using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class SalaryEditor : System.Web.UI.Page
    {
        public static int EmpId = 0;
        public static int SalaryRecID = 0;
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                


                if (SalaryRecID != 0)
                {
                    DataTable SalaryDT = BBAALL.getSalaryRecBySalaryRecID(SalaryRecID);

                    DataTable EmpTbl = BBAALL.getEmpByID(Convert.ToInt32(SalaryDT.Rows[0]["EmpID"].ToString()));

                  


                            EmpName.Text = EmpTbl.Rows[0]["EmpName"].ToString();
                            EmpJob.Text = EmpTbl.Rows[0]["EmpJob"].ToString();
                            EmpSal.Text = EmpTbl.Rows[0]["EmpSalary"].ToString();
                            SalDate.Text = SalaryDT.Rows[0]["RecDate"].ToString();



                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {



                    //DataTable SalaryDT = BBAALL.getSalaryRecBySalaryRecID(SalaryRecID);

                    DataTable EmpTbl = BBAALL.getEmpByID(EmpId);




                    EmpName.Text = EmpTbl.Rows[0]["EmpName"].ToString();
                    EmpJob.Text = EmpTbl.Rows[0]["EmpJob"].ToString();
                    EmpSal.Text = EmpTbl.Rows[0]["EmpSalary"].ToString();


                    DateTime dateTime = DateTime.UtcNow.Date;




                    SalDate.Text = dateTime.ToString("dd/MM/yyyy");






                  
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة مرتب جديد";


                 

                }
            }
        }

        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Salary.aspx");



        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (SalaryRecID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertSalary(ProjectID, EmpId, SalDate.Text,Convert.ToInt32(EmpSal.Text));




                Response.Redirect("Salary.aspx");

            }
            else
            {


                BBAALL.UpdateSalary(ProjectID, EmpId, SalDate.Text, Convert.ToInt32(EmpSal.Text),SalaryRecID);

                EmpId = 0;
                SalaryRecID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة مرتب جديد";


                Response.Redirect("Salary.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteSalary(SalaryRecID);
            EmpId = 0;
            SalaryRecID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة مرتب جديد";


            EmpName.Text = "";
            EmpJob.Text = "";
            EmpSal.Text = "";

            Response.Redirect("Salary.aspx");



        }

    }
}