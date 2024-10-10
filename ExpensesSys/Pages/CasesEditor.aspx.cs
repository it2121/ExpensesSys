using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class CasesEditor : System.Web.UI.Page
    {
        public static int CaseID = 0;
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
                if (CaseID != 0)
                {
                    DataTable ProjectDT = BBAALL.GetCaseByIDLAW(CaseID);

                    foreach (DataRow dt in ProjectDT.Rows)
                    {
                        



                            CaseNumber.Text = dt["CaseNumber"].ToString();
                            CaseDate.Text = dt["CaseDate"].ToString();
                            CaseResultes.Text = dt["CaseResultes"].ToString();
                            CaseResultesDate.Text = dt["CaseResultesDate"].ToString();


                        

                    }
                    CreateBtn.Text = "حفظ التعديلات";

                    DelBtn.Visible = true;
                }
                else
                {
                    CaseID = 0;


                    CreateBtn.Text = "اضافة دعوى جديدة";
                    DelBtn.Visible = false;


                    CaseNumber.Text = "";
                    CaseDate.Text = "";
                    CaseResultes.Text = "";
                    CaseResultesDate.Text = "";

                    DateTime dateTime = DateTime.UtcNow.Date;
                    CaseDate.Text = dateTime.ToString("dd/MM/yyyy");
                    CaseResultesDate.Text = dateTime.ToString("dd/MM/yyyy");

                }
            }
        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("Cases.aspx");



        }
        protected void CreateItem(object sender, EventArgs e)
        {
            if (CaseID == 0)
            {



                BBAALL.InsertIntoCasesLAW(CaseNumber.Text,CaseDate.Text,CaseResultes.Text,CaseResultesDate.Text,ProjectID);
                Response.Redirect("Cases.aspx");

            }
            else
            {


                BBAALL.UpdateCasesLAW(CaseNumber.Text, CaseDate.Text, CaseResultes.Text, CaseResultesDate.Text,
                    ProjectID,CaseID);

                CaseID = 0;

                CreateBtn.Text = "اضافة دعوى جديدة";

                CaseNumber.Text = "";
                CaseDate.Text = "";
                CaseResultes.Text = "";
                CaseResultesDate.Text = "";
                Response.Redirect("Cases.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteCaseLAW(CaseID);
            ProjectID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة دعوى جديدة";



            CaseNumber.Text = "";
            CaseDate.Text = "";
            CaseResultes.Text = "";
            CaseResultesDate.Text = "";

            Response.Redirect("Cases.aspx");



        }
    }
}