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
        DataTable ProjectsNames;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProjectsNames = BBAALL.GetAllProjects();
            if (!IsPostBack)
            {

                ProjectsNames = BBAALL.GetAllProjects();
                WithdrowParty.Items.Add("تمويل من المستثمر");
                WithdrowParty.Items.Add("قرض");

                foreach (DataRow row in ProjectsNames.Rows)
                {

                    WithdrowParty.Items.Add(row["Name"].ToString());

                }


                if (SalaryRecID != 0)
                {
                    DataTable SalaryDT = BBAALL.getSalaryRecBySalaryRecID(SalaryRecID);

                    DataTable EmpTbl = BBAALL.getEmpByID(Convert.ToInt32(SalaryDT.Rows[0]["EmpID"].ToString()));

                  


                            EmpName.Text = EmpTbl.Rows[0]["EmpName"].ToString();
                            EmpJob.Text = EmpTbl.Rows[0]["EmpJob"].ToString();
                            EmpSal.Text = EmpTbl.Rows[0]["EmpSalary"].ToString();
                            SalDate.Text = SalaryDT.Rows[0]["RecDate"].ToString();
                    WithdrowParty.Text = SalaryDT.Rows[0]["WithdrowParty"].ToString();


                    if (SalaryDT.Rows[0]["ProjectID"].ToString().Equals(0))
                    {

                            WithdrowParty.Text = "تمويل من المستثمر";


                    }else
                    {

                      //  WithdrowParty.Text = BBAALL.getProjectNameByID(Convert.ToInt32(SalaryDT.Rows[0]["ProjectID"].ToString())).Rows[0][0].ToString();

                        WithdrowParty.Text = SalaryDT.Rows[0]["WithdrowParty"].ToString();

                    }



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

            Salary.fromItSelf = true;
            Response.Redirect("Salary.aspx");



        }

        protected void CreateItem(object sender, EventArgs e)
        {
       /*     int ProjectIDFromSelection = 0;
            foreach(DataRow row in ProjectsNames.Rows)
            {

                if (row["Name"].Equals(WithdrowParty.Text))
                {

                    ProjectIDFromSelection = Convert.ToInt32(row["ID"]);

                }

            }*/
            
            if (SalaryRecID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertSalary(ProjectID, EmpId, SalDate.Text,Convert.ToInt32(EmpSal.Text), WithdrowParty.Text);



                Salary.fromItSelf = true;

                Response.Redirect("Salary.aspx");

            }
            else
            {


                BBAALL.UpdateSalary(ProjectID, EmpId, SalDate.Text, Convert.ToInt32(EmpSal.Text),SalaryRecID,WithdrowParty.Text);

                EmpId = 0;
                SalaryRecID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة مرتب جديد";

                Salary.fromItSelf = true;

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
            Salary.fromItSelf = true;

            Response.Redirect("Salary.aspx");



        }

    }
}