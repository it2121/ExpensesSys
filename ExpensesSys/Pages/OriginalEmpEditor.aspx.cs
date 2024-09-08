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
                            HiringDate.Text = dt["HiringDate"].ToString();
                            TreminationDate.Text = dt["TreminationDate"].ToString();
                            if (!TreminationDate.Text.Equals("0")) {

                                TreminationDate.Enabled = true;
                            }

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

                    
                    TreminationDate.Text = "";
                    TreminationDate.Enabled = false;
                    DateTime dateTime = DateTime.UtcNow.Date;
                    HiringDate.Text = dateTime.ToString("dd/MM/yyyy");


                }
            }
        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("OriginalEmp.aspx");



        }


        protected void ChckedChanged(object sender, EventArgs e)
        {
            if (TermatedCheck.Checked == true)
            {
              
                TreminationDate.Enabled = true;
                DateTime dateTime = DateTime.UtcNow.Date;
                TreminationDate.Text = dateTime.ToString("dd/MM/yyyy");
            }
            else
            {
                TreminationDate.Enabled = false;
                TreminationDate.Text = "";


            }
            UpdateTermanationPanel.Update();
        }



        protected void CreateItem(object sender, EventArgs e)
        {
            string Termdate = "0";
            if (TreminationDate.Text.Length > 0)
            Termdate = TreminationDate.Text;
            if (ID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);
               



                BBAALL.InsertIntoOrigenalEmp(EmpName.Text,
                    EmpJob.Text,Depart.Text,Address.Text,Note.Text,InvolvmentType,ProjectID,HiringDate.Text, Termdate);

                Response.Redirect("OriginalEmp.aspx");

            }
            else
            {


                BBAALL.UpdateOrigenalEmp(EmpName.Text,
                     EmpJob.Text, Depart.Text, Address.Text, Note.Text, InvolvmentType, ProjectID,ID, HiringDate.Text, Termdate);

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
            HiringDate.Text = "";
            TreminationDate.Text = "";
            TreminationDate.Enabled = false;


            Response.Redirect("OriginalEmp.aspx");



        }
    }
}