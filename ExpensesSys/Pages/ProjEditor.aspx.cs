using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class ProjEditor : System.Web.UI.Page
    {
        public static int ProjID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ProjID != 0)
                {
                    DataTable ProjectDT = BBAALL.getProjctByID(ProjID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in ProjectDT.Rows)
                    {
                        if (ProjID.Equals(dt[0]))
                        {



                            ProjectName.Text = dt["Name"].ToString();
                      

                        }

                    }
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {
                    ProjID = 0;
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة مشروع جديد";


                    ProjectName.Text = "";
                   

                }
            }
        }

        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("ProjMan.aspx");



        }
        protected void CreateItem(object sender, EventArgs e)
        {
            if (ProjID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



               BBAALL.InsertProject(ProjectName.Text);




                Response.Redirect("ProjMan.aspx");

            }
            else
            {


                 BBAALL.UpdateProject(ProjectName.Text,ProjID);

                ProjID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة مشروع جديد";


                Response.Redirect("ProjMan.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteProject(ProjID);
            ProjID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة مشروع جديد";


            ProjectName.Text = "";
         
            Response.Redirect("ProjMan.aspx");



        }
    }
}